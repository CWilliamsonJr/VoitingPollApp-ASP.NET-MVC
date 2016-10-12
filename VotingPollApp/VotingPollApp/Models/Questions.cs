using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VotingPollApp.Models
{
    public class Questions
    {
       
        [Key]
        public int QuestionId { get; set; }
        //[ForeignKey("Users")]
        //public int UserId { get; set; }
        public string Question { get; set; }
    }
}