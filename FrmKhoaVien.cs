using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.AccessControl;

namespace TranNhatThang_QLSV
{
    public partial class FrmKhoaVien : Form
    {
        public FrmKhoaVien()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            txtMaKhoa.Text = "";
            txtMaKhoa.Focus();
            txtTenKhoa.Text = "";
            txtTenKhoa.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
        }

        KetNoiDB kn = new KetNoiDB();
        public void LAY_DULIEU()
        {
            DataTable dta = new DataTable();
            dta = kn.LayBang("Select MAKHOA, TENKHOA, DIACHI, SODT from KHOAVIEN");
            dataKhoaVien.DataSource = dta;
            HIENTHIDULIEU();
        }

        private void HIENTHIDULIEU()
        {
            txtMaKhoa.DataBindings.Clear();
            txtMaKhoa.DataBindings.Add("Text", dataKhoaVien.DataSource, "MAKHOA");
           
            txtTenKhoa.DataBindings.Clear();
            txtTenKhoa.DataBindings.Add("Text", dataKhoaVien.DataSource, "TENKHOA");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dataKhoaVien.DataSource, "DIACHI");

            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dataKhoaVien.DataSource, "SODT");
        }

        private void DataKhoaVien_Load(object sender, EventArgs e)
        {
            LAY_DULIEU();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String sql_xoa = "DELETE FROM KHOAVIEN WHERE MAKHOA = '" + txtMaKhoa.Text + "'";
            kn.THUCTHI_DULIEU(sql_xoa);
            LAY_DULIEU();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            String sql_sua = string.Format("UPDATE KHOAVIEN SET TENKHOA = '{0}', DIACHI = '{1}', SODT = '{2}' WHERE MAKHOA = '{3}'", txtTenKhoa.Text, txtDiaChi.Text, txtSDT.Text, txtMaKhoa.Text);
            kn.THUCTHI_DULIEU(sql_sua);
            LAY_DULIEU();
        }

        private void btnChen_Click(object sender, EventArgs e)
        {
            String sql_chen = string.Format("INSERT INTO KHOAVIEN VALUES ('{0}','{1}','{2}','{3}')", txtMaKhoa.Text,txtTenKhoa.Text,txtDiaChi.Text,txtSDT.Text);
            kn.THUCTHI_DULIEU(sql_chen);
            LAY_DULIEU();
        }
    }
}
