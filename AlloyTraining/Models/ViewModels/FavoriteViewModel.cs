﻿using AlloyTraining.Models.DDS;
using EPiServer.Core;
using System.Collections.Generic;

namespace AlloyTraining.Models.ViewModels
{
    public class FavoriteViewModel
    {
        public List<Favorite> Favorites { get; set; }

        public ContentReference CurrentPageContentReference { get; set; }
    }
}