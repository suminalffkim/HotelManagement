using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotelbuchungsverwaltung
{
    public partial class BookingForm : Form
    {
        DataConnection dataConnection = new DataConnection();

        public BookingForm()
        {
            InitializeComponent();
        }



        private void BookingForm_Load(object sender, EventArgs e)
        {
            string query = "SELECT ZimmerNummer FROM zimmer";

            DataTable table = dataConnection.LoadFromSQL(query);

            if (table != null)
            {
                foreach (DataRow row in table.Rows)
                {
                    zimmerCombobox.Items.Add(row["ZimmerNummer"].ToString());
                }
            }
        }


        double zimmerPreis = 0;
        int nPerson = 2;
        int nFruestueck = 0;
        int nNacht = 1;
        int fruestueckPreis = 14;
        double preis;
        private void anzahlTextbox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(anzahlTextbox.Text, out int value))
            {
                nPerson = value;
            }
            else
            {
                nPerson = 2;
            }

            CheckZimmerVerfuegbarkeit();
        }
        private void NfruestueckTextbox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(NfruestueckTextbox.Text, out int value))
            {
                nFruestueck = value;
            }
            else
            {
                nFruestueck = 0;
            }
            CalculatePreis();
        }
        private void zimmerCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //bei Auswahl des Zimmers wird preis neu berechnet 

            string query = "SELECT Preis FROM zimmer WHERE ZimmerNummer=@zimmerNummer";
            MySqlParameter[] parameters = {
    new MySqlParameter("@zimmerNummer", zimmerCombobox.Text)
};
            DataTable table = dataConnection.LoadFromSQL(query, parameters);
            if (table != null && table.Rows.Count > 0)
            {
                object zimmerPreisObject = table.Rows[0]["Preis"];
                if (zimmerPreisObject != DBNull.Value)
                {
                    zimmerPreis = Convert.ToInt32(zimmerPreisObject);
                }
                else
                {
                    MessageBox.Show("Der Preis für die ausgewählte ZimmerNummer ist null.");
                }
            }
            CalculateNacht();
            CalculatePreis();

        }
        private void CheckZimmerVerfuegbarkeit()
        {//nur verfuegbare zimmer wird auf der Zimmerliste gezeigt.
            //es wird mit dem Datum und nPerson uberpreft werden
            zimmerCombobox.Items.Clear();

            //verfuegbarkeit nach Datum
            DateTime checkin = checkinDatetimepicker.Value.Date;
            DateTime checkout = checkoutDatetimepicker.Value.Date;

            string query = "SELECT DISTINCT ZimmerID FROM reservierungen WHERE CheckOutDatum > @checkIn AND CheckInDatum<@checkout";
            MySqlParameter[] parameters = {
    new MySqlParameter("@checkIn", checkin),
    new MySqlParameter("@checkout", checkout),
};
            DataTable table = dataConnection.LoadFromSQL(query, parameters);

            if (table != null)
            {
                foreach (DataRow row in table.Rows)
                {
                    //verfuegbarkeit nach nPerson
                    string newQuery = "SELECT ZimmerNummer FROM zimmer WHERE ZimmerID=@id AND ZimmerTyp >=@AnzahlPerson";//nur passende Zimmer fuer Gaesteanzahl zeigen

                    MySqlParameter[] newparameters = {
    new MySqlParameter("@id", row["ZimmerID"].ToString()),
    new MySqlParameter("@AnzahlPerson", nPerson),
                };
                    DataTable newTable = dataConnection.LoadFromSQL(newQuery, newparameters);
                    if (newTable != null)
                    {
                        foreach (DataRow newrow in newTable.Rows)
                        {
                            zimmerCombobox.Items.Add(newrow["ZimmerNummer"].ToString());
                        }
                    }
                }
            }

        }
        private void checkinDatetimepicker_ValueChanged(object sender, EventArgs e)
        {
            CheckZimmerVerfuegbarkeit();
            CalculateNacht();
            CalculatePreis();
        }
        private void checkoutDatetimepicker_ValueChanged(object sender, EventArgs e)
        {
            CheckZimmerVerfuegbarkeit();
            CalculateNacht();
            CalculatePreis();
        }
        private void CalculateNacht()
        {
            TimeSpan difference = checkoutDatetimepicker.Value.Date - checkinDatetimepicker.Value.Date;
            nNacht = difference.Days;
        }

        private void CalculatePreis()
        {
            preis = nNacht * zimmerPreis + nFruestueck * fruestueckPreis;
            PreisLabel.Text = "Uebernachtung: " + nNacht.ToString() + " * " + zimmerPreis + "\n"
                + "Fruestueck: " + nFruestueck.ToString() + " * " + fruestueckPreis + "\n"
                + "Total: " + preis.ToString() + "Euro";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //hier wird reservierung gespeichert. dafuer muss man zimmerID des gewaehlten zimmers und gastID (egal ob neu/bestand Kunden) wissen. 

            //(string zimmerId, string gastID, DateTime checkInDatum, DateTime checkOutDatum, string gastName, string gastEmail,
            ////string gastTelefon, int nPersonen, int nFruehstueck, string isBezahlt, string preis)

            //suche nach zimmer id
            int zimmerid = 0;
            string query = "SELECT ZimmerID FROM zimmer WHERE ZimmerNummer=@zimmerNummer";
            MySqlParameter[] parameters = {
    new MySqlParameter("@zimmerNummer", zimmerCombobox.Text)
};
            DataTable table = dataConnection.LoadFromSQL(query, parameters);
            if (table != null && table.Rows.Count > 0)
            {
                object zimmeridObj = table.Rows[0]["ZimmerID"];
                if (zimmeridObj != DBNull.Value)
                {
                    zimmerid = Convert.ToInt32(zimmeridObj);
                }
                else
                {
                    MessageBox.Show("Fehler beim Zimmersuchen");
                }
            }

            //suche nach gast id
            int gastid = 0;
            string query2 = "SELECT GastID FROM gaeste WHERE Email = @Email";
            MySqlParameter[] parameters2 = {
    new MySqlParameter("@Email", emailTextbox.Text)
};
            DataTable tableGast = dataConnection.LoadFromSQL(query2, parameters2);

            if (tableGast != null && tableGast.Rows.Count > 0)
            {
                object gastidOjb = tableGast.Rows[0]["GastID"];
                if (gastidOjb != DBNull.Value)
                {
                    gastid = Convert.ToInt32(gastidOjb);
                }
                else
                {
                    MessageBox.Show("Fehler beim Gastsuchen");
                }
            }
            string gastname = vornameTextbox.Text + " " + nachnameTextbox.Text;
            string bezahlt = "y";
            dataConnection.writeDataReservierung(zimmerid, gastid, checkinDatetimepicker.Value.Date, checkoutDatetimepicker.Value.Date, gastname, emailTextbox.Text, telTextbox.Text, nPerson, nFruestueck, bezahlt, preis.ToString());
        }

        private void kundensuchenButton_Click(object sender, EventArgs e)
        {
            SearchCustomers searchCustomers = new SearchCustomers(this);
            searchCustomers.ShowDialog();
        }

        private void neuKundeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;

            // nur wenn checkbox gehackt ist, fuege neue Kunden hinzu
            if (checkBox != null && checkBox.Checked)
            {
                //string vorname, string nachname, string email, string telefon, string adresse
                dataConnection.writeDataGast(vornameTextbox.Text.ToString(), nachnameTextbox.Text.ToString(), emailTextbox.Text.ToString(),
                    telTextbox.Text.ToString(), AdresseTextbox.Text.ToString());
            }
        }
        public void setKundenDaten(string vorname, string nachname, string email, string adresse, string tel)
        {
            vornameTextbox.Text = vorname;
            nachnameTextbox.Text = nachname;
            emailTextbox.Text = email;
            AdresseTextbox.Text = adresse;
            telTextbox.Text = tel;
        }
    }
}
