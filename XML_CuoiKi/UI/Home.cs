﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XML_CuoiKi.UI;

namespace XML_CuoiKi
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private void ShowControl(UserControl control)
        {
            // Xóa nội dung cũ
            Panel_navigation.Controls.Clear();

            // Thêm UserControl mới vào Panel
            control.Dock = DockStyle.Fill;
            Panel_navigation.Controls.Add(control);
        }

        private void btn_hoadon_Click(object sender, EventArgs e)
        {
            ShowControl(new HoaDon());
        }

        private void btn_nguoidung_Click(object sender, EventArgs e)
        {
            ShowControl(new NguoiDung());

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }




        private void Panel_navigation_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_laptop_Click(object sender, EventArgs e)
        {
            ShowControl(new Laptop());
        }

        private void Home_Load(object sender, EventArgs e)
        {
            ShowControl(new TrangChu());

        }

        private void btn_Danhmuc_Click(object sender, EventArgs e)
        {
            ShowControl(new Danhmuclaptop());

        }

        private void btn_nhacungcap_Click(object sender, EventArgs e)
        {
            ShowControl(new Nhacungcap());

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowControl(new TrangChu());
        }
    }
}
