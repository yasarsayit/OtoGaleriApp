using OtoGaleriApp.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoGaleriApp.View
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GirisForm mainForm = new GirisForm();
            GirisPresenter girisPresenter = new GirisPresenter(mainForm);
            Application.Run(mainForm);
        }
    }
}
