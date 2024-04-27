using System;

namespace Hotelbuchungsverwaltung
{
    partial class BookingForm
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.vornameTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nachnameTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AdresseTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.telTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.anzahlTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NfruestueckTextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkinDatetimepicker = new System.Windows.Forms.DateTimePicker();
            this.checkoutDatetimepicker = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.BestaetigungButton = new System.Windows.Forms.Button();
            this.zimmerCombobox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.PreisLabel = new System.Windows.Forms.Label();
            this.kundensuchenButton = new System.Windows.Forms.Button();
            this.neuKundeCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(36, 54);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // vornameTextbox
            // 
            this.vornameTextbox.Location = new System.Drawing.Point(339, 162);
            this.vornameTextbox.Name = "vornameTextbox";
            this.vornameTextbox.Size = new System.Drawing.Size(252, 20);
            this.vornameTextbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vorname:";
            // 
            // nachnameTextbox
            // 
            this.nachnameTextbox.Location = new System.Drawing.Point(339, 188);
            this.nachnameTextbox.Name = "nachnameTextbox";
            this.nachnameTextbox.Size = new System.Drawing.Size(252, 20);
            this.nachnameTextbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nachname:";
            // 
            // AdresseTextbox
            // 
            this.AdresseTextbox.Location = new System.Drawing.Point(339, 214);
            this.AdresseTextbox.Name = "AdresseTextbox";
            this.AdresseTextbox.Size = new System.Drawing.Size(252, 20);
            this.AdresseTextbox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adresse:";
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(339, 240);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(252, 20);
            this.emailTextbox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "email:";
            // 
            // telTextbox
            // 
            this.telTextbox.Location = new System.Drawing.Point(339, 266);
            this.telTextbox.Name = "telTextbox";
            this.telTextbox.Size = new System.Drawing.Size(252, 20);
            this.telTextbox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tel:";
            // 
            // anzahlTextbox
            // 
            this.anzahlTextbox.Location = new System.Drawing.Point(339, 86);
            this.anzahlTextbox.Name = "anzahlTextbox";
            this.anzahlTextbox.Size = new System.Drawing.Size(252, 20);
            this.anzahlTextbox.TabIndex = 1;
            this.anzahlTextbox.TextChanged += new System.EventHandler(this.anzahlTextbox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Anzahl Person:";
            // 
            // NfruestueckTextbox
            // 
            this.NfruestueckTextbox.Location = new System.Drawing.Point(339, 291);
            this.NfruestueckTextbox.Name = "NfruestueckTextbox";
            this.NfruestueckTextbox.Size = new System.Drawing.Size(252, 20);
            this.NfruestueckTextbox.TabIndex = 1;
            this.NfruestueckTextbox.Text = "0";
            this.NfruestueckTextbox.TextChanged += new System.EventHandler(this.NfruestueckTextbox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(254, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "N Fruehstueck:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(254, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "CheckOut:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(254, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "CheckIn:";
            // 
            // checkinDatetimepicker
            // 
            this.checkinDatetimepicker.Location = new System.Drawing.Point(339, 35);
            this.checkinDatetimepicker.Name = "checkinDatetimepicker";
            this.checkinDatetimepicker.Size = new System.Drawing.Size(150, 20);
            this.checkinDatetimepicker.TabIndex = 3;
            this.checkinDatetimepicker.ValueChanged += new System.EventHandler(this.checkinDatetimepicker_ValueChanged);
            // 
            // checkoutDatetimepicker
            // 
            this.checkoutDatetimepicker.Location = new System.Drawing.Point(339, 59);
            this.checkoutDatetimepicker.Name = "checkoutDatetimepicker";
            this.checkoutDatetimepicker.Size = new System.Drawing.Size(150, 20);
            this.checkoutDatetimepicker.TabIndex = 3;
            this.checkoutDatetimepicker.Value = new System.DateTime(2024, 4, 28, 21, 14, 26, 883);
            this.checkoutDatetimepicker.ValueChanged += new System.EventHandler(this.checkoutDatetimepicker_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(255, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Zimmer: ";
            // 
            // BestaetigungButton
            // 
            this.BestaetigungButton.Location = new System.Drawing.Point(339, 327);
            this.BestaetigungButton.Name = "BestaetigungButton";
            this.BestaetigungButton.Size = new System.Drawing.Size(133, 27);
            this.BestaetigungButton.TabIndex = 6;
            this.BestaetigungButton.Text = "Bestaetigen";
            this.BestaetigungButton.UseVisualStyleBackColor = true;
            this.BestaetigungButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // zimmerCombobox
            // 
            this.zimmerCombobox.FormattingEnabled = true;
            this.zimmerCombobox.Location = new System.Drawing.Point(339, 112);
            this.zimmerCombobox.Name = "zimmerCombobox";
            this.zimmerCombobox.Size = new System.Drawing.Size(150, 21);
            this.zimmerCombobox.TabIndex = 7;
            this.zimmerCombobox.SelectedIndexChanged += new System.EventHandler(this.zimmerCombobox_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(254, 366);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Preise:";
            // 
            // PreisLabel
            // 
            this.PreisLabel.AutoSize = true;
            this.PreisLabel.Location = new System.Drawing.Point(339, 367);
            this.PreisLabel.Name = "PreisLabel";
            this.PreisLabel.Size = new System.Drawing.Size(13, 13);
            this.PreisLabel.TabIndex = 9;
            this.PreisLabel.Text = "0";
            // 
            // kundensuchenButton
            // 
            this.kundensuchenButton.Location = new System.Drawing.Point(620, 163);
            this.kundensuchenButton.Name = "kundensuchenButton";
            this.kundensuchenButton.Size = new System.Drawing.Size(64, 45);
            this.kundensuchenButton.TabIndex = 10;
            this.kundensuchenButton.Text = "suchen";
            this.kundensuchenButton.UseVisualStyleBackColor = true;
            this.kundensuchenButton.Click += new System.EventHandler(this.kundensuchenButton_Click);
            // 
            // neuKundeCheckBox
            // 
            this.neuKundeCheckBox.AutoSize = true;
            this.neuKundeCheckBox.Location = new System.Drawing.Point(339, 139);
            this.neuKundeCheckBox.Name = "neuKundeCheckBox";
            this.neuKundeCheckBox.Size = new System.Drawing.Size(86, 17);
            this.neuKundeCheckBox.TabIndex = 11;
            this.neuKundeCheckBox.Text = "Neue Kunde";
            this.neuKundeCheckBox.UseVisualStyleBackColor = true;
            this.neuKundeCheckBox.CheckedChanged += new System.EventHandler(this.neuKundeCheckBox_CheckedChanged);
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.neuKundeCheckBox);
            this.Controls.Add(this.kundensuchenButton);
            this.Controls.Add(this.PreisLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.zimmerCombobox);
            this.Controls.Add(this.BestaetigungButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.checkoutDatetimepicker);
            this.Controls.Add(this.checkinDatetimepicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NfruestueckTextbox);
            this.Controls.Add(this.anzahlTextbox);
            this.Controls.Add(this.telTextbox);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.AdresseTextbox);
            this.Controls.Add(this.nachnameTextbox);
            this.Controls.Add(this.vornameTextbox);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "BookingForm";
            this.Text = "Neue Buchung";
            this.Load += new System.EventHandler(this.BookingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox vornameTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nachnameTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AdresseTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox telTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox anzahlTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NfruestueckTextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker checkinDatetimepicker;
        private System.Windows.Forms.DateTimePicker checkoutDatetimepicker;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BestaetigungButton;
        private System.Windows.Forms.ComboBox zimmerCombobox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label PreisLabel;
        private System.Windows.Forms.Button kundensuchenButton;
        private System.Windows.Forms.CheckBox neuKundeCheckBox;
    }
}