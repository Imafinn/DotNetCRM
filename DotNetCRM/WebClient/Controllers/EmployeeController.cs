using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebClient.Controllers
{
    using Helper;
    using DataModels.Entities;
    using System.IO;
    using System.Xml.Linq;

    public class EmployeeController : Controller
    {
        private IEmployeeRepository _repo;

        public EmployeeController()
        {
            _repo = new EmployeeRepository();
        }
        // GET: Employee
        [HttpGet]
        public ActionResult Index()
        {
            List<RestEmployee> employees = _repo.GetAll();

            return View(employees);
        }

        // GET: Employee/Details/5
        [HttpGet]
        public ActionResult Details(int id)
        {
            RestEmployee employee = _repo.GetById(id);

            return View(employee);
        }

        [HttpGet]
        public ActionResult Export()
        {
            string path = Directory.GetCurrentDirectory();
            string fileName = "employees.xml";

            XDocument doc = new XDocument();
            XElement employees = new XElement("Employees",
                                from employee in _repo.GetAll()
                                select new XElement("Employee",
                                                new XAttribute("Id", employee.Id),
                                                new XAttribute("Firstname", employee.Firstname),
                                                new XAttribute("Lastname", employee.Lastname),
                                                new XAttribute("Department", employee.Department),
                                                new XAttribute("Salary", employee.Salary)));

            doc.Add(employees);
            doc.Save(path + "/" + fileName);

            // .xml File für Download bereitstellen
            Response.Clear();
            Response.AddHeader("content-disposition", "attachment; filename=" + fileName);
            Response.WriteFile(path + "/" + fileName);
            Response.ContentType = "";
            Response.End();

            //return File(System.IO.File.ReadAllBytes("C:/eplatform/projects.xml"), "application/xml");
            //return Content(doc.ToString());
            return RedirectToAction("Index", "Employee");
            //return Redirect("~/Project");
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
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

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employee/Edit/5
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

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete/5
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
