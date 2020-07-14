using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RaRat_server
{
    public partial class ra_main : Form
    {

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
    }
}
