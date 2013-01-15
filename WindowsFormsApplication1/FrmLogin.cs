using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class FrmLogin : Form
    {
        Settings.Setting setting = new Settings.Setting();

        public FrmLogin(Settings.Setting _setting)
        {
            InitializeComponent();
            setting = _setting;
        }

        
        private bool firstTimeLogin = false;
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            var userName = setting.User.Email;
            if (string.IsNullOrEmpty(userName))
            {
                firstTimeLogin = true;
                btnLogin.Text = "Kayıt Ol";
            }
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUserName.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                if (firstTimeLogin)
                {
                    setting.User.Email = txtUserName.Text;
                    setting.User.Password = txtPassword.Text;
                    
                    Settings.SerializeToXml(setting);
                    
                    this.Visible = false;
                }
                else
                {
                    var userName = setting.User.Email;
                    var password = setting.User.Password;
                    if (txtUserName.Text.Equals(userName) && txtPassword.Text.Equals(password))
                    {
                        this.Visible = false;    
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı ve/veya şifre hatalı");
                    }
                }
            }
        }
        
        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
