using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Write_text_CS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void ApplicationLog()
        {
            //// Create a string with a line of text.
            //string text = "First line" + Environment.NewLine;

            //// Set a variable to the Documents path.
            //string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //string docPath = @"\test.log";
            ////string docPath = Directory.GetCurrentDirectory(@"\test.log");
            ////(Environment.SpecialFolder.MyDocuments)

            //// Write the text to a new file named "WriteFile.txt".
            //File.WriteAllText(Path.Combine(docPath, "WriteFile.txt"), text);

            //// Create a string array with the additional lines of text
            //string[] lines = { "New line 1", "New line 2" };

            //// Append new lines of text to the file
            //File.AppendAllLines(Path.Combine(docPath, "WriteFile.txt"), lines);

        }

        public void log()
        {
            //Set a variable to the Documents path.
            string docPath = string.Format($@"{Application.StartupPath}\log.log");
            StreamWriter write = File.AppendText(docPath);
            write.WriteLine($"{DateTime.Now}" + " " + "Sample log entry");
            write.Close();
        }

        public void log2()
        {
            const string fileName = @".\DateFile.txt";
            StreamWriter outFile = new StreamWriter(fileName);
            // Save DateTime value.
            DateTime dateToSave = DateTime.SpecifyKind(new DateTime(2008, 6, 12, 18, 45, 15),
            DateTimeKind.Local);
            string dateString = dateToSave.ToString("o");
            Console.WriteLine("Converted {0} ({1}) to {2}.",
            dateToSave.ToString(),
            dateToSave.Kind.ToString(),
            dateString);
            outFile.WriteLine(dateString);
            Console.WriteLine("Wrote {0} to {1}.", dateString, fileName);
            outFile.Close();
            // Restore DateTime value.
            DateTime restoredDate;
            StreamReader inFile = new StreamReader(fileName);
            dateString = inFile.ReadLine();
            inFile.Close();
            restoredDate = DateTime.Parse(dateString, null, DateTimeStyles.RoundtripKind);
            Console.WriteLine("Read {0} ({2}) from {1}.", restoredDate.ToString(),
            fileName,
            restoredDate.Kind.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ApplicationLog();
            log();
            //log2();
        }
    }
}
