using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.Class09.Events
{
    public class BlockbasterStore
    {
        public event EventHandler<VideoEventArgs> Notifications;

        public void NewMovieRelase(Movie movie)
        {
            Console.WriteLine($"{movie.Title} is now availble on Dvd");

            OnNewMovieRelease(movie);
        }

        protected virtual void OnNewMovieRelease(Movie movie)
        {
            // if notification is null Invoke will not be triggered
            //Notifications?.Invoke(this, new VideoEventArgs() { Movie = movie });
            if (Notifications != null)
            {
                Notifications(this, new VideoEventArgs() { Movie = movie });
            }
        }
    }
}
