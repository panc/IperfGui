using System;
using System.Diagnostics;

namespace Iperf.Gui
{
    public class IperfProcess
    {
        private const string IPERF_EXE = "iperf.exe";

        private Process _process;
        private readonly Action _onStoppedCallback;
        private readonly Action<string> _onOutputReceived;

        public IperfProcess(Action onStoppedCallback, Action<string> onOutputReceived)
        {
            _onStoppedCallback = onStoppedCallback;
            _onOutputReceived = onOutputReceived;
        }

        public void Start(string arguments)
        {
            _process = new Process()
            {
                StartInfo = new ProcessStartInfo(IPERF_EXE)
                {
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    Arguments = arguments,
                },
                EnableRaisingEvents = true
            };

            _process.Exited += _OnProcessStopped;
            _process.OutputDataReceived += _OnOutputReceived;
            _process.Start();
            _process.BeginOutputReadLine();

            _onOutputReceived(string.Format("{0} {1}", _process.StartInfo.FileName, _process.StartInfo.Arguments));
        }

        public void Stop()
        {
            _process.Exited -= _OnProcessStopped;
            _process.OutputDataReceived -= _OnOutputReceived;
            _process.Kill();
            _process = null;
        }

        public bool IsRunning
        {
            get { return _process != null; }
        }

        private void _OnProcessStopped(object sender, EventArgs e)
        {
            _process = null;
            _onStoppedCallback();
        }

        private void _OnOutputReceived(object sender, DataReceivedEventArgs e)
        {
            _onOutputReceived(e.Data);
        }
    }
}