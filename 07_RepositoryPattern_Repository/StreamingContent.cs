﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
{
    public enum GenreType
    {
        Horror,
        RomCom,
        Fantasy,
        SciFi,
        Drama,
        Bromance,
        Action,
        Documentary,
        Thriller
    }
    public class StreamingContent
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public float StarRating { get; set; }
        public string MaturityRating { get; set; }
        public bool IsFamilyFriendly { get; set; }
        public GenreType TypeOfGenre { get; set; }
        //create empty constuctor
        public StreamingContent() { }
        //create overloaded constructor
        public StreamingContent(string title, string description, float starRating,
         string mRating, bool famFriendly, GenreType typeOfGenre)
        {
            Title = title;
            Description = description;
            StarRating = starRating;
            MaturityRating = mRating;
            IsFamilyFriendly = famFriendly;
            TypeOfGenre = typeOfGenre;
        }
        //build a repository for streaming content - own file

    }
}
