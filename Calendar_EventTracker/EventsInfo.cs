using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar_EventTracker
{
    // all events will be temporary stored here while app is running
    public class Events
    {
        public string Event_Name { get; set; }
        public string Location { get; set; }
        public string Details { get; set; }
    }

}
