using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using static Nave_Project2.Utils.Database;

namespace Nave_Project2.Pages
{
    public partial class test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void UploadButton_Click(object sender, EventArgs e)
        {

            HttpPostedFile file = this.FileUpload1.PostedFile;
            string SaveLocation = Server.MapPath("~/images/products/");
            SaveLocation += file.FileName;
            file.SaveAs(SaveLocation);


        }
    }
}