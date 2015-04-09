using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semaphore
{
    static partial class LightsController
    {



        static LightsForm form;
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form = new LightsForm();
            new Action(ControlV1).BeginInvoke(null, null);
            Application.Run(form);
        }
    }
}
