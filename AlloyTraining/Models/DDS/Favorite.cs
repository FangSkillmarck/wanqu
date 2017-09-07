﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using EPiServer.Core;
using EPiServer.Data;
using EPiServer.Data.Dynamic;

namespace AlloyTraining.Models.DDS
{
    public class Favorite: IDynamicData

    {
        public Identity Id { get; set; }
        public string UserName { get; set; }
        public ContentReference FavoriteContentReference { get; set; }

        public Favorite()
        {
            Id = Identity.NewIdentity(Guid.NewGuid());
            UserName = string.Empty;
            FavoriteContentReference = ContentReference.EmptyReference;
        }

        public Favorite(ContentReference contentReferenceToAdd,
            string userName) : this() // calls the default constructor first
        {
            UserName = userName;
            FavoriteContentReference = contentReferenceToAdd;
        }
    }


}