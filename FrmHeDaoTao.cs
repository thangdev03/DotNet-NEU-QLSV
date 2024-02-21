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
    public partial class FrmHeDaoTao : Form
    {
        public FrmHeDaoTao()
        {
            InitializeComponent();
        }

        private void FrmHeDaoTao_Load(object sender, EventArgs e)
        {
            LAY_DULIEU();
        }

        KetNoiDB kn = new KetNoiDB();
        public void LAY_DULIEU()
        {
            DataTable dta = new DataTable();
            dta = kn.LayBang("Select * from HEDAOTAO");
            dataHeDaoTao.DataSource = dta;
            HIENTHIDULIEU();
        }

        public void HIENTHIDULIEU()
        {
            txtMaHe.DataBindings.Clear();
            txtMaHe.DataBindings.Add("Text", dataHeDaoTao.DataSource, "MAHE");

            txtTenHe.DataBindings.Clear();
            txtTenHe.DataBindings.Add("Text", dataHeDaoTao.DataSource, "TENHE");
            
            txtMucHP.DataBindings.Clear();
            txtMucHP.DataBindings.Add("Text", dataHeDaoTao.DataSource, "MUCHP");

            txtSoNam.DataBindings.Clear();
            txtSoNam.DataBindings.Add("Text", dataHeDaoTao.DataSource, "SONAM");

            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", dataHeDaoTao.DataSource, "GHICHU");
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            txtMaHe.Text = "";
            txtMaHe.Focus();
            txtTenHe.Text = "";
            txtMucHP.Text = "";
            txtSoNam.Text = "";
            txtGhiChu.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String sql_xoa = "DELETE FROM HEDAOTAO WHERE MAHE='" + txtMaHe.Text + "'";
            kn.THUCTHI_DULIEU(sql_xoa);
            LAY_DULIEU();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            String sql_sua = string.Format("UPDATE HEDAOTAO SET TENHE = '{0}', MUCHP = '{1}', SONAM = '{2}', GHICHU = '{3}' WHERE MAHE= '{4}'", txtTenHe.Text, txtMucHP.Text, txtSoNam.Text, txtGhiChu.Text, txtMaHe);
            kn.THUCTHI_DULIEU(sql_sua);
            LAY_DULIEU();
        }

        private void btnChen_Click(object sender, EventArgs e)
        {
            String sql_chen = string.Format("INSERT INTO HEDAOTAO VALUES ('{0}','{1}','{2}','{3}','{4}')", txtMaHe.Text, txtTenHe.Text, txtMucHP.Text, txtSoNam.Text, txtGhiChu.Text);
            kn.THUCTHI_DULIEU(sql_chen);
            LAY_DULIEU();
        }
    }
}
