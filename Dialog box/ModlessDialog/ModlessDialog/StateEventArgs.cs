using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModlessDialog
{
    public class StateEventArgs : EventArgs
    {
        public bool State { get; set; }
    }

    public delegate void StateEventHandler(object sender, StateEventArgs e);
}
