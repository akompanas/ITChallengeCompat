namespace FormsClient
{
    partial class MainForm
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
            this.listUsersBtn = new System.Windows.Forms.Button();
            this.userList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listUsersBtn
            // 
            this.listUsersBtn.Location = new System.Drawing.Point(486, 52);
            this.listUsersBtn.Name = "listUsersBtn";
            this.listUsersBtn.Size = new System.Drawing.Size(75, 23);
            this.listUsersBtn.TabIndex = 0;
            this.listUsersBtn.Text = "List";
            this.listUsersBtn.UseVisualStyleBackColor = true;
            this.listUsersBtn.Click += new System.EventHandler(this.listUsersBtn_Click);
            // 
            // userList
            // 
            this.userList.FormattingEnabled = true;
            this.userList.Location = new System.Drawing.Point(31, 31);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(390, 95);
            this.userList.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 324);
            this.Controls.Add(this.userList);
            this.Controls.Add(this.listUsersBtn);
            this.Name = "MainForm";
            this.Text = "Antas\' App";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button listUsersBtn;
        private System.Windows.Forms.ListBox userList;
    }
}

