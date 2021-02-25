﻿using System;

namespace EduZbieracz.Domain.Entities
{
    public class Webinars
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }

        public string ImageUrl { get; set; }
        public string FacebookEventUrl { get; set; }
        public string SlidesUrl { get; set; }

        public string WatchFacebookLink { get; set; }
        public string WatchYoutubeLink { get; set; }

        public DateTime Date { get; set; }
        public bool AlreadyHappend { get; set; }
    }
}
