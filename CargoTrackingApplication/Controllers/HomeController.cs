using CargoTrackingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CargoTrackingApplication.Controllers
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

        public ActionResult Service()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(TrackContactUs contactUs)
        {
            if (ModelState.IsValid)
            {
                using (CargoTrackerDbContext db = new CargoTrackerDbContext())
                {
                    db.Contacts.Add(contactUs);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = contactUs.FullName + " " + "Request was successfully sent";
                return View();
            }

            return View();
        }

        public ActionResult TrackShipment()
        {
            return View();
        }

        [HttpPost]
        public ActionResult TrackShipment(string TrackingId)
        {
            if (ModelState.IsValid)
            {
                using (CargoTrackerDbContext db = new CargoTrackerDbContext())
                {
                    var result = db.ClientRegistrations.SingleOrDefault(u => u.TrackingId == TrackingId);
                    var result2 = db.UpdateTrackerInformations.SingleOrDefault(u => u.TrackingId == TrackingId);
                    if(result == null)
                    {
                        ViewBag.Message = "Invalid User Tracker Id";
                        return View();
                    }
                    db.SaveChanges();
                    Session["User"] = result;
                    Session["User2"] = result2;
                }
               
            }
            return RedirectToAction("Account");
        }

        public ActionResult Account()
        {
            if(Session["User"] == null)
            {
                return RedirectToAction("TrackShipment");
            }
            return View();
        }

        public ActionResult Feedback()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Feedback(TrackContactUs track)
        {
            if (ModelState.IsValid)
            {
                using (CargoTrackerDbContext db = new CargoTrackerDbContext())
                {
                    var result = db.Contacts.Add(track);
                    if(result == null)
                    {
                        return View();
                    }
                    db.SaveChanges();
                }
                ViewBag.Message = "Message sent Successfully";
                ModelState.Clear();
            }
            return View();
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index");
        }

    }
}