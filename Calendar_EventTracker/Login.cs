    using MaterialSkin.Controls;
    using MaterialSkin;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace Calendar_EventTracker
    {
        public partial class Login : MaterialForm
        {
            string userName = "harry.potter";
            string password = "magic123";

            MainPage mainPage = new MainPage();
            public Login()
            {
                InitializeComponent();
                var skinManager = MaterialSkinManager.Instance;
                SkinManager.AddFormToManage(this);
                SkinManager.Theme = MaterialSkinManager.Themes.DARK;
                SkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
            }

            private void label1_Click(object sender, EventArgs e)
            {

            }

            private void Login_Load(object sender, EventArgs e)
            {

            }

            private void btnClose_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }

            private void btnLogin_Click(object sender, EventArgs e)
            {
                if (txtUserName.Text == userName && txtPassword.Text == password)
                {
                    // display main page
                    mainPage.Show();

                    // clear text fields
                    txtUserName.Clear();
                    txtPassword.Clear();
                }
                else
                {
                    MessageBox.Show("Incorrect User Login or Password!", "ERROR");

                    // clear text fields
                    txtUserName.Clear();
                    txtPassword.Clear();
                }
            }
        }
    }
