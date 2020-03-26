namespace ProjectRider.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;
    using Models;

    [ValidateInput(false)]
    public class ProjectController : Controller
    {
        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            using (var db = new ProjectRiderDbContext())
            {
                var projects = db.Projects.ToList();
                return View(projects);
            }
        }

        [HttpGet]
        [Route("create")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Project project)
        {
            using (var db = new ProjectRiderDbContext())
            {
                db.Projects.Add(project);
                db.SaveChanges();

                return this.Redirect("/");
            }
        }

        [HttpGet]
        [Route("edit/{id}")]
        public ActionResult Edit(int id)
        {
            using (var db = new ProjectRiderDbContext())
            {
                Project currentProject = db.Projects.Find(id);

                return View(currentProject);

            }
        }

        [HttpPost]
        [Route("edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult EditConfirm(int id, Project project)
        {
            using (var db = new ProjectRiderDbContext())
            {
                Project currentProject = db.Projects.Find(id);

                currentProject.Title = project.Title;
                currentProject.Description = project.Description;
                currentProject.Budget = project.Budget;

                db.SaveChanges();

                return Redirect("/");
            }
        }

        [HttpGet]
        [Route("delete/{id}")]
        public ActionResult Delete(int id)
        {
            using (var db = new ProjectRiderDbContext())
            {
                var project = db.Projects.Find(id);

                return View(project);
            }
        }

        [HttpPost]
        [Route("delete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id, Project reportModel)
        {
            using (var db = new ProjectRiderDbContext())
            {
                var projectFromDb = db.Projects.Find(id);

                db.Projects.Remove(projectFromDb);
                db.SaveChanges();

                return Redirect("/");
            }
        }
    }
}