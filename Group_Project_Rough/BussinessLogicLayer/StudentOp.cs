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
using Group_Project_Rough.DataAccessLayer;

namespace Group_Project_Rough.BussinessLogicLayer
{
    class StudentOp
    {
        StudentInformationCRUD st= new StudentInformationCRUD();
        public DataTable GetStudent() {
            DataTable dt = new DataTable();

            dt = st.Read();
            return dt;

        }
        public string InsertStudent(int id, string fn, string ln, string dob, string g, int phone, string address, string modcode, Image Img) {
           

            string s =st.InsertStudent(id,fn, ln, dob,  g,  phone, address,  modcode,  Img);
            return s;
        }
        public string Delete(int id) {

            string ss = st.DeleteStudent(id);
            return ss;
        }
        public DataTable Search(int id) {
            DataTable dt = new DataTable();

            try
            {

                dt = st.SearchStudent(id);
            }
            catch (Exception e)
            {
                dt = null;
                string message = "Incorrect Student ID";


            }
            
            return dt;
            
        }
        public string Update(int id, string fn, string ln, string dob, string g, int phone, string address, string modcode) {

            string dd = st.UpdateStudent( id, fn, ln,dob, g, phone, address,  modcode);
            return dd;
        }
        public MemoryStream getPic(int id) {

            return st.Getpictures(id);
        }
    }
}
