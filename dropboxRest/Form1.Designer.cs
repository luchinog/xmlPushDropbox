namespace dropboxRest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnPushDropBox = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPaste = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txtShareURL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnPushDropBox
            // 
            this.btnPushDropBox.Location = new System.Drawing.Point(182, 199);
            this.btnPushDropBox.Name = "btnPushDropBox";
            this.btnPushDropBox.Size = new System.Drawing.Size(165, 60);
            this.btnPushDropBox.TabIndex = 4;
            this.btnPushDropBox.Text = "OK";
            this.btnPushDropBox.UseVisualStyleBackColor = true;
            this.btnPushDropBox.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "URL";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(39, 23);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(308, 20);
            this.txtTitle.TabIndex = 7;
            this.txtTitle.Text = "Movie";
            this.txtTitle.Click += new System.EventHandler(this.txtTitle_Click);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(39, 63);
            this.txtURL.Multiline = true;
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(308, 114);
            this.txtURL.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 9;
            // 
            // btnPaste
            // 
            this.btnPaste.Location = new System.Drawing.Point(39, 199);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(137, 60);
            this.btnPaste.TabIndex = 10;
            this.btnPaste.Text = "PASTE";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(599, 199);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(165, 60);
            this.button5.TabIndex = 11;
            this.button5.Text = "GetShareLink";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtShareURL
            // 
            this.txtShareURL.Location = new System.Drawing.Point(397, 63);
            this.txtShareURL.Multiline = true;
            this.txtShareURL.Name = "txtShareURL";
            this.txtShareURL.Size = new System.Drawing.Size(367, 114);
            this.txtShareURL.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "GetShareURL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 270);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtShareURL);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnPaste);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPushDropBox);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "DropboxShareURL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnPushDropBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtShareURL;
        private System.Windows.Forms.Label label4;
    }
}

