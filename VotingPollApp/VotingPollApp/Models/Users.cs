using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VotingPollApp.Models
{
    public class Users
    {
        private MyDbContext db = new MyDbContext();

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password  { get; set; }
    }
}