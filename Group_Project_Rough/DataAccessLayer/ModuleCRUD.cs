using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient; 


namespace Group_Project_Rough.DataAccessLayer
{
    class ModuleCRUD
    {
        static string ConnectionString = @"Data Source=(local);Initial Catalog=StudentInformation;Integrated Security=True;"; 

        ////////////////////// Student Module CRUD operations /////////////////////////////////////////////////
       
         public DataTable ViewModules()
        {
            SqlConnection Sconn = new SqlConnection(ConnectionString);
            string qry = "Select * From Modules";
            DataTable DT = new DataTable();
            try
            {
                SqlDataAdapter DA = new SqlDataAdapter(qry, ConnectionString);
                DA.Fill(DT);
            }
            catch (Exception e)
            {

                throw e; 
            }
           

            return DT; 

        }

        public string InsertModules(string Mcode, string Mname, string Mdescription , string Mlink)
        {
            SqlConnection Sconn = new SqlConnection(ConnectionString);
            string qry = "Insert into Modules(ModuleCode,ModuleName,ModuleDescription,ModLink)" +
                "Values('"+Mcode+"', '"+Mname+"', '"+Mdescription+"', '"+Mlink+"')";

            try
            {
                Sconn.Open();
                SqlCommand Scommand = new SqlCommand(qry, Sconn);
                Scommand.ExecuteNonQuery(); 

            }
            catch (Exception)
            {
                return "Something went wrong"; 
            }
            finally
            {
                Sconn.Close(); 
            }

            return "Successfully inserted a new module"; 
        }

        public string DeleteModules(string Mid)
        {
            SqlConnection Sconn = new SqlConnection(ConnectionString);
            string DelQuery = "Delete From Modules where ModuleCode = '"+Mid+"'";

            try
            {
                Sconn.Open(); 
                SqlCommand Scommand = new SqlCommand(DelQuery,Sconn);
                Scommand.ExecuteNonQuery(); 
            }
            catch (Exception)
            {

                return "Something went wrong, Maybe try again";
            }
            finally
            {
                Sconn.Close(); 
            }
            return "Deleted Successfully"; 


        }

        public string searchModule(string ModCode)
        {
            SqlConnection Sconn = new SqlConnection(ConnectionString);
            string qry = "Select * From Modules Where ModuleName='"+ModCode+"'";

            try
            {
                Sconn.Open();
                SqlCommand scommand = new SqlCommand(qry, Sconn);
                scommand.ExecuteNonQuery(); 
            }
            catch (Exception)
            {

                return "Something went wrong"; 

            }
            finally
            {
                Sconn.Close(); 

            }
            return "Search was sucessfull";

        }

        public string updateModule(string ID, string description, string link)
        {
            SqlConnection Sconn = new SqlConnection(ConnectionString);
            string qry = "Update Modules SET ModuleDescription = '" + description + "', ModLink='" + link + "' Where ModuleCode = '"+ID+"'";

            try
            {
                Sconn.Open();
                SqlCommand scommand = new SqlCommand(qry, Sconn);
                scommand.ExecuteNonQuery(); 

            }
            catch (SystemException e)
            {

                return e.Message; 

            }
            finally
            {
                Sconn.Close(); 
            }
            return "Updated Successfully"; 




        }








    }
}
