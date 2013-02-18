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

        }
    }
}
