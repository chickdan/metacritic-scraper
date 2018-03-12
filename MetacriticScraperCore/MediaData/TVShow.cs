using System;

namespace MetacriticScraperCore.MediaData
{
    public class TVShow : MediaItem, IEquatable<TVShow>
    {
        public int Season { get; set; }
        public string Studio { get; set; }

        public bool Equals(TVShow other)
        {
            return base.Equals(other) &&
                Season == other.Season &&
                Studio == other.Studio;
        }
    }
}