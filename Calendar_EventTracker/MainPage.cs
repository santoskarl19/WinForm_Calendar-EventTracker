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

                            // JANUARY
        private void btnOpenEvents_Click(object sender, EventArgs e)
        {
            EventView eventView = new EventView();
            eventView.ShowDialog();
        }

        public void panel1_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox1.Text = "X";
        }
        
        private void panel2_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox2.Text = "X";
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox3.Text = "X";
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox4.Text = "X";
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox5.Text = "X";
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox6.Text = "X";
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox7.Text = "X";
        }

        private void panel14_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox8.Text = "X";
        }

        private void panel13_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox9.Text = "X";
        }

        private void panel12_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox10.Text = "X";
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox11.Text = "X";
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox12.Text = "X";
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox13.Text = "X";
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox14.Text = "X";
        }

        private void panel21_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox15.Text = "X";
        }

        private void panel20_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox16.Text = "X";
        }

        private void panel19_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox17.Text = "X";
        }

        private void panel18_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox18.Text = "X";
        }

        private void panel17_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox19.Text = "X";
        }

        private void panel16_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox20.Text = "X";
        }

        private void panel15_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox21.Text = "X";
        }

        private void panel28_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox22.Text = "X";
        }

        private void panel27_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox23.Text = "X";
        }

        private void panel26_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox24.Text = "X";
        }

        private void panel25_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox25.Text = "X";
        }

        private void panel24_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox26.Text = "X";
        }

        private void panel23_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox27.Text = "X";
        }

        private void panel22_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox28.Text = "X";
        }

        private void panel35_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox29.Text = "X";
        }

        private void panel34_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox30.Text = "X";
        }

        private void panel33_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox31.Text = "X";
        }

                        // FEBRUARY
        private void button2_Click(object sender, EventArgs e)
        {
            EventView eventView = new EventView();
            eventView.ShowDialog();
        }
        private void panel81_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox33.Text = "X";
        }

        private void panel80_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox34.Text = "X";
        }

        private void panel79_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox35.Text = "X";
        }

        private void panel78_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox36.Text = "X";
        }

        private void panel77_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox37.Text = "X";
        }

        private void panel76_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox38.Text = "X";
        }

        private void panel75_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox39.Text = "X";
        }

        private void panel74_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox40.Text = "X";
        }

        private void panel73_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox41.Text = "X";
        }

        private void panel72_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox42.Text = "X";
        }

        private void panel71_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox43.Text = "X";
        }

        private void panel70_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox44.Text = "X";
        }

        private void panel69_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox45.Text = "X";
        }

        private void panel68_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox46.Text = "X";
        }

        private void panel67_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox47.Text = "X";
        }

        private void panel66_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox48.Text = "X";
        }

        private void panel65_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox49.Text = "X";
        }

        private void panel64_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox50.Text = "X";
        }

        private void panel63_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox51.Text = "X";
        }

        private void panel62_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox52.Text = "X";
        }

        private void panel61_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox53.Text = "X";
        }

        private void panel60_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox54.Text = "X";
        }

        private void panel59_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox55.Text = "X";
        }

        private void panel58_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox56.Text = "X";
        }

        private void panel57_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox57.Text = "X";
        }

        private void panel56_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox58.Text = "X";
        }

        private void panel55_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox59.Text = "X";
        }

        private void panel54_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox60.Text = "X";
        }
                            // MARCH
        private void button3_Click(object sender, EventArgs e)
        {
            EventView eventView = new EventView();
            eventView.ShowDialog();
        }

        private void panel123_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox61.Text = "X";
        }

        private void panel122_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox62.Text = "X";
        }

        private void panel121_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox63.Text = "X";
        }

        private void panel120_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox64.Text = "X";
        }

        private void panel119_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox65.Text = "X";
        }

        private void panel118_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox66.Text = "X";
        }

        private void panel117_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox67.Text = "X";
        }

        private void panel116_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox68.Text = "X";
        }

        private void panel115_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox69.Text = "X";
        }

        private void panel114_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox70.Text = "X";
        }

        private void panel113_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox71.Text = "X";
        }

        private void panel112_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox72.Text = "X";
        }

        private void panel111_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox73.Text = "X";
        }

        private void panel110_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox74.Text = "X";
        }

        private void panel109_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox75.Text = "X";
        }

        private void panel108_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox76.Text = "X";
        }

        private void panel107_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox77.Text = "X";
        }

        private void panel106_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox78.Text = "X";
        }

        private void panel105_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox79.Text = "X";
        }

        private void panel104_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox80.Text = "X";
        }

        private void panel103_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox81.Text = "X";
        }

        private void panel102_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox82.Text = "X";
        }

        private void panel101_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox83.Text = "X";
        }

        private void panel100_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox84.Text = "X";
        }

        private void panel99_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox85.Text = "X";
        }

        private void panel98_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox86.Text = "X";
        }

        private void panel97_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox87.Text = "X";
        }

        private void panel96_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox88.Text = "X";
        }

        private void panel95_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox89.Text = "X";
        }

        private void panel94_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox90.Text = "X";
        }

        private void panel93_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox91.Text = "X";
        }

                            // APRIL
        private void button1_Click(object sender, EventArgs e)
        {
            EventView eventView = new EventView();
            eventView.ShowDialog();
        }
    }
}
