using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace login
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        //EXIT BUTTON
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //LOGIN BUTTON
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
