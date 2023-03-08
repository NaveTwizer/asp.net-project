using System;
using System.IO;
using System.Data;
using static Nave_Project2.Utils.Database;
using System.Web.UI.HtmlControls;
using static Nave_Project2.Utils.Security;
namespace Nave_Project2.Pages.profiles
{
    public partial class my : System.Web.UI.Page
    {   // דף הפרופיל שלי
        protected void Page_Load(object sender, EventArgs e)
        {
            RedirectUnloggedUser(System.Web.HttpContext.Current);
            string username = Session["username"].ToString();
            
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

            // In honor of Andrew Tate. #FreeTopG
            if (username.ToLower().Equals("andrewtate"))
            {
                this.bgMusic.Attributes.Add("autoplay", "autoplay");
                this.bgMusic.Attributes.Add("loop", "loop");
                this.bgMusic.Style.Add("display", "none");
            }
        }

        protected void UploadProfilePictureButton_Click(object sender, EventArgs e)
        {   // העלה תמונת פרופיל
            string username = Session["username"].ToString();
            //string username = "AndrewTate";
            if (ProfilePictureFileUpload.HasFile) // בדוק שהמשתמש העלה תמונה
            {
                string filePath = Path.Combine(Server.MapPath("~/images/profiles"), $"{username.ToLower()}.png");
                ProfilePictureFileUpload.SaveAs(filePath); // שמור תמונה
            }
        }
    }
}