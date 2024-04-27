using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotelbuchungsverwaltung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //DataConnection dataConnection=new DataConnection();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Hier kannst du Initialisierungscode für das Formular platzieren
            // z.B. Daten laden, Steuerelemente initialisieren, usw.
        }



        private void InitializeComponents()
        {
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            BookingForm bookingform = new BookingForm();
            bookingform.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            BookingManagementForm managementform = new BookingManagementForm();
           managementform.ShowDialog();
        }


    }
}
