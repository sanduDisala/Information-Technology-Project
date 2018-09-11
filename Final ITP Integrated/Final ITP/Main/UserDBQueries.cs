using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Main
{
    class UserDBQueries
    {
        public DataSet getUserDetails(string username, string password)
        {
            DataSet userID = new DBConnect().GetFromDB("SELECT User_ID,Type FROM tbl_user WHERE Username = '" + username + "' AND Password = '" + password + "'");
            return userID;
        }
    }
}
