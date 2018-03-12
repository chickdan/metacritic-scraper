﻿using System;
using System.Collections.Generic;
using MetacriticScraperCore.Interfaces;

namespace MetacriticScraperCore.MediaData
{
    public class SearchData : IMetacriticData
    {
        public int? TotalResultCount { get; set; }

        private List<SearchItem> m_searchItems;
        public List<SearchItem> SearchItems
        {
            get
            {
                return m_searchItems;
            }
        }

        public SearchData ()
        {
            m_searchItems = new List<SearchItem>();
        }

        public void AddItem (SearchItem item)
        {
            m_searchItems.Add(item);
        }

        public class SearchItem : IEquatable<SearchItem>
        {
            public string Id { get; set; }
            public string Title { get; set; }
            public string ReleaseDate { get; set; }
            public string Genre { get; set; }
            public Rating Rating { get; set; }

            public bool Equals(SearchItem other)
            {
                if (string.IsNullOrEmpty(Id))
                {
                    return Id == other.Id;
                }
                else
                {
                    return Title == other.Title &&
                        ReleaseDate == other.ReleaseDate;
                }
            }
        }
    }
}
