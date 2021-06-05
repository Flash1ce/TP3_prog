using System;
using System.Windows.Forms;

namespace travail3
{
    public static class Programme
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        public static void Main ()
        {
            Application.EnableVisualStyles ();
            Application.SetCompatibleTextRenderingDefault (false);
            Application.Run (new FenetrePrincipale ());
        }
    }
}
