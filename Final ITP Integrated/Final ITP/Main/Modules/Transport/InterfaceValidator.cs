using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    class InterfaceValidator
    {
        public Boolean checkIsEmpty(string textbox){
            if (textbox == "")
            {
                return true;
            }
            else {
                return false;
            }
        }

        public Boolean validateInputDateTime(DateTime startdate,/* TimeSpan time, string parameter,*/ DateTime enddate)
        {

            DateTime currentDate = DateTime.Now.Date;//.ToString("yyyy-MM-dd");
           // MessageBox.Show(currentDate.ToString(), "Date");
            //string inputDate = date;
           // MessageBox.Show((currentDate != startdate).ToString() + (startdate > enddate).ToString());
            if ((currentDate != startdate.Date) || (startdate.Date > enddate.Date))
            {
                return false;
            }
            else {
                return true;
            }
        }

        public Boolean validateInputTime(TimeSpan time)
        {
            TimeSpan currentTime = DateTime.Now.TimeOfDay;

            if (time > currentTime)
            {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
