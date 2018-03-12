using System;
using MetacriticScraperCore.Interfaces;

namespace MetacriticScraperCore.MediaData
{
    public class Album : MediaItem, IEquatable<Album>
    {
        public string PrimaryArtist { get; set; }

        public bool Equals(Album other)
        {
            return base.Equals(other) && PrimaryArtist == other.PrimaryArtist;
        }
    }
}