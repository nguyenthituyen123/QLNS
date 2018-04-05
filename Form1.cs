using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace baitaplon2
{
    public partial class frmHopDong : Form
    {
        public frmHopDong()
        {
            InitializeComponent();
        }
        SqlConnection con;

        private void frmHopDong_Load(object sender, EventArgs e)
        {
            string cnString = ConfigurationManager.ConnectionStrings["QLNS"].ConnectionString.ToString();
            con = new SqlConnection(cnString);
            con.Open();
            Hienthi();
        }

        private void frmHopDong_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
        public void Hienthi()
        {
            string sql = "SELECT * FROM HopDong";
            //tao doi tuong comman de doc no
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvhopdong.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO HopDong VALUES(@MaHĐ, @TenHĐ, @LoaiHĐ, @ThoiHan, @GhiChu, @IsDelete)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("MaHĐ", txtmahd.Text);
            cmd.Parameters.AddWithValue("TenHĐ", txttenhd.Text);
            cmd.Parameters.AddWithValue("LoaiHĐ", txtloaihd.Text);
            cmd.Parameters.AddWithValue("ThoiHan", txtthoihan.Text);
            cmd.Parameters.AddWithValue("GhiChu", txtghichu.Text);
            cmd.Parameters.AddWithValue("IsDelete", txtIs.Text);

            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE HopDong SET TenHĐ = @TenHĐ, LoaiHĐ = @LoaiHĐ, ThoiHan = @ThoiHan, GhiChu = @GhiChu WHERE MaHĐ = @MaHĐ";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("MaHĐ", txtmahd.Text);
            cmd.Parameters.AddWithValue("TenHĐ", txttenhd.Text);
            cmd.Parameters.AddWithValue("LoaiHĐ", txtloaihd.Text);
            cmd.Parameters.AddWithValue("ThoiHan", txtthoihan.Text);
            cmd.Parameters.AddWithValue("GhiChu", txtghichu.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM HopDong WHERE MaHĐ = @MaHĐ";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("MaHĐ", txtmahd.Text);
            cmd.Parameters.AddWithValue("TenHĐ", txttenhd.Text);
            cmd.Parameters.AddWithValue("LoaiHĐ", txtloaihd.Text);
            cmd.Parameters.AddWithValue("ThoiHan", txtthoihan.Text);
            cmd.Parameters.AddWithValue("GhiChu", txtghichu.Text);
            cmd.ExecuteNonQuery();
            Hienthi();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM HopDong WHERE MaHĐ = @MaHĐ";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("MaHĐ", txtmahd.Text);
            cmd.Parameters.AddWithValue("TenHĐ", txttenhd.Text);
            cmd.Parameters.AddWithValue("LoaiHĐ", txtloaihd.Text);
            cmd.Parameters.AddWithValue("ThoiHan", txtthoihan.Text);
            cmd.Parameters.AddWithValue("GhiChu", txtghichu.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvhopdong.DataSource = dt;
        }

    }
}
