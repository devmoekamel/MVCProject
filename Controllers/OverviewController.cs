﻿using System.Security.Claims;
using FreelanceManager.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace FreelanceManager.Controllers
{
    public class OverviewController : Controller
    {
        private readonly IClientRepo clientRepo;
        private readonly IMissionRepo missionRepo;
        private readonly IProjectRepo projectRepo;
        private readonly ITimeTrackingRepo timeTrackingRepo;

        public OverviewController(IClientRepo clientRepo,IMissionRepo missionRepo , IProjectRepo projectRepo,ITimeTrackingRepo timeTrackingRepo)
        {
            this.clientRepo = clientRepo;
            this.missionRepo = missionRepo;
            this.projectRepo = projectRepo;
            this.timeTrackingRepo = timeTrackingRepo;
        }
<<<<<<< HEAD
        public IActionResult Index()
        {
            string Userid = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value; // this return id of user

            OverviewVM overview = new()
            { ClientsNum = projectRepo.GetAll().Where(p => p.FreelancerId == Userid).Select(p=>p.Client).Count(),
              RecentTasks= missionRepo.GetAll().TakeLast(5),
              RecentProjects =projectRepo.GetAll().TakeLast(5),
              TasksNum = projectRepo.GetAll().Where(p => p.FreelancerId == Userid).SelectMany(p=>p.Missions).Count(),
              ProjectsNum= projectRepo.GetAll().Where(p=>p.FreelancerId==Userid).Count(),
            };
            return View(overview);
        }
    }
=======
		public IActionResult Index()
		{
			string Userid = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value; // this return id of user

			OverviewVM overview = new()
			{
				ClientsNum = projectRepo.GetAll().Where(p => p.FreelancerId == Userid).Select(p => p.Client).Count(),
				RecentTasks = missionRepo.GetAll().TakeLast(5),
				RecentProjects = projectRepo.GetAll().TakeLast(5),
				TasksNum = projectRepo.GetAll().Where(p => p.FreelancerId == Userid).SelectMany(p => p.Missions).Count(),
				ProjectsNum = projectRepo.GetAll().Where(p => p.FreelancerId == Userid).Count(),
			};
			return View(overview);
		}
	}
>>>>>>> 652093f27841105ed75fb3098c01d835172f601d
}
