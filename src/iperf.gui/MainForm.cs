using System;
using System.Text;
using System.Windows.Forms;

namespace Iperf.Gui
{
    public partial class MainForm : Form
    {
        private readonly IperfProcess _serverProcess;
        private readonly IperfProcess _clientProcess;

        public MainForm()
        {
            InitializeComponent();

            _serverProcess = new IperfProcess(_StopServer, _OnServerOutputDataReceived);
            _clientProcess = new IperfProcess(_StopClient, _OnClientOutputDataReceived);

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
            _StopServer();
            _StopClient();

            base.OnClosing(e);
        }

        #region Server Mode

        private void StartServerButton_Click(object sender, EventArgs e)
        {
            if (_serverProcess.IsRunning)
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
            
            _serverProcess.Start(arguments.ToString());

            _serverSettingsPanel.Enabled = false;
            _startServerButton.Text = "Stop Server";
        }

        private void _StopServer()
        {
            if (InvokeRequired)
            {
                Invoke((Action)(_StopServer));
            }
            else
            {
                if (_serverProcess.IsRunning)
                    _serverProcess.Stop();

                _serverSettingsPanel.Enabled = true;
                _startServerButton.Text = "Start Server";
            }
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

        private void _OnServerOutputDataReceived(string data)
        {
            if (InvokeRequired)
                Invoke((Action<string>)(_OnServerOutputDataReceived), data);
            else
                _serverOutputTextBox.Text += data + Environment.NewLine;
        }

        #endregion

        #region Client Mode

        private void StartClientButton_Click(object sender, EventArgs e)
        {
            if (_clientProcess.IsRunning)
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

            _clientProcess.Start(arguments.ToString());
            
            _clientSettingsPanel.Enabled = false;
            _startClientButton.Text = "Stop Client";
        }

        private void _StopClient()
        {
            if (InvokeRequired)
            {
                Invoke((Action)(_StopClient));
            }
            else
            {
                if (_clientProcess.IsRunning)
                    _clientProcess.Stop();
                
                _clientSettingsPanel.Enabled = true;
                _startClientButton.Text = "Start Client";
            }
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

        private void _OnClientOutputDataReceived(string data)
        {
            if (InvokeRequired)
                Invoke((Action<string>)(_OnClientOutputDataReceived), data);
            else
                _clientOutputTextBox.Text += data + Environment.NewLine;
        }

        #endregion
    }
}
