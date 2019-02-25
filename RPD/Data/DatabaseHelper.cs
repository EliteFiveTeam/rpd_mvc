using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Threading;
using System.Diagnostics;

namespace RPD.Data
{
    class DatabaseHelper
    {
        private OleDbConnection con;
        private OleDbCommand command = new OleDbCommand();
        private OleDbDataReader reader;


        private void Connect()
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=" + Application.StartupPath + "/baza_dan_proekt_kh.accdb");
            command.Connection = con;
            
        }


        public OleDbDataReader GetReader(String commandText)
        {
            Connect();
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            command.CommandText = commandText;
            reader = command.ExecuteReader();
            return reader;
        }

        public void Close()
        {
            if (con != null)
            {
                con.Close();
            }
        }

    }
}
