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

namespace TranNhatThang_QLSV
{
    public partial class FrmLogin : Form
    {
        KetNoiDB kn = new KetNoiDB();

        public FrmLogin()
        {
            InitializeComponent();
        }


        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            kn.KetNoi_Dulieu();
            string DN = txtUsername.Text;
            string MK = txtPassword.Text;
            string sql_login = "Select TENDN, MATKHAU From HETHONG Where TENDN = '" + DN + "' and MATKHAU ='" + MK + "'";

            SqlCommand cmd = new SqlCommand(sql_login, kn.cnn);
            SqlDataReader datRed = cmd.ExecuteReader();
            if (datRed.Read() == true)
            {
                MessageBox.Show("Đăng nhập thành công!");
            }
            else
            {
                MessageBox.Show("Thông tin mật khẩu hoặc tên đăng nhập bị sai");
            }
            kn.HuyKetNoi();
        }
    }
}
