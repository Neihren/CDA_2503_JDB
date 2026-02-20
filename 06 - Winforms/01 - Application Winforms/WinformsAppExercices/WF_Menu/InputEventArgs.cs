using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Menu
{
    public class InputEventArgs : EventArgs
    {
        private string input;

        public InputEventArgs(string input) : base()
        {
            this.input = input;
        }

        public string Input { get => input; /*set => input = value;*/ }

    }
}
