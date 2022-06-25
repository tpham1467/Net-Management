using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetManagement.DTO;
using NetManagement.Helper;
using NetManagement.Model;
using NetManagement.BLL.BLLEmployee.BLLCheckInCheckOut;
namespace NetManagement.View.FormEmployee
{
    public partial class CheckIO_Form : Form
    {
        private int id;
        private BllCheckIncheckOut _BllCheckIncheckOut = new BllCheckIncheckOut();
        private static string Starttime = "";
        private static string Endtime = "";
        public static int id_shift = 0 ;
        private static bool Ischeckin = false;
        private static bool IsCheckOut = false;
        public CheckIO_Form(int id_emloyee)
        {
            
            id = id_emloyee;


            InitializeComponent();
            labelTimeStart.Text = Starttime;
            labelTimEnd.Text = Endtime;
            Reload();
            Load_Statistic();
            CheckShift();
        }
        public void  CheckShift()
        {
            if(_BllCheckIncheckOut.GetShiftForDay(id) == -1)
            {
                btnCheckin.Enabled = false;
                btnCheckout.Enabled = false;
            }
        }
        public  int GetshiftCur()
        {
            return _BllCheckIncheckOut.GetShiftForDay(id);
        }
        public void Load_Statistic()
        {
            labeltotalworkingtime.Text = _BllCheckIncheckOut.TotalWorkingTime(id).ToString();
            labelTotal_WorkingDay.Text = _BllCheckIncheckOut.Total_WorkingDay(id).ToString();
            labelAveWorkingTime.Text = _BllCheckIncheckOut.AveWorkingTime(id).ToString();

        }
        private void btnCheckin_Click(object sender, EventArgs e)
        {
            if (Ischeckin) return;
            Starttime = DateTime.Now.ToString("hh:mm tt");
            labelTimeStart.Text = Starttime;
            _BllCheckIncheckOut.CheckIn(id_shift);
            Ischeckin = true;
            btnCheckin.Enabled = false;
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (btnCheckin.Enabled == true) return;
            if (IsCheckOut) return;
            Endtime = DateTime.Now.ToString("hh:mm tt");
            labelTimEnd.Text = Endtime;
            _BllCheckIncheckOut.CheckOut(id_shift);
            btnCheckout.Enabled = false;
            IsCheckOut = true;
            Load_Statistic();
        }



       public void Reload(IEnumerable<object> list = null)
        {
            if(list == null) dataGridView1.DataSource = _BllCheckIncheckOut.Filter(id, new StatusShift { ID_StatusShift = 1 });
            else
            dataGridView1.DataSource = list.ToList() ;
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            int statushit;
            if (checkBoxDalam.Checked == true) statushit = 2;
            else statushit = 1;
            if ((comboBoxmode.SelectedItem  as string) == "Asc")
            {
                Reload(_BllCheckIncheckOut.Sort(id, new StatusShift { ID_StatusShift = statushit }, SortEnum.Asc, comboBoxProperty.SelectedItem as string) );
            }
            else
            {
                Reload(_BllCheckIncheckOut.Sort(id, new StatusShift { ID_StatusShift = statushit }, SortEnum.Desc, comboBoxProperty.SelectedItem as string) );
            }
           
        }
        private List<int> GetSelect()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                List<int> data = new List<int>();
                foreach (DataGridViewRow i in dataGridView1.SelectedRows)
                {
                    int id = System.Convert.ToInt32(i.Cells["ID_Shift"].Value);
                    data.Add(id);
                }
                return data;
            }
            return new List<int>();
        }
        private void buttonSetoff_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count>0)
            {
                List<int> data = GetSelect();
                foreach(var i in data)
                {
                    _BllCheckIncheckOut.SetShiftOff(i);
                }
                Reload(_BllCheckIncheckOut.Filter(id ,new StatusShift { ID_StatusShift = 1 }) );
            }
        }

        private void checkBoxDalam_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxDalam.Checked == true)
            {
                Reload(_BllCheckIncheckOut.Filter(id, new StatusShift { ID_StatusShift = 2 }) );
            }
            else
            {
                Reload();
            }
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            if (checkBoxDalam.Checked == true)
            {
                Reload(_BllCheckIncheckOut.Filter(id, new StatusShift { ID_StatusShift = 2 }, dateTimePickerfrom.Value, dateTimePickerTo.Value) );
            }
            else
            {
                Reload(_BllCheckIncheckOut.Filter(id, new StatusShift { ID_StatusShift = 1 }, dateTimePickerfrom.Value, dateTimePickerTo.Value) );
            }
           
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            if (checkBoxDalam.Checked == true)
            {
                Reload(_BllCheckIncheckOut.Filter(id, new StatusShift { ID_StatusShift = 2 } ) );
            }
            else
            {
                Reload( _BllCheckIncheckOut.Filter(id, new StatusShift { ID_StatusShift = 1 } ) );
            }
        }
    }
}
