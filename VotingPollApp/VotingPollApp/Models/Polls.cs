using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc.Html;

namespace VotingPollApp.Models
{
    public class Polls
    {
       
        [Key]
        public int PollId { get; set; }
        public bool Public { get; set; } 
        //[ForeignKey("Users")]
        //public Users UserId { get; set; }
        [Required]
        public string Question { get; set; }
        [ForeignKey("QuestionId")]
        public int QuestionId { get; set; }
        public int Votes { get; set; }
        public string Choice { get; set; }
    }
}