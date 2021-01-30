using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
   public class MathupEntryModel
    {
        /// <summary>
        ///  Represents one team in the matchup.
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Represents the score for this particular team.
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Represnets the matchup that this team came from as the winner.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }


        public MathupEntryModel(double initialScore)
        {
            Console.WriteLine();
        }
    }
}
