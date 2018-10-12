using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace SuperLobbyTool
{
	// Token: 0x02000018 RID: 24
	internal static class Program
	{
		// Token: 0x060000D5 RID: 213 RVA: 0x00015F7C File Offset: 0x0001417C
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			try
			{
				if (Directory.Exists(Application.StartupPath + "/logs"))
				{
					Debug.Listeners.Add(new TextWriterTraceListener(Application.StartupPath + "/logs/" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".txt"));
					Debug.AutoFlush = true;
				}
				DebugTools.Print("Welcome to the Super Lobby Tool.");
				DebugTools.Print(string.Format("This is the {0} version.", InternalConfig.Restricted ? "public" : "full"));
				DebugTools.Print("Startup: Begin!");
				DebugTools.Print("Startup: Loading program configuration.");
				try
				{
					Program.configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
					Program.Config = (Program.configFile.GetSection("ProgramConfig") as ProgramConfigSection);
				}
				catch (Exception ex)
				{
					DebugTools.Print("Startup: Unrecoverable error while reading the configuration file.");
					DebugTools.Print(ex.ToString());
					if (MessageBox.Show("An unrecoverable error occured while reading the configuration file:" + ex.Message + "\n\nThe configuration file cannot be used until this is corrected.\nDo you want to continue startup?", "Error loading configuration.", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.No)
					{
						Environment.Exit(1);
						DebugTools.Print("Closing due to the previous error.");
					}
				}
				if (Program.Config == null)
				{
					DebugTools.Print("Startup: Using default configuration.");
					MessageBox.Show("Configuration file was unreadable, loading an empty configuration.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					Program.Config = new ProgramConfigSection();
					Program.configFile.Sections.Add("ProgramConfig", Program.Config);
				}
				GameData.Init();
				SteamData.Init();
			}
			catch (Exception arg)
			{
				DebugTools.Print("Unexpected error during startup: " + arg);
				MessageBox.Show("An unexpected error has occured during startup:\n\n" + arg + "\n\nSuper Lobby Tool must close now.\nPlease send the latest log file (located in the logs folder) to Tyapp.", "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			try
			{
				Application.Run(new MainForm());
			}
			catch (Exception arg2)
			{
				DebugTools.Print("Unexpected error: " + arg2);
				MessageBox.Show("An unexpected error has occured:\n\n" + arg2 + "\n\nSuper Lobby Tool must close now.\nPlease send the latest log file (located in the logs folder) to Tyapp.", "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			try
			{
				DebugTools.Print("Shutdown: Begin!");
				if (GameMemory._OverlayProcess != null)
				{
					GameMemory.OverlayUnload();
				}
				DebugTools.Write("Shutdown: Saving program configuration... ");
				Program.configFile.Save(ConfigurationSaveMode.Modified);
				Debug.Print("done.");
				DebugTools.Print("Shutdown: Updating encrypted banlist text file.");
				string path = Application.StartupPath + "/banlist_encrypted.txt";
				if (File.Exists(path))
				{
					File.Delete(path);
				}
				string contents = RijndaelManagedEncryption.EncryptRijndael(string.Join("\n", PlayerListUI.TextExport("banlist", Program.Config.Banlist.Players)));
				File.WriteAllText(path, contents);
				DebugTools.Print("Saved to banlist_encrypted.txt");
				DebugTools.Print("Thank you for using Super Lobby Tool. :)");
				Application.Exit();
			}
			catch (Exception arg3)
			{
				DebugTools.Print("Unexpected error during shutdown: " + arg3);
				MessageBox.Show("An unexpected error has occured during shutdown:\n\n" + arg3 + "\n\nPlease send the latest log file (located in the logs folder) to Tyapp.", "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x040001A4 RID: 420
		private static Configuration configFile;

		// Token: 0x040001A5 RID: 421
		public static ProgramConfigSection Config;
	}
}
