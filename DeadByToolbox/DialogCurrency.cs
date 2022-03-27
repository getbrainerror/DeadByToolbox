using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeadByToolbox
{
    public partial class DialogCurrency : Form
    {
        public DialogCurrency()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int cells;
            int shards;
            int bloodpoints;

            if (!int.TryParse(textBoxCells.Text, out cells) |
                !int.TryParse(textBoxShards.Text, out shards) |
                !int.TryParse(textBoxBloodpoints.Text, out bloodpoints))
            {
                MessageBox.Show("Couldn't convert to integer. Please check your input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Properties.Settings.Default.CurrencyCells = cells;
            Properties.Settings.Default.CurrencyShards = shards;
            Properties.Settings.Default.CurrencyBloodpoints = bloodpoints;
        }

        private void DialogCurrency_Load(object sender, EventArgs e)
        {
            textBoxCells.Text = Properties.Settings.Default.CurrencyCells.ToString();
            textBoxShards.Text = Properties.Settings.Default.CurrencyShards.ToString();
            textBoxBloodpoints.Text = Properties.Settings.Default.CurrencyBloodpoints.ToString();
        }
    }
}
