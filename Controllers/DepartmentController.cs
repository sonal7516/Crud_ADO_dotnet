using Crud_ADO_dotnet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Crud_ADO_dotnet.Controllers
{
    public class DepartmentController : Controller
    {
        private DepartmentDB department = new DepartmentDB();
        public ActionResult Index()
        {
            var dept = department.GetAllDepartment();
            return View(dept);
        }
    }
}