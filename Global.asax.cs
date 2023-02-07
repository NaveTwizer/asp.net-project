using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Routing;

namespace Nave_Project2
{
    public class Global : System.Web.HttpApplication
    {
        void RegisterCustomRoutes(RouteCollection routes)
        {
            /*routes.MapPageRoute(
                "ProductsByCategoryRoute",
                "Category/{categoryName}",
                "~/ProductList.aspx"
            );*/
            /*routes.MapPageRoute(
                "ProductByNameRoute",
                "Product/{productName}",
                "~/ProductDetails.aspx"
            );*/
            //routes.MapPageRoute(
            //    "Profile",
            //    "Pages/profiles/{username}",
            //    "~/Pages/profiles/redirect.aspx"
            //);
        }
        protected void Application_Start(object sender, EventArgs e)
        {
            RouteTable.Routes.MapPageRoute("OtherUser", "Pages/profiles/{username}", "~/Pages/profiles/OtherUser.aspx");
            RouteTable.Routes.MapPageRoute("MyProfile", "Pages/profiles/my-profile", "~/Pages/profiles/my-profile.aspx");
            //RouteTable.Routes.MapPageRoute("ProfileRedirecting", "Pages/profiles/{username}", "~/Pages/profiles/redirect.aspx");
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            var serverError = Server.GetLastError() as HttpException;

            if (serverError != null)
            {
                if (serverError.GetHttpCode() == 404)
                {
                    Server.ClearError();
                    Server.Transfer("~/Pages/404.aspx");
                }
            }
        }
        protected void Session_End(object sender, EventArgs e)
        {
            Response.Redirect("/Pages/afk.aspx");
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}