namespace Hotelbuchungsverwaltung
{
    partial class SearchCustomers
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
            this.suchTextBox = new System.Windows.Forms.TextBox();
            this.suchenButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.kundenDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.kundenDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Suchfeld:";
            // 
            // suchTextBox
            // 
            this.suchTextBox.Location = new System.Drawing.Point(78, 38);
            this.suchTextBox.Name = "suchTextBox";
            this.suchTextBox.Size = new System.Drawing.Size(163, 20);
            this.suchTextBox.TabIndex = 6;
            // 
            // suchenButton
            // 
            this.suchenButton.Location = new System.Drawing.Point(258, 36);
            this.suchenButton.Name = "suchenButton";
            this.suchenButton.Size = new System.Drawing.Size(75, 21);
            this.suchenButton.TabIndex = 11;
            this.suchenButton.Text = "suchen";
            this.suchenButton.UseVisualStyleBackColor = true;
            this.suchenButton.Click += new System.EventHandler(this.suchenButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "suche mit Vorname, Nachname oder Email";
            // 
            // kundenDataGridView
            // 
            this.kundenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kundenDataGridView.Location = new System.Drawing.Point(12, 73);
            this.kundenDataGridView.Name = "kundenDataGridView";
            this.kundenDataGridView.Size = new System.Drawing.Size(454, 150);
            this.kundenDataGridView.TabIndex = 13;
            this.kundenDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kundenDataGridView_CellClick);
            // 
            // SearchCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 344);
            this.Controls.Add(this.kundenDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.suchenButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.suchTextBox);
            this.Name = "SearchCustomers";
            this.Text = "SearchCustomers";
            this.Load += new System.EventHandler(this.SearchCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kundenDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox suchTextBox;
        private System.Windows.Forms.Button suchenButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView kundenDataGridView;
    }
}