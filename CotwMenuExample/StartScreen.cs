using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CotwMenuExample
{
    public partial class StartScreen : UserControl, IWindowState
    {
        private StringHolder stringHolder;

        public StartScreen(StringHolder output)
        {
            InitializeComponent();
            stringHolder = output;
        }

        public void Render()
        {
            stringHolder.Change("Start screen");
            Debug.WriteLine("now: " + stringHolder.Output);
        }
    }
}
