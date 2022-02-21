
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonDirectoryPicker
            // 
            this.buttonDirectoryPicker.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDirectoryPicker.Location = new System.Drawing.Point(4, 334);
            this.buttonDirectoryPicker.Name = "buttonDirectoryPicker";
            this.buttonDirectoryPicker.Size = new System.Drawing.Size(329, 31);
            this.buttonDirectoryPicker.TabIndex = 0;
            this.buttonDirectoryPicker.Text = "Выбрать папку с файлами для поиска";
            this.buttonDirectoryPicker.UseVisualStyleBackColor = true;
            this.buttonDirectoryPicker.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_searchCriteria
            // 
            this.textBox_searchCriteria.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_searchCriteria.Location = new System.Drawing.Point(4, 301);
            this.textBox_searchCriteria.Name = "textBox_searchCriteria";
            this.textBox_searchCriteria.Size = new System.Drawing.Size(329, 27);
            this.textBox_searchCriteria.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Текст для поиска";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.BackColor = System.Drawing.SystemColors.Control;
            this.labelOutput.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOutput.Location = new System.Drawing.Point(49, 109);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(247, 18);
            this.labelOutput.TabIndex = 3;
            this.labelOutput.Text = "Выберите папку с файлами Docx";
            this.labelOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(338, 377);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelOutput;
    }
}

