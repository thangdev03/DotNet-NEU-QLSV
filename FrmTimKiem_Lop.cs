﻿using System;
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
    public partial class FrmTimKiem_Lop : Form
    {
        public FrmTimKiem_Lop()
        {
            InitializeComponent();
        }

        KetNoiDB kn = new KetNoiDB();

        private void FrmTimKiem_Lop_Load(object sender, EventArgs e)
        {
            DataTable dtaKhoa = kn.LayBang("SELECT MAKHOA FROM KHOAVIEN");
            DataTable dtaHe = kn.LayBang("SELECT MAHE FROM HEDAOTAO");

            cboMaKhoa.DataSource = dtaKhoa;
            cboMaKhoa.DisplayMember = "MAKHOA";
            cboMaKhoa.ValueMember = "MAKHOA";

            cboMaHe.DataSource = dtaHe;
            cboMaHe.DisplayMember = "MAHE";
            cboMaHe.ValueMember = "MAHE";

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            String malop = txtMaLop.Text;
            String tenlop = txtTenLop.Text;
            String makhoa = cboMaKhoa.Text;
            String mahe = cboMaHe.Text;

            String sql_timkiem = "SELECT * FROM LOP";

            if (optMaLop.Checked == true)
            {
                sql_timkiem = $"SELECT * FROM LOP WHERE MALOP like '%{malop}%'";
            } else if (optTenLop.Checked == true)
            {
                sql_timkiem = $"SELECT * FROM LOP WHERE TENLOP like '%{tenlop}%'";

            } else if (optMaKhoa.Checked == true)
            {
                sql_timkiem = $"SELECT * FROM LOP WHERE MAKHOA like '{makhoa}'";

            } else if (optMaHe.Checked == true)
            {
                sql_timkiem = $"SELECT * FROM LOP WHERE MAHE like '{mahe}'";
            }

            dta = kn.LayBang(sql_timkiem);
            dataGridKetQua.DataSource = dta;
        }
    }
}
