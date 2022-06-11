using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
    public static class TournamentLogic
    {
        
        /// <summary>
        /// Order our list randomly of teams
        /// Check if it is big enough - if not, add in byes - 2*2*2*2 - 2^4
        /// Create our first round of matchups
        /// Create every round after that - 8 matchups - 4 matchups - 2 matchups - 1 matchup
        /// </summary>
        /// <param name="model"></param>
        public static void CreateRounds(TournamentModel model)
        {
            List<TeamModel> randomizedTeams = RandomizeTeamOrder(model.EnteredTeams);
            int rounds = FindNumberOfRounds(randomizedTeams.Count);
            int byes = NumberOfByes(rounds, randomizedTeams.Count);

            model.Rounds.Add(CreateFirstRound(byes, randomizedTeams));

            CreateOtherRounds(model, rounds);
        }
        /// <summary>
        /// This will update the tournament rounds through the TournamentModel and update the matchups
        /// </summary>
        /// <param name="model"></param>
        public static void UpdateTournamentResults(TournamentModel model)
        {
            int startingRound = model.CheckCurrentRound();
            List<MatchupModel> toScore = new List<MatchupModel>();

            foreach (List<MatchupModel> round in model.Rounds)
            {
                foreach (MatchupModel rm in round)
                {
                    if ((rm.Entries.Any(x => x.Score != 0) || rm.Entries.Count == 1))
                    {
                        toScore.Add(rm);
                    }
                }
            }

            MarkWinnerInMatchups(toScore);

            AdvanceWinners(toScore, model);

            toScore.ForEach(x => GlobalConfig.Connection.UpdateMatchup(x));
            int endingRound = model.CheckCurrentRound();

            if (endingRound > startingRound)
            {
                model.AlertUsersToNewRound();
            }
        }

        public static void AlertUsersToNewRound(this TournamentModel model)
        {
            int currentRoundNumber = model.CheckCurrentRound();
            List<MatchupModel> currentRound = model.Rounds.Where(x => x.First().MatchupRound == currentRoundNumber).First();

            foreach (MatchupModel matchup in currentRound)
            {
                foreach (MatchupEntryModel me in matchup.Entries)
                {
                    foreach (PersonModel p in me.TeamCompeting.TeamMembers)
                    {
                        AlertPersonToNewRound(p, me.TeamCompeting.TeamName, matchup.Entries.Where(x => x.TeamCompeting != me.TeamCompeting).FirstOrDefault());
                    }
                }
            }
        }

        private static void AlertPersonToNewRound(PersonModel p, string teamName, MatchupEntryModel competitor)
        {
            if (p.EmailAddress.Length > 0)
            {
                string to = "";
                string subject = "";
                StringBuilder body = new StringBuilder();

                if (competitor != null)
                {
                    subject = $"You have a new matchup with { competitor.TeamCompeting.TeamName }";

                    body.AppendLine("<h1>You have a new matchup</h1>");
                    body.Append("<strong>Competitor: </strong>");
                    body.Append(competitor.TeamCompeting.TeamName);
                    body.AppendLine();
                    body.AppendLine();
                    body.AppendLine("Have a great time!");
                    body.AppendLine("~Tournament Tracker");
                }
                else
                {
                    subject = "You have a bye week this round";

                    body.AppendLine("Enjoy your round off!");
                    body.AppendLine("~Tournament Tracker");
                }

                to = p.EmailAddress;

                EmailLogic.SendEmail(to, subject, body.ToString());
            }
            if (p.TelephoneNumber.Length > 0)
            {
                if (competitor != null)
                {
                    SMSLogic.SendSMSMessage(p.TelephoneNumber, $"You have a new matchup with { competitor.TeamCompeting.TeamName }");
                }
                else
                {
                    SMSLogic.SendSMSMessage(p.TelephoneNumber, $"You have a bye week for the first round.");
                }
            }

        }

        /// <summary>
        /// This checks the current round for the winner
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        private static int CheckCurrentRound(this TournamentModel model)
        {
            int output = 1;

            foreach (List<MatchupModel> round in model.Rounds)
            {
                if (round.All(x => x.Winner != null))
                {
                    output += 1;
                }
                else
                {
                    return output;
                }
            }

            // Tournament is complete
            CompleteTournament(model);

            return output - 1;
        }

        /// <summary>
        /// This will complete the tournament
        /// </summary>
        /// <param name="model"></param>
        private static void CompleteTournament(TournamentModel model)
        {
            GlobalConfig.Connection.CompleteTournament(model);
            TeamModel winners = model.Rounds.Last().First().Winner;
            TeamModel runnerUp = model.Rounds.Last().First().Entries.Where(x => x.TeamCompeting != winners).First().TeamCompeting;
         
            decimal winnerPrize = 0;
            decimal runnerUpPrize = 0;

            if (model.Prizes.Count > 0)
            {
                decimal totalIncome = model.EnteredTeams.Count * model.EntryFee;

                PrizeModel firstPlacePrize = model.Prizes.Where(x => x.placeNumber == 1).FirstOrDefault();
                PrizeModel secondPlacePrize = model.Prizes.Where(x => x.placeNumber == 2).FirstOrDefault();

                if (firstPlacePrize != null)
                {
                    winnerPrize = firstPlacePrize.CalculatePrizePayout(totalIncome);
                }

                if (secondPlacePrize != null)
                {
                    runnerUpPrize = secondPlacePrize.CalculatePrizePayout(totalIncome);
                }
            }

            // Send Email to all tournament
            string subject = "";
            StringBuilder body = new StringBuilder();

            subject = $"In { model.TournamentName }, { winners.TeamName } has won!";   

            body.AppendLine("<h1>We have a WINNER!</h1>");
            body.AppendLine("<p>Congratulations to our winner on a great tournament.</p>");
            body.AppendLine("<br />");

            if (winnerPrize > 0)
            {
                body.AppendLine($"<p>{ winners.TeamName } will receive ${ winnerPrize }</p>");
            }

            if (runnerUpPrize > 0)
            {
                body.AppendLine($"<p>{ runnerUp.TeamName } will receive ${ runnerUpPrize }</p>");
            }

            body.AppendLine("<p>Thanks for a great tournament everyone!</p>");
            body.AppendLine("~Tournament Tracker");


            List<string> bcc = new List<string>();

            foreach (TeamModel t in model.EnteredTeams)
            {
                foreach (PersonModel p in t.TeamMembers)
                {
                    if (p.EmailAddress.Length > 0)
                    {
                        bcc.Add(p.EmailAddress);
                    }
                }
            }

            EmailLogic.SendEmail(new List<string>(), bcc, subject, body.ToString());

            // Complete Tournament
            model.CompleteTournament();
        }

        /// <summary>
        /// This will calculate the prize payout based on the entryfee
        /// </summary>
        /// <param name="prize"></param>
        /// <param name="totalIncome"></param>
        /// <returns></returns>
        private static decimal CalculatePrizePayout(this PrizeModel prize, decimal totalIncome)
        {
            decimal output = 0;

            if (prize.prizeAmount > 0)
            {
                output = prize.prizeAmount;
            }
            else
            {
                output = Decimal.Multiply(totalIncome, Convert.ToDecimal(prize.prizePercentage / 100));
            }

            return output;
        }

        /// <summary>
        /// This advances the winners to the end of the tournament
        /// </summary>
        /// <param name="models"></param>
        /// <param name="tournament"></param>
        private static void AdvanceWinners(List<MatchupModel> models, TournamentModel tournament)
        {
            foreach (MatchupModel m in models)
            {
                foreach (List<MatchupModel> round in tournament.Rounds)
                {
                    foreach (MatchupModel rm in round)
                    {
                        foreach (MatchupEntryModel me in rm.Entries)
                        {
                            if (me.ParentMatchup != null)
                            {
                                if (me.ParentMatchup.MatchupID == m.MatchupID)
                                {
                                    me.TeamCompeting = m.Winner;
                                    GlobalConfig.Connection.UpdateMatchup(rm);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// This marks the winner in matchups
        /// </summary>
        /// <param name="models"></param>
        /// <exception cref="Exception"></exception>
        private static void MarkWinnerInMatchups(List<MatchupModel> models)
        {
            // greater or lesser
            string greaterWins = ConfigurationManager.AppSettings["greaterWins"];

            foreach (MatchupModel m in models)
            {
                // Checks for bye week entry
                if (m.Entries.Count == 1)
                {
                    m.Winner = m.Entries[0].TeamCompeting;
                    continue;
                }

                // 0 means false, or low score wins
                if (greaterWins == "0")
                {
                    if (m.Entries[0].Score < m.Entries[1].Score)
                    {
                        m.Winner = m.Entries[0].TeamCompeting;
                    }
                    else if (m.Entries[1].Score < m.Entries[0].Score)
                    {
                        m.Winner = m.Entries[1].TeamCompeting;
                    }
                    else
                    {
                        throw new Exception("We do not allow ties in this application.");
                    }
                }
                else
                {
                    // 1 mean true, or high score wins
                    if (m.Entries[0].Score > m.Entries[1].Score)
                    {
                        m.Winner = m.Entries[0].TeamCompeting;
                    }
                    else if (m.Entries[1].Score > m.Entries[0].Score)
                    {
                        m.Winner = m.Entries[1].TeamCompeting;
                    }
                    else
                    {
                        throw new Exception("We do not allow ties in this application.");
                    }
                }
            }
        }

        /// <summary>
        /// This Creates other rounds of this tournament
        /// </summary>
        /// <param name="model"></param>
        /// <param name="rounds"></param>
        private static void CreateOtherRounds(TournamentModel model, int rounds)
        {
            int round = 2;
            List<MatchupModel> previousRound = model.Rounds[0];
            List<MatchupModel> currRound = new List<MatchupModel>();
            MatchupModel currMatchup = new MatchupModel();

            while (round <= rounds)
            {
                foreach (MatchupModel match in previousRound)
                {
                    currMatchup.Entries.Add(new MatchupEntryModel { ParentMatchup = match });

                    if (currMatchup.Entries.Count > 1)
                    {
                        currMatchup.MatchupRound = round;
                        currRound.Add(currMatchup);
                        currMatchup = new MatchupModel();
                    }
                }

                model.Rounds.Add(currRound);
                previousRound = currRound;

                currRound = new List<MatchupModel>();
                round += 1;
            }
        }
        /// <summary>
        /// This creates the first round of the tournament
        /// </summary>
        /// <param name="byes"></param>
        /// <param name="teams"></param>
        /// <returns></returns>
        private static List<MatchupModel> CreateFirstRound(int byes, List<TeamModel> teams)
        {
            List<MatchupModel> output = new List<MatchupModel>();
            MatchupModel curr = new MatchupModel();

            foreach (TeamModel team in teams)
            {
                curr.Entries.Add(new MatchupEntryModel { TeamCompeting = team });

                if (byes > 0 || curr.Entries.Count > 1)
                {
                    curr.MatchupRound = 1;
                    output.Add(curr);
                    curr = new MatchupModel();

                    if (byes > 0)
                    {
                        byes -= 1;
                    }
                }
            }

            return output;
        }
        /// <summary>
        /// This counts the number of byes
        /// </summary>
        /// <param name="rounds"></param>
        /// <param name="numberOfTeams"></param>
        /// <returns></returns>
        private static int NumberOfByes(int rounds, int numberOfTeams)
        {
            int output = 0;
            int totalTeams = 1;

            for (int i = 1; i <= rounds; i++)
            {
                totalTeams *= 2;
            }

            output = totalTeams - numberOfTeams;

            return output;
        }
        /// <summary>
        /// This finds the number of rounds
        /// </summary>
        /// <param name="teamCount"></param>
        /// <returns></returns>
        private static int FindNumberOfRounds(int teamCount)
        {
            int output = 1;
            int val = 2;

            while (val < teamCount)
            {
                // output = output + 1;
                output += 1;

                // val = val * 2;
                val *= 2;
            }

            return output;
        }
        /// <summary>
        /// This randomises the teams in the tournament
        /// </summary>
        /// <param name="teams"></param>
        /// <returns></returns>
        private static List<TeamModel> RandomizeTeamOrder(List<TeamModel> teams)
        {
            // cards.OrderBy(a => Guid.NewGuid()).ToList();
            return teams.OrderBy(x => Guid.NewGuid()).ToList();
        }

    }
}