using System;
using System.Windows.Forms;
using Geo.SMART.DBConsistencyCheck.Model;

namespace Geo.SMART.DBConsistencyCheck
{
    public partial class Main : Form
    {
        private DBConnectModel _sourceDbConnectModel;
        private DBConnectModel _destDbConnectModel;

        public Main()
        {
            InitializeComponent();
        }

        private void btnSetSourceConn_Click(object sender, EventArgs e)
        {
            var setConnect = new SetConnect(_sourceDbConnectModel)
            {
                StartPosition = FormStartPosition.WindowsDefaultLocation
            };
            var dialogResult = setConnect.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                _sourceDbConnectModel = setConnect.DbConnect;
                lblSourceConnStr.Text = setConnect.DbConnect.ConnectionString;
            }
        }

        private void btnSetDestConn_Click(object sender, EventArgs e)
        {
            var setConnect = new SetConnect(_destDbConnectModel)
            {
                StartPosition = FormStartPosition.WindowsDefaultLocation
            };
            var dialogResult = setConnect.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                _destDbConnectModel = setConnect.DbConnect;
                lblDestConnStr.Text = setConnect.DbConnect.ConnectionString;
            }
        }
    }
}
