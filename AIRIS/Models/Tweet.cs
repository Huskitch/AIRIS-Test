using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AIRIS.Models
{
    public class Tweet
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        public DateTimeOffset Date { get; set; }
    }

    public class TweetDBContext : DbContext
    {
        public DbSet<Tweet> Tweets { get; set; }
    }
}