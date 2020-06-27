using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.Class09.Example
{
    public class VideoStore
    {
        // 1 - define delegate
        // 2 - define event
        // 3 - raise event

        public delegate void AddNewMovieEventHadnler(string movie);
        public event AddNewMovieEventHadnler NotifyUsers;

        public void AddNewMovie(string movie)
        {
            Console.WriteLine("Adding movie" + movie);

            NewMovieAdded(movie);
        }

        // this is by convention naming
        protected virtual void OnNewMovie(string movie)
        {
            if(NotifyUsers != null)
            {
                NotifyUsers(movie);
            }
        }

        // this is our way
        public void NewMovieAdded(string movie)
        {
            if (NotifyUsers != null)
            {
                NotifyUsers(movie);
            }
        }
    }
}
