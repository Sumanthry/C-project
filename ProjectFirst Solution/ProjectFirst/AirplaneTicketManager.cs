using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectFirst
{
    public partial class AirplaneTicketManager : Form
    {
        public AirplaneTicketManager()
        {
            InitializeComponent();
        }

        private void eXitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // closes the form
            this.Close();
        }// close the form

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox(); // creating an instance of about box
            aboutBox.MdiParent = this;// make aboutbox child form
            aboutBox.Show();// displaying the aboutbox
        }// end about box tool strip menu
    }
}
