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
    public partial class BANGLUONG : Form
    {
        Class_BANGLUONG bangluong;
        public BANGLUONG()
        {
            InitializeComponent();
            bangluong = new Class_BANGLUONG();
            bangluong.loaddulieu(this);
            txt_ngaytao.Text = DateTime.Now.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int donghientai = dgv_bangluong.CurrentRow.Index;
                cbb_matinhluong.Text = dgv_bangluong.Rows[donghientai].Cells[0].Value.ToString();
                txt_hesoluong.Text = dgv_bangluong.Rows[donghientai].Cells[1].Value.ToString();
                txt_luongcoban.Text = dgv_bangluong.Rows[donghientai].Cells[2].Value.ToString();
                txt_thuong.Text = dgv_bangluong.Rows[donghientai].Cells[3].Value.ToString();
                txt_tamung.Text = dgv_bangluong.Rows[donghientai].Cells[4].Value.ToString();
                txt_ngaytao.Text = dgv_bangluong.Rows[donghientai].Cells[5].Value.ToString();
            
            }
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            bangluong.them(this);
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            bangluong.xoa(this);
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            bangluong.sua(this);
        }

     
      

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

 

      
    }
}
