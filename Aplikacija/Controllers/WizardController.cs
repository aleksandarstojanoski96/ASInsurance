using Aplikacija.Core;
using Domain.Interfaces;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aplikacija.Controllers
{
    public class WizardController : Controller
    {
        PolicyRepository p_repo = new PolicyRepository();

        // GET: Wizard
        public ActionResult Index()
        {
            return View();
        }

        // GET: Wizard/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Wizard/Create
        public ActionResult Create()
        {
            ViewBag.Franshiza = new SelectList(p_repo.GetAllFranshizas(), "ID", "Name");  //odi do baza i zemi gi site zapisi od tabela franshiza //Franshiza.ToList();
            ViewBag.Package = new SelectList(p_repo.GetAllPackages(), "ID", "Name");
            ViewBag.ContractorTipkind = new SelectList(p_repo.GetAllTipkinds(), "ID", "Title");
            ViewBag.InsuredTipkind = new SelectList(p_repo.GetAllTipkinds(), "ID", "Title");
            return View();
        }

        //POST: Wizard/Create
        [HttpPost]
        public ActionResult Create(PolicyViewModel collection, string package, string franshiza, string contractortipkind, string insuredtipkind)
        {
            string policyID = string.Empty;
            int ID = 0;
      
            try
            {
                if (p_repo.SavePolicy(collection, package, franshiza, contractortipkind, insuredtipkind, out policyID) && int.TryParse(policyID, out ID))
                    return RedirectToAction("Test", new { id = ID});
                else
                    return View();
            }
            catch (Exception ex)
            {
                ViewBag.ErrMsg = ex.Message;
                return View();
            }
            //return Json(new { success = true }, JsonRequestBehavior.AllowGet);

            //return Json(new { success = false }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Test(int id)
        {
            //ViewBag.Franshiza = p_repo.
            PolicyViewModel p = p_repo.GetPolicyByID(id);
            if (p.PolicyID != 0)
                return View(p);
            else
                return View();
        }

        //[HttpPost]
        //public JsonResult Create(PolicyViewModel collection, string package, string franshiza, string contractortipkind, string insuredtipkind)
        //{

        //    try
        //    {
        //        string _err = "";
        //        //p_repo.SavePolicy(collection, package, franshiza, contractortipkind, insuredtipkind);
        //        return Json(new { success = true, path = "Views/Wizard/Test.cshtml" }, JsonRequestBehavior.AllowGet);
        //        //return Json(new { success = p_repo.SavePolicy(collection, package, franshiza, contractortipkind, insuredtipkind), path = "example.cshtml" }, JsonRequestBehavior.AllowGet);
        //    }
        //    catch(Exception ex)
        //    {
        //        return Json(new { success = false, error = ex.Message }, JsonRequestBehavior.AllowGet);
        //    }
        //}

        // POST: Wizard/Create
        //[HttpPost]
        //public ActionResult AddPolicy(PolicyViewModel collection, string package, string franshiza, string contractortipkind, string insuredtipkind)
        //{
        //    //Write your database insert code / activities  
        //    return RedirectToAction("create");
        //}

        // GET: Wizard/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Wizard/Edit/5
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

        // GET: Wizard/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Wizard/Delete/5
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
