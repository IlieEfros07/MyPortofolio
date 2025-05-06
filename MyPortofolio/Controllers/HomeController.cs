using Microsoft.AspNetCore.Mvc;
using MyPortofolio.Models;
using System.Collections.Generic;

namespace MyPortfolio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            var skills = new List<string>
            {
                "C#","C++","Python","Java", "ASP.NET Core", "Entity Framework",
                "SQL Server", "JavaScript", "React/Vite","HTML/CSS",
                "Git"
            };

            var projects = new List<Project>
            {
                new Project
                {
                    Title = "Avicol ISI Farm",
                    Description = "Full-stack ordering app for Avicol ISI Farm",
                    Technologies = new List<string> { "ASP.NET Core", "Entity Framework", "MySQL" },
                    Link="https://github.com/IlieEfros07/avicol-isi-farm" ,
                    ImageUrl = "https://i.imgur.com/CgFOIFP.png"
                },
                new Project
                {
                    Title = "Pathway Career Finder",
                    Description = "Desing for a career finder app",
                    Technologies = new List<string> { "ASP.NET Core", "Entity Framework", "MySQL", "HTML/CSS" },
                    Link = "https://github.com/IlieEfros07/pathway-career-finder-",
                    ImageUrl = "https://i.imgur.com/OQE6TVA.png"
                },
                new Project
                {
                    Title = "Task Manager with AI",
                    Description = "To Do app that uses AI to compose your task",
                    Technologies = new List<string> { "React", "ForeFornt API", "Prisma" },
                    Link="https://github.com/IlieEfros07/Task-Manager-with-AI",
                    ImageUrl = "https://i.imgur.com/f0WCLzO.png"

                },
                new Project
                {
                    Title = "GoPro Landing Page",
                    Description = "A Landing Page for GoPro",
                    Technologies = new List<string> { "HTML", "CSS" },
                    Link="https://github.com/IlieEfros07/GOPRO-PROJECT",
                    ImageUrl = "https://i.imgur.com/rLQdQLC.png"
                }

            };

            ViewBag.Skills = skills;
            ViewBag.Projects = projects;

            return View();
        }
    }
}