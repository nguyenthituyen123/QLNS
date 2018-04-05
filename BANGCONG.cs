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
    public partial class BANGCONG : Form
    {
        Class_BANGCONG bangcong;
        public BANGCONG()
        {
            InitializeComponent();
            bangcong = new Class_BANGCONG();
            bangcong.loaddulieu(this);
            bangcong.loaddulieucbbbl(this);
        }

        private void BANGCONG_Load(object sender, EventArgs e)
        {

        }

        private void dgv_bangcong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int donghientai = dgv_bangcong.CurrentRow.Index;
                cbb_matinhcong.Text = dgv_bangcong.Rows[donghientai].Cells[0].Value.ToString();
                txt_chedocong.Text = dgv_bangcong.Rows[donghientai].Cells[1].Value.ToString();
                txt_socongnghi.Text = dgv_bangcong.Rows[donghientai].Cells[2].Value.ToString();
                cbb_matinhluong.Text = dgv_bangcong.Rows[donghientai].Cells[4].Value.ToString();
                txt_congtangca.Text = dgv_bangcong.Rows[donghientai].Cells[3].Value.ToString();

            }
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            bangcong.them(this);
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            bangcong.xoa(this);
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            bangcong.sua(this);
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_tongcong_Click(object sender, EventArgs e)
        {
            bangcong.tinhcong(this);
        }

       
    }
}
