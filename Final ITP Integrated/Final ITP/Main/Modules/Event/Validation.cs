using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Main.Modules.Event
{
    class Validation
    {
        ArrayList EmptyErrors = new ArrayList();
        ArrayList DateTimeErrors = new ArrayList();

        public Boolean validateInput(string objectValue, string parameter)
        {
            if (objectValue == parameter)
            {
              //  MessageBox.Show(parameter+" "+"textfeild is empty");
                return true;

               
            }

            return false;
           

            //DBConnect b2 = new DBConnect();
            //b2.ConnectToDatabase();
        }

        public void validateInputDateTime(string date, TimeSpan time, string parameter)
        {

            string currentDate = DateTime.Now.ToLongDateString();
            string inputDate = date;
            TimeSpan currentTime = DateTime.Now.TimeOfDay;

            if (!(currentDate == inputDate))
            {
                DateTimeErrors.Add(parameter + " Date");
            }

            if (time > currentTime)
            {
                DateTimeErrors.Add(parameter + " Time");
            }
        }

        public bool emailIsValid(string email)
        {
            string expresion;

            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }
        //public void ClearText(string nm)
        //{
            
            ////foreach (Control ct in cc)
            ////{
            //    TextBox tb = ct as TextBox;
            //    if (tb != null)
            //    {
            //        tb.Text = "";
            //    }
            //    else
            //        ClearText(ct.Controls);
            //}
        //}
    }
}