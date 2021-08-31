using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Net;
using ReportePE.Models;

using S7.Net;
using System.Text.RegularExpressions;



namespace ReportePE.Controllers
{
    public class HomeController : Controller
    {
        CSL_CON_OPCEntities sp = new CSL_CON_OPCEntities();

       
        public ActionResult Index(int IdLinea = 0)
        {

            var today = DateTime.Today;
            DateTime inicio = today.AddDays(0);
            DateTime fin = today.AddDays(1);

            ViewBag.IdLinea = IdLinea;

            //ViewBag.HTH = (sp.Cambiodetroquels.Where(a => a.INICIO >= inicio && a.INICIO <= fin).Average(a => a.TOTALHTH) / 60.00);
            //ViewBag.HTR = (sp.Cambiodetroquels.Where(a => a.INICIO >= inicio && a.INICIO <= fin).Average(a => a.TOTAL) / 60.00);



            return View(sp.Cambiodetroquels.Where(a => a.INICIO >= inicio && a.INICIO <= fin && a.BANDERA == false && (IdLinea == 0 || a.IDLINEA == IdLinea)).OrderBy(b => b.INICIO).ToList());
        }

        public ActionResult Index2(int IdLinea = 0)
        {

            var today = DateTime.Today;
            DateTime inicio = today.AddDays(0);
            DateTime fin = today.AddDays(1);

            ViewBag.IdLinea = IdLinea;

            return View(sp.Cambiodetroquels.Where(a => a.INICIO >= inicio && a.INICIO <= fin && (IdLinea == 0 || a.IDLINEA == IdLinea)).OrderBy(b => b.INICIO).ToList());
        }

        public ActionResult Datefilter(DateTime inicio, DateTime fin, int IdLinea = 0)
        {

            ViewBag.inicio = inicio.Month.ToString() + "/" + inicio.Day.ToString() + "/" + inicio.Year.ToString();
            ViewBag.fin = fin.Month.ToString() + "/" + fin.Day.ToString() + "/" + fin.Year.ToString();
            ViewBag.IdLinea = IdLinea;
            fin = fin.AddHours(23);
            fin = fin.AddMinutes(59);

            return View(sp.Cambiodetroquels.Where(a => a.INICIO >= inicio && a.INICIO <= fin && (IdLinea == 0 || a.IDLINEA == IdLinea)).OrderBy(b => b.INICIO).ToList());
        }

        [HttpGet]
        [Route ("{IdLinea}")]
        public JsonResult Views(int IdLinea = 0)
        {

            var today = DateTime.Today;
            DateTime inicio = today.AddDays(0);
            DateTime fin = today.AddDays(1);
            ViewBag.IdLinea = IdLinea;
            // ViewBag.HTH = (sp.Cambiodetroquels.Where(a => a.INICIO >= inicio && a.INICIO <= fin).Average(a => a.TOTALHTH) / 60.00);
            // ViewBag.HTR = (sp.Cambiodetroquels.Where(a => a.INICIO >= inicio && a.INICIO <= fin).Average(a => a.TOTAL) / 60.00);

            return Json(sp.Cambiodetroquels.Where(a => a.INICIO >= inicio && a.INICIO <= fin && a.BANDERA == false && (IdLinea == 0 || a.IDLINEA == IdLinea)).OrderBy(b => b.INICIO).ToList(), JsonRequestBehavior.AllowGet);

        }

        [HttpGet]
        public JsonResult Views2(int IdLinea = 0)
        {

            var today = DateTime.Today;
            DateTime inicio = today.AddDays(0);
            DateTime fin = today.AddDays(1);
            ViewBag.IdLinea = IdLinea;


            // ViewBag.HTH = (sp.Cambiodetroquels.Where(a => a.INICIO >= inicio && a.INICIO <= fin).Average(a => a.TOTALHTH) / 60.00);
            // ViewBag.HTR = (sp.Cambiodetroquels.Where(a => a.INICIO >= inicio && a.INICIO <= fin).Average(a => a.TOTAL) / 60.00);

            return Json(sp.Cambiodetroquels.Where(a => a.INICIO >= inicio && a.INICIO <= fin && a.RUN == null && (IdLinea == 0 || a.IDLINEA == IdLinea)).OrderBy(b => b.INICIO).ToList(), JsonRequestBehavior.AllowGet);

        }


        [HttpGet]
        public JsonResult Lineas()
        {
            return Json(sp.PRENSAS_Cat_NombresLinea.ToList(), JsonRequestBehavior.AllowGet);
        }

    }

}