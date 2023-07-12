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

        private void btnOpenEvents_Click(object sender, EventArgs e)
        {
            EventView eventView = new EventView();

            eventView.ShowDialog();
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

        private void panel4_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();

            eventForm.ShowDialog();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();

            eventForm.ShowDialog();
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();

            eventForm.ShowDialog();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();

            eventForm.ShowDialog();
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();

            eventForm.ShowDialog();
        }

        private void panel14_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();

            eventForm.ShowDialog();
        }

        private void panel13_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();

            eventForm.ShowDialog();
        }

        private void panel12_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();

            eventForm.ShowDialog();
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();

            eventForm.ShowDialog();
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();

            eventForm.ShowDialog();
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();

            eventForm.ShowDialog();
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();

            eventForm.ShowDialog();
        }

        private void panel21_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();

            eventForm.ShowDialog();
        }

        private void panel20_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();

            eventForm.ShowDialog();
        }

        private void panel19_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();

            eventForm.ShowDialog();
        }

        private void panel18_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();

            eventForm.ShowDialog();
        }

        private void panel17_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();

            eventForm.ShowDialog();
        }

        private void panel16_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();

            eventForm.ShowDialog();
        }

        private void panel15_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();

            eventForm.ShowDialog();
        }

        private void panel28_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();

            eventForm.ShowDialog();
        }

        private void panel27_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();

            eventForm.ShowDialog();
        }

        private void panel26_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();

            eventForm.ShowDialog();
        }

        private void panel25_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();

            eventForm.ShowDialog();
        }

        private void panel24_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();

            eventForm.ShowDialog();
        }

        private void panel23_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();

            eventForm.ShowDialog();
        }

        private void panel22_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();

            eventForm.ShowDialog();
        }

        private void panel35_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();

            eventForm.ShowDialog();
        }

        private void panel34_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();

            eventForm.ShowDialog();
        }

        private void panel33_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();

            eventForm.ShowDialog();
        }

        
    }
}
