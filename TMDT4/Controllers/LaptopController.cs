using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TMDT4.Models;

namespace TMDT4.Controllers
{
    public class LaptopController : Controller
    {
        // GET: Laptop

        TMDT5Entities db = new TMDT5Entities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult getCompany()
        {
            var ListCompany = db.laptops.GroupBy(l => l.Company).Select(l => l.Key);
            return PartialView(ListCompany);
        }
        public ActionResult getCPU()
        {
            var ListCPU = db.laptops.GroupBy(l => l.Cpu).Select(l => l.Key);
            return PartialView(ListCPU);
        }

        public ActionResult SetScreenResolution()
        {
            var ScreenResolution = db.laptops.GroupBy(l => l.ScreenResolution).Select(l => l.Key);
            return PartialView(ScreenResolution);
        }

        public ActionResult SetTypeName()
        {
            var TypeName = db.laptops.GroupBy(l => l.TypeName).Select(l => l.Key);
            return PartialView(TypeName);
        }
        //4 diem

        public ActionResult SetMemory()
        {
            var SetMemory = db.laptops.GroupBy(l => l.Memory).Select(l => l.Key);
            return PartialView(SetMemory);
        }
        public ActionResult SetGPU()
        {
            var SetGPU = db.laptops.GroupBy(l => l.Gpu).Select(l => l.Key);
            return PartialView(SetGPU);
        }
        //5 diem

        public ActionResult SetOS()
        {
            var SetOS = db.laptops.GroupBy(l => l.OpSys).Select(l => l.Key);
            return PartialView(SetOS);
        }

        public ActionResult SetRam()
        {
            var SetRam = db.laptops.GroupBy(l => l.Ram.ToString()).Select(l => l.Key);
            return PartialView(SetRam);
        }
        //6 diem
        public ActionResult SetInch()
        {
            var SetInch = db.laptops.GroupBy(l =>Math.Round( (float)l.Inches,3).ToString()).Select(l => l.Key);
          
            return PartialView(SetInch);
        }
        public ActionResult SetSpeed()
        {
            var SetSpeed = db.laptops.GroupBy(l => Math.Round((float)l.Speed, 1).ToString()).Select(l => l.Key);

            return PartialView(SetSpeed);
        }
        // 7 diem

    }
}