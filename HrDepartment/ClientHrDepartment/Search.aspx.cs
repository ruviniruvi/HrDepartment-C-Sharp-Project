using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClientHrDepartment
{
    public partial class Search : System.Web.UI.Page
    {


        public string BasicHttpBinding_IService1 { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client reference = new ServiceReference1.Service1Client();
            //ServiceReference1.Service1Client refrence = new ServiceReference1.Service1Client();

            string region = textregion.Text;

            ServiceReference1.DepartmentInfo result = reference.GetDepartmnetDetails();

            LblMngr.Text = string.Format(" Total Managers  in {0} are {1} ", region, result.Managers);

          LblEng.Text = string.Format(" Total Engineers in {0} are {1} ", region, result.Engineers);
          LblAsc.Text = string.Format(" Total Associates in {0} are {1} ", region, result.Associates);



        }


    }
}