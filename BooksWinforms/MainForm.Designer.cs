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
            this.SerializeBooksXML = new System.Windows.Forms.Button();
            this.SavePeriodicalsTxt = new System.Windows.Forms.Button();
            this.AddNewItemButton = new System.Windows.Forms.Button();
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
            // SerializeBooksXML
            // 
            this.SerializeBooksXML.Location = new System.Drawing.Point(173, 8);
            this.SerializeBooksXML.Name = "SerializeBooksXML";
            this.SerializeBooksXML.Size = new System.Drawing.Size(118, 23);
            this.SerializeBooksXML.TabIndex = 2;
            this.SerializeBooksXML.Text = "SerializeBooksXml";
            this.SerializeBooksXML.UseVisualStyleBackColor = true;
            this.SerializeBooksXML.Click += new System.EventHandler(this.SerializeBooksXML_Click);
            // 
            // SavePeriodicalsTxt
            // 
            this.SavePeriodicalsTxt.Location = new System.Drawing.Point(173, 38);
            this.SavePeriodicalsTxt.Name = "SavePeriodicalsTxt";
            this.SavePeriodicalsTxt.Size = new System.Drawing.Size(118, 23);
            this.SavePeriodicalsTxt.TabIndex = 3;
            this.SavePeriodicalsTxt.Text = "SavePeriodicalsTxt";
            this.SavePeriodicalsTxt.UseVisualStyleBackColor = true;
            this.SavePeriodicalsTxt.Click += new System.EventHandler(this.SavePeriodicalsTxt_Click);
            // 
            // AddNewItemButton
            // 
            this.AddNewItemButton.Location = new System.Drawing.Point(486, 8);
            this.AddNewItemButton.Name = "AddNewItemButton";
            this.AddNewItemButton.Size = new System.Drawing.Size(120, 23);
            this.AddNewItemButton.TabIndex = 4;
            this.AddNewItemButton.Text = "Add New Item...";
            this.AddNewItemButton.UseVisualStyleBackColor = true;
            this.AddNewItemButton.Click += new System.EventHandler(this.AddNewItemButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 487);
            this.Controls.Add(this.AddNewItemButton);
            this.Controls.Add(this.SavePeriodicalsTxt);
            this.Controls.Add(this.SerializeBooksXML);
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
        private System.Windows.Forms.Button SerializeBooksXML;
        private System.Windows.Forms.Button SavePeriodicalsTxt;
        private System.Windows.Forms.Button AddNewItemButton;
    }
}

