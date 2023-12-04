namespace MediaDownloaderApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDownload = new Button();
            btnBrowse = new Button();
            label1 = new Label();
            progressBar1 = new ProgressBar();
            textBoxUrl = new TextBox();
            textBoxBrowse = new TextBox();
            label2 = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            textBoxFilename = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnDownload
            // 
            btnDownload.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnDownload.Location = new Point(359, 335);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(90, 30);
            btnDownload.TabIndex = 0;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = true;
            // 
            // btnBrowse
            // 
            btnBrowse.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnBrowse.Location = new Point(599, 183);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(53, 23);
            btnBrowse.TabIndex = 1;
            btnBrowse.Text = ". . .";
            btnBrowse.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(313, 32);
            label1.Name = "label1";
            label1.Size = new Size(175, 20);
            label1.TabIndex = 2;
            label1.Text = "Insert Url for Download";
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = Color.FromArgb(255, 192, 128);
            progressBar1.Location = new Point(153, 386);
            progressBar1.Name = "progressBar1";
            progressBar1.RightToLeft = RightToLeft.Yes;
            progressBar1.RightToLeftLayout = true;
            progressBar1.Size = new Size(499, 23);
            progressBar1.TabIndex = 3;
            // 
            // textBoxUrl
            // 
            textBoxUrl.Location = new Point(213, 79);
            textBoxUrl.Name = "textBoxUrl";
            textBoxUrl.Size = new Size(337, 23);
            textBoxUrl.TabIndex = 4;
            // 
            // textBoxBrowse
            // 
            textBoxBrowse.Location = new Point(220, 183);
            textBoxBrowse.Name = "textBoxBrowse";
            textBoxBrowse.ReadOnly = true;
            textBoxBrowse.Size = new Size(337, 23);
            textBoxBrowse.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(313, 136);
            label2.Name = "label2";
            label2.Size = new Size(182, 20);
            label2.TabIndex = 6;
            label2.Text = "Select where to Downlad";
            // 
            // textBoxFilename
            // 
            textBoxFilename.Location = new Point(220, 285);
            textBoxFilename.Name = "textBoxFilename";
            textBoxFilename.Size = new Size(330, 23);
            textBoxFilename.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(338, 243);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 8;
            label3.Text = "Input Name File";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(textBoxFilename);
            Controls.Add(label2);
            Controls.Add(textBoxBrowse);
            Controls.Add(textBoxUrl);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            Controls.Add(btnBrowse);
            Controls.Add(btnDownload);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDownload;
        private Button btnBrowse;
        private Label label1;
        private ProgressBar progressBar1;
        private TextBox textBoxUrl;
        private TextBox textBoxBrowse;
        private Label label2;
        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox textBoxFilename;
        private Label label3;
    }
}