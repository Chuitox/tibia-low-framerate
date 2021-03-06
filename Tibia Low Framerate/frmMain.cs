﻿using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace TLF
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            Reload();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Reload();
            if (lstbxClients.Items.Count > 0)
            {
                lstbxClients.SelectedIndex = 0;
            }
        }

        private void Reload()
        {
            try
            {
                ClientManager.Clients.Clear();
                lstbxClients.DataSource = null;
                lstbxClients.DisplayMember = null;
                lstbxClients.ValueMember = null;
                lstbxClients.DataSource = ClientManager.Clients;
                lstbxClients.DisplayMember = "Text";
                lstbxClients.ValueMember = "Process";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateSelection_Click(object sender, EventArgs e)
        {
            if (lstbxClients.SelectedIndex <= -1)
            {
                return;
            }

            ((Client)lstbxClients.SelectedItem).SetFramerate((double)nmrcFPS.Value);
            Reload();
        }

        private void btnUpdateAll_Click(object sender, EventArgs e)
        {
            var updated = false;
            var newFps = (double)nmrcFPS.Value;
            foreach (Client selectedItem in lstbxClients.Items)
            {
                selectedItem.SetFramerate(newFps);
                updated = true;
            }
            if (updated)
            {
                Reload();
            }
        }

        private void lstbxClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstbxClients.SelectedIndex > -1)
            {
                SwitchButtonsState(true);
            }
            else
            {
                SwitchButtonsState(false);
            }
        }

        private void SwitchButtonsState(bool enabled)
        {
            btnResetAll.Enabled = enabled;
            btnResetSelection.Enabled = enabled;
            btnUpdateAll.Enabled = enabled;
            btnUpdateSelection.Enabled = enabled;
        }

        private void btnResetSelection_Click(object sender, EventArgs e)
        {
            if (lstbxClients.SelectedIndex > -1)
            {
                ((Client)lstbxClients.SelectedItem).SetFramerate(Constants.DefaultFps);
                Reload();
            }
        }

        private void btnResetAll_Click(object sender, EventArgs e)
        {
            var updated = false;
            foreach (Client selectedItem in lstbxClients.Items)
            {
                selectedItem.SetFramerate(Constants.DefaultFps);
                updated = true;
            }
            if (updated)
            {
                Reload();
            }
        }

        private void picBox_Click(object sender, EventArgs e)
        {
            Process.Start("http://forums.xenobot.net/showthread.php?21060");
        }
    }
}
