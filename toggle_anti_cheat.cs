using System;
using System.IO;
using System.Windows.Forms;
using System.Reflection;

[assembly: AssemblyTitle("Elden Ring Mod Toggler")]
[assembly: AssemblyDescription("Toggles Anti-Cheat for offline modding")]
[assembly: AssemblyCompany("NexusMods Community")]
[assembly: AssemblyProduct("Elden Ring Toggler")]
[assembly: AssemblyCopyright("Copyright 2026")]
[assembly: AssemblyFileVersion("1.0.0.0")]

class toggle_anti_cheat {
    static void Main() {
        string eacLauncher = "start_protected_game.exe";
        string eacBackup = "start_protected_game-old.exe";
        string gameExe = "eldenring.exe";

        try {
            if (File.Exists(eacBackup)) {
                
                if (File.Exists(eacLauncher)) {
                    File.Delete(eacLauncher);
                }
                
                File.Move(eacBackup, eacLauncher);
                
                MessageBox.Show("Anti-Cheat ENABLED", "Elden Ring Toggler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (File.Exists(eacLauncher) && File.Exists(gameExe)) {
                
                File.Move(eacLauncher, eacBackup);
                
                File.Copy(gameExe, eacLauncher);
                
                MessageBox.Show("Anti-Cheat DISABLED", "Elden Ring Toggler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show("Required files not found! Make sure this .exe is inside your Elden Ring 'Game' folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
        catch (Exception ex) {
            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
