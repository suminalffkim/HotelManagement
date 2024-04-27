using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotelbuchungsverwaltung
{
    public partial class SearchCustomers : Form
    {
        DataConnection dataConnection = new DataConnection();
        private BookingForm bookingForm;

        public SearchCustomers(BookingForm bookingForm)
        {
            InitializeComponent();
            this.bookingForm = bookingForm;
        }

        private void SearchCustomers_Load(object sender, EventArgs e)
        {

        }

        private void suchenButton_Click(object sender, EventArgs e)
        {
            MySqlParameter[] parameters = {
                new MySqlParameter("@Value", suchTextBox.Text)
            };
            DataTable kundenTabelle = dataConnection.LoadFromSQL("SELECT * FROM gaeste WHERE Vorname LIKE @Value OR Nachname LIKE @Value OR Email LIKE @Value"
                , parameters);
            kundenDataGridView.DataSource = kundenTabelle;

        }

        private void kundenDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Greifen Sie auf die ausgewählte Zeile zu
                DataGridViewRow row = kundenDataGridView.Rows[e.RowIndex];

                // Lesen Sie die Daten aus den Zellen dieser Zeile
                string vorname = row.Cells["Vorname"].Value.ToString();
                string nachname = row.Cells["Nachname"].Value.ToString();
                string email = row.Cells["Email"].Value.ToString();
                string tel= row.Cells["Telefon"].Value.ToString();
               string adresse = row.Cells["Adresse"].Value.ToString();

                bookingForm.setKundenDaten(vorname, nachname, email, adresse, tel);
                this.Close();
            }
        }
    }
}
