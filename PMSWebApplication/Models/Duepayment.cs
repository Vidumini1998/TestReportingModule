﻿using System;
using System.ComponentModel.DataAnnotations;

namespace PMSWebApplication.Models
{
    public class Duepayment
    {

        public int Id { get; set; }

        public string ProjectName { get; set; }

        //public string ClientName { get; set; }

        public DateTime? Deadline { get; set; }

        public string TaskName { get; set; }

        [Display(Name = "Paid Amount")]
        public decimal? PaidAmount { get; set; }
    }
}