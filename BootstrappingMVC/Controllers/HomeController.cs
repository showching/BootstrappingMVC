using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BootstrappingMVC.Models;

namespace BootstrappingMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var notifications = new List<NotificationViewModel>();
            notifications.Add(new NotificationViewModel
            {
                Count = 2,
                NotificationType = "Registration",
                BadgeClass = "info"
            });
            notifications.Add(new NotificationViewModel
            {
                Count = 1,
                NotificationType = "Email",
                BadgeClass = "success"
            });
            ViewBag.Notifications = notifications;

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
    }
}