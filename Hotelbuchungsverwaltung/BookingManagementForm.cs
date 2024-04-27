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

namespace Hotelbuchungsverwaltung
{
    public partial class BookingManagementForm : Form
    {
        DataConnection dataConnection = new DataConnection();
        public BookingManagementForm()
        {
            InitializeComponent();
            DataTable zimmerTabelle = dataConnection.LoadFromSQL("SELECT Zimmernummer FROM zimmer");
            dataGridView1.DataSource = zimmerTabelle;


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            int zimmerNum = Convert.ToInt32(row.Cells["ZimmerNummer"].Value);
            //zeige ZimmerInfo
            if (e.RowIndex >= 0)
            {

                string query = "SELECT * FROM zimmer WHERE ZimmerNummer =@zimmerNum";
                MySqlParameter[] parameters = {
    new MySqlParameter("@zimmerNum", zimmerNum) };
                DataTable table = dataConnection.LoadFromSQL(query, parameters);
                dataGridView2.DataSource = table;



                //zeige Alle buchung fuer diese Zimmer
                string query3 = "SELECT ZimmerID FROM zimmer WHERE Zimmernummer=@zimmerNum";
                DataTable table3 = dataConnection.LoadFromSQL(query3, parameters);
                int zimmerID = 0;
                if (table3 != null && table3.Rows.Count > 0)
                {
                    object zimmeridObj = table3.Rows[0]["ZimmerID"];
                    if (zimmeridObj != DBNull.Value)
                    {
                        zimmerID = Convert.ToInt32(zimmeridObj);
                    }
                    else
                    {
                        MessageBox.Show("Zimmer nicht gefunden");
                    }
                }

                string query2 = "SELECT * FROM reservierungen WHERE ZimmerID=@zimmerID ORDER BY CheckInDatum ASC";
                MySqlParameter[] parameters2 = {
    new MySqlParameter("@zimmerID", zimmerID) };
                DataTable resTablle = dataConnection.LoadFromSQL(query2, parameters2);
                dataGridView3.DataSource = resTablle;

            }

        }

    }
}