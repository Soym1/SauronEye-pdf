
namespace SauronEYE
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textPath = new System.Windows.Forms.TextBox();
            this.textFW = new System.Windows.Forms.TextBox();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.FileFound = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.TimeBox = new System.Windows.Forms.TextBox();
            this.FileBox = new System.Windows.Forms.TextBox();
            this.TotalBox = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.Label();
            this.OpenBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(42, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Keywords  :";
            // 
            // textPath
            // 
            this.textPath.Location = new System.Drawing.Point(91, 23);
            this.textPath.Name = "textPath";
            this.textPath.Size = new System.Drawing.Size(394, 20);
            this.textPath.TabIndex = 2;
            // 
            // textFW
            // 
            this.textFW.Location = new System.Drawing.Point(91, 67);
            this.textFW.Name = "textFW";
            this.textFW.Size = new System.Drawing.Size(394, 20);
            this.textFW.TabIndex = 3;
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.Location = new System.Drawing.Point(506, 23);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(75, 23);
            this.BtnBrowse.TabIndex = 4;
            this.BtnBrowse.Text = "Browse";
            this.BtnBrowse.UseVisualStyleBackColor = true;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(506, 66);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // listView
            // 
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(38, 152);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(447, 250);
            this.listView.TabIndex = 6;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseDoubleClick);
            // 
            // FileFound
            // 
            this.FileFound.AutoSize = true;
            this.FileFound.Location = new System.Drawing.Point(35, 405);
            this.FileFound.Name = "FileFound";
            this.FileFound.Size = new System.Drawing.Size(67, 13);
            this.FileFound.TabIndex = 7;
            this.FileFound.Text = "Files Match :";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(355, 405);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(33, 13);
            this.Time.TabIndex = 8;
            this.Time.Text = "Time:";
            // 
            // TimeBox
            // 
            this.TimeBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TimeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TimeBox.Location = new System.Drawing.Point(394, 406);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(90, 13);
            this.TimeBox.TabIndex = 9;
            // 
            // FileBox
            // 
            this.FileBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.FileBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FileBox.Location = new System.Drawing.Point(105, 404);
            this.FileBox.Name = "FileBox";
            this.FileBox.Size = new System.Drawing.Size(90, 13);
            this.FileBox.TabIndex = 10;
            // 
            // TotalBox
            // 
            this.TotalBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TotalBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TotalBox.Location = new System.Drawing.Point(259, 406);
            this.TotalBox.Name = "TotalBox";
            this.TotalBox.Size = new System.Drawing.Size(90, 13);
            this.TotalBox.TabIndex = 12;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(189, 407);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(58, 13);
            this.Total.TabIndex = 11;
            this.Total.Text = "Total files :";
            // 
            // OpenBtn
            // 
            this.OpenBtn.Location = new System.Drawing.Point(506, 152);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(75, 23);
            this.OpenBtn.TabIndex = 13;
            this.OpenBtn.Text = "Open";
            this.OpenBtn.UseVisualStyleBackColor = true;
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(506, 197);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 14;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 450);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.OpenBtn);
            this.Controls.Add(this.TotalBox);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.FileBox);
            this.Controls.Add(this.TimeBox);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.FileFound);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.BtnBrowse);
            this.Controls.Add(this.textFW);
            this.Controls.Add(this.textPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SauronEYE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPath;
        private System.Windows.Forms.TextBox textFW;
        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Label FileFound;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.TextBox TimeBox;
        private System.Windows.Forms.TextBox FileBox;
        private System.Windows.Forms.TextBox TotalBox;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Button OpenBtn;
        private System.Windows.Forms.Button ClearBtn;
    }
}

