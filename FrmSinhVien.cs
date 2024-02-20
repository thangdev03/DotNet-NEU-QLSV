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
            Console.WriteLine("malop:" + malop);
            Console.WriteLine("ngaysinh:" + ngaysinh);

            String optGioiTinh = "0";
            if (optNam.Checked == true)
            {
                optGioiTinh = "1";
            }
            String sql_chen = $"INSERT INTO SINHVIEN VALUES ('{masv}','{hoten}','{optGioiTinh}','{ngaysinh}','{noisinh}','{malop}')";
            kn.THUCTHI_DULIEU(sql_chen);
            LAY_DULIEU();
        }
    }
}
