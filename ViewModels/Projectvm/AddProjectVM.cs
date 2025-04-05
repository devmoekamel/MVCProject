﻿using FreelanceManager.Enums;
using System.ComponentModel.DataAnnotations;

namespace FreelanceManager.ViewModels.Projectvm
{
    public class AddProjectVM
    {
		[Required]
		public string Name { get; set; }
		[Required]
        public double Budget { get; set; }
		[Required]

        public double HourlyRate { get; set; }
        [Required]

        public string Company { get; set; }
        [Required]

        public priority Priority { get; set; }

        [Required]
        public categoty category { get; set; }
        [Required]

        public string Description { get; set; }
        [Required]

        public DateTime StartDate { get; set; }
        [Required]

        public DateTime EndDate { get; set; }
        [Required]

        public int ClientId { get; set; }

	}
}
