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
    public partial class EventForm : Form
    {
        private string selectedDate;
        public EventForm(string selectedDate)
        {
            InitializeComponent();

            this.selectedDate = selectedDate;
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            txtDate.Text = selectedDate;
        }

        public void btnSave_Click(object sender, EventArgs e)
        {
            BindingList<Events> listOfEvents = new BindingList<Events>();
            Events newEvent = new Events();

            newEvent.eventDate = selectedDate; // Use the selected date from the constructor
            newEvent.eventName = txtEvent.Text;

            listOfEvents.Add(newEvent);
        }
    }
}
