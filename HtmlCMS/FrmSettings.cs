using System;
using System.Windows.Forms;

namespace HtmlCMS
{
    public partial class FrmSettings : Form
    {
        private readonly Settings.Setting _setting;

        public FrmSettings()
        {
            InitializeComponent();
        }

        public FrmSettings(Settings.Setting setting)
        {
            InitializeComponent();
            _setting = setting;
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            chkLinkTarget.Checked = _setting.LinkTarget;
            chkLinkrel.Checked = _setting.LinkRel;

        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            _setting.LinkTarget = chkLinkTarget.Checked;
            _setting.LinkRel = chkLinkrel.Checked;
            if (Settings.SerializeToXml(_setting))
                this.Close();
            else
                MessageBox.Show("Unsuccessfull");
        }
    }
}
