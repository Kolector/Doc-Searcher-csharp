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
using DocumentFormat.OpenXml.Packaging;

namespace DocxWordSearcher
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FindWordInFile()
        {

        }

        private void FindWords()
        {
            if (textBox_searchCriteria.Text != "")
            {
                
                string Path = textBoxPath.Text;

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

                string ResultInTxtPath = Path + "\\Результат поиска.txt";

                File.WriteAllText(ResultInTxtPath, WholeThing);

            }
            else
                MessageBox.Show("Введите текст для поиска.");
        }

        private void FolderBrowser(string path)
        {
            DirectoryInfo ThisDirectory = new DirectoryInfo(path);

            listBoxFolder.Items.Clear();
            listBoxFiles.Items.Clear();

            //string[] AllDirectories = Directory.GetDirectories(path);
            // int AmmountOfDirectories = 0; //AllDirectories.Length;

            foreach(DirectoryInfo Directory in ThisDirectory.GetDirectories())
            {
                listBoxFolder.Items.Add(Directory.Name);
            }
            foreach(FileInfo File in ThisDirectory.GetFiles())
            {
                listBoxFiles.Items.Add(File.Name);
            }

            textBoxPath.Text = ThisDirectory.FullName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DocxFolderBrowser.ShowDialog() == DialogResult.OK)
            {
                string Path = DocxFolderBrowser.SelectedPath;

                textBoxPath.Text = Path;

                FolderBrowser(Path);
            }
        }
        private void listBoxFolder_DoubleClick(object sender, EventArgs e)
        {
            DirectoryInfo DirectoryChosen = new DirectoryInfo(textBoxPath.Text + "\\" + listBoxFolder.SelectedItem.ToString());
            FolderBrowser(DirectoryChosen.FullName);
        }

        private void buttonSearch_click(object sender, EventArgs e)
        {
            FindWords();
        }

        private void listBoxFiles_DoubleClick(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(textBoxPath.Text + "\\" + listBoxFiles.SelectedItem.ToString());

            if (file.Exists)
                if (DocxSearch.FindKeyword(textBox_searchCriteria.Text, file.FullName))
                    if (MessageBox.Show("Искомое слово найдено. Открыть файл?", "Результат поиска", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        //file.Open(FileMode.Open);
                        WordprocessingDocument.Open(file.FullName, true);
                        string path = file.FullName.ToString();
                    }
                        
                    else
                        MessageBox.Show("Слово не найдено.", "Результат поиска", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else
                    MessageBox.Show("Файл несуществует, зафиксируйте ошибку в каком-либо документе для разработчика.", "Ошибка обращения к файлу", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void buttonBack_Click(object sender, EventArgs e)
        {

        }
    }
}
