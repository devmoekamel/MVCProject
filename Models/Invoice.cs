﻿using System.ComponentModel.DataAnnotations.Schema;
using FreelanceManager.Models;

namespace WebApplication2.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public String Status { get; set; }
        public String Currency { get; set; }
        public String Notes { get; set; }

        [ForeignKey("Project")]
        public int ProjectId { get; set; }
        public Project? project { get; set; }
    }
}
