using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Data;
using Group_Project_Rough.DataAccessLayer;

namespace Group_Project_Rough.BussinessLogicLayer
{
    class ModuleOp
    {
        ModuleCRUD md = new ModuleCRUD();
        public DataTable Viewmod() {

            DataTable dt = new DataTable();
            dt = md.ViewModules();
            return dt;
        }
        public string InsertMod(string Mcode, string Mname, string Mdescription, string Mlink) {

            string ss = md.InsertModules(Mcode, Mname, Mdescription, Mlink);
            return ss;
        }
        public string DeleteMod(string Mid) {

            string ss = md.DeleteModules(Mid);
            return ss;
        }
        public string searchMod(string ModCode) {

            string ss = md.searchModule(ModCode);
            return ss;
        }
        public string updateModule(string ID, string description, string link) {

            string ss = md.updateModule(ID, description, link);
            return ss;
        }
    }
}
