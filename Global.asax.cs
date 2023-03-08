using System;
using System.Diagnostics;
using System.Web;
using System.Web.Routing;
using System.Data;
using static Nave_Project2.Utils.Database;
namespace Nave_Project2
{
    public class Global : System.Web.HttpApplication
    {
        private bool DoesRowExist(string today)
        {
            return GetDataSet($"SELECT * FROM ViewsTable WHERE day_date='{today}'").Tables[0].Rows.Count != 0;
        }

        private void RegisterRoutes()
        {
            RouteTable.Routes.MapPageRoute("CatalogRoute", "Pages/shop/products/catalog/", "~/Pages/shop/products/catalog.aspx");
            RouteTable.Routes.MapPageRoute("MyProfile", "Pages/profile/my-profile/", "~/Pages/profile/my.aspx");
            RouteTable.Routes.MapPageRoute("ProductsRoute", "Pages/shop/products/{product}/", "~/Pages/shop/products/product.aspx");
            RouteTable.Routes.MapPageRoute("InvoicesRoute", "Pages/shop/invoices/{invoice}/", "~/Pages/shop/Invoices/invoice.aspx");
            RouteTable.Routes.MapPageRoute("RegisterRoute", "Pages/auth/registration", "~/Pages/auth/registration.aspx");
            RouteTable.Routes.MapPageRoute("LoginRoute", "Pages/auth/login", "~/Pages/auth/login.aspx");
            RouteTable.Routes.MapPageRoute("OrderRoute", "Pages/shop/order", "~/Pages/shop/order.aspx");
        }
        protected void Application_Start(object sender, EventArgs e)
        {
            RegisterRoutes();
            string query = "SELECT * FROM ViewsTable";
            var now = DateTime.Now;
            string today = $"{now.Day}/{now.Month}/{now.Year}";
            DataSet ds = GetDataSet(query);
            if (DoesRowExist(today))
            {
                DataRow row = ds.Tables[0].Select($"day_date='{today}'")[0];
                string CurrentValue = row["views"].ToString();
                int NewValue = int.Parse(CurrentValue) + 1;
                row["views"] = NewValue.ToString();
                SaveDatabase(query, ds);
            }
            // first view of the day
            else
            {
                DataRow row = ds.Tables[0].NewRow();
                row["day_date"] = today;
                row["views"] = "1";
                ds.Tables[0].Rows.Add(row);
                SaveDatabase(query, ds);
            }
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
            
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}