using System;
using System.Configuration;

namespace SuperLobbyTool
{
	// Token: 0x02000020 RID: 32
	public class PlayerElement : ConfigurationElementEx
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x00016638 File Offset: 0x00014838
		// (set) Token: 0x060000FA RID: 250 RVA: 0x00016674 File Offset: 0x00014874
		[ConfigurationProperty("Name", DefaultValue = "")]
		public string Name
		{
			get
			{
				string result;
				try
				{
					result = (string)base["Name"];
				}
				catch
				{
					result = "";
				}
				return result;
			}
			set
			{
				base["Name"] = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060000FB RID: 251 RVA: 0x00016684 File Offset: 0x00014884
		// (set) Token: 0x060000FC RID: 252 RVA: 0x000166BC File Offset: 0x000148BC
		[ConfigurationProperty("SteamId", DefaultValue = 0UL)]
		public ulong SteamId
		{
			get
			{
				ulong result;
				try
				{
					result = (ulong)base["SteamId"];
				}
				catch
				{
					result = 0UL;
				}
				return result;
			}
			set
			{
				base["SteamId"] = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060000FD RID: 253 RVA: 0x000166D0 File Offset: 0x000148D0
		// (set) Token: 0x060000FE RID: 254 RVA: 0x000165FC File Offset: 0x000147FC
		[ConfigurationProperty("Enabled", DefaultValue = true)]
		public bool Enabled
		{
			get
			{
				bool result;
				try
				{
					result = (bool)base["Enabled"];
				}
				catch
				{
					result = true;
				}
				return result;
			}
			set
			{
				base["Enabled"] = value;
			}
		}
	}
}
