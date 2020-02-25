using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;

namespace ChildPro.Controllers
{
    public class TestController : Controller
    {
        TeacherManager teacherManager = new TeacherManager();
        // GET: Test
        public ActionResult Index()
        {
            var teacher = teacherManager.GetTeacher();
            return View(teacher);
        }
    }
}