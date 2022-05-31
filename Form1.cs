using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stadium_Seating
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_btn_Click(object sender, EventArgs e)
        {
            double revA = 0;
            double revB = 0;
            double revC = 0;
            double total = 0;

            revA = double.Parse(seatA_txbox.Text);
            revB = double.Parse(seatB_txtbox.Text);
            revC = double.Parse(seatC_txtbox.Text);

            revA_txtbox.Text = (revA * 15).ToString("C");
            revB_txtbox.Text = (revB * 12).ToString("C");
            revC_txtbox.Text = (revC * 9).ToString("C");

            total = (revA * 15) + (revB * 12) + (revC * 9);
            total_txtbox.Text = total.ToString("C");
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            seatA_txbox.Clear();
            seatB_txtbox.Clear();
            seatC_txtbox.Clear();
            revA_txtbox.Clear();
            revB_txtbox.Clear();
            revC_txtbox.Clear();
            total_txtbox.Clear();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
