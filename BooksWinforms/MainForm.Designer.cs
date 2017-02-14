namespace BooksWinforms
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
            this.mediaCheckdListBox = new System.Windows.Forms.CheckedListBox();
            this.mediaListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // mediaCheckdListBox
            // 
            this.mediaCheckdListBox.CheckOnClick = true;
            this.mediaCheckdListBox.FormattingEnabled = true;
            this.mediaCheckdListBox.Location = new System.Drawing.Point(10, 10);
            this.mediaCheckdListBox.Margin = new System.Windows.Forms.Padding(10);
            this.mediaCheckdListBox.Name = "mediaCheckdListBox";
            this.mediaCheckdListBox.Size = new System.Drawing.Size(150, 79);
            this.mediaCheckdListBox.TabIndex = 0;
            this.mediaCheckdListBox.SelectedIndexChanged += new System.EventHandler(this.mediaCheckdListBox_SelectedIndexChanged);
            this.mediaCheckdListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.mediaCheckdListBox_MouseDoubleClick);
            // 
            // mediaListView
            // 
            this.mediaListView.AllowColumnReorder = true;
            this.mediaListView.FullRowSelect = true;
            this.mediaListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.mediaListView.Location = new System.Drawing.Point(5, 134);
            this.mediaListView.Margin = new System.Windows.Forms.Padding(5);
            this.mediaListView.Name = "mediaListView";
            this.mediaListView.Size = new System.Drawing.Size(604, 348);
            this.mediaListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.mediaListView.TabIndex = 1;
            this.mediaListView.UseCompatibleStateImageBehavior = false;
            this.mediaListView.View = System.Windows.Forms.View.Details;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 487);
            this.Controls.Add(this.mediaListView);
            this.Controls.Add(this.mediaCheckdListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Media Collection";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox mediaCheckdListBox;
        private System.Windows.Forms.ListView mediaListView;
    }
}

