using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace HrDepartment
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public DepartmentInfo GetDepartmnetDetails(string region)
        {
            DepartmentInfo infor = null;

            SqlConnection connection = new SqlConnection("Data Source = RUVISE; Initial Catalog = hr_department; Integrated Security = True");

            connection.Open();

            SqlCommand cmd = new SqlCommand("select Managers , Engineers, Associates from department where region =  @region;", connection);
            cmd.Parameters.AddWithValue("@region ", region);

            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            if (reader.HasRows)
            {
                infor = new DepartmentInfo
                {
                    Managers = reader.GetInt32(0),
                    Engineers = reader.GetInt32(1),
                    Associates = reader.GetInt32(2)
                };



            }
            connection.Close();
            return infor;


             

        }

        

     
    }
}
