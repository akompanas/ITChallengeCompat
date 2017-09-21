namespace DesktopClient
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
            this.listBtn = new System.Windows.Forms.Button();
            this.userListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBtn
            // 
            this.listBtn.Location = new System.Drawing.Point(379, 39);
            this.listBtn.Name = "listBtn";
            this.listBtn.Size = new System.Drawing.Size(75, 23);
            this.listBtn.TabIndex = 0;
            this.listBtn.Text = "List All";
            this.listBtn.UseVisualStyleBackColor = true;
            this.listBtn.Click += new System.EventHandler(this.listBtn_Click);
            // 
            // userListBox
            // 
            this.userListBox.FormattingEnabled = true;
            this.userListBox.Location = new System.Drawing.Point(22, 25);
            this.userListBox.Name = "userListBox";
            this.userListBox.Size = new System.Drawing.Size(296, 121);
            this.userListBox.TabIndex = 1;
            this.userListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.userListBox_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 286);
            this.Controls.Add(this.userListBox);
            this.Controls.Add(this.listBtn);
            this.Name = "Form1";
            this.Text = "Anto Tūlzas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button listBtn;
        private System.Windows.Forms.ListBox userListBox;
    }
}

