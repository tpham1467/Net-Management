using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetManagement.Helper
{
    public class Convert
    {
        public static float ConVertMoneyTohour(int Money)
        {
            int hour = (int)(Money / 7200);
            Money = Money - hour * 7200;
            int minite = (int)(Money / 120);
            Money = Money - minite * 120;
            return (float)hour + (float)(minite / 60);
        }
        public static String ConvertMenyToHour(int Money)
        {
            int hour = (int)(Money / 7200);
            Money = Money - hour * 7200;
            int minite = (int)(Money / 120);
            Money = Money - minite * 120;
            int second = (int)(Money / 2);
            return (hour == 0 ? "00" : hour.ToString()) + ":" + (minite == 0 ? "00" : minite.ToString()) + ":" + (second == 0 ? "00" : second.ToString());
        }
        public static String ConvertMoneyToVND(int money)
        {
            String s = money.ToString(); int j = 0;
            for (int i = s.Length - 1; i >= 2; i--)
            {
                if (j == 2)
                {
                    s = s.Insert(i, ".");
                    j = -1;
                }
                j++;
            }
            return s + " VND";
        }
    }
}
