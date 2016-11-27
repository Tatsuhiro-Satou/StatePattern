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
    public partial class MenuScreen : UserControl, IWindowState
    {
        private StringHolder stringHolder;

        public MenuScreen(StringHolder output)
        {
            InitializeComponent();
            stringHolder = output;
        }

        public void Render()
        {
            stringHolder.Change("Menu screen");
        }
    }
}
