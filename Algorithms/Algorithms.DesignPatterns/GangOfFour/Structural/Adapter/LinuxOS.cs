using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DesignPatterns.GangOfFour.Structural.Adapter
{
    public class LinuxOS
    {
        public void StartTerminal()
        {
            Console.WriteLine("Linux is starting the Terminal ...Done");
        }
        
        public void StartGraphicEnvironment ()
        {
            Console.WriteLine("Linux is starting the Graphic Environment ...Done");
        }

        public void ShutdownTerminal ()
        {
            Console.WriteLine("Linux is shutting down the Terminal ...Done");
        }

        public void ShutDownGraphicEnvironment ()
        {
            Console.WriteLine("Linux is shutting down the Graphic Environment");
        }
    }
}
