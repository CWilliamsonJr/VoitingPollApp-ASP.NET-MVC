using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VotingPollApp.Models
{
    public class Voters
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int QuestionId { get; set; }
        public int PollId { get; set; }
        public string IpAddress { get; set; }
    }
}