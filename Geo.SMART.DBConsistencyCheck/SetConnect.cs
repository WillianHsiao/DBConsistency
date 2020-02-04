using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Geo.SMART.DBConsistencyCheck.Model;

namespace Geo.SMART.DBConsistencyCheck
{
    public partial class SetConnect : Form
    {
        public SetConnect(DBConnectModel dbConnectModel)
        {
            InitializeComponent();
            if (dbConnectModel == null) return;
            DbConnect = dbConnectModel;
            txtServerName.Text = DbConnect.ServerName;
            txtDBName.Text = DbConnect.DBName;
            txtAccount.Text = DbConnect.Account;
            txtPassword.Text = DbConnect.Password;
        }

        public DBConnectModel DbConnect { get; private set; }

        /// <summary>
        /// 測試結果
        /// </summary>
        private bool _testSuccess;

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (_testSuccess)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                if (TestConn())
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show(@"連線測試失敗");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            DbConnect = null;
        }

        private void btnTestConn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TestConn() ? "連線測試成功" : "連線測試失敗");
        }

        private bool TestConn()
        {
            DbConnect = new DBConnectModel
            {
                ServerName = txtServerName.Text,
                DBName = txtDBName.Text,
                Account = txtAccount.Text,
                Password = txtPassword.Text
            };

            using (var conn = new SqlConnection(DbConnect.ConnectionString))
            {
                try
                {
                    conn.Open();
                    _testSuccess = true;
                }
                catch
                {
                    _testSuccess = false;
                }
            }

            return _testSuccess;
        }
    }
}
