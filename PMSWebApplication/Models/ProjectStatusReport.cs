﻿using System;

namespace PMSWebApplication.Models
{
    public class ProjectStatusReport
    {
        public int Id { get; set; }

        public DateTime? Deadline { get; set; }

        public string ClientName { get; set; }

        public string ProjectName { get; set; }

        public string EmployeeName { get; set; }

        public string ProjectStatus { get; set; }
    }
}