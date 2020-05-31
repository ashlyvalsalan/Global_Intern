﻿using Global_Intern.Models;
using System;
namespace Global_Intern.Models
{
    public class StudentExperience
    {
        public int ExperienceId { get; set; }
        public string ExperienceTitle { get; set; }
        public string ExperienceType { get; set; }
        public string ExperienceCompany { get; set; }
        public string Location { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public Boolean Present { get; set; }
        public Student Student { get; set; }
    }
}
