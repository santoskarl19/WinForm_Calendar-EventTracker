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

        private void panel162_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox92.Text = "X";
        }

        private void panel161_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox93.Text = "X";
        }

        private void panel160_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox94.Text = "X";
        }

        private void panel159_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox95.Text = "X";
        }

        private void panel158_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox96.Text = "X";
        }

        private void panel157_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox97.Text = "X";
        }

        private void panel156_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox98.Text = "X";
        }

        private void panel155_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox99.Text = "X";
        }

        private void panel154_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox100.Text = "X";
        }

        private void panel153_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox101.Text = "X";
        }

        private void panel152_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox102.Text = "X";
        }

        private void panel151_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox103.Text = "X";
        }

        private void panel150_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox104.Text = "X";
        }

        private void panel149_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox105.Text = "X";
        }

        private void panel148_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox106.Text = "X";
        }

        private void panel147_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox107.Text = "X";
        }

        private void panel146_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox108.Text = "X";
        }

        private void panel145_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox109.Text = "X";
        }

        private void panel144_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox110.Text = "X";
        }

        private void panel143_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox111.Text = "X";
        }

        private void panel142_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox112.Text = "X";
        }

        private void panel141_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox113.Text = "X";
        }

        private void panel140_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox114.Text = "X";
        }

        private void panel139_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox115.Text = "X";
        }

        private void panel138_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox116.Text = "X";
        }

        private void panel137_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox117.Text = "X";
        }

        private void panel136_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox118.Text = "X";
        }

        private void panel135_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox119.Text = "X";
        }

        private void panel134_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox120.Text = "X";
        }

        private void panel133_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox121.Text = "X";
        }
                            // MAY
        private void button4_Click(object sender, EventArgs e)
        {
            EventView eventView = new EventView();
            eventView.ShowDialog();
        }

        private void panel209_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox122.Text = "X";
        }

        private void panel208_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox123.Text = "X";
        }

        private void panel207_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox124.Text = "X";
        }

        private void panel206_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox125.Text = "X";
        }

        private void panel205_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox126.Text = "X";
        }

        private void panel204_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox127.Text = "X";
        }

        private void panel203_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox128.Text = "X";
        }

        private void panel202_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox129.Text = "X";
        }

        private void panel201_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox130.Text = "X";
        }

        private void panel200_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox131.Text = "X";
        }

        private void panel199_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox132.Text = "X";
        }

        private void panel198_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox133.Text = "X";
        }

        private void panel197_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox134.Text = "X";
        }

        private void panel196_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox135.Text = "X";
        }

        private void panel195_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox136.Text = "X";
        }

        private void panel194_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox137.Text = "X";
        }

        private void panel193_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox138.Text = "X";
        }

        private void panel192_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox139.Text = "X";
        }

        private void panel191_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox140.Text = "X";
        }

        private void panel190_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox141.Text = "X";
        }

        private void panel189_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox142.Text = "X";
        }

        private void panel188_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox143.Text = "X";
        }

        private void panel187_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox144.Text = "X";
        }

        private void panel186_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox145.Text = "X";
        }

        private void panel185_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox146.Text = "X";
        }

        private void panel184_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox147.Text = "X";
        }

        private void panel183_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox148.Text = "X";
        }

        private void panel182_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox149.Text = "X";
        }

        private void panel181_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox150.Text = "X";
        }

        private void panel180_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox151.Text = "X";
        }

        private void panel179_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox152.Text = "X";
        }
                           // JUNE
        private void button5_Click(object sender, EventArgs e)
        {
            EventView eventView = new EventView();
            eventView.ShowDialog();
        }

        private void panel248_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox153.Text = "X";
        }

        private void panel247_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox154.Text = "X";
        }

        private void panel246_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox155.Text = "X";
        }

        private void panel245_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox156.Text = "X";
        }

        private void panel244_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox157.Text = "X";
        }

        private void panel243_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox158.Text = "X";
        }

        private void panel242_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox159.Text = "X";
        }

        private void panel241_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox160.Text = "X";
        }

        private void panel240_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox161.Text = "X";
        }

        private void panel239_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox162.Text = "X";
        }

        private void panel238_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox163.Text = "X";
        }

        private void panel237_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox164.Text = "X";
        }

        private void panel236_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox165.Text = "X";
        }

        private void panel235_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox166.Text = "X";
        }

        private void panel234_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox167.Text = "X";
        }

        private void panel233_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox168.Text = "X";
        }

        private void panel232_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox169.Text = "X";
        }

        private void panel231_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox170.Text = "X";
        }

        private void panel230_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox171.Text = "X";
        }

        private void panel229_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox172.Text = "X";
        }

        private void panel228_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox173.Text = "X";
        }

        private void panel227_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox174.Text = "X";
        }

        private void panel226_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox175.Text = "X";
        }

        private void panel225_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox176.Text = "X";
        }

        private void panel224_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox177.Text = "X";
        }

        private void panel223_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox178.Text = "X";
        }

        private void panel222_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox179.Text = "X";
        }

        private void panel221_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox180.Text = "X";
        }

        private void panel220_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox181.Text = "X";
        }

        private void panel219_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox182.Text = "X";
        }
                            // JULY
        private void button6_Click(object sender, EventArgs e)
        {
            EventView eventView = new EventView();
            eventView.ShowDialog();
        }

        private void panel288_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox183.Text = "X";
        }

        private void panel287_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox184.Text = "X";
        }

        private void panel286_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox185.Text = "X";
        }

        private void panel285_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox186.Text = "X";
        }

        private void panel284_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox187.Text = "X";
        }

        private void panel283_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox188.Text = "X";
        }

        private void panel282_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox189.Text = "X";
        }

        private void panel281_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox190.Text = "X";
        }

        private void panel280_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox191.Text = "X";
        }

        private void panel279_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox192.Text = "X";
        }

        private void panel278_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox193.Text = "X";
        }

        private void panel277_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox194.Text = "X";
        }

        private void panel276_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox195.Text = "X";
        }

        private void panel275_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox196.Text = "X";
        }

        private void panel274_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox197.Text = "X";
        }

        private void panel273_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox198.Text = "X";
        }

        private void panel272_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox199.Text = "X";
        }

        private void panel271_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox200.Text = "X";
        }

        private void panel270_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox201.Text = "X";
        }

        private void panel269_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox202.Text = "X";
        }

        private void panel268_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox203.Text = "X";
        }

        private void panel267_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox204.Text = "X";
        }

        private void panel266_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox205.Text = "X";
        }

        private void panel265_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox206.Text = "X";
        }

        private void panel264_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox207.Text = "X";
        }

        private void panel263_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox208.Text = "X";
        }

        private void panel262_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox209.Text = "X";
        }

        private void panel261_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox210.Text = "X";
        }

        private void panel260_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox211.Text = "X";
        }

        private void panel259_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox212.Text = "X";
        }

        private void panel258_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox213.Text = "X";
        }
                          // AUGUST
        private void button7_Click(object sender, EventArgs e)
        {
            EventView eventView = new EventView();
            eventView.ShowDialog();
        }

        private void panel334_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox214.Text = "X";
        }

        private void panel333_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox215.Text = "X";
        }

        private void panel332_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox216.Text = "X";
        }

        private void panel331_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox217.Text = "X";
        }

        private void panel330_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox218.Text = "X";
        }

        private void panel329_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox219.Text = "X";
        }

        private void panel328_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox220.Text = "X";
        }

        private void panel327_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox221.Text = "X";
        }

        private void panel326_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox222.Text = "X";
        }

        private void panel325_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox223.Text = "X";
        }

        private void panel324_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox224.Text = "X";
        }

        private void panel323_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox225.Text = "X";
        }

        private void panel322_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox226.Text = "X";
        }

        private void panel321_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox227.Text = "X";
        }

        private void panel320_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox228.Text = "X";
        }

        private void panel319_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox229.Text = "X";
        }

        private void panel318_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox230.Text = "X";
        }

        private void panel317_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox231.Text = "X";
        }

        private void panel316_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox232.Text = "X";
        }

        private void panel315_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox233.Text = "X";
        }

        private void panel314_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox234.Text = "X";
        }

        private void panel313_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox235.Text = "X";
        }

        private void panel312_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox236.Text = "X";
        }

        private void panel311_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox237.Text = "X";
        }

        private void panel310_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox238.Text = "X";
        }

        private void panel309_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox239.Text = "X";
        }

        private void panel308_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox240.Text = "X";
        }

        private void panel307_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox241.Text = "X";
        }

        private void panel306_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox242.Text = "X";
        }

        private void panel305_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox243.Text = "X";
        }

        private void panel304_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox244.Text = "X";
        }
                        // SEPTEMBER
        private void button8_Click(object sender, EventArgs e)
        {
            EventView eventView = new EventView();
            eventView.ShowDialog();
        }

        private void panel373_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox245.Text = "X";
        }

        private void panel372_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox246.Text = "X";
        }

        private void panel371_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox247.Text = "X";
        }

        private void panel370_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox248.Text = "X";
        }

        private void panel369_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox249.Text = "X";
        }

        private void panel368_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox250.Text = "X";
        }

        private void panel367_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox251.Text = "X";
        }

        private void panel366_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox252.Text = "X";
        }

        private void panel365_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox253.Text = "X";
        }

        private void panel364_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox254.Text = "X";
        }

        private void panel363_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox255.Text = "X";
        }

        private void panel362_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox256.Text = "X";
        }

        private void panel361_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox257.Text = "X";
        }

        private void panel360_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox258.Text = "X";
        }

        private void panel359_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox259.Text = "X";
        }

        private void panel358_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox260.Text = "X";
        }

        private void panel357_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox261.Text = "X";
        }

        private void panel356_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox262.Text = "X";
        }

        private void panel355_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox263.Text = "X";
        }

        private void panel354_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox264.Text = "X";
        }

        private void panel353_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox265.Text = "X";
        }

        private void panel352_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox266.Text = "X";
        }

        private void panel351_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox267.Text = "X";
        }

        private void panel350_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox268.Text = "X";
        }

        private void panel349_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox269.Text = "X";
        }

        private void panel348_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox270.Text = "X";
        }

        private void panel347_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox271.Text = "X";
        }

        private void panel346_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox272.Text = "X";
        }

        private void panel345_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox273.Text = "X";
        }

        private void panel344_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            if (GlobalData.ifAdded == true)
                textBox274.Text = "X";
        }
    }
}
