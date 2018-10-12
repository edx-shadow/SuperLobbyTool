using System;
using System.Windows.Forms;
using System.Xml;

namespace SuperLobbyTool
{
	// Token: 0x02000019 RID: 25
	public static class ErrorMessage
	{
		// Token: 0x060000D6 RID: 214 RVA: 0x0001629C File Offset: 0x0001449C
		public static void UnrecognisedConfigOption(string setting, string value)
		{
			DebugTools.Print(string.Concat(new string[]
			{
				"Found an unknown configuration option while reading the config file: ",
				setting,
				" = '",
				value,
				"'"
			}));
			if (MessageBox.Show(string.Concat(new string[]
			{
				"Found an unknown configuration option while reading the config file:\n\n",
				setting,
				" = '",
				value,
				"'\n\nDo you wish to continue startup, with this option being ignored?"
			}), "Error loading configuration.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
			{
				Environment.Exit(0);
				DebugTools.Print("Closing due to the previous error.");
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00016324 File Offset: 0x00014524
		public static void UnrecognisedConfigSection(string section, XmlReader xmlReader)
		{
			DebugTools.Print("Found an unknown configuration section while reading the config file: " + section);
			if (MessageBox.Show(string.Concat(new object[]
			{
				"Found an unknown configuration section while reading the config file:\n\n",
				section,
				" on line ",
				((IXmlLineInfo)xmlReader).LineNumber,
				"\n\nDo you wish to continue startup, with this section being ignored?"
			}), "Error loading configuration.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
			{
				Environment.Exit(0);
				DebugTools.Print("Closing due to the previous error.");
			}
		}
	}
}
