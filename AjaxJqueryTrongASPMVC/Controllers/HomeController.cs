using AjaxJqueryTrongASPMVC.Models;
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
        };

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult LoadData(string model)
        {
            return Json(new
            {
                data = listEmployee,
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