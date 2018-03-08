using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniproject
{
    static class Program
    {
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Basic_Operations form1 = new Basic_Operations();
            Expenditure_Analysis form2 = new Expenditure_Analysis();
            Modify_Record form3 = new Modify_Record();
            form1.Show();
            form2.Show();
            form3.Show();
            Application.Run();
        }
    }
}
