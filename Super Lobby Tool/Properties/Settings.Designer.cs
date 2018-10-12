using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace SuperLobbyTool.Properties
{
	// Token: 0x0200002E RID: 46
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.6.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00016FB2 File Offset: 0x000151B2
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x040001A8 RID: 424
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
