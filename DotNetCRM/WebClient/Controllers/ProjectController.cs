using DataModels.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebClient.Helper;

namespace WebClient.Controllers
{
    public class ProjectController : Controller
    {
        private IProjectRepository _repo;

        public ProjectController()
        {
            _repo = new ProjectRepositoryFake();
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
