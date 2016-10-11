using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VotingPollApp.Models
{
    public class Questions
    {
        private MyDbContext db = new MyDbContext();

        public int Id { get; set; }
        public Users User { get; set; }
        public string Question { get; set; }
    }
}