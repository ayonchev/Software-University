namespace LogNoziroh.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;
    using Models;

    [ValidateInput(false)]
    public class ReportController : Controller
    {
        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            using (var db = new LogNozirohDbContext())
            {
                var reports = db.Reports.ToList();
                return View(reports);
            }
        }

        [HttpGet]
        [Route("details/{id}")]
        public ActionResult Details(int id)
        {
            using (var db = new LogNozirohDbContext())
            {
                var report = db.Reports
                    .Where(a => a.Id == id)
                    .First();

                return View(report);
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
        public ActionResult Create(Report report)
        {
            using (var db = new LogNozirohDbContext())
            {
                db.Reports.Add(report);
                db.SaveChanges();

                return this.Redirect("/");
            }
        }

        [HttpGet]
        [Route("delete/{id}")]
        public ActionResult Delete(int id)
        {
            using (var db = new LogNozirohDbContext())
            {
                var report = db.Reports.Find(id);
                
                return View(report);
            }
        }

        [HttpPost]
        [Route("delete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id, Report reportModel)
        {
            using (var db = new LogNozirohDbContext())
            {
                var reportFromDb = db.Reports.Find(id);

                db.Reports.Remove(reportFromDb);
                db.SaveChanges();

                return Redirect("/");
            }
        }
    }
}