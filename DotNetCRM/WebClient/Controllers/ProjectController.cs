using DataModels.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using WebClient.Helper;

namespace WebClient.Controllers
{
    public class ProjectController : Controller
    {
        private IProjectRepository _repo;

        public ProjectController()
        {
            _repo = new ProjectRepository();
        }
        // GET: Project
        [HttpGet]
        public ActionResult Index()
        {
            List<RestProject> projects = _repo.GetAll();

            return View(projects);
        }

        // GET: Project/Details/5
        [HttpGet]
        public ActionResult Details(int id)
        {
            RestProject project = _repo.GetById(id);

            return View(project);
        }

        [HttpGet]
        public ActionResult Export()
        {
            string path = Directory.GetCurrentDirectory();
            string fileName = "projects.xml";

            XDocument doc = new XDocument();
            XElement projects = new XElement("Projects",
                                from project in _repo.GetAll()
                                select new XElement("Project",
                                                new XAttribute("Id", project.Id),
                                                new XAttribute("Name", project.Name),
                                                new XElement("Descirption", project.Description),
                                                new XAttribute("Status", project.Status),
                                                new XAttribute("Projecthead", project.ProjectHeadId)));

            doc.Add(projects);
            doc.Save(path + "/" + fileName);

            // .xml File für Download bereitstellen
            Response.Clear();
            Response.AddHeader("content-disposition", "attachment; filename=" + fileName);
            Response.WriteFile(path + "/" + fileName);
            Response.ContentType = "";
            Response.End();

            //return File(System.IO.File.ReadAllBytes("C:/eplatform/projects.xml"), "application/xml");
            //return Content(doc.ToString());
            return RedirectToAction("Index", "Project");
            //return Redirect("~/Project");
        }

        // GET: Project/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Project/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Project/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Project/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Project/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Project/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
