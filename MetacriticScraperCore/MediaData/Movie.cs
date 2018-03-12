using System;

namespace MetacriticScraperCore.MediaData
{
    public class Movie : MediaItem, IEquatable<Movie>
    {
        public string Director { get; set; }

        public bool Equals(Movie other)
        {
            return base.Equals(other) && Director == other.Director;
        }
    }
}