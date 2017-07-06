﻿using AjaxJqueryTrongASPMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace AjaxJqueryTrongASPMVC.Controllers
{
    public class HomeController : Controller
    {
        List<EmployeeModel> listEmployee = new List<EmployeeModel>() {
             new EmployeeModel()
            {
            ID = 1,
                Name = "Nguyen Van A",
                Salary = 20000,
                Status = true
            },
              new EmployeeModel()
            {
            ID = 2,
                Name = "Nguyen Van B",
                Salary = 20000,
                Status = true
            },
               new EmployeeModel()
            {
            ID = 3,
                Name = "Nguyen Van C",
                Salary = 20000,
                Status = true
            },
               new EmployeeModel()
            {
            ID = 3,
                Name = "Nguyen Van D",
                Salary = 20000,
                Status = true
            },
               new EmployeeModel()
            {
            ID = 4,
                Name = "Nguyen Van E",
                Salary = 20000,
                Status = true
            },
               new EmployeeModel()
            {
            ID = 5,
                Name = "Nguyen Van F",
                Salary = 20000,
                Status = true
            },
               new EmployeeModel()
            {
            ID = 6,
                Name = "Nguyen Van G",
                Salary = 20000,
                Status = true
            },
               new EmployeeModel()
            {
            ID = 7,
                Name = "Nguyen Van H",
                Salary = 20000,
                Status = true
            },
               new EmployeeModel()
            {
            ID = 8,
                Name = "Nguyen Van I",
                Salary = 20000,
                Status = true
            },
               new EmployeeModel()
            {
            ID = 9,
                Name = "Nguyen Van K",
                Salary = 20000,
                Status = true
            },
        };

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult LoadData(int page,int pageSize = 3)
        {
            var model = listEmployee
                        .Skip((page - 1) * pageSize)
                        .Take(pageSize);
            int totalRow = listEmployee.Count;
            return Json(new
            {
                data = model,
                total = totalRow,
                status = true
            }, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult Update(string model)
        {
            //save data
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            EmployeeModel employee = serializer.Deserialize<EmployeeModel>(model);
            var entity = listEmployee.Single(x => x.ID == employee.ID);
            entity.Salary = employee.Salary;
            return Json(new
            {
                status = true
            });
        }
       
    }

}