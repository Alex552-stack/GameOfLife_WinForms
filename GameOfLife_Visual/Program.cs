using GameOfLife_Visual.VisualComponents;
using System;
using System.Windows.Forms;

namespace GameOfLife_Visual
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form1 = new Form1();
            if (form1.ShowDialog() == DialogResult.OK)
            {
                int rowNumber = form1.RowNumber;
                int lineNumber = form1.LinesNumber;
                Application.Run(new Game(rowNumber,lineNumber));
            }
        }
    }
}
