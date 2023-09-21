using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Feedback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitFeedback(object sender, EventArgs e)
        {
            string nameValue = name.Text;
            string emailValue = email.Text;
            string messageValue = message.Text;

            // Process the form data (e.g., send an email or save to a database)

            // Redirect to a thank you page or show a confirmation message
            Response.Redirect("ThankYou.aspx");
        }
    }
}