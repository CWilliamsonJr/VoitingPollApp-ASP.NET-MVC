using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VotingPollApp.Models
{
    public class Voters
    {
        private MyDbContext db = new MyDbContext();

        public int Id { get; set; }
        public Users User { get; set; }
        public Questions Question { get; set; }
        public Polls Poll { get; set; }
        public string IpAddress { get; set; }
    }
}