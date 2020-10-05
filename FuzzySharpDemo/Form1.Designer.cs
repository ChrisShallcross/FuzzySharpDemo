namespace FuzzySharpDemo
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
            this.cbEntityName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvResults = new System.Windows.Forms.ListView();
            this.Cedant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Score = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // cbEntityName
            // 
            this.cbEntityName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEntityName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEntityName.FormattingEnabled = true;
            this.cbEntityName.Location = new System.Drawing.Point(152, 26);
            this.cbEntityName.Name = "cbEntityName";
            this.cbEntityName.Size = new System.Drawing.Size(367, 21);
            this.cbEntityName.Sorted = true;
            this.cbEntityName.TabIndex = 2;
            this.cbEntityName.SelectedIndexChanged += new System.EventHandler(this.cbEntityName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Entity Name";
            // 
            // lvResults
            // 
            this.lvResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Cedant,
            this.Score});
            this.lvResults.GridLines = true;
            this.lvResults.HideSelection = false;
            this.lvResults.Location = new System.Drawing.Point(16, 72);
            this.lvResults.Name = "lvResults";
            this.lvResults.Size = new System.Drawing.Size(517, 382);
            this.lvResults.TabIndex = 3;
            this.lvResults.UseCompatibleStateImageBehavior = false;
            this.lvResults.View = System.Windows.Forms.View.Details;
            // 
            // Cedant
            // 
            this.Cedant.Text = "Cedant";
            this.Cedant.Width = 356;
            // 
            // Score
            // 
            this.Score.Text = "Score";
            this.Score.Width = 101;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 466);
            this.Controls.Add(this.lvResults);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbEntityName);
            this.MinimumSize = new System.Drawing.Size(561, 505);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Fuzzy Sharp Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEntityName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvResults;
        private System.Windows.Forms.ColumnHeader Cedant;
        private System.Windows.Forms.ColumnHeader Score;
    }
}

