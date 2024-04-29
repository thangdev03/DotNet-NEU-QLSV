using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranNhatThang_QLSV
{
    public partial class FrmSinhVien : Form
    {
        public FrmSinhVien()
        {
            InitializeComponent();
        }

        private void FrmSinhVien_Load(object sender, EventArgs e)
        {
            LAY_DULIEU();
            LAY_DULIEU_BANGLOP();
            dataSinhVien.SelectionChanged += dataSinhVien_SelectionChanged;
        }

        KetNoiDB kn = new KetNoiDB();
        
        public void LAY_DULIEU()
        {
            DataTable dta = new DataTable();
            dta = kn.LayBang("Select * From SINHVIEN");
            dataSinhVien.DataSource = dta;
            HIENTHIDULIEU();
        }

        public void LAY_DULIEU_BANGLOP()
        {
            DataTable dta = kn.LayBang("Select MALOP, TENLOP From LOP");
            cboMaLop.DataSource = dta;
            cboMaLop.DisplayMember = "MALOP";
            cboMaLop.ValueMember = "MALOP";
        }

        public void LAY_DULIEU_GIOITINH(String maSV)
        {
            DataTable dta = kn.LayBang($"Select GIOITINH From SINHVIEN WHERE MASV = {maSV}");
        }

        private void dataSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            HIENTHIDULIEU();
        }

        public void HIENTHIDULIEU()
        {
            txtMaSV.DataBindings.Clear();
            txtMaSV.DataBindings.Add("Text", dataSinhVien.DataSource, "MASV");

            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("Text", dataSinhVien.DataSource, "HOTEN");

            txtNgaySinh.DataBindings.Clear();
            txtNgaySinh.DataBindings.Add("Value", dataSinhVien.DataSource, "NGAYSINH");

            txtNoiSinh.DataBindings.Clear();
            txtNoiSinh.DataBindings.Add("Text", dataSinhVien.DataSource, "NOISINH");

            cboMaLop.DataBindings.Clear();
            cboMaLop.DataBindings.Add("Text", dataSinhVien.DataSource, "MALOP");

            string gioiTinhValue = dataSinhVien.CurrentRow.Cells["GIOITINH"].Value.ToString();

            optNam.Checked = (gioiTinhValue == "1") ? true : false;
            optNu.Checked = (gioiTinhValue == "0") ? true : false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            txtMaSV.Text = "";
            txtMaSV.Focus();
            txtHoTen.Text = "";
            txtNgaySinh.Text = "";
            txtNoiSinh.Text = "";
            optNam.Checked = false;
            optNu.Checked = false;
        }

        private void btnChen_Click(object sender, EventArgs e)
        {
            String masv = txtMaSV.Text;
            String hoten = txtHoTen.Text;
            DateTime ngaysinhValue = txtNgaySinh.Value;
            String ngaysinh = ngaysinhValue.ToString("MM-dd-yyyy");
            String noisinh = txtNoiSinh.Text;
            String malop = cboMaLop.Text;
            String optGioiTinh = optNam.Checked ? "1" : "0";

            String sql_chen = $"INSERT INTO SINHVIEN VALUES ('{masv}','{hoten}','{optGioiTinh}','{ngaysinh}','{noisinh}','{malop}')";
            kn.THUCTHI_DULIEU(sql_chen);
            LAY_DULIEU();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String sql_xoa = $"DELETE FROM SINHVIEN WHERE MASV = '{txtMaSV.Text}'";
            kn.THUCTHI_DULIEU(sql_xoa);
            LAY_DULIEU();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            String masv = txtMaSV.Text;
            String hoten = txtHoTen.Text;
            DateTime ngaysinhValue = txtNgaySinh.Value;
            String ngaysinh = ngaysinhValue.ToString("MM-dd-yyyy");
            String noisinh = txtNoiSinh.Text;
            String malop = cboMaLop.Text;
            String optGioiTinh = optNam.Checked ? "1" : "0";

            String sql_sua = $"UPDATE SINHVIEN SET HOTEN = '{hoten}',GIOITINH = '{optGioiTinh}',NGAYSINH = '{ngaysinh}' ,NOISINH = '{noisinh}',MALOP = '{malop}'" +
                $"WHERE MASV = '{masv}'";

            kn.THUCTHI_DULIEU(sql_sua);
            LAY_DULIEU();
        }
    }
}
