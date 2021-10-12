using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Group_Project_Rough.DataAccessLayer
{
    class FileHandler
    {
        string path = "UserDetails.txt";

        public bool ValidateUser(string name , string pass) {
            bool flag = false;

            if (File.Exists(path)) {

                using (StreamReader sr = new StreamReader(path)) {
                    string ln;
                    while ((ln=sr.ReadLine())!=null) {
                        string[] user = ln.Split(',');
                        if ((user[0] == name) && (user[1] == pass)) {

                            flag = true;
                            break;
               
                        }


                    

                    }
                
                

                }


            }
            return flag;
        }
        public bool addUser(string name, string pass) {
            bool flag = false;
            if (File.Exists(path)) {

                using (StreamWriter sw = new StreamWriter(path)) {

                    sw.WriteLine(name+","+pass);
                    flag = true;

                }

            }
            return flag;
        }
    }
}
