using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    /// <summary>
    /// This script is for whoever implements IDataConnection will have a method called that creates
    /// a model and then returns it back to the ID
    /// </summary>
    public interface IDbConnection
    {
        //this passes a model and then returns the model back to the ID
        void CreatePrize(PrizeModel model);
        void CreatePerson(PersonModel model);
        void CreateTeam(TeamModel model);
        void createTournament(TournamentModel model);

        //this updates an existing model and store it in the data source
        void UpdateMatchup(MatchupModel model);

        //this completes the tournament model and stores it in the data source
        void CompleteTournament(TournamentModel model);

        //this is select statements to all models
        List<PersonModel> GetPerson_All();
        List<TeamModel> GetTeam_All();
        List<TournamentModel> GetTournament_All();
        List<PrizeModel> GetPrizes_All();


    }    
}