using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
{
    public class Movie : StreamingContent //inherit movie from St..Content
    {
        public double RunTime { get; set; }
        public Movie() { }//create empty constructor of Movie class
        
        //build constructor overloaded with parameters
        public Movie(string title, string description, float starRating, 
            string mRating, bool isFamFriendly, GenreType typeOfGenre, double runTime)
                :base(title,description,starRating,mRating,isFamFriendly,typeOfGenre)
        {
            RunTime = runTime;
        }

    }
}
