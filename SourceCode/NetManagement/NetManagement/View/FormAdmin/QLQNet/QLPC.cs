using ChoosePC_UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Data.SqlClient;
namespace QLQNet
{
    public class QLPC
    {
        SqlConnection cnn;

        public QLPC(string s)
        {
            cnn = new SqlConnection(s);
        } 

        public List<PC> getRecordPC(string query)
        {
            List<PC> p = new List<PC>();
            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataReader r;
            cnn.Open();
            r = cmd.ExecuteReader();
            while (r.Read())
            {
                p.AddRange(new PC[]
                {
                     new PC(r["NamePC"].ToString(), r["ID"].ToString(), Convert.ToBoolean(r["StatusPC"].ToString())),
                });
            }
            cnn.Close();
            return p;
        }
    }
}
