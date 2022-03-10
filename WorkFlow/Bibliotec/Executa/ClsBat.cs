using System.Diagnostics;

namespace Bibliotec.Executa
{
    public class ClsBat
    {
        public static void ExecutaBat(string sBat)
        {
            ProcessStartInfo oInfo = new ProcessStartInfo(sBat);
            oInfo.UseShellExecute = false;
            oInfo.CreateNoWindow = true;
            //clsUteis.iIDTaskill = Process.Start(oInfo).Id;
            Process.Start(oInfo).WaitForExit();
        }
    }
}
