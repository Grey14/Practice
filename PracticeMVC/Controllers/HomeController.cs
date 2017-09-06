using PracticeMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace PracticeMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult GetStudentPropertyName()
        {
            string[] names = typeof(Student).GetProperties().Select(p => p.Name).ToArray();
            return Json(names);
        }

        public ActionResult GetStudents()
        {
            //準備假資料
            List<Student> data = new List<Student>();
            data.Add(new Student { Name = "Wang Xiaoming", Height = 170, Weight = 72 });
            data.Add(new Student { Name = "Zhang Xiaochun", Height = 180, Weight = 75 });
            data.Add(new Student { Name = "Tian Fengsheng", Height = 175, Weight = 60 });
            data.Add(new Student { Name = "Yang Ming Shan", Height = 165, Weight = 90 });
            data.Add(new Student { Name = "Linghu Chong", Height = 172, Weight = 80 });
            //計算BMI
            foreach (var item in data)
            {
                var height = item.Height / 100;
                item.BMI = Math.Round(item.Weight / (height * height),2);
                if (item.BMI > 30)
                    item.Memo = "too heavy!";
                if (item.BMI < 20)
                    item.Memo = "too thin!";
            }

            return Json(data);
        }
    }
}