namespace Hotelbuchungsverwaltung
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.NeueBuchungButton = new System.Windows.Forms.Button();
            this.VerwaltungButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NeueBuchungButton
            // 
            this.NeueBuchungButton.Location = new System.Drawing.Point(73, 111);
            this.NeueBuchungButton.Name = "NeueBuchungButton";
            this.NeueBuchungButton.Size = new System.Drawing.Size(265, 195);
            this.NeueBuchungButton.TabIndex = 0;
            this.NeueBuchungButton.Text = "Neue Buchung";
            this.NeueBuchungButton.UseVisualStyleBackColor = true;
            this.NeueBuchungButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // VerwaltungButton
            // 
            this.VerwaltungButton.Location = new System.Drawing.Point(431, 111);
            this.VerwaltungButton.Name = "VerwaltungButton";
            this.VerwaltungButton.Size = new System.Drawing.Size(265, 195);
            this.VerwaltungButton.TabIndex = 0;
            this.VerwaltungButton.Text = "Buchung Verwaltung";
            this.VerwaltungButton.UseVisualStyleBackColor = true;
            this.VerwaltungButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VerwaltungButton);
            this.Controls.Add(this.NeueBuchungButton);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NeueBuchungButton;
        private System.Windows.Forms.Button VerwaltungButton;
    }
}

