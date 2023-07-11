using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu;

namespace Calendar_EventTracker
{
    public partial class EventView : Form
    {
        public EventView()
        {
            InitializeComponent();

        }

        private void EventView_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GlobalData.EventList;
        }
    }
}
