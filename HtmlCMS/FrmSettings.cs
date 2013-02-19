using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HtmlCMS
{
    public partial class FrmSettings : Form
    {
        private Settings.Setting _setting;

        public FrmSettings()
        {
            InitializeComponent();
        }

        public FrmSettings(Settings.Setting setting)
        {
            InitializeComponent();
            this._setting = setting;
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            txtMaxWidth.Text = _setting.MaxWidthSetting;
            chkLinkPushStyle.Checked = _setting.LinkPushStyle;

            if (string.IsNullOrEmpty(txtMaxWidth.Text))
                txtMaxWidth.Text = "max-width:755px;";
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            _setting.MaxWidthSetting = txtMaxWidth.Text.Trim();
            _setting.LinkPushStyle = chkLinkPushStyle.Checked;
            if (Settings.SerializeToXml(_setting))
                this.Close();
            else
                MessageBox.Show("Unsuccessfull");
        }
    }
}
