using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp14.Models;
using WindowsFormsApp14.Models.RelationShip;

namespace WindowsFormsApp14
{
    public static class Program
    {

        

        [STAThread]
        static void Main()
        {
         
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
