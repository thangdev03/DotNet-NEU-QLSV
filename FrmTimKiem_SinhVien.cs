using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Thêm thư viện để tìm kiếm với biến

namespace TranNhatThang_QLSV
{
    public partial class FrmTimKiem_SinhVien : Form
    {
        public FrmTimKiem_SinhVien()
        {
            InitializeComponent();
        }

        KetNoiDB kn = new KetNoiDB();

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            String masv = txtMaSV.Text;
            String malop = cboMaLop.Text;
            String sql_timkiem;
            // sql_timkiem = $"SELECT * FROM SINHVIEN WHERE MASV LIKE '%{masv}%' OR HOTEN LIKE '%{masv}%'";
            sql_timkiem = $"SELECT * FROM SINHVIEN WHERE MALOP LIKE '{malop}'";
            dta = kn.LayBang(sql_timkiem);
            dataGridKetQua.DataSource = dta;
        }

        private void FrmTimKiem_SinhVien_Load(object sender, EventArgs e)
        {
            // Hiển thị dữ liệu combobox
            DataTable dta = kn.LayBang("SELECT MALOP FROM LOP");
            cboMaLop.DataSource = dta;
            cboMaLop.DisplayMember = "MALOP";
            cboMaLop.ValueMember = "MALOP";
        }

        private void dataGridKetQua_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cboMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
