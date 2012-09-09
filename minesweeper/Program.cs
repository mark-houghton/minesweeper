using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace minesweeper
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        /// This program is minesweeper.
        /// It will generate a typical Advanced/Expert level grid.
        ///     This is 16 rows high by 30 columns wide.
        ///     There will be 99 mines hidden.
        /// It will randomly place mines, and keep them hidden.
        /// Upon click, it will either display the blank space, or the number of neighbor mines, or show that user clicked on a mine & game over.
        /// If mine is clicked on, prompt game over and offer to start again.
        /// If all empty spaces are uncovered, prompt game won, and offer to start again.

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            /// Generate grid layout.
            
        }
    }
}
