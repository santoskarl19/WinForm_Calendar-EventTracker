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
using Bunifu;

namespace Calendar_EventTracker
{
    public partial class EventView : MaterialForm
    {
        public EventView() 
        {
            InitializeComponent();
        }

        private void EventView_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GlobalData.EventList;
        }

        private void btnDeleteEvent_Click(object sender, EventArgs e)
        {
            // display warning message and store it to object variable
            DialogResult result = MessageBox.Show("Do you like to proceed?", "Warning", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // remove selected index from data grid
                GlobalData.EventList.RemoveAt(dataGridView1.CurrentRow.Index);

                // display message once record is deleted
                MessageBox.Show("Event Successfully Deleted!");

            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Event Not Deleted!");
            }
        }

    }
}
