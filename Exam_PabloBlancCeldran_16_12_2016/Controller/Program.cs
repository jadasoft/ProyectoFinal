using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Controller
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            MainController controller = new MainController();

            controller.start();
        }
    }
}
