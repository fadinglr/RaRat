using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace RaRat_server
{
    public partial class ra_main : Form
    {
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();

        public static string convertDataTableToString(DataTable dataTable)
        {
            string data = string.Empty;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow row = dataTable.Rows[i];
                for (int j = 0; j < dataTable.Columns.Count; j++)
                {
                    data += dataTable.Columns[j].ColumnName + ":" + row[j];
                    if (j == dataTable.Columns.Count - 1)
                    {
                        if (i != (dataTable.Rows.Count - 1))
                            data += "$";
                    }
                    else
                        data += "/";
                }
            }
            return data;
        }

        private void SetConnection() {
            sql_con = new SQLiteConnection("Data Source=database.db;version=3;New=False;Compress=True;");
        }

        private void LoadData() {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            String CommandText = "select client_id, client_ip from client_table";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            sql_con.Close();
            string res = convertDataTableToString(DT);
            richTextBox1.Text = res;

        }

        public ra_main()

        { 
        
            int server_listen_port =3030 ;
            int client_listen_port =3020 ;

            InitializeComponent();
            richTextBox1.Text = " Welcome to RaRat v0.1 \n\r ====================";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
