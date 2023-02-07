using System;
using System.IO;
using System.Data;
using static Nave_Project2.Utils.Database;
using System.Web.UI.HtmlControls;
using static Nave_Project2.Utils.Security;
namespace Nave_Project2.Pages.profiles
{
    public partial class my : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string username = "AndrewTate";
            RedirectUnloggedUser(System.Web.HttpContext.Current);
            string username = Session["username"].ToString();
            if (!IsPostBack)
            {
                string path;
                if (File.Exists(Server.MapPath($"/images/profiles/{username.ToLower()}.png")))
                    path = $"/images/profiles/{username.ToLower()}.png";
                else
                    path = $"/images/profiles/default.png";

                this.pfp.Src = path;

                string query = $"SELECT * FROM Users WHERE username='{username}'";
                DataSet ds = GetDataSet(query);
                DataRow row = ds.Tables[0].Rows[0];
                this.NameField.Value = row["firstname"].ToString() + " " +  row["lastname"].ToString();
                this.MailField.Value = row["mail"].ToString();
                this.AddressField.Value = row["address"].ToString();
            }
        }

        protected void UploadProfilePictureButton_Click(object sender, EventArgs e)
        {
            string username = Session["username"].ToString();
            //string username = "AndrewTate";
            if (ProfilePictureFileUpload.HasFile)
            {
                //string FileName = Path.GetFileName(ProfilePictureFileUpload.FileName);
                string filePath = Path.Combine(Server.MapPath("~/images/profiles"), $"{username.ToLower()}.png");
                ProfilePictureFileUpload.SaveAs(filePath);
            }
        }
    }
}