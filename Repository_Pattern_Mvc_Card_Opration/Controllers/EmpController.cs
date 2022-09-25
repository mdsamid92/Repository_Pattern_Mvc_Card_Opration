using Repository_Pattern_Mvc_Card_Opration.Models;
using Repository_Pattern_Mvc_Card_Opration.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Repository_Pattern_Mvc_Card_Opration.Controllers
{
    public class EmpController : Controller
    {
        private IEmployee _reg;

        public EmpController()
        {
            this._reg = new EmployeeRepo(new Mvc_RepositoryPattern22Entities());
        }

        public ActionResult Index()
        {
            var data = _reg.GetAll();
            return View(data);
        }

        public ActionResult Create()
        { 
            return View();  
        }

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            _reg.Insert(employee);
            _reg.Save();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var emp = _reg.GetById(id);
            return View(emp);
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            var emp = _reg.GetById(id);
            return View(emp);
        }
        [HttpPost]
        public ActionResult Delete(Employee employee)
        {
             _reg.Delete(employee);
             _reg.Save();
             return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var emp = _reg.GetById(id);
            return View(emp);
        }
        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            _reg.Update(employee);
            _reg.Save();
            return RedirectToAction("Index");
        }
    }
}