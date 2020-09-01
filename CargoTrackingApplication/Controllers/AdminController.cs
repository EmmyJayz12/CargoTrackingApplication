using CargoTrackingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CargoTrackingApplication.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            if (AuthenticateUser())
            {
                return RedirectToAction("Inbox");
            }
            return View();
        }

        [HttpPost]
        public ActionResult Index(string username, string password)
        {
            if (ModelState.IsValid)
            {
                using (CargoTrackerDbContext db = new CargoTrackerDbContext())
                {
                    var result = db.AdminLogins.SingleOrDefault(u => u.Username == username && u.Password == password);
                    if (result == null)
                    {
                        ViewBag.Message = "Invalid Email or Password";
                        return View();
                    }
                    Session["user"] = result;
                }
            }
            return RedirectToAction("Inbox");
        }


        public ActionResult Clientreg()
        {
            if (!AuthenticateUser())
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public ActionResult Clientreg(ClientRegistration reg)
        {
            if (ModelState.IsValid)
            {
                using (CargoTrackerDbContext db = new CargoTrackerDbContext())
                {
                    var result = db.ClientRegistrations.Add(reg);
                    if (result == null)
                    {
                        return View();
                    }
                    else
                    {
                        db.SaveChanges();
                    }
                    TrackInfoUpdate update = new TrackInfoUpdate();
                    update.TrackingId = result.TrackingId;
                    update.CreatedOn = result.CreatedOn;
                    update.Location = result.ShippersCountryName;
                    update.Status = result.Status;
                    db.UpdateTrackerInformations.Add(update);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = reg.ShippersFirstName + " " + reg.ShippersLastName + " " + "was successfully Registered";

            }
            return View();
        }


        public ActionResult clientupdate()
        {
            if (!AuthenticateUser())
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        public ActionResult Edit(int? id)
        {
            if (!AuthenticateUser())
            {
                return RedirectToAction("Index");
            }

            if (id == null || id == 0)
            {
                return RedirectToAction("manageusers");
            }

            using (CargoTrackerDbContext db = new CargoTrackerDbContext())
            {
                var result = db.ClientRegistrations.SingleOrDefault(u => u.UserId == id);
                if (result == null)
                {
                    return RedirectToAction("manageusers");
                }

                Session["client"] = result;
               
            }
            return RedirectToAction("clientupdate");
        }

        [HttpPost]
        public ActionResult clientupdate(ClientRegistration reg)
        {
            if (reg.UserId == 0)
            {
                return RedirectToAction("inbox");
            }

            if (ModelState.IsValid) { 

            using (CargoTrackerDbContext db = new CargoTrackerDbContext())
            {
                var result = db.ClientRegistrations.SingleOrDefault(u => u.UserId == reg.UserId);
                if (result == null)
                {
                    return RedirectToAction("Manageusers");
                }
                              
                result.ShippersFirstName = reg.ShippersFirstName;
                result.ShippersLastName = reg.ShippersLastName;
                result.ReceiversFirstName = reg.ReceiversFirstName;
                result.ReceiversLastName = reg.ReceiversLastName;
                result.ReceiversCountryName = reg.ReceiversCountryName;
                result.ReceiversEmail = reg.ReceiversEmail;
                result.ReceiversPhone = reg.ReceiversPhone;
                result.ShippersPhone = reg.ShippersPhone;
                result.Status = reg.ShippersPhone;
                result.TrackingId = reg.TrackingId;
                result.weight = reg.weight;
                result.TotalFreight = reg.TotalFreight;
                result.ReceiversAddress = reg.ReceiversAddress;
                result.BookingMode= reg.BookingMode;
                result.Comment = reg.Comment;
                result.CreatedOn = reg.CreatedOn;
                result.Invoice = reg.Invoice;
                result.PickTime = reg.PickTime;
                result.PickupDate = reg.PickupDate;
                result.DeliveryMode = reg.DeliveryMode;
                result.Description = reg.Description;
                db.SaveChanges();
            }
                
            }

            return RedirectToAction("Manageusers");
        }

        public ActionResult Delete(int? id)
        {
            if (!AuthenticateUser())
            {
                return RedirectToAction("Index");
            }

            if (id == null || id == 0)
            {
                return RedirectToAction("manageusers");
            }

            using (CargoTrackerDbContext db = new CargoTrackerDbContext())
            {
                var result = db.ClientRegistrations.Find(id);
                if(result == null)
                {
                    return RedirectToAction("manageusers");
                }
                string TrackingId = result.TrackingId;
                var data = db.ClientRegistrations.Remove(result);
                db.SaveChanges();
                if (data == null)
                {
                    var result2 = db.UpdateTrackerInformations.Find(TrackingId);
                    db.UpdateTrackerInformations.Remove(result2);
                    db.SaveChanges();
                }
            }

            return RedirectToAction("manageusers");
        }

        public ActionResult AdminRegistration()
        {
            if (!AuthenticateUser())
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpPost]
        public ActionResult AdminRegistration(AdminLogin login)
        {
            if (ModelState.IsValid)
            {
                using (CargoTrackerDbContext db = new CargoTrackerDbContext())
                {
                    if (login.Password != login.ConfirmPassword)
                    {
                        ViewBag.Message = "Both password must be the same";
                        return View();
                    }
                    var result = db.AdminLogins.Add(login);
                    if (result == null)
                    {
                        return View();
                    }
                    db.SaveChanges();
                }
                ViewBag.Message = "Successfully Registered";
                ModelState.Clear();
            }
            return View();
        }

        public ActionResult Createtrackinfo()
        {
            if (!AuthenticateUser())
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpPost]
        public ActionResult Createtrackinfo(string TrackingId, string Location, string Status)
        {
            if (ModelState.IsValid)
            {
                using (CargoTrackerDbContext db = new CargoTrackerDbContext())
                {
                    var result = db.UpdateTrackerInformations.SingleOrDefault(U => U.TrackingId == TrackingId);
                    if (result == null)
                    {
                        return View();
                    }
                    result.Location = Location;
                    result.Status = Status;
                    result.CreatedOn = DateTime.Now;
                    db.SaveChanges();
                }
                ViewBag.Message = "Successful Update";
                ModelState.Clear();
            }
            return View();
        }


        public ActionResult Delclient()
        {
            if (!AuthenticateUser())
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        public ActionResult Delmsg()
        {
            if (!AuthenticateUser())
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        public ActionResult Delrep()
        {
            if (!AuthenticateUser())
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        public ActionResult Inbox()
        {
            if (!AuthenticateUser())
            {
                return RedirectToAction("Index");
            }

            using (CargoTrackerDbContext db = new CargoTrackerDbContext())
            {
                var result = db.Contacts.ToList();
                if (result == null)
                {
                    return RedirectToAction("Index");
                }
                result.Reverse();
                return View(result);
            }

        }

        public ActionResult Logout()
        {
            if (!AuthenticateUser())
            {
                return RedirectToAction("Index");
            }

            Session.Clear();
            return RedirectToAction("Index"); ;
        }

        public ActionResult Manageacct()
        {
            if (!AuthenticateUser())
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        public ActionResult Manageusers()
        {
            if (!AuthenticateUser())
            {
                return RedirectToAction("Index");
            }

            using (CargoTrackerDbContext db = new CargoTrackerDbContext())
            {
                var result = db.ClientRegistrations.ToList();
                if (result == null)
                {
                    return RedirectToAction("Index");
                }
                result.Reverse();
                return View(result);
            }

        }

        public ActionResult Report()
        {
            if (!AuthenticateUser())
            {
                return RedirectToAction("Index");
            }

            using (CargoTrackerDbContext db = new CargoTrackerDbContext())
            {
                var result = db.UpdateTrackerInformations.ToList();
                if(result == null)
                {
                    return View();
                }

                result.Reverse();
                return View(result);
            }
            
        }


        public ActionResult Close1()
        {
            if (!AuthenticateUser())
            {
                return RedirectToAction("Index");
            }

            Session.Clear();
            return RedirectToAction("Inbox");
        }

        public Boolean AuthenticateUser()
        {
            if (Session["user"] != null)
            {
                return true;
            }

            return false;
        }

    }
}