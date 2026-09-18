using Microsoft.AspNetCore.Mvc;
using IT_ELECTIVE_2_Midterm_A1_Antonio_MarcKevin.Data;
using IT_ELECTIVE_2_Midterm_A1_Antonio_MarcKevin.Models;

namespace IT_ELECTIVE_2_Midterm_A1_Antonio_MarcKevin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var projects = PortfolioData.Projects;
            return View(projects);
        }

        public IActionResult Details(int id)
        {
            var project = PortfolioData.Projects.FirstOrDefault(p => p.Id == id);
            if (project == null)
            {
                return NotFound();
            }
            return View(project);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddComment(int projectId, string author, string content)
        {
            var project = PortfolioData.Projects.FirstOrDefault(p => p.Id == projectId);
            if (project != null && !string.IsNullOrWhiteSpace(author) && !string.IsNullOrWhiteSpace(content))
            {
                project.Comments.Add(new Comment
                {
                    Id = project.Comments.Count + 1,
                    ProjectId = projectId,
                    Author = author,
                    Content = content,
                    DateAdded = DateTime.Now
                });
            }
            return RedirectToAction("Details", new { id = projectId });
        }
    }
}