using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using static Nave_Project2.Utils.Database;
using static Nave_Project2.Utils.Security;

namespace Nave_Project2.Pages
{
    public partial class statistics : System.Web.UI.Page
    {
        private void SetIsLoading(ref bool flag, bool value)
        {
            flag = value;
        }
        private void Alert(string message)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", $"alert('{message}')", true);
        }
        private DataTable GetChartData()
        {
            DataSet ds = GetDataSet("SELECT TOP 7 * FROM ViewsTable ORDER BY count DESC");
            return ds.Tables[0];
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            RedirectLoggedUserFromAdminePages(HttpContext.Current);
            //(value, setValue) = useState("RJS");
            if (!IsPostBack)
            {
                DataSet ds1 = GetDataSet("SELECT * FROM Users");
                DataSet ds2 = GetDataSet("SELECT * FROM ProductsTable");
                DataSet ds3 = GetDataSet("SELECT * FROM SalesTable");
                DataSet ds4 = GetDataSet("SELECT * FROM BranchesTable");
                DataSet ds5 = GetDataSet("SELECT * FROM WorkersTable");
                this.UsersDiv.InnerText = ds1.Tables[0].Rows.Count.ToString();
                this.ProductsDiv.InnerText = ds2.Tables[0].Rows.Count.ToString();
                this.SalesDiv.InnerText = ds3.Tables[0].Rows.Count.ToString();
                this.BranchesDiv.InnerText = ds4.Tables[0].Rows.Count.ToString();
                this.WorkersDiv.InnerText = ds5.Tables[0].Rows.Count.ToString();

                DataTable dt = GetChartData();
                Chart1.DataSource = dt;
                Chart1.DataBind();
                Chart1.Series["Series1"].XValueMember = "day_date";
                Chart1.Series["Series1"].YValueMembers = "views";
            }
        }
    }
}