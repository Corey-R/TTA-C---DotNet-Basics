using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;
using CarInsurance.ViewModels;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var insurees = db.Insurees;                

                var insureeVms = new List<insureeVm>();
                foreach (var insuree in insurees)
                {
                    var insureeVm = new insureeVm();
                    insureeVm.Id = insuree.Id;
                    insureeVm.Quote = Math.Round(insuree.Quote, 2);
                    insureeVm.FirstName = insuree.FirstName;
                    insureeVm.LastName = insuree.LastName;
                    insureeVm.EmailAddress = insuree.EmailAddress;
                    insureeVms.Add(insureeVm);
                }
                return View(insureeVms);
            }
            
        }
    }
}