using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Nhớ thêm thư viện
using System.Data.SqlClient;

namespace TranNhatThang_QLSV
{
    public partial class FrmTimKiem_SinhVien_SQL : Form
    {
        public FrmTimKiem_SinhVien_SQL()
        {
            InitializeComponent();
        }

        KetNoiDB kn = new KetNoiDB();

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTimKiem_SinhVien_SQL_Load(object sender, EventArgs e)
        {
            // Hiển thị dữ liệu combobox
            DataTable dta = kn.LayBang("SELECT MALOP FROM LOP");
            cboMaLop.DataSource = dta;
            cboMaLop.DisplayMember = "MALOP";
            cboMaLop.ValueMember = "MALOP";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            String sql_timkiem = "";

            if (optMasv.Checked == true)
            {
                String masv = txtMaSV.Text;
                sql_timkiem = $"EXEC TimKiemSinhVien_View_MASV '{masv}'";
            } else if (optHoten.Checked == true)
            {
                String hoten = txtHoTen.Text;
                sql_timkiem = $"EXEC TimKiemSinhVien_TENSV '{hoten}'";
            } else if (optMalop.Checked == true)
            {
                String malop = cboMaLop.Text;
                sql_timkiem = $"EXEC TimKiemSinhVien_MALOP '{malop}'";
            }

            dta = kn.LayBang(sql_timkiem);
            dataGridKetQua.DataSource = dta;
        }
    }
}
