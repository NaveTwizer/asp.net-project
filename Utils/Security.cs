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
            // פעולה שנועדה למנוע ממשתמשים לא רשומים לגשת לאזורים הלא מורשים להם
            var Session = context.Session;
            try
            {
                String _us = Session["username"].ToString();
            }
            catch (Exception)
            {
                context.Response.Redirect("~/Pages/auth/login", true);
                return;
            }
            String username = Session["username"].ToString();
            if (String.IsNullOrEmpty(username))
            {
                context.Response.Redirect("~/Pages/auth/login", true);
                return;
            }
        }
        public static void RedirectLoggedUserFromAdminePages(HttpContext ctx)
        {
            // פעולה שנועדה למנוע מלקוחות רשומים מלהגיע לאיזורי מנהל
            var Session = ctx.Session;
            try
            {
                String _us = Session["username"].ToString();
            }
            catch (Exception)
            {
                ctx.Response.Redirect("~/Pages/auth/login", true);
                return;
            }
            String username = Session["username"].ToString();
            if (String.IsNullOrEmpty(username))
            {
                ctx.Response.Redirect("~/Pages/auth/login", true);
                return;
            }
            if (!username.Equals("nave"))
            {
                ctx.Response.Redirect("~/Pages/LoggedHomePage.aspx", true);
            }
        }
    }
}