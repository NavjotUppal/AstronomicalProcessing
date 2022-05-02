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
            this.components = new System.ComponentModel.Container();
            this.btnGetInteractions = new System.Windows.Forms.Button();
            this.ListBoxInteractions = new System.Windows.Forms.ListBox();
            this.btnSortInteractions = new System.Windows.Forms.Button();
            this.ListBoxSort = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.ListBoxResults = new System.Windows.Forms.ListBox();
            this.GrpBoxEdit = new System.Windows.Forms.GroupBox();
            this.LblNewValue = new System.Windows.Forms.Label();
            this.TextBoxTime = new System.Windows.Forms.TextBox();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.LblTime = new System.Windows.Forms.Label();
            this.TextBoxNewValue = new System.Windows.Forms.TextBox();
            this.ButtonClearAll = new System.Windows.Forms.Button();
            this.GrpBoxSearch = new System.Windows.Forms.GroupBox();
            this.ButtonSequentialSearch = new System.Windows.Forms.Button();
            this.GrpBoxDataAnalysis = new System.Windows.Forms.GroupBox();
            this.TextBoxRange = new System.Windows.Forms.TextBox();
            this.ButtonMidExtreme = new System.Windows.Forms.Button();
            this.ButtonMode = new System.Windows.Forms.Button();
            this.TextBoxAverage = new System.Windows.Forms.TextBox();
            this.ButtonAverage = new System.Windows.Forms.Button();
            this.ButtonRange = new System.Windows.Forms.Button();
            this.TextBoxMode = new System.Windows.Forms.TextBox();
            this.TextBoxMidExtreme = new System.Windows.Forms.TextBox();
            this.toolTip_btngetInteractions = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_ListBoxInteractions = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_btnSortInteractions = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_ListBoxSortInteractions = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_btnBinarySearch = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_txtBoxSearch = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_ListBoxSearch = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_btnSequentialSearch = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_TextBoxTime = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_TextBoxNewValue = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_TextBoxMidExtreme = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_ButtonMidExtreme = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_ButtonEdit = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_ButtonMode = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_TextBoxMode = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_ButtonRange = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_TextBoxRange = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_ButtonClearAll = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_ButtonAverage = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_TextBoxAverage = new System.Windows.Forms.ToolTip(this.components);
            this.GrpBoxSeqSearch = new System.Windows.Forms.GroupBox();
            this.ListBoxSearchResults = new System.Windows.Forms.ListBox();
            this.TextBox_SeqSearch = new System.Windows.Forms.TextBox();
            this.toolTip_TextBoxSeqSearch = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_ListBoxSearchResults = new System.Windows.Forms.ToolTip(this.components);
            this.GrpBoxEdit.SuspendLayout();
            this.GrpBoxSearch.SuspendLayout();
            this.GrpBoxDataAnalysis.SuspendLayout();
            this.GrpBoxSeqSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetInteractions
            // 
            this.btnGetInteractions.Location = new System.Drawing.Point(15, 14);
            this.btnGetInteractions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGetInteractions.Name = "btnGetInteractions";
            this.btnGetInteractions.Size = new System.Drawing.Size(136, 63);
            this.btnGetInteractions.TabIndex = 0;
            this.btnGetInteractions.Text = "Neutrino Interactions/hour";
            this.btnGetInteractions.UseVisualStyleBackColor = true;
            this.btnGetInteractions.Click += new System.EventHandler(this.btnGetInteractions_Click);
            this.btnGetInteractions.MouseHover += new System.EventHandler(this.btnGetInteraction_MouseHover);
            // 
            // ListBoxInteractions
            // 
            this.ListBoxInteractions.FormattingEnabled = true;
            this.ListBoxInteractions.ItemHeight = 16;
            this.ListBoxInteractions.Location = new System.Drawing.Point(16, 93);
            this.ListBoxInteractions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListBoxInteractions.Name = "ListBoxInteractions";
            this.ListBoxInteractions.Size = new System.Drawing.Size(135, 404);
            this.ListBoxInteractions.TabIndex = 1;
            this.ListBoxInteractions.MouseHover += new System.EventHandler(this.ListBoxInteractions_MouseHover);
            // 
            // btnSortInteractions
            // 
            this.btnSortInteractions.Location = new System.Drawing.Point(168, 14);
            this.btnSortInteractions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSortInteractions.Name = "btnSortInteractions";
            this.btnSortInteractions.Size = new System.Drawing.Size(136, 63);
            this.btnSortInteractions.TabIndex = 2;
            this.btnSortInteractions.Text = "Sort Neutrino Interactions";
            this.btnSortInteractions.UseVisualStyleBackColor = true;
            this.btnSortInteractions.Click += new System.EventHandler(this.btnSortInteractions_Click);
            this.btnSortInteractions.MouseHover += new System.EventHandler(this.btnSortInteractions_MouseHover);
            // 
            // ListBoxSort
            // 
            this.ListBoxSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxSort.FormattingEnabled = true;
            this.ListBoxSort.ItemHeight = 17;
            this.ListBoxSort.Location = new System.Drawing.Point(168, 93);
            this.ListBoxSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListBoxSort.MultiColumn = true;
            this.ListBoxSort.Name = "ListBoxSort";
            this.ListBoxSort.Size = new System.Drawing.Size(135, 395);
            this.ListBoxSort.TabIndex = 3;
            this.ListBoxSort.MouseHover += new System.EventHandler(this.ListBoxSortInteractions_MouseHover);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(148, 38);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(136, 25);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.MouseHover += new System.EventHandler(this.btnSerach_MouseHover);
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Location = new System.Drawing.Point(7, 38);
            this.TextBoxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(135, 22);
            this.TextBoxSearch.TabIndex = 5;
            this.TextBoxSearch.MouseHover += new System.EventHandler(this.TextBoxSearch_MouseHover);
            // 
            // ListBoxResults
            // 
            this.ListBoxResults.FormattingEnabled = true;
            this.ListBoxResults.ItemHeight = 16;
            this.ListBoxResults.Location = new System.Drawing.Point(7, 68);
            this.ListBoxResults.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListBoxResults.Name = "ListBoxResults";
            this.ListBoxResults.Size = new System.Drawing.Size(135, 116);
            this.ListBoxResults.TabIndex = 7;
            this.ListBoxResults.MouseHover += new System.EventHandler(this.ListBoxResults_MouseHover);
            // 
            // GrpBoxEdit
            // 
            this.GrpBoxEdit.Controls.Add(this.LblNewValue);
            this.GrpBoxEdit.Controls.Add(this.TextBoxTime);
            this.GrpBoxEdit.Controls.Add(this.ButtonEdit);
            this.GrpBoxEdit.Controls.Add(this.LblTime);
            this.GrpBoxEdit.Controls.Add(this.TextBoxNewValue);
            this.GrpBoxEdit.Location = new System.Drawing.Point(328, 287);
            this.GrpBoxEdit.Margin = new System.Windows.Forms.Padding(4);
            this.GrpBoxEdit.Name = "GrpBoxEdit";
            this.GrpBoxEdit.Padding = new System.Windows.Forms.Padding(4);
            this.GrpBoxEdit.Size = new System.Drawing.Size(316, 132);
            this.GrpBoxEdit.TabIndex = 8;
            this.GrpBoxEdit.TabStop = false;
            this.GrpBoxEdit.Text = "Edit";
            // 
            // LblNewValue
            // 
            this.LblNewValue.AutoSize = true;
            this.LblNewValue.Location = new System.Drawing.Point(16, 59);
            this.LblNewValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNewValue.Name = "LblNewValue";
            this.LblNewValue.Size = new System.Drawing.Size(75, 16);
            this.LblNewValue.TabIndex = 6;
            this.LblNewValue.Text = "New Value:";
            // 
            // TextBoxTime
            // 
            this.TextBoxTime.Location = new System.Drawing.Point(107, 18);
            this.TextBoxTime.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxTime.Name = "TextBoxTime";
            this.TextBoxTime.Size = new System.Drawing.Size(135, 22);
            this.TextBoxTime.TabIndex = 0;
            this.TextBoxTime.TextChanged += new System.EventHandler(this.TextBoxTime_TextChanged);
            this.TextBoxTime.MouseHover += new System.EventHandler(this.TextBoxTime_MouseHover);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Location = new System.Drawing.Point(107, 82);
            this.ButtonEdit.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(136, 25);
            this.ButtonEdit.TabIndex = 4;
            this.ButtonEdit.Text = "Edit";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            this.ButtonEdit.MouseHover += new System.EventHandler(this.ButtonEdit_MouseHover);
            // 
            // LblTime
            // 
            this.LblTime.AutoSize = true;
            this.LblTime.Location = new System.Drawing.Point(55, 27);
            this.LblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(41, 16);
            this.LblTime.TabIndex = 5;
            this.LblTime.Text = "Time:";
            // 
            // TextBoxNewValue
            // 
            this.TextBoxNewValue.Location = new System.Drawing.Point(107, 50);
            this.TextBoxNewValue.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxNewValue.Name = "TextBoxNewValue";
            this.TextBoxNewValue.Size = new System.Drawing.Size(135, 22);
            this.TextBoxNewValue.TabIndex = 3;
            this.TextBoxNewValue.MouseHover += new System.EventHandler(this.TextBoxNewValue_MouseHover);
            // 
            // ButtonClearAll
            // 
            this.ButtonClearAll.Cursor = System.Windows.Forms.Cursors.No;
            this.ButtonClearAll.Location = new System.Drawing.Point(501, 652);
            this.ButtonClearAll.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonClearAll.Name = "ButtonClearAll";
            this.ButtonClearAll.Size = new System.Drawing.Size(136, 25);
            this.ButtonClearAll.TabIndex = 9;
            this.ButtonClearAll.Text = "Clear All";
            this.ButtonClearAll.UseVisualStyleBackColor = true;
            this.ButtonClearAll.Click += new System.EventHandler(this.ButtonClearAll_Click);
            this.ButtonClearAll.MouseHover += new System.EventHandler(this.ButtonClearAll_MouseHover);
            // 
            // GrpBoxSearch
            // 
            this.GrpBoxSearch.Controls.Add(this.ListBoxResults);
            this.GrpBoxSearch.Controls.Add(this.TextBoxSearch);
            this.GrpBoxSearch.Controls.Add(this.btnSearch);
            this.GrpBoxSearch.Location = new System.Drawing.Point(321, 14);
            this.GrpBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.GrpBoxSearch.Name = "GrpBoxSearch";
            this.GrpBoxSearch.Padding = new System.Windows.Forms.Padding(4);
            this.GrpBoxSearch.Size = new System.Drawing.Size(316, 234);
            this.GrpBoxSearch.TabIndex = 10;
            this.GrpBoxSearch.TabStop = false;
            this.GrpBoxSearch.Text = "Binary Search";
            // 
            // ButtonSequentialSearch
            // 
            this.ButtonSequentialSearch.Location = new System.Drawing.Point(136, 31);
            this.ButtonSequentialSearch.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonSequentialSearch.Name = "ButtonSequentialSearch";
            this.ButtonSequentialSearch.Size = new System.Drawing.Size(112, 27);
            this.ButtonSequentialSearch.TabIndex = 9;
            this.ButtonSequentialSearch.Text = "Search";
            this.ButtonSequentialSearch.UseVisualStyleBackColor = true;
            this.ButtonSequentialSearch.Click += new System.EventHandler(this.ButtonSequentialSearch_Click);
            this.ButtonSequentialSearch.MouseHover += new System.EventHandler(this.btnSequentialSerach_MouseHover);
            // 
            // GrpBoxDataAnalysis
            // 
            this.GrpBoxDataAnalysis.Controls.Add(this.TextBoxRange);
            this.GrpBoxDataAnalysis.Controls.Add(this.ButtonMidExtreme);
            this.GrpBoxDataAnalysis.Controls.Add(this.ButtonMode);
            this.GrpBoxDataAnalysis.Controls.Add(this.TextBoxAverage);
            this.GrpBoxDataAnalysis.Controls.Add(this.ButtonAverage);
            this.GrpBoxDataAnalysis.Controls.Add(this.ButtonRange);
            this.GrpBoxDataAnalysis.Controls.Add(this.TextBoxMode);
            this.GrpBoxDataAnalysis.Controls.Add(this.TextBoxMidExtreme);
            this.GrpBoxDataAnalysis.Location = new System.Drawing.Point(328, 467);
            this.GrpBoxDataAnalysis.Margin = new System.Windows.Forms.Padding(4);
            this.GrpBoxDataAnalysis.Name = "GrpBoxDataAnalysis";
            this.GrpBoxDataAnalysis.Padding = new System.Windows.Forms.Padding(4);
            this.GrpBoxDataAnalysis.Size = new System.Drawing.Size(316, 167);
            this.GrpBoxDataAnalysis.TabIndex = 11;
            this.GrpBoxDataAnalysis.TabStop = false;
            this.GrpBoxDataAnalysis.Text = "Data Analysis";
            // 
            // TextBoxRange
            // 
            this.TextBoxRange.Location = new System.Drawing.Point(161, 121);
            this.TextBoxRange.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxRange.Name = "TextBoxRange";
            this.TextBoxRange.Size = new System.Drawing.Size(144, 22);
            this.TextBoxRange.TabIndex = 7;
            this.TextBoxRange.MouseHover += new System.EventHandler(this.TextBoxRange_MouseHover);
            // 
            // ButtonMidExtreme
            // 
            this.ButtonMidExtreme.Location = new System.Drawing.Point(8, 23);
            this.ButtonMidExtreme.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonMidExtreme.Name = "ButtonMidExtreme";
            this.ButtonMidExtreme.Size = new System.Drawing.Size(145, 25);
            this.ButtonMidExtreme.TabIndex = 1;
            this.ButtonMidExtreme.Text = "Mid-Extreme";
            this.ButtonMidExtreme.UseVisualStyleBackColor = true;
            this.ButtonMidExtreme.Click += new System.EventHandler(this.ButtonMidExtreme_Click);
            this.ButtonMidExtreme.MouseHover += new System.EventHandler(this.ButtonMidExtreme_MouseHover);
            // 
            // ButtonMode
            // 
            this.ButtonMode.Location = new System.Drawing.Point(8, 55);
            this.ButtonMode.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonMode.Name = "ButtonMode";
            this.ButtonMode.Size = new System.Drawing.Size(145, 25);
            this.ButtonMode.TabIndex = 0;
            this.ButtonMode.Text = "Mode";
            this.ButtonMode.UseVisualStyleBackColor = true;
            this.ButtonMode.Click += new System.EventHandler(this.ButtonMode_Click);
            this.ButtonMode.MouseHover += new System.EventHandler(this.ButtonMode_MouseHover);
            // 
            // TextBoxAverage
            // 
            this.TextBoxAverage.Location = new System.Drawing.Point(161, 89);
            this.TextBoxAverage.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxAverage.Name = "TextBoxAverage";
            this.TextBoxAverage.Size = new System.Drawing.Size(144, 22);
            this.TextBoxAverage.TabIndex = 6;
            this.TextBoxAverage.MouseHover += new System.EventHandler(this.TextBoxAverage_MouseHover);
            // 
            // ButtonAverage
            // 
            this.ButtonAverage.Location = new System.Drawing.Point(8, 87);
            this.ButtonAverage.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonAverage.Name = "ButtonAverage";
            this.ButtonAverage.Size = new System.Drawing.Size(145, 25);
            this.ButtonAverage.TabIndex = 2;
            this.ButtonAverage.Text = "Average";
            this.ButtonAverage.UseVisualStyleBackColor = true;
            this.ButtonAverage.Click += new System.EventHandler(this.ButtonAverage_Click);
            this.ButtonAverage.MouseHover += new System.EventHandler(this.ButtonAverage_MouseHover);
            // 
            // ButtonRange
            // 
            this.ButtonRange.Location = new System.Drawing.Point(8, 119);
            this.ButtonRange.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonRange.Name = "ButtonRange";
            this.ButtonRange.Size = new System.Drawing.Size(145, 25);
            this.ButtonRange.TabIndex = 3;
            this.ButtonRange.Text = "Range";
            this.ButtonRange.UseVisualStyleBackColor = true;
            this.ButtonRange.Click += new System.EventHandler(this.ButtonRange_Click);
            this.ButtonRange.MouseHover += new System.EventHandler(this.ButtonRange_MouseHover);
            // 
            // TextBoxMode
            // 
            this.TextBoxMode.Location = new System.Drawing.Point(161, 57);
            this.TextBoxMode.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxMode.Name = "TextBoxMode";
            this.TextBoxMode.Size = new System.Drawing.Size(144, 22);
            this.TextBoxMode.TabIndex = 5;
            this.TextBoxMode.MouseHover += new System.EventHandler(this.TextBoxMode_MouseHover);
            // 
            // TextBoxMidExtreme
            // 
            this.TextBoxMidExtreme.Location = new System.Drawing.Point(161, 25);
            this.TextBoxMidExtreme.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxMidExtreme.Name = "TextBoxMidExtreme";
            this.TextBoxMidExtreme.Size = new System.Drawing.Size(144, 22);
            this.TextBoxMidExtreme.TabIndex = 4;
            this.TextBoxMidExtreme.MouseHover += new System.EventHandler(this.TextBoxMidExtreme_MouseHover);
            // 
            // toolTip_ButtonClearAll
            // 
            this.toolTip_ButtonClearAll.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.toolTip_ButtonClearAll.ToolTipTitle = "Clear";
            // 
            // GrpBoxSeqSearch
            // 
            this.GrpBoxSeqSearch.Controls.Add(this.ListBoxSearchResults);
            this.GrpBoxSeqSearch.Controls.Add(this.ButtonSequentialSearch);
            this.GrpBoxSeqSearch.Controls.Add(this.TextBox_SeqSearch);
            this.GrpBoxSeqSearch.Location = new System.Drawing.Point(12, 517);
            this.GrpBoxSeqSearch.Name = "GrpBoxSeqSearch";
            this.GrpBoxSeqSearch.Size = new System.Drawing.Size(279, 193);
            this.GrpBoxSeqSearch.TabIndex = 12;
            this.GrpBoxSeqSearch.TabStop = false;
            this.GrpBoxSeqSearch.Text = "Sequential Search";
            // 
            // ListBoxSearchResults
            // 
            this.ListBoxSearchResults.FormattingEnabled = true;
            this.ListBoxSearchResults.ItemHeight = 16;
            this.ListBoxSearchResults.Location = new System.Drawing.Point(6, 71);
            this.ListBoxSearchResults.Name = "ListBoxSearchResults";
            this.ListBoxSearchResults.Size = new System.Drawing.Size(120, 100);
            this.ListBoxSearchResults.TabIndex = 10;
            this.ListBoxSearchResults.MouseHover += new System.EventHandler(this.ListBoxSearchResults_MouseHover);
            // 
            // TextBox_SeqSearch
            // 
            this.TextBox_SeqSearch.Location = new System.Drawing.Point(6, 33);
            this.TextBox_SeqSearch.Name = "TextBox_SeqSearch";
            this.TextBox_SeqSearch.Size = new System.Drawing.Size(114, 22);
            this.TextBox_SeqSearch.TabIndex = 0;
            this.TextBox_SeqSearch.MouseHover += new System.EventHandler(this.TextBoxSeqSearch_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 731);
            this.Controls.Add(this.GrpBoxSeqSearch);
            this.Controls.Add(this.GrpBoxDataAnalysis);
            this.Controls.Add(this.GrpBoxSearch);
            this.Controls.Add(this.ButtonClearAll);
            this.Controls.Add(this.GrpBoxEdit);
            this.Controls.Add(this.ListBoxSort);
            this.Controls.Add(this.btnSortInteractions);
            this.Controls.Add(this.ListBoxInteractions);
            this.Controls.Add(this.btnGetInteractions);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Astronomical Processing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GrpBoxEdit.ResumeLayout(false);
            this.GrpBoxEdit.PerformLayout();
            this.GrpBoxSearch.ResumeLayout(false);
            this.GrpBoxSearch.PerformLayout();
            this.GrpBoxDataAnalysis.ResumeLayout(false);
            this.GrpBoxDataAnalysis.PerformLayout();
            this.GrpBoxSeqSearch.ResumeLayout(false);
            this.GrpBoxSeqSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetInteractions;
        private System.Windows.Forms.ListBox ListBoxInteractions;
        private System.Windows.Forms.Button btnSortInteractions;
        private System.Windows.Forms.ListBox ListBoxSort;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.ListBox ListBoxResults;
        private System.Windows.Forms.GroupBox GrpBoxEdit;
        private System.Windows.Forms.TextBox TextBoxTime;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.TextBox TextBoxNewValue;
        private System.Windows.Forms.Label LblNewValue;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Button ButtonClearAll;
        private System.Windows.Forms.GroupBox GrpBoxSearch;
        private System.Windows.Forms.GroupBox GrpBoxDataAnalysis;
        private System.Windows.Forms.Button ButtonRange;
        private System.Windows.Forms.Button ButtonAverage;
        private System.Windows.Forms.Button ButtonMidExtreme;
        private System.Windows.Forms.Button ButtonMode;
        private System.Windows.Forms.TextBox TextBoxRange;
        private System.Windows.Forms.TextBox TextBoxAverage;
        private System.Windows.Forms.TextBox TextBoxMode;
        private System.Windows.Forms.TextBox TextBoxMidExtreme;
        private System.Windows.Forms.Button ButtonSequentialSearch;
        private System.Windows.Forms.ToolTip toolTip_btngetInteractions;
        private System.Windows.Forms.ToolTip toolTip_ListBoxInteractions;
        private System.Windows.Forms.ToolTip toolTip_btnSortInteractions;
        private System.Windows.Forms.ToolTip toolTip_ListBoxSortInteractions;
        private System.Windows.Forms.ToolTip toolTip_btnBinarySearch;
        private System.Windows.Forms.ToolTip toolTip_txtBoxSearch;
        private System.Windows.Forms.ToolTip toolTip_ListBoxSearch;
        private System.Windows.Forms.ToolTip toolTip_btnSequentialSearch;
        private System.Windows.Forms.ToolTip toolTip_TextBoxTime;
        private System.Windows.Forms.ToolTip toolTip_TextBoxNewValue;
        private System.Windows.Forms.ToolTip toolTip_TextBoxMidExtreme;
        private System.Windows.Forms.ToolTip toolTip_ButtonMidExtreme;
        private System.Windows.Forms.ToolTip toolTip_ButtonEdit;
        private System.Windows.Forms.ToolTip toolTip_ButtonMode;
        private System.Windows.Forms.ToolTip toolTip_TextBoxMode;
        private System.Windows.Forms.ToolTip toolTip_ButtonRange;
        private System.Windows.Forms.ToolTip toolTip_TextBoxRange;
        private System.Windows.Forms.ToolTip toolTip_ButtonClearAll;
        private System.Windows.Forms.ToolTip toolTip_ButtonAverage;
        private System.Windows.Forms.ToolTip toolTip_TextBoxAverage;
        private System.Windows.Forms.GroupBox GrpBoxSeqSearch;
        private System.Windows.Forms.ListBox ListBoxSearchResults;
        private System.Windows.Forms.TextBox TextBox_SeqSearch;
        private System.Windows.Forms.ToolTip toolTip_TextBoxSeqSearch;
        private System.Windows.Forms.ToolTip toolTip_ListBoxSearchResults;
    }
}

