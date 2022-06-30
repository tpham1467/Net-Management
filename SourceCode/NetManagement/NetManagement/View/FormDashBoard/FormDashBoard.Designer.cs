
namespace NetManagement.View.FormDashBoard
{
    partial class FormDashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnThisMonth = new System.Windows.Forms.Button();
            this.btnLast30Days = new System.Windows.Forms.Button();
            this.btnLast7Days = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.btnOkCustomDate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNumOrders = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotalProfit = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chartsoluongtiennapmoitaikhoa = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTopProducts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblNumemployee = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblNumcomputer = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNumCustomers = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labeltongsogiosudungmay = new System.Windows.Forms.Label();
            this.labeltongsotienbanhang = new System.Windows.Forms.Label();
            this.labeltongsotientraluong = new System.Windows.Forms.Label();
            this.labeltongsotiennapmay = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.chartmaysudung = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartsoluongtiennapmoitaikhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopProducts)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartmaysudung)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "MMM dd, yyyy";
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(202, 18);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(122, 23);
            this.dtpStartDate.TabIndex = 1;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "MMM dd, yyyy";
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(341, 18);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(122, 23);
            this.dtpEndDate.TabIndex = 2;
            // 
            // btnThisMonth
            // 
            this.btnThisMonth.Location = new System.Drawing.Point(1024, 10);
            this.btnThisMonth.Margin = new System.Windows.Forms.Padding(5);
            this.btnThisMonth.Name = "btnThisMonth";
            this.btnThisMonth.Size = new System.Drawing.Size(130, 35);
            this.btnThisMonth.TabIndex = 3;
            this.btnThisMonth.Text = "Tháng Này";
            this.btnThisMonth.UseVisualStyleBackColor = true;
            this.btnThisMonth.Click += new System.EventHandler(this.btnThisMonth_Click);
            // 
            // btnLast30Days
            // 
            this.btnLast30Days.Location = new System.Drawing.Point(870, 13);
            this.btnLast30Days.Margin = new System.Windows.Forms.Padding(5);
            this.btnLast30Days.Name = "btnLast30Days";
            this.btnLast30Days.Size = new System.Drawing.Size(130, 35);
            this.btnLast30Days.TabIndex = 4;
            this.btnLast30Days.Text = "30 Ngày Trước ";
            this.btnLast30Days.UseVisualStyleBackColor = true;
            this.btnLast30Days.Click += new System.EventHandler(this.btnLast30Days_Click);
            // 
            // btnLast7Days
            // 
            this.btnLast7Days.Location = new System.Drawing.Point(713, 14);
            this.btnLast7Days.Margin = new System.Windows.Forms.Padding(5);
            this.btnLast7Days.Name = "btnLast7Days";
            this.btnLast7Days.Size = new System.Drawing.Size(130, 35);
            this.btnLast7Days.TabIndex = 5;
            this.btnLast7Days.Text = "Bảy Ngày Trước";
            this.btnLast7Days.UseVisualStyleBackColor = true;
            this.btnLast7Days.Click += new System.EventHandler(this.btnLast7Days_Click);
            // 
            // btnToday
            // 
            this.btnToday.Location = new System.Drawing.Point(559, 13);
            this.btnToday.Margin = new System.Windows.Forms.Padding(5);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(130, 35);
            this.btnToday.TabIndex = 6;
            this.btnToday.Text = "Hôm Nay";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // btnOkCustomDate
            // 
            this.btnOkCustomDate.Location = new System.Drawing.Point(498, 13);
            this.btnOkCustomDate.Margin = new System.Windows.Forms.Padding(5);
            this.btnOkCustomDate.Name = "btnOkCustomDate";
            this.btnOkCustomDate.Size = new System.Drawing.Size(39, 35);
            this.btnOkCustomDate.TabIndex = 8;
            this.btnOkCustomDate.Text = "Ok";
            this.btnOkCustomDate.UseVisualStyleBackColor = true;
            this.btnOkCustomDate.Click += new System.EventHandler(this.btnOkCustomDate_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblNumOrders);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(14, 55);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 73);
            this.panel1.TabIndex = 9;
            // 
            // lblNumOrders
            // 
            this.lblNumOrders.AutoSize = true;
            this.lblNumOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOrders.Location = new System.Drawing.Point(67, 38);
            this.lblNumOrders.Name = "lblNumOrders";
            this.lblNumOrders.Size = new System.Drawing.Size(97, 29);
            this.lblNumOrders.TabIndex = 1;
            this.lblNumOrders.Text = "100000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.label2.Location = new System.Drawing.Point(50, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tổng Số Ordrer";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblTotalRevenue);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(302, 55);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(458, 73);
            this.panel2.TabIndex = 10;
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRevenue.Location = new System.Drawing.Point(74, 34);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(97, 29);
            this.lblTotalRevenue.TabIndex = 1;
            this.lblTotalRevenue.Text = "100000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.label4.Location = new System.Drawing.Point(74, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tổng Doanh Thu";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblTotalProfit);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(770, 55);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(420, 73);
            this.panel3.TabIndex = 11;
            // 
            // lblTotalProfit
            // 
            this.lblTotalProfit.AutoSize = true;
            this.lblTotalProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProfit.Location = new System.Drawing.Point(74, 34);
            this.lblTotalProfit.Name = "lblTotalProfit";
            this.lblTotalProfit.Size = new System.Drawing.Size(97, 29);
            this.lblTotalProfit.TabIndex = 1;
            this.lblTotalProfit.Text = "100000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.label5.Location = new System.Drawing.Point(74, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tổng Lợi ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // chartsoluongtiennapmoitaikhoa
            // 
            chartArea4.Name = "ChartArea1";
            this.chartsoluongtiennapmoitaikhoa.ChartAreas.Add(chartArea4);
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            legend4.IsTextAutoFit = false;
            legend4.Name = "Legend1";
            this.chartsoluongtiennapmoitaikhoa.Legends.Add(legend4);
            this.chartsoluongtiennapmoitaikhoa.Location = new System.Drawing.Point(14, 138);
            this.chartsoluongtiennapmoitaikhoa.Margin = new System.Windows.Forms.Padding(5);
            this.chartsoluongtiennapmoitaikhoa.Name = "chartsoluongtiennapmoitaikhoa";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartsoluongtiennapmoitaikhoa.Series.Add(series4);
            this.chartsoluongtiennapmoitaikhoa.Size = new System.Drawing.Size(449, 277);
            this.chartsoluongtiennapmoitaikhoa.TabIndex = 12;
            this.chartsoluongtiennapmoitaikhoa.Text = "chartGrossRevenue";
            title4.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title4.Name = "Title1";
            title4.Text = "Tổng Số Tiền Nạp Mỗi Tài Khoản";
            this.chartsoluongtiennapmoitaikhoa.Titles.Add(title4);
            this.chartsoluongtiennapmoitaikhoa.Click += new System.EventHandler(this.chartGrossRevenue_Click);
            // 
            // chartTopProducts
            // 
            chartArea5.Name = "ChartArea1";
            this.chartTopProducts.ChartAreas.Add(chartArea5);
            legend5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            legend5.IsTextAutoFit = false;
            legend5.Name = "Legend1";
            this.chartTopProducts.Legends.Add(legend5);
            this.chartTopProducts.Location = new System.Drawing.Point(870, 138);
            this.chartTopProducts.Margin = new System.Windows.Forms.Padding(5);
            this.chartTopProducts.Name = "chartTopProducts";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            series5.IsValueShownAsLabel = true;
            series5.LabelForeColor = System.Drawing.Color.White;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartTopProducts.Series.Add(series5);
            this.chartTopProducts.Size = new System.Drawing.Size(320, 495);
            this.chartTopProducts.TabIndex = 13;
            this.chartTopProducts.Text = "chartTopProducts";
            title5.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title5.Name = "Title1";
            title5.Text = "Các Sản Phẩm Bán Chạy";
            this.chartTopProducts.Titles.Add(title5);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lblNumemployee);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.lblNumcomputer);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.lblNumCustomers);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(14, 417);
            this.panel4.Margin = new System.Windows.Forms.Padding(5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(230, 216);
            this.panel4.TabIndex = 10;
            // 
            // lblNumemployee
            // 
            this.lblNumemployee.AutoSize = true;
            this.lblNumemployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumemployee.Location = new System.Drawing.Point(59, 185);
            this.lblNumemployee.Name = "lblNumemployee";
            this.lblNumemployee.Size = new System.Drawing.Size(97, 29);
            this.lblNumemployee.TabIndex = 6;
            this.lblNumemployee.Text = "100000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.label9.Location = new System.Drawing.Point(60, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "Nhân Viên";
            // 
            // lblNumcomputer
            // 
            this.lblNumcomputer.AutoSize = true;
            this.lblNumcomputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumcomputer.Location = new System.Drawing.Point(59, 125);
            this.lblNumcomputer.Name = "lblNumcomputer";
            this.lblNumcomputer.Size = new System.Drawing.Size(97, 29);
            this.lblNumcomputer.TabIndex = 4;
            this.lblNumcomputer.Text = "100000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.label8.Location = new System.Drawing.Point(60, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Máy Tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 29);
            this.label7.TabIndex = 2;
            this.label7.Text = "Total Counters";
            // 
            // lblNumCustomers
            // 
            this.lblNumCustomers.AutoSize = true;
            this.lblNumCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCustomers.Location = new System.Drawing.Point(59, 65);
            this.lblNumCustomers.Name = "lblNumCustomers";
            this.lblNumCustomers.Size = new System.Drawing.Size(97, 29);
            this.lblNumCustomers.TabIndex = 1;
            this.lblNumCustomers.Text = "100000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.label6.Location = new System.Drawing.Point(60, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Khách hàng ";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.labeltongsogiosudungmay);
            this.panel5.Controls.Add(this.labeltongsotienbanhang);
            this.panel5.Controls.Add(this.labeltongsotientraluong);
            this.panel5.Controls.Add(this.labeltongsotiennapmay);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Location = new System.Drawing.Point(254, 425);
            this.panel5.Margin = new System.Windows.Forms.Padding(5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(606, 208);
            this.panel5.TabIndex = 11;
            // 
            // labeltongsogiosudungmay
            // 
            this.labeltongsogiosudungmay.AutoSize = true;
            this.labeltongsogiosudungmay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltongsogiosudungmay.Location = new System.Drawing.Point(356, 161);
            this.labeltongsogiosudungmay.Name = "labeltongsogiosudungmay";
            this.labeltongsogiosudungmay.Size = new System.Drawing.Size(97, 29);
            this.labeltongsogiosudungmay.TabIndex = 9;
            this.labeltongsogiosudungmay.Text = "100000";
            // 
            // labeltongsotienbanhang
            // 
            this.labeltongsotienbanhang.AutoSize = true;
            this.labeltongsotienbanhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltongsotienbanhang.Location = new System.Drawing.Point(65, 161);
            this.labeltongsotienbanhang.Name = "labeltongsotienbanhang";
            this.labeltongsotienbanhang.Size = new System.Drawing.Size(97, 29);
            this.labeltongsotienbanhang.TabIndex = 8;
            this.labeltongsotienbanhang.Text = "100000";
            // 
            // labeltongsotientraluong
            // 
            this.labeltongsotientraluong.AutoSize = true;
            this.labeltongsotientraluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltongsotientraluong.Location = new System.Drawing.Point(356, 54);
            this.labeltongsotientraluong.Name = "labeltongsotientraluong";
            this.labeltongsotientraluong.Size = new System.Drawing.Size(97, 29);
            this.labeltongsotientraluong.TabIndex = 7;
            this.labeltongsotientraluong.Text = "100000";
            // 
            // labeltongsotiennapmay
            // 
            this.labeltongsotiennapmay.AutoSize = true;
            this.labeltongsotiennapmay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltongsotiennapmay.Location = new System.Drawing.Point(65, 54);
            this.labeltongsotiennapmay.Name = "labeltongsotiennapmay";
            this.labeltongsotiennapmay.Size = new System.Drawing.Size(97, 29);
            this.labeltongsotiennapmay.TabIndex = 3;
            this.labeltongsotiennapmay.Text = "100000";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.label15.Location = new System.Drawing.Point(300, 105);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(249, 25);
            this.label15.TabIndex = 6;
            this.label15.Text = "Tổng Số giờ Sử Dụng Máy ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.label14.Location = new System.Drawing.Point(300, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(224, 25);
            this.label14.TabIndex = 5;
            this.label14.Text = "Tổng Số Tiền trả Lương ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.label13.Location = new System.Drawing.Point(16, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(229, 25);
            this.label13.TabIndex = 4;
            this.label13.Text = "Tổng Số Tiền Bán Hàng ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.label12.Location = new System.Drawing.Point(16, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(216, 25);
            this.label12.TabIndex = 3;
            this.label12.Text = "Tổng Số Tiền Nạp Máy";
            // 
            // chartmaysudung
            // 
            chartArea6.Name = "ChartArea1";
            this.chartmaysudung.ChartAreas.Add(chartArea6);
            legend6.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            legend6.IsTextAutoFit = false;
            legend6.Name = "Legend1";
            this.chartmaysudung.Legends.Add(legend6);
            this.chartmaysudung.Location = new System.Drawing.Point(473, 138);
            this.chartmaysudung.Margin = new System.Windows.Forms.Padding(5);
            this.chartmaysudung.Name = "chartmaysudung";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartmaysudung.Series.Add(series6);
            this.chartmaysudung.Size = new System.Drawing.Size(388, 277);
            this.chartmaysudung.TabIndex = 14;
            this.chartmaysudung.Text = "chart1";
            title6.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title6.Name = "Title1";
            title6.Text = "Số Giờ Sử Dụng Của Mỗi Máy";
            this.chartmaysudung.Titles.Add(title6);
            // 
            // FormDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 641);
            this.Controls.Add(this.chartmaysudung);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.chartTopProducts);
            this.Controls.Add(this.chartsoluongtiennapmoitaikhoa);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOkCustomDate);
            this.Controls.Add(this.btnToday);
            this.Controls.Add(this.btnLast7Days);
            this.Controls.Add(this.btnLast30Days);
            this.Controls.Add(this.btnThisMonth);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDashBoard";
            this.Text = "Store statistics";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartsoluongtiennapmoitaikhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopProducts)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartmaysudung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnThisMonth;
        private System.Windows.Forms.Button btnLast30Days;
        private System.Windows.Forms.Button btnLast7Days;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button btnOkCustomDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNumOrders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotalProfit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartsoluongtiennapmoitaikhoa;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopProducts;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblNumemployee;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblNumcomputer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNumCustomers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labeltongsogiosudungmay;
        private System.Windows.Forms.Label labeltongsotienbanhang;
        private System.Windows.Forms.Label labeltongsotientraluong;
        private System.Windows.Forms.Label labeltongsotiennapmay;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartmaysudung;
    }
}