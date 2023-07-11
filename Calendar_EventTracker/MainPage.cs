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
using System.Reflection;

namespace Calendar_EventTracker
{
    public partial class MainPage : MaterialForm
    {
        public MainPage()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            SkinManager.AddFormToManage(this);
            SkinManager.Theme = MaterialSkinManager.Themes.DARK;
            SkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);

        }

        private void Form2_Load(object sender, EventArgs e)
        {



        }

        // January
        public void panel1_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();

            eventForm.ShowDialog();

        }

        private void panel2_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();

            eventForm.ShowDialog();
        }
        private void btnViewEvents_Click(object sender, EventArgs e)
        {
            EventView eventView = new EventView();

            eventView.ShowDialog();
        }

        
    }
}
