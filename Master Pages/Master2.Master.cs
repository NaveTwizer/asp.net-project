using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using static Nave_Project2.Utils.Database;
using static Nave_Project2.Utils.Security;

namespace Nave_Project2.Master_Pages
{
    public partial class Master2 : System.Web.UI.MasterPage
    {
        private bool DoesRowExist(string today)
        {
            return GetDataSet($"SELECT * FROM ViewsTable WHERE day_date='{today}'").Tables[0].Rows.Count != 0;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            RedirectUnloggedUser(HttpContext.Current);

            string query = "SELECT * FROM ViewsTable";
            var now = DateTime.Now;
            string today = $"{now.Day}/{now.Month}/{now.Year}";
            DataSet ds = GetDataSet(query);
            if (DoesRowExist(today))
            {
                DataRow row = ds.Tables[0].Select($"day_date='{today}'").First();
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
    }
}