using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VotingPollApp.Models
{
    public class Questions
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Question { get; set; }
    }
}