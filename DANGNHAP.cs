using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQLNS
{
    public partial class DANGNHAP : Form
    {
        Class_checker check;
        Class_dangnhap login;
        public DANGNHAP()
        {
            InitializeComponent();
            check = new Class_checker();
            login = new Class_dangnhap();

        }

        private void bt_dangnhap_Click(object sender, EventArgs e)
        {
            if(check.kiemtra(txt_loginname.Text,txt_pass.Text)==true)
            {
                this.Hide();
                login.dangnhap(this);
             }
            }

        public int i = 0;
        }

    }

