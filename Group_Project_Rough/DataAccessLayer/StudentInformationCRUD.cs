using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO; 



namespace Group_Project_Rough.DataAccessLayer
{
    class StudentInformationCRUD
    {
        static string ConnectionString = @"Data Source=(local);Initial Catalog=StudentInformation;Integrated Security=True;"; 


        public DataTable Read()
        {
            SqlConnection Sconn = new SqlConnection(ConnectionString);
            string qry = "SELECT StudentNumber, StudentName, StudentDateOFBirth, StudentGender, StudentPhone, StudentAddress, StudentModuleCode FROM tblStudents";


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

        public MemoryStream Getpictures(int id)
        {
            SqlConnection sconn = new SqlConnection(ConnectionString);
            string qry = "Select StudentImage From tblStudents Where StudentNumber = '"+id+"'";

            sconn.Open();
            SqlCommand scommand = new SqlCommand(qry, sconn);
            SqlDataAdapter DA = new SqlDataAdapter();

            DataSet DS = new DataSet();
            DA.Fill(DS);

            MemoryStream ms = new MemoryStream((byte[])DS.Tables[0].Rows[0]["StudentImage"]);

            return ms; 
        }



        public string InsertStudent(int id, string fn , string ln, string dob, string g, int phone, string address, string modcode , Image Img)
        {
            SqlConnection Sconn = new SqlConnection(ConnectionString);
            string qry = "Insert into tblStudents(StudentNumber, StudentName, StudentSurname,StudentDateOFBirth,StudentGender,StudentPhone,StudentAddress,StudentModuleCode,StudentImage)" +
                "Values('"+id+"', '"+fn+"', '"+ln+"', '"+dob+"', '"+g+"', '"+phone+"', '"+address+"', '"+modcode+"', @StudentImage )";

            SqlCommand Scommand = new SqlCommand(qry, Sconn);

            // image insertion code 
            MemoryStream MS = new MemoryStream();
            Img.Save(MS, ImageFormat.Jpeg);
            byte[] PA = new byte[MS.Length];
            MS.Position = 0;
            MS.Read(PA, 0, PA.Length);
            Scommand.Parameters.AddWithValue("@StudentImage", PA);

            // normal insertion code 
            try
            {
                Sconn.Open();
                Scommand.ExecuteNonQuery();
            }
            catch (Exception)
            {

                return "error inserting ";
            }
            finally
            {
                Sconn.Close();
            }

            return "Inserted Successfully"; 

        }

        public string DeleteStudent()
        {

        }

        public string SearchStudent()
        {

        }

        public string UpdateStudent()
        {

        }
       

    }
}
