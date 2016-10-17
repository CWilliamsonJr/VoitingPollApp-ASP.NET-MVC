using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace VotingPollApp.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("VotingApp")
        {
            
        }

        public DbSet <Polls> Polls { get; set; }
        public DbSet <Questions> Questions { get; set; }
        public DbSet <Users> Users { get; set; }
        public DbSet <Voters> Voters { get; set; }
    }
}