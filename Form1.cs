using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using DocxSearcher;

namespace DocxWordSearcher
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox_searchCriteria.Text != "")
            {
                if (DocxFolderBrowser.ShowDialog() == DialogResult.OK)
                {
                    string Path = DocxFolderBrowser.SelectedPath;

                    File.SetAttributes(Path, FileAttributes.Normal);
                    //TODO: разобраться как List записывать в файлы txt

                    string WholeThing = "";

                    Console.WriteLine("_______________________________________");
                    List<string> FoundInFiles = DocxSearch.FindKeywordInDir(textBox_searchCriteria.Text, Path, true);
                    FoundInFiles.ForEach(p => Console.WriteLine(p + " " + "!!!"));
                    Console.WriteLine("_______________________________________");


                    foreach (string matchingFiles in DocxSearch.FindKeywordInDir(textBox_searchCriteria.Text, Path, true))
                    {
                        WholeThing += matchingFiles;
                        WholeThing += "\n";
                    }

                    string ResultInTxtPath = Path + "//Результат поиска.txt";

                    File.WriteAllText(ResultInTxtPath, WholeThing);
                }
            }
            else
                MessageBox.Show("Введите текст для поиска.");
        }
    }
}
