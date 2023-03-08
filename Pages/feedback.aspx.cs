using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
//using System.Web.UI.DataVisualization.Charting;
using static Nave_Project2.Utils.Database;
using static Nave_Project2.Utils.Security;

namespace Nave_Project2.Pages
{
    public partial class feedbacl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RedirectUnloggedUser(Context);
            this.output.InnerText = "";
        }

        private (string, string, string, string, string) GetFormData()
        {
            return (
                Request.Form["opinion"],
                Request.Form["access"],
                Request.Form["quality"],
                Request.Form["design"],
                Request.Form["feedback"]
            );
        }
        protected void SendButton_Click(object sender, EventArgs e)
        {
            (string opinion, string access, string quality, string design, string feedback) = GetFormData();

            string query = "SELECT * FROM Feedbacks";
            DataSet ds = GetDataSet(query);
            DataRow row = ds.Tables[0].NewRow();

            row["username"] = Session["username"];
            row["opinion"] = opinion;
            row["access"] = access;
            row["quality"] = quality;
            row["design"] = design;
            row["feedback"] = feedback;
            var now = DateTime.Now;
            row["TimeSent"] = $"{now.Day}/{now.Month}/{now.Year} {now.Hour}:{now.Minute}:{now.Second}";

            ds.Tables[0].Rows.Add(row);
            SaveDatabase(query, ds);
            this.output.InnerText = "תגובתך התקבלה, תודה!";
        }
    }
}