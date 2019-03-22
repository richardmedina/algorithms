using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DesignPatterns.GangOfFour.Structural.Adapter
{
    public class LinuxOperativeSystemAdapter : IOperativeSystem
    {
        private readonly LinuxOS linuxOS = new LinuxOS();

        public void ShutDown()
        {
            linuxOS.ShutDownGraphicEnvironment();
            linuxOS.ShutdownTerminal();
        }

        public void TurnOn()
        {
            linuxOS.StartTerminal();
            linuxOS.StartGraphicEnvironment();
        }
    }
}
