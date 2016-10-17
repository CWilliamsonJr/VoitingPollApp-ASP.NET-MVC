using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc.Html;

namespace VotingPollApp.Models
{
    public class Polls
    {
        private readonly int _votes;
        // private MyDbContext db = new MyDbContext();
        
        public int Id { get; set; }
        public bool Public { get; set; } = true;
        public Users UserId { get; set; }
        [Required]
        public string Question { get; set; }
        public int Votes => _votes;
        [Display(Name = "Option")]
        public string Choice { get; set; }
    }
}