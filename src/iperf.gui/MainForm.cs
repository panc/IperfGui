using System;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace Iperf.Gui
{
    public partial class MainForm : Form
    {
        private const string IPERF_EXE = "iperf.exe";

        private Process _serverProcess;
        private Process _clientProcess;

        public MainForm()
        {
            InitializeComponent();

            var availableSizes = new[]
            {
                new ComboBoxItem<string>("k", "KByte"),
                new ComboBoxItem<string>("m", "MByte"),
            };

            _serverWindowComboBox.DataSource = availableSizes;
            _serverWindowComboBox.DisplayMember = "Text";
            _serverWindowComboBox.ValueMember = "Value";
            _serverWindowComboBox.SelectedIndex = 0;

            _clientWindowComboBox.DataSource = availableSizes;
            _clientWindowComboBox.DisplayMember = "Text";
            _clientWindowComboBox.ValueMember = "Value";
            _clientWindowComboBox.SelectedIndex = 0;

            var addressToolTip = new ToolTip
            {
                AutomaticDelay = 5000,
                AutoPopDelay = 50000,
                InitialDelay = 100,
                ReshowDelay = 500
            };

            addressToolTip.SetToolTip(_clientAddressCheckBox, "Ip-Address or host name");
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            if (_serverProcess != null)
                _serverProcess.Kill();

            if (_clientProcess != null)
                _clientProcess.Kill();

            base.OnClosing(e);
        }

        #region Server Mode

        private void StartServerButton_Click(object sender, EventArgs e)
        {
            if (_serverProcess != null)
                _StopServer();
            else
                _StartServer();
        }

        private void _StartServer()
        {
            var arguments = new StringBuilder("-s ");

            if (_serverPortCheckBox.Checked)
            {
                arguments.Append("-p ")
                    .Append(_serverPortTextBox.Text)
                    .Append(" ");
            }

            if (_serverWindowCheckBox.Checked)
            {
                var unit = _serverWindowComboBox.SelectedValue.ToString();
                arguments.Append("-w ")
                    .Append(_serverWindowTextBox.Text)
                    .Append(unit)
                    .Append(" ");
            }

            _serverProcess = Process.Start(IPERF_EXE, arguments.ToString());
            _serverProcess.EnableRaisingEvents = true;
            _serverProcess.Exited += _OnServerStopped;

            _serverSettingsPanel.Enabled = false;
            _startServerButton.Text = "Stop Server";
        }

        private void _StopServer()
        {
            if (_serverProcess != null)
            {
                _serverProcess.Kill();
                _serverProcess = null;
            }

            if (InvokeRequired)
            {
                Invoke((Action)(_StopServer));
            }
            else
            {
                _serverSettingsPanel.Enabled = true;
                _startServerButton.Text = "Start Server";
            }
        }

        private void _OnServerStopped(object sender, EventArgs e)
        {
            _serverProcess = null;
            _StopServer();
        }

        private void ServerWindowCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _serverWindowTextBox.Enabled = _serverWindowCheckBox.Checked;
            _serverWindowComboBox.Enabled = _serverWindowCheckBox.Checked;
        }

        private void ServerPortCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _serverPortTextBox.Enabled = _serverPortCheckBox.Checked;
        }

        #endregion

        #region Client Mode

        private void StartClientButton_Click(object sender, EventArgs e)
        {
            if (_clientProcess != null)
                _StopClient();
            else
                _StartClient();
        }

        private void _StartClient()
        {
            var arguments = new StringBuilder("-c ");

            if (_clientPortCheckBox.Checked)
            {
                arguments.Append(_clientAddressTextBox.Text)
                    .Append(" ");
            }
            
            if (_clientPortCheckBox.Checked)
            {
                arguments.Append("-p ")
                    .Append(_clientPortTextBox.Text)
                    .Append(" ");
            }

            if (_clientWindowCheckBox.Checked)
            {
                var unit = _clientWindowComboBox.SelectedValue.ToString();
                arguments.Append("-w ")
                    .Append(_serverWindowTextBox.Text)
                    .Append(unit)
                    .Append(" ");
            }

            _clientProcess= Process.Start(IPERF_EXE, arguments.ToString());
            _clientProcess.EnableRaisingEvents = true;
            _clientProcess.Exited += _OnClientStopped;

            _clientSettingsPanel.Enabled = false;
            _startClientButton.Text = "Stop Client";
        }

        private void _StopClient()
        {
            if (_clientProcess != null)
            {
                _clientProcess.Kill();
                _clientProcess = null;
            }

            if (InvokeRequired)
            {
                Invoke((Action)(_StopClient));
            }
            else
            {
                _clientSettingsPanel.Enabled = true;
                _startClientButton.Text = "Start Client";
            }
        }

        private void _OnClientStopped(object sender, EventArgs e)
        {
            _clientProcess = null;
            _StopClient();
        }

        private void _clientAddressCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _clientAddressTextBox.Enabled = _clientAddressCheckBox.Checked;
        }

        private void _clientPortCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _clientPortTextBox.Enabled = _clientPortCheckBox.Checked;
        }

        private void _clientWindowCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _clientWindowTextBox.Enabled = _clientWindowCheckBox.Checked;
            _clientWindowComboBox.Enabled = _clientWindowCheckBox.Checked;
        }

        #endregion
    }
}
