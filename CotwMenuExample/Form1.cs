using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CotwMenuExample
{
    public partial class Form1 : Form
    {
        public GameStateManager gameStateManager { get; private set; }
        private StringHolder pretendDevice;

        public Form1()
        {
            InitializeComponent();
            pretendDevice = new StringHolder();
            pretendDevice.Change("no state");
            gameStateManager = new GameStateManager(new MenuScreen(pretendDevice));

            //while (true)
            //{
            gameStateManager.Process();
            //}
            Debug.WriteLine("now: " + pretendDevice.Output);


        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString(pretendDevice.Output, this.Font, Brushes.Black, 0, 0);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                Debug.WriteLine("You pressed ENTER");
                gameStateManager.Switch(new StartScreen(pretendDevice));
            }
        }
    }
}

/* other way


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CotwMenuExample
{
    public enum WindowState
    {
        MENU,
        START,
        INGAME
    }

    public partial class Form1 : Form
    {
        private WindowState windowState;

        public Form1()
        {
            InitializeComponent();
            ChangeState(windowState.MENU);
        }

        public void ChangeState()
        {
            switch (windowState)
            {
                case WindowState.MENU:
                    windowState = WindowState.MENU;
                        // ... Display menu
                    break;
                case WindowState.START:
                    windowState = WindowState.START;
                    // ... Display start screen 
                    break;
                case windowState.INGAME:
                    windowState = WindowState.INGAME;
                    // ... Display game screen 
                    break;
                default:
                    break;
            }

        }
    }
}

*/