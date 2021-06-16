namespace Ap1310TP_Bakhodir_Test.Helpers
{
    public interface IAp1310
    {
        bool Open();
        bool IsOpen();                
        bool FreeLines(byte linesCount);
        bool NewLine();
        bool PartialCut();
        bool Cut();
        bool Print(PrintMode printMode, string text, bool underline = false);
        bool SetUnderlineMode(SwitchMode switchMode);
        bool Close();
    }
}