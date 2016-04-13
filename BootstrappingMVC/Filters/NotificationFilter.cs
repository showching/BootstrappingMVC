using BootstrappingMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrappingMVC.Filters
{
    public class NotificationFilter : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
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

            filterContext.Controller.ViewBag.Notifications = notifications;
        }
    }
}