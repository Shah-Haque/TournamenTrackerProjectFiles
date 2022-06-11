using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class SqlConnector : IDbConnection
    {
        private const string db = "Tournaments";

        /// <summary>
        /// Saves a prize to the database
        /// </summary>
        /// <param name="model">The Prize information</param>
        /// <returns>The Prize information, including the unique ID</returns>
        //creates a prize in the Prizemodel and stores it in the Prizes table in the SQL Database
        public void CreatePrize(PrizeModel model)
        {
            using (System.Data.IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@PlaceNumber", model.placeNumber);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PrizeAmount", model.prizeAmount);
                p.Add("@PrizePercentage", model.prizePercentage);
                p.Add("@PrizesID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.SPPrizes_Insert", p, commandType: CommandType.StoredProcedure);

                model.PrizesID = p.Get<int>(@"PrizesID");

                    
            }
        }
        /// <summary>
        /// This creates a new person and stores that person in the database
        /// </summary>
        /// <param name="model"></param>
        public void CreatePerson(PersonModel model)
        {
            using (System.Data.IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@FirstName", model.FirstName);
                p.Add("@LastName", model.LastName);
                p.Add("@EmailAddress", model.EmailAddress);
                p.Add("@TelephoneNumber", model.TelephoneNumber);
                p.Add("@ID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.SpPeople_Insert", p, commandType: CommandType.StoredProcedure);

                model.ID = p.Get<int>(@"ID");
            }
        }

        /// <summary>
        /// This gets all the people 
        /// </summary>
        /// <returns></returns>
        public List<PersonModel> GetPerson_All()
        {
            List<PersonModel> output;
            using (System.Data.IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<PersonModel>("dbo.spPeople_GetAll").ToList();
            }
            return output;
        }

        /// <summary>
        /// This creates the teams and stores it in the database
        /// </summary>
        /// <param name="model"></param>
        public void CreateTeam(TeamModel model)
        {
            using (System.Data.IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@TeamName", model.TeamName);
                p.Add("@TeamID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTeams_Insert", p, commandType: CommandType.StoredProcedure);

                model.TeamID = p.Get<int>(@"TeamID");

                //for each person model in TeamMembers 
                //Refer to TeamMembers table
                foreach (PersonModel TM in model.TeamMembers)
                {
                    p = new DynamicParameters();
                    p.Add("@TeamID", model.TeamID);
                    p.Add("@PersonID", TM.ID);

                    connection.Execute("dbo.spTeamMembers_Insert", p, commandType: CommandType.StoredProcedure);
                }
            }
        }
        public List<PrizeModel> GetPrizes_All()
        {
            List<PrizeModel> output;
            using (System.Data.IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<PrizeModel>("dbo.spPrizes_GetAll").ToList();
            }
            return output;
        }  
        
        /// <summary>
                    /// This gets all teams 
                    /// </summary>
                    /// <returns></returns>
        public List<TeamModel> GetTeam_All()
        {
            List<TeamModel> output;

            using (System.Data.IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<TeamModel>("dbo.spTeam_GetAll").ToList();

                foreach (TeamModel team in output)
                {
                    var p = new DynamicParameters();
                    p.Add("@TeamID", team.TeamID);

                    team.TeamMembers = connection.Query<PersonModel>("dbo.spTeamMembers_GetByTeam", p, commandType: CommandType.StoredProcedure).ToList();
                }
            }
            return output;
        }

        /// <summary>
        /// This Creates a new tournament
        /// </summary>
        /// <param name="model"></param>
        public void createTournament(TournamentModel model)
        {
            using (System.Data.IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                SaveTournament(connection, model);

                SaveTournamentPrizes(connection, model);

                SaveTournamentEntries(connection, model);

                SaveTournamentRounds(connection, model);

                TournamentLogic.UpdateTournamentResults(model);
          
            }
        }

        /// <summary>
        /// This saves Tournament Rounds
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="model"></param>
        private void SaveTournamentRounds(System.Data.IDbConnection connection, TournamentModel model)
         {

            ///----STEPS-----///
            //  Loop through Rounds
            //  Loop through Matchups
            //  Save the matchup 
            //  Look through the entries and save them 

            foreach (List<MatchupModel> round in model.Rounds)
            {
                foreach (MatchupModel matchup in round)
                {
                    var p = new DynamicParameters();
                    p.Add("@TournamentID", model.TournamentID);
                    p.Add("@MatchupRound", matchup.MatchupRound);
                    p.Add("@MatchupID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                    connection.Execute("dbo.spMatchups_Insert", p, commandType: CommandType.StoredProcedure);

                    matchup.MatchupID = p.Get<int>("@MatchupID");

                    foreach (MatchupEntryModel entry in matchup.Entries)
                    {
                        p = new DynamicParameters();

                        p.Add("@MatchupID", matchup.MatchupID);

                        if (entry.ParentMatchup == null)
                        {
                            p.Add("@ParentMatchupID", null);
                        }
                        else
                        {
                            p.Add("@ParentMatchupID", entry.ParentMatchup.MatchupID);
                        }

                        if (entry.TeamCompeting == null)
                        {
                            p.Add("@TeamCompetingID", null);
                        }
                        else
                        {
                            p.Add("@TeamCompetingID", entry.TeamCompeting.TeamID);
                        }

                        p.Add("@MatchupEntryID", 0, dbType: DbType.Int32, ParameterDirection.Output);

                        connection.Execute("dbo.spMatchupEntries_insert", p, commandType: CommandType.StoredProcedure);

                    }
                }
            }
        }

        /// <summary>
        /// This saves Tournaments
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="model"></param>
        private void SaveTournament(System.Data.IDbConnection connection, TournamentModel model)
        {
            var p = new DynamicParameters();
            p.Add("@TournamentName", model.TournamentName);
            p.Add("@EntryFee", model.EntryFee);
            p.Add("@TournamentID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            connection.Execute("dbo.spTournaments_insert", p, commandType: CommandType.StoredProcedure);

            model.TournamentID = p.Get<int>("@TournamentID");
        }

        /// <summary>
        /// This saves a Tournament prize
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="model"></param>
        private void SaveTournamentPrizes(System.Data.IDbConnection connection, TournamentModel model)
        {
            //for each person model in TeamMembers 
            //Refer to TeamMembers table
            foreach (PrizeModel PM in model.Prizes)
            {
                var p = new DynamicParameters();
                p.Add("@TournamentID", model.TournamentID);
                p.Add("@PrizeID", PM.PrizesID);
                p.Add("@TournamentPrizeID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTournamentPrizes_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }

        /// <summary>
        /// This saves a tournament Entry
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="model"></param>
        private void SaveTournamentEntries(System.Data.IDbConnection connection, TournamentModel model)
        {
            foreach (TeamModel TM in model.EnteredTeams)
            {
                var p = new DynamicParameters();
                p.Add("@TournamentID", model.TournamentID);
                p.Add("@TeamID", TM.TeamID);
                p.Add("@TournamentEntriesID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTournamentEntries_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }

        /// <summary>
        /// This gets all Tournaments
        /// </summary>
        /// <returns></returns>
        public List<TournamentModel> GetTournament_All()
        {
            List<TournamentModel> output;
            using (System.Data.IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<TournamentModel>("dbo.spTournaments_GetAll").ToList();
                var p = new DynamicParameters();

                foreach (TournamentModel t in output)
                {
                    // This will populate the Prizes
                    p = new DynamicParameters();
                    p.Add("@TournamentID", t.TournamentID);

                    t.Prizes = connection.Query<PrizeModel>("dbo.spPrizes_GetByTournament", p, commandType: CommandType.StoredProcedure).ToList();
                  

                    // This will Populate the teams
                    p = new DynamicParameters();
                    p.Add("@TournamentID", t.TournamentID);

                    t.EnteredTeams = connection.Query<TeamModel>("dbo.spTeam_GetByTournament", p, commandType: CommandType.StoredProcedure).ToList();


                    foreach (TeamModel team in t.EnteredTeams)
                    {
                        p = new DynamicParameters();
                        p.Add("@TeamID", team.TeamID);

                        team.TeamMembers = connection.Query<PersonModel>("dbo.spTeamMembers_GetByTeam", p, commandType: CommandType.StoredProcedure).ToList();
                    }

                     p = new DynamicParameters();
                     p.Add("@TournamentID", t.TournamentID);

                    // Populate rounds---Matchups
                    List<MatchupModel> matchups = connection.Query<MatchupModel>("dbo.spMatchups_GetByTournament", p, commandType: CommandType.StoredProcedure).ToList();

                    foreach (MatchupModel m in matchups)
                    {
                         p = new DynamicParameters();
                        p.Add("@MatchupID", m.MatchupID);

                        // Populate rounds
                        m.Entries = connection.Query<MatchupEntryModel>("spMatchupEntries_getbyMatchup", p, commandType: CommandType.StoredProcedure).ToList();

                        // Popukate each entry (2 models)
                        // populate each matchup(1 matchup)

                        List<TeamModel> allTeams = GetTeam_All();

                        if (m.WinnerID > 0)
                        {
                            m.Winner = allTeams.Where(x => x.TeamID == m.WinnerID).First();
                        }


                        foreach (var me  in m.Entries)
                        {
                            if (me.TeamCompetingID > 0)
                            {
                                //in all the teams find all the team id and show the user the first id
                                me.TeamCompeting = allTeams.Where(x => x.TeamID == me.TeamCompetingID).First();
                            }

                            if (me.ParentMatchupID > 0)
                            {
                                // Look in all the matchups and find the parentmatchupid and show the user the first id
                                me.ParentMatchup = matchups.Where(x => x.MatchupID == me.ParentMatchupID).First();
                            }

                        }

                    }

                    // List<List<MatchupModel>> - List of a list of Matchup
                    /// 3 matchups total
                    /// 1 round is current round
                    /// add the next matchup in the next round 
                    List<MatchupModel> currRow = new List<MatchupModel>();
                    int currRound = 1;

                    foreach (MatchupModel m in matchups)
                    {
                        if (m.MatchupRound > currRound)
                        {
                            t.Rounds.Add(currRow);
                            currRow = new List<MatchupModel>();
                            currRound += 1;
                        }

                        currRow.Add(m);
                    }
                    t.Rounds.Add(currRow);
                }
            }

            return output;
        }
        
        /// <summary>
        /// Updates the Matchups
        /// </summary>
        /// <param name="model"></param>
        public void UpdateMatchup(MatchupModel model)
        {
            using (System.Data.IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {  
                var p = new DynamicParameters();
                if (model.Winner != null)
                {
                    p.Add("@MatchupID", model.MatchupID);
                    p.Add("@WinnerID", model.WinnerID);

                    connection.Execute("dbo.spMatchups_Update", p, commandType: CommandType.StoredProcedure);
                }
  
                foreach (MatchupEntryModel me in model.Entries)
                {
                    if (me.TeamCompeting != null)
                    {
                        p = new DynamicParameters();
                        p.Add("@MatchupEntryID", me.MatchupEntryID);
                        p.Add("@TeamCompetingID", me.TeamCompeting.TeamID);
                        p.Add("@Score", me.Score);

                        connection.Execute("dbo.spMatchupEntries_Update", p, commandType: CommandType.StoredProcedure);
                    }
                }
            }
        }  
        /// <summary>
        /// This will compelete the tournament 
        /// once all the rounds are completed
        /// And one team remains
        /// </summary>
        /// <param name="model"></param>
        public void CompleteTournament(TournamentModel model)
        {
            
            using (System.Data.IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@TournamentID",model.TournamentID);

                connection.Execute("dbo.spTournaments_Complete", p, commandType: CommandType.StoredProcedure);
            }
        }
    }
}