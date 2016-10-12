using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VotingPollApp.Models
{
    public class Voters
    {
        

        public int Id { get; set; }
        //[ForeignKey("Users")]
        //public int UserId { get; set; }
        [ForeignKey("QuestionId")]
        public int QuestionId { get; set; }
        [ForeignKey("PollId")]
        public int PollId { get; set; }
        public string IpAddress { get; set; }
    }
}