using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeadByToolbox
{
    public partial class FormMain : Form
    {
        private readonly string EnginePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\DeadByDaylight\Saved\Config\WindowsNoEditor\Engine.ini";
        private Proxy proxy = new Proxy();

        public FormMain()
        {
            InitializeComponent();

        }

        private void Proxy_BhvrSessionChanged(string session)
        {
            textBoxBhvrSession.Text = session;
        }

        private void buttonStartStop_Click(object sender, EventArgs e)
        {
            LoadFiles();
            if (proxy.IsRunning)
            {
                buttonStartStop.Text = "Start";
                labelProxyStatus.ForeColor = Color.Red;
                labelProxyStatus.Text = "Stopped";
                proxy.Stop();
            } else
            {
                buttonStartStop.Text = "Stop";
                labelProxyStatus.ForeColor = Color.Green;
                labelProxyStatus.Text = "Running";
                proxy.Start();
            }
        }


        private void LoadFiles()
        {
            if (File.Exists(@"data\inventory.json"))
            {
                proxy.ResponseInventory = File.ReadAllText(@"data\inventory.json");
 
                checkBoxInventoryOverride.Enabled = true;
            }
            else
            {
                checkBoxInventoryOverride.Enabled = false;
            }
            if (File.Exists(@"data\currencies.json"))
            {

                proxy.ResponseCurrencies = GenerateCurrencyResponse();
                checkBoxCurrencySpoofer.Enabled = true;
            }
            else
            {
                checkBoxCurrencySpoofer.Enabled = false;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadSettings();
            LoadFiles();
            proxy.BhvrSessionChanged += Proxy_BhvrSessionChanged;
            proxy.InstallCerts();
            proxy.Start(); 

        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            proxy.Stop();
            proxy.UninstallCerts();
            SaveSettings();
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.InventoryOverride = checkBoxInventoryOverride.Checked;
            Properties.Settings.Default.CurrencySpoofer = checkBoxCurrencySpoofer.Checked;
       
        }
        private void LoadSettings()
        {
            checkBoxInventoryOverride.Checked = Properties.Settings.Default.InventoryOverride;
            checkBoxCurrencySpoofer.Checked = Properties.Settings.Default.CurrencySpoofer;    
        }
        private string GenerateCurrencyResponse()
        {
            string result = File.ReadAllText(@"data\currencies.json");
            result = result.Replace("{SHARDS}", Properties.Settings.Default.CurrencyShards.ToString());
            result = result.Replace("{CELLS}", Properties.Settings.Default.CurrencyCells.ToString());
            result = result.Replace("{BLODDPOINTS}", Properties.Settings.Default.CurrencyBloodpoints.ToString());
            return result;
        }


        private void checkBoxInventoryOverride_CheckedChanged(object sender, EventArgs e)
        {
            proxy.InventoryOverride = checkBoxInventoryOverride.Checked;
        }

        private void checkBoxCurrencySpoofer_CheckedChanged(object sender, EventArgs e)
        {
            proxy.CurrencySpoofer = checkBoxCurrencySpoofer.Checked;
        }

        private void buttonCopyBhvrSession_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxBhvrSession.Text);
        }

        private void buttonSSLBypassInstall_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"data\EngineBypass.ini"))
            {
                File.Copy(@"data\EngineBypass.ini", EnginePath, true);
                MessageBox.Show("SSL Bypass installed!");
            } else
            {
                MessageBox.Show("Could not find EngineBypass.ini!");
            }
        }

        private void buttonSSLBypassUninstall_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"data\Engine.ini"))
            {
                File.Copy(@"data\Engine.ini", EnginePath, true);
                MessageBox.Show("SSL Bypass uninstalled!");
            }
            else
            {
                MessageBox.Show("Could not find Engine.ini!");
            }
        }


        private void buttonCurrencyEdit_Click(object sender, EventArgs e)
        {
            DialogCurrency dialogCurrency = new DialogCurrency();
            if(dialogCurrency.ShowDialog() == DialogResult.OK)
            {
                LoadFiles();
            }
        }
    }
}
