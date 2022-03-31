namespace AstronomicalProcessing
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
            this.btnGetInteractions = new System.Windows.Forms.Button();
            this.ListBoxInteractions = new System.Windows.Forms.ListBox();
            this.btnSortInteractions = new System.Windows.Forms.Button();
            this.ListBoxSort = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ListBoxResults = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnGetInteractions
            // 
            this.btnGetInteractions.Location = new System.Drawing.Point(22, 12);
            this.btnGetInteractions.Name = "btnGetInteractions";
            this.btnGetInteractions.Size = new System.Drawing.Size(136, 63);
            this.btnGetInteractions.TabIndex = 0;
            this.btnGetInteractions.Text = "Neutrino Interactions/hour";
            this.btnGetInteractions.UseVisualStyleBackColor = true;
            this.btnGetInteractions.Click += new System.EventHandler(this.btnGetInteractions_Click);
            // 
            // ListBoxInteractions
            // 
            this.ListBoxInteractions.FormattingEnabled = true;
            this.ListBoxInteractions.ItemHeight = 16;
            this.ListBoxInteractions.Location = new System.Drawing.Point(34, 81);
            this.ListBoxInteractions.Name = "ListBoxInteractions";
            this.ListBoxInteractions.Size = new System.Drawing.Size(114, 420);
            this.ListBoxInteractions.TabIndex = 1;
            // 
            // btnSortInteractions
            // 
            this.btnSortInteractions.Location = new System.Drawing.Point(215, 15);
            this.btnSortInteractions.Name = "btnSortInteractions";
            this.btnSortInteractions.Size = new System.Drawing.Size(115, 60);
            this.btnSortInteractions.TabIndex = 2;
            this.btnSortInteractions.Text = "Sort Neutrino Interactions";
            this.btnSortInteractions.UseVisualStyleBackColor = true;
            this.btnSortInteractions.Click += new System.EventHandler(this.btnSortInteractions_Click);
            // 
            // ListBoxSort
            // 
            this.ListBoxSort.FormattingEnabled = true;
            this.ListBoxSort.ItemHeight = 16;
            this.ListBoxSort.Location = new System.Drawing.Point(215, 82);
            this.ListBoxSort.Name = "ListBoxSort";
            this.ListBoxSort.Size = new System.Drawing.Size(115, 420);
            this.ListBoxSort.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(730, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 33);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Location = new System.Drawing.Point(583, 37);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(71, 22);
            this.TextBoxSearch.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(501, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search";
            // 
            // ListBoxResults
            // 
            this.ListBoxResults.FormattingEnabled = true;
            this.ListBoxResults.ItemHeight = 16;
            this.ListBoxResults.Location = new System.Drawing.Point(455, 103);
            this.ListBoxResults.Name = "ListBoxResults";
            this.ListBoxResults.Size = new System.Drawing.Size(307, 68);
            this.ListBoxResults.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 511);
            this.Controls.Add(this.ListBoxResults);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.ListBoxSort);
            this.Controls.Add(this.btnSortInteractions);
            this.Controls.Add(this.ListBoxInteractions);
            this.Controls.Add(this.btnGetInteractions);
            this.Name = "Form1";
            this.Text = "Astronomical Processing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetInteractions;
        private System.Windows.Forms.ListBox ListBoxInteractions;
        private System.Windows.Forms.Button btnSortInteractions;
        private System.Windows.Forms.ListBox ListBoxSort;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ListBoxResults;
    }
}

