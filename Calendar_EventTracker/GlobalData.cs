using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar_EventTracker
{
    public static class GlobalData
    {
        public static BindingList<Events> EventList { get; } = new BindingList<Events>();
    }
}
