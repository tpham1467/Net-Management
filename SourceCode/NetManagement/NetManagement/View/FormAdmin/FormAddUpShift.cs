using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetManagement.BLL;
using NetManagement.Model;

using NetManagement.Helper;
namespace NetManagement.View.FormAdmin
{
    public partial class FormAddUpShift : Form
    {
        public Action<StatusShift, List<Object>> action;
        AdminBLL_Em adBLLEm = new AdminBLL_Em();
        AdminBLL_Timekeeping adShi = new AdminBLL_Timekeeping();
        int id;
        int indexCommobox;
        int id_employee;

        public FormAddUpShift(int m)
        {
            id = m;
            if (id != -1)
            {
                Shift sh = adShi.GetShiById(id);
                id_employee = sh.ID_Employee;
            }
            this.AutoScaleMode = AutoScaleMode.None;
            InitializeComponent();
           
            CreateCBB();
            Gui();
        }



        public void Gui()
        {
            if (id != -1)
            {
                cbbStatus.Enabled = true;

                Shift sh = adShi.GetShiById(id);
                dtpWD.Value = System.Convert.ToDateTime(sh.WorkedDate);
                cbbNameE.SelectedIndex = indexCommobox;
                mTbStartTime.Text = sh.ShiftStartTime.ToString("hh:mm");
                mTbEndTime.Text = sh.ShiftEndTime.ToString("hh:mm");
                if(sh.ID_StatusShift == 2 )
                {
                    cbbStatus.SelectedIndex = 0;
                }
                else if( sh.ID_StatusShift == 1)
                {
                    cbbStatus.SelectedIndex = 1;
                }
                else
                {
                    cbbStatus.SelectedIndex = 2;
                }
            }
            else
            {
                cbbStatus.Enabled = false;
                cbbStatus.Text = "Chưa Làm";
            }

        }

        public void CreateCBB()
        {
            int j = 0;
            foreach (Employee em in adBLLEm.GetAll())
            {
                if(em.ID_User
                     == id_employee)
                {
                    indexCommobox = j; 
                }
                j++;
                cbbNameE.Items.Add(new SetCBB { id = em.ID_User, name = em.FirstName + em.LastName });
            }

        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            DateTime workDate = dtpWD.Value;

            Shift sh = adShi.Create();



            try
            {
                DateTime starttime;
                DateTime endtime;
                try
                {
                    starttime = new DateTime(2022, 8, 12, System.Convert.ToInt32(mTbStartTime.Text.Split(':')[0]), System.Convert.ToInt32(mTbStartTime.Text.Split(':')[1]), 23);

                     endtime = new DateTime(2022, 8, 12, System.Convert.ToInt32(mTbEndTime.Text.Split(':')[0]), System.Convert.ToInt32(mTbEndTime.Text.Split(':')[1]), 23); ;
                    DateTime.Parse(starttime.ToString());
                    DateTime.Parse(endtime.ToString());

                    sh.ShiftStartTime = starttime;
                    sh.ShiftEndTime = endtime;
                }
                catch
                {
                    throw new Exception("Bạn Chưa nhập giờ Hoặc Giờ Sai");
                }
                if (starttime.Minute != 0 || endtime.Minute != 0) throw new Exception("Giờ Bắt Đầu Làm Hoặc Kết Thúc Phải Chẵn");

                sh.Hour = endtime.Hour - starttime.Hour;
                try
                {
                    sh.ID_Employee = (cbbNameE.SelectedItem as SetCBB).id;
                }
                catch
                {
                    throw new Exception("Bạn Chưa Chọn Nhân Viên");
                }
                sh.WorkedDate = workDate;

                if (cbbStatus.SelectedIndex == 0)
                    sh.ID_StatusShift = 2;
                else if (cbbStatus.SelectedIndex == 1)
                    sh.ID_StatusShift = 1;
                else sh.ID_StatusShift = 3;
                try
                {
                    if (id == -1)
                    {
                        sh.ID_StatusShift = 1;
                        adShi.Add(sh);
                    }
                    else
                        adShi.UpDate(sh, id);
                } catch
                {
                    throw new Exception("Opp !!! . Xin lỗi Bạn hiện hệ thống không thể hoạt động . Vui Lòng Thử Lại");
                }
            }catch( Exception mess)
            {
                DialogResult result = NetMessageBox.Show(mess.Message,
                "Important Message");
                return;
            }
            action(null , null);
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
