﻿using Melody.Shared.Enums;

namespace Melody.BusinessLayer.Requests.Search
{
    public class SearchItemRequest
    {
        public string SearchString { get; set; } // you can find track, podcast, playlist, creator, genre, topic, tag

        public SearchType Type { get; set; }
    }
}
