﻿using FreelanceManager.Enums;
using FreelanceManager.Models;

namespace FreelanceManager.ViewModels.Project
{
    public class ProjectDetialsVM
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public double Budget { get; set; }
        public double HourlyRate { get; set; }
        public string Company { get; set; }
        public priority Priority { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public status Status { get; set; }


		// addition
		public int AllMissionsCount { get; set; }
		public int CompletedMissionsCount { get; set; }

		public IEnumerable<Mission> Missions { get; set; }

    }
}
