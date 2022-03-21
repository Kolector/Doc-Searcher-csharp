
namespace DocxWordSearcher
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DocxFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonDirectoryPicker = new System.Windows.Forms.Button();
            this.textBox_searchCriteria = new System.Windows.Forms.TextBox();
            this.labelTextSearch = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.listBoxFolder = new System.Windows.Forms.ListBox();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDirectoryPicker
            // 
            this.buttonDirectoryPicker.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDirectoryPicker.Location = new System.Drawing.Point(254, 58);
            this.buttonDirectoryPicker.Name = "buttonDirectoryPicker";
            this.buttonDirectoryPicker.Size = new System.Drawing.Size(131, 28);
            this.buttonDirectoryPicker.TabIndex = 0;
            this.buttonDirectoryPicker.Text = "Выбрать папку";
            this.buttonDirectoryPicker.UseVisualStyleBackColor = true;
            this.buttonDirectoryPicker.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_searchCriteria
            // 
            this.textBox_searchCriteria.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_searchCriteria.Location = new System.Drawing.Point(4, 414);
            this.textBox_searchCriteria.Name = "textBox_searchCriteria";
            this.textBox_searchCriteria.Size = new System.Drawing.Size(381, 27);
            this.textBox_searchCriteria.TabIndex = 1;
            // 
            // labelTextSearch
            // 
            this.labelTextSearch.AutoSize = true;
            this.labelTextSearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextSearch.Location = new System.Drawing.Point(0, 392);
            this.labelTextSearch.Name = "labelTextSearch";
            this.labelTextSearch.Size = new System.Drawing.Size(136, 19);
            this.labelTextSearch.TabIndex = 2;
            this.labelTextSearch.Text = "Текст для поиска";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.BackColor = System.Drawing.SystemColors.Control;
            this.labelOutput.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOutput.Location = new System.Drawing.Point(68, 22);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(247, 18);
            this.labelOutput.TabIndex = 3;
            this.labelOutput.Text = "Выберите папку с файлами Docx";
            this.labelOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.Location = new System.Drawing.Point(4, 447);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(381, 52);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPath.Location = new System.Drawing.Point(4, 59);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.ReadOnly = true;
            this.textBoxPath.Size = new System.Drawing.Size(244, 27);
            this.textBoxPath.TabIndex = 6;
            // 
            // listBoxFolder
            // 
            this.listBoxFolder.FormattingEnabled = true;
            this.listBoxFolder.Location = new System.Drawing.Point(4, 125);
            this.listBoxFolder.Name = "listBoxFolder";
            this.listBoxFolder.Size = new System.Drawing.Size(192, 264);
            this.listBoxFolder.TabIndex = 7;
            this.listBoxFolder.DoubleClick += new System.EventHandler(this.listBoxFolder_DoubleClick);
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.Location = new System.Drawing.Point(202, 125);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(183, 264);
            this.listBoxFiles.TabIndex = 8;
            this.listBoxFiles.DoubleClick += new System.EventHandler(this.listBoxFiles_DoubleClick);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(4, 92);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(89, 27);
            this.buttonBack.TabIndex = 9;
            this.buttonBack.Text = "<--";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(388, 503);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.listBoxFiles);
            this.Controls.Add(this.listBoxFolder);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.labelTextSearch);
            this.Controls.Add(this.textBox_searchCriteria);
            this.Controls.Add(this.buttonDirectoryPicker);
            this.Name = "FormMain";
            this.Text = "Поисковик слов в файлах Docx";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog DocxFolderBrowser;
        private System.Windows.Forms.Button buttonDirectoryPicker;
        private System.Windows.Forms.TextBox textBox_searchCriteria;
        private System.Windows.Forms.Label labelTextSearch;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.ListBox listBoxFolder;
        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.Button buttonBack;
    }
}

