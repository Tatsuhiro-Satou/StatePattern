using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotwMenuExample
{
    public class GameStateManager
    {
        private IWindowState windowState;

        public void Process()
        {
            if (windowState != null)
                windowState.Render();

        }
        /// <summary>
        /// Return current state and replace it with the new state
        /// Return so that you have a reference of the previous screen
        /// </summary>
        public IWindowState Switch(IWindowState newWindowState)
        {
            IWindowState previousState = windowState;
            windowState = newWindowState;

            Debug.WriteLine("Window after switch: " + windowState);
            return previousState;
        }

        public GameStateManager(IWindowState initialState)
        {
            windowState = initialState;
            Debug.WriteLine("Window on startup: " + windowState);
        }
    }
}
