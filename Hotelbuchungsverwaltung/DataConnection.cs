using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Hotelbuchungsverwaltung
{
    class DataConnection
    {
        public DataConnection()
        {
        }
        string connectionString = "Server=localhost; Database=hotel; uid=project;pwd=pwd;";

        public DataTable LoadFromSQL(string query, MySqlParameter[] parameters = null)
        {
            //hier kann man mit parametern SQL verwenden
            DataTable table = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);

                if (parameters != null)
                {
                    foreach (var parameter in parameters)
                    {
                        command.Parameters.Add(parameter);
                    }
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                try
                {
                    connection.Open();
                    adapter.Fill(table);
                    return table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler beim Laden der Daten: " + ex.Message);
                    return null;
                }
            }
        }


        public void writeDataGast(string vorname, string nachname, string email, string telefon, string adresse)
        {

            string query = "INSERT INTO gaeste (Vorname, Nachname, Email, Telefon, Adresse) " +
               "VALUES (@Vorname, @Nachname, @Email, @Telefon, @Adresse)";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Vorname", vorname);
                command.Parameters.AddWithValue("@Nachname", nachname);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Telefon", telefon);
                command.Parameters.AddWithValue("@Adresse", adresse);


                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show(rowsAffected + " Gast wurden erfolgreich hinzugefügt.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler beim Hinzufügen des Gasts: " + ex.Message);
                }

            }
        }

        public void writeDataReservierung(int zimmerId, int gastID, DateTime checkInDatum, DateTime checkOutDatum, string gastName, string gastEmail, string gastTelefon, int nPersonen, int nFruehstueck, string bezahlt, string preis)
        {

            string query = "INSERT INTO reservierungen (ZimmerID, GastID, CheckInDatum, CheckOutDatum,GastName,GastEmail,GastTelefon,AnzahlPersonen, FruehstueckInklusive, Bezahlt,Preise)" +
               "VALUES (@ZimmerID, @GastID, @CheckInDatum, @CheckOutDatum,@GastName,@GastEmail,@GastTelefon,@AnzahlPersonen, @FruehstueckInklusive, @Bezahlt,@Preise)";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@ZimmerID", zimmerId);
                command.Parameters.AddWithValue("@GastID", gastID);
                command.Parameters.Add("@CheckInDatum", MySqlDbType.Date).Value = checkInDatum;
                command.Parameters.Add("@CheckOutDatum", MySqlDbType.Date).Value = checkOutDatum;

                command.Parameters.AddWithValue("@GastName", gastName);
                command.Parameters.AddWithValue("@GastEmail", gastEmail);
                command.Parameters.AddWithValue("@GastTelefon", gastTelefon);
                command.Parameters.AddWithValue("@AnzahlPersonen", nPersonen);
                command.Parameters.AddWithValue("@FruehstueckInklusive", nFruehstueck);
                command.Parameters.AddWithValue("@Bezahlt", bezahlt);
                command.Parameters.AddWithValue("@Preise", preis);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show(rowsAffected + " Reservierung wurden erfolgreich hinzugefügt.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler beim Hinzufügen des Reservierung: " + ex.Message);
                }
            }
        }
    }
}
