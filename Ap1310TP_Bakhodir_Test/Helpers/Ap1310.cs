using System.IO.Ports;
using System.Text;
using System.Threading;

namespace Ap1310TP_Bakhodir_Test.Helpers
{
    public class Ap1310 : IAp1310
    {
        private SerialPort _serialPort;
        private string _port;
        private int _boundRate;

        public Ap1310(string port, int boundRate = 9600)
        {
            _port = port;
            _boundRate = boundRate;
        }

        public bool Open()
        {
            try
            {
                return InternalOpen();
            }
            catch
            {
                return false;
            }
        }

        public bool IsOpen()
        {
            return _serialPort?.IsOpen ?? false;
        }

        public bool SetUnderlineMode(SwitchMode switchMode)
        {
            try
            {
                SendAndRead(new byte[] { 0x1b, 0x2d, (byte)switchMode });
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool NewLine()
        {
            try
            {
                SendAndRead(Encoding.GetEncoding(866).GetBytes("\n"));
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Print(PrintMode printMode, string text, bool underline = false)
        {
            try
            {
                var uLine = underline ? 1 : 0;
                var mode = new int[8];
                switch (printMode)
                {
                    case PrintMode.Default:
                        mode = new int[8] { 0, 0, 0, 0, 0, 0, 0, uLine };
                        break;
                    case PrintMode.DoubleWidth:
                        mode = new int[8] { 0, 0, 0, 0, 0, 1, 0, uLine };
                        break;
                    case PrintMode.DoubleWidthAndHieght:
                        mode = new int[8] { 0, 0, 0, 0, 1, 0, 0, uLine };
                        break;

                }
                SendAndRead(new byte[] { 0x1b, 0x21, mode.BitsToByte() });
                SendAndRead(Encoding.GetEncoding(866).GetBytes(text));

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Close()
        {
            try
            {
                _serialPort.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Cut()
        {
            try
            {
                SendAndRead(new byte[] { 0x1b, 0x69 });
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool PartialCut()
        {
            try
            {
                SendAndRead(new byte[] { 0x1b, 0x6d });
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool FreeLines(byte linesCount)
        {
            try
            {
                SendAndRead(new byte[] { 0x1b, 0x64, linesCount });
                return true;
            }
            catch
            {
                return false;
            }
        }


        private bool InternalOpen()
        {
            if (_serialPort == null)
                _serialPort = new SerialPort(_port);
            if (_serialPort.IsOpen)
                return false;
            _serialPort.BaudRate = _boundRate;
            _serialPort.Parity = Parity.None;
            _serialPort.StopBits = StopBits.One;
            _serialPort.DataBits = 8;
            _serialPort.Handshake = Handshake.None;
            _serialPort.DtrEnable = true;
            _serialPort.Open();
            return true;
        }
        private byte[] SendAndRead(byte[] writeData, int waitBeforeReadMilliSecound = 100)
        {

            _serialPort.Write(writeData, 0, writeData.Length);
            Thread.Sleep(waitBeforeReadMilliSecound);

            var bytesToRead = _serialPort.BytesToRead;
            var buffer = new byte[bytesToRead];
            _serialPort.Read(buffer, 0, bytesToRead);
            return buffer;
        }

    }
}
