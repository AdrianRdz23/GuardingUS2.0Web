using GuardingUS2._0.Models;
using GuardingUS2._0.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;

namespace GuardingUS.Services
{
    public class AdminDAO
    {
        //String that contains the connection of your data base
        string connectionString = @"Data Source=DESKTOP-FSADQVG;Initial Catalog = GuardingUS; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        //Method to read all homes
        /*
        public List<IdentityUser> ReadIdentity()
        {
            //bool success = false;

            List<HomeVM> list = new List<HomeVM>();

            //sql statement to select  homes and user by using JOIN
            //string sqlStatement = "SELECT * FROM dbo.home WHERE status=0";
            string sqlStatement = "SELECT h.Id, u.[name] , h.number, h.cars, h.[address], h.[status], h.startDate, h.modificationDate from Homes h join AspNetUsers u on h.iduser = u.Id WHERE h.[status] = 0";


            //convert sql Statement to a Sql connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //create a command that comes with the sql statement and the connection
                SqlCommand command = new SqlCommand(sqlStatement, connection);

                try
                {
                    //You open the connection
                    connection.Open();

                    //Use sql data reader to read 
                    SqlDataReader reader = command.ExecuteReader();


                    //Use while to able to grab the homes information
                    while (reader.Read())
                    {

                        //Create a model for user and home
                        IdentityUser myuser = new IdentityUser();


                        list.Add(myuser);

                    }




                }
                catch (Exception e)
                {
                    //Error Message
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    //Close the connection
                    connection.Close();
                }


            }
            return list;
        }
        */
    }
}