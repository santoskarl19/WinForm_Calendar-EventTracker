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
    public partial class EventForm : MaterialForm
    {
        public EventForm()
        {
            InitializeComponent();

        }

        private void EventForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveEvent_Click(object sender, EventArgs e)
        {
            Events newEvent = new Events();

            newEvent.Event_Name = txtEvent.Text;
            newEvent.Location = txtLocation.Text;
            newEvent.Details = txtDetails.Text;

            GlobalData.EventList.Add(newEvent);

            MessageBox.Show("Event added!");

            txtDetails.Clear();
            txtEvent.Clear();
            txtLocation.Clear();

            this.Close();
        }
    }
}
