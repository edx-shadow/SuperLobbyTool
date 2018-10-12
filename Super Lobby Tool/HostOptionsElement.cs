using System;
using System.Configuration;

namespace SuperLobbyTool
{
	// Token: 0x0200001E RID: 30
	public class HostOptionsElement : ConfigurationElementEx
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00016524 File Offset: 0x00014724
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x0001655C File Offset: 0x0001475C
		[ConfigurationProperty("SkipLobbySearch", DefaultValue = false)]
		public bool SkipLobbySearch
		{
			get
			{
				bool result;
				try
				{
					result = (bool)base["SkipLobbySearch"];
				}
				catch
				{
					result = true;
				}
				return result;
			}
			set
			{
				base["SkipLobbySearch"] = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x00016570 File Offset: 0x00014770
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x000165A8 File Offset: 0x000147A8
		[ConfigurationProperty("DisableMirrorTracks", DefaultValue = false)]
		public bool DisableMirrorTracks
		{
			get
			{
				bool result;
				try
				{
					result = (bool)base["DisableMirrorTracks"];
				}
				catch
				{
					result = true;
				}
				return result;
			}
			set
			{
				base["DisableMirrorTracks"] = value;
			}
		}
	}
}
