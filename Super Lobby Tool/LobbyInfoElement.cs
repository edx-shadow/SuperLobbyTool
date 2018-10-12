using System;
using System.Configuration;

namespace SuperLobbyTool
{
	// Token: 0x02000027 RID: 39
	public class LobbyInfoElement : ConfigurationElementEx
	{
		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600011F RID: 287 RVA: 0x00016A9C File Offset: 0x00014C9C
		// (set) Token: 0x06000120 RID: 288 RVA: 0x00016AD4 File Offset: 0x00014CD4
		[ConfigurationProperty("ShortNames", DefaultValue = false)]
		public bool ShortNames
		{
			get
			{
				bool result;
				try
				{
					result = (bool)base["ShortNames"];
				}
				catch
				{
					result = false;
				}
				return result;
			}
			set
			{
				base["ShortNames"] = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000121 RID: 289 RVA: 0x00016AE8 File Offset: 0x00014CE8
		[ConfigurationProperty("Basic")]
		public LobbyBasicElement Basic
		{
			get
			{
				LobbyBasicElement lobbyBasicElement = base["Basic"] as LobbyBasicElement;
				if (lobbyBasicElement != null)
				{
					return lobbyBasicElement;
				}
				return new LobbyBasicElement();
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000122 RID: 290 RVA: 0x00016B10 File Offset: 0x00014D10
		[ConfigurationProperty("MatchMode")]
		public LobbyMatchModeElement MatchMode
		{
			get
			{
				LobbyMatchModeElement lobbyMatchModeElement = base["MatchMode"] as LobbyMatchModeElement;
				if (lobbyMatchModeElement != null)
				{
					return lobbyMatchModeElement;
				}
				return new LobbyMatchModeElement();
			}
		}
	}
}
