using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SEDC.Adv.Class09.Events
{
    public class RentalStore
    {
        // 1 - define delegate
        // 2 - define event
        // 3 - raise event
        // old way
        //public delegate void RentalStoreEventHandler(object source, EventArgs args);
        //public event RentalStoreEventHandler NotifyUsers;

        //public delegate void RentalStoreEventHandler(object source, MovieEventArgs args);
        //public event RentalStoreEventHandler NotifyUsers;

        //public event EventHandler NotifyUsers;
        public event EventHandler<MovieEventArgs> NotifyUsers;
        // signature of event is return type void and input params object, MovieEventArgs as generic param
        public event EventHandler<VideoEventArgs> NotifyUsersVideoEvent;

        public void AddNewMovie(string movieTitle)
        {
            Console.WriteLine("Adding movie ....");
            Thread.Sleep(2000);
            Console.WriteLine($"Added {movieTitle} to available movies for rental");

            //OnNewMovie();
            OnNewMovie(movieTitle);
            OnNewMovie(new Movie() { Title = movieTitle });
        }

        // by convention is protected virtual but it does not have to be :)
        protected virtual void OnNewMovie()
        {
            //if(NotifyUsers != null)
            //{
            //    NotifyUsers(this, EventArgs.Empty);
            //}
        }

        protected virtual void OnNewMovie(string movieTitle)
        {
            if(NotifyUsers != null)
            {
                NotifyUsers(this, new MovieEventArgs() { MovieTitle = movieTitle });
            }
        }

        protected virtual void OnNewMovie(Movie movie)
        {
            if(NotifyUsersVideoEvent != null)
            {
                NotifyUsersVideoEvent(this, new VideoEventArgs() { Movie = movie });
            }
        }
    }
}
