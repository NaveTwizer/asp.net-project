using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nave_Project2.Utils
{
    public class Security
    {
        public static void RedirectUnloggedUser(HttpContext context)
        {
            var Session = context.Session;
            try
            {
                String _us = Session["username"].ToString();
            }
            catch (Exception)
            {
                context.Response.Redirect("~/Pages/login.aspx", true);
                return;
            }
            String username = Session["username"].ToString();
            if (String.IsNullOrEmpty(username))
            {
                context.Response.Redirect("~/Pages/login.aspx", true);
                return;
            }
        }
        public static void RedirectLoggedUserFromAdminePages(HttpContext ctx)
        {
            var Session = ctx.Session;
            try
            {
                String _us = Session["username"].ToString();
            }
            catch (Exception)
            {
                ctx.Response.Redirect("~/Pages/login.aspx", true);
                return;
            }
            String username = Session["username"].ToString();
            if (String.IsNullOrEmpty(username))
            {
                ctx.Response.Redirect("~/Pages/login.aspx", true);
                return;
            }
            if (!username.Equals("nave"))
            {
                ctx.Response.Redirect("~/Pages/LoggedHomePage.aspx", true);
            }
        }
    }
}