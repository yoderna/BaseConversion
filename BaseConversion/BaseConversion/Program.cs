//////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//      Project:    Base Conversion
//
//    File Name:    Program.cs
//
//       Author:    Nicholas Yoder
//
//  Description:    Contains the main entry point for the application, which opens ConvertForm.
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Windows.Forms;

namespace BaseConversion
{
    /// <summary>
    /// This class contains the program entry point
    /// </summary>
    static class Program
    {
        /// <summary>
        /// The entry point for the application; opens ConvertForm
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ConvertForm());
        }
    }
}
