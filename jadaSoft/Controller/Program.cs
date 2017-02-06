using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using jadaSoft;
using System.Windows.Forms;




namespace Controller
{
    static class Program
    {

        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            MainController controller = new MainController();
            controller.start();
        }
    }
}


