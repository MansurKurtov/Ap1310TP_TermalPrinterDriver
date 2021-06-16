using Ap1310TP_Bakhodir_Test.Helpers;
using System;
using System.Windows.Forms;

namespace Ap1310TP_Bakhodir_Test
{
    public partial class Form1 : Form
    {
        private Ap1310 MyDevice;

        public Form1()
        {
            InitializeComponent();
            MyDevice = new Ap1310("COM16");
            MyDevice.Open();
        }
                
        private void btnTest1_Click(object sender, EventArgs e)
        {
            if (!MyDevice.IsOpen())
                return;

            MyDevice.Print(PrintMode.Default, "Test default");
            MyDevice.NewLine();
            MyDevice.Print(PrintMode.DoubleWidth, "Test DoubleWidth");
            MyDevice.NewLine();
            MyDevice.Print(PrintMode.DoubleWidthAndHieght, "Test DoubleWidthAndHieght");
            MyDevice.FreeLines(5);
            MyDevice.Print(PrintMode.Default, "Test UnderlineMode default", true);
            MyDevice.NewLine();
            MyDevice.Print(PrintMode.DoubleWidth, "Test UnderlineMode DoubleWidth", true);
            MyDevice.NewLine();
            MyDevice.Print(PrintMode.DoubleWidthAndHieght, "Test UnderlineMode DoubleWidthAndHieght", true);
            MyDevice.FreeLines(5);
            MyDevice.Print(PrintMode.Default, "finish!!!");
            MyDevice.FreeLines(5);
            MyDevice.Close();
        } 
    }
}
