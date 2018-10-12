using System;
using System.Configuration;

namespace SuperLobbyTool
{
	// Token: 0x02000026 RID: 38
	public class AdditionalElement : ConfigurationElementEx
	{
		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600011B RID: 283 RVA: 0x00016A24 File Offset: 0x00014C24
		[ConfigurationProperty("LobbyInfo")]
		public LobbyInfoElement LobbyInfo
		{
			get
			{
				LobbyInfoElement lobbyInfoElement = base["LobbyInfo"] as LobbyInfoElement;
				if (lobbyInfoElement != null)
				{
					return lobbyInfoElement;
				}
				return new LobbyInfoElement();
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00016A4C File Offset: 0x00014C4C
		[ConfigurationProperty("PlayerName")]
		public PlayerNameElement PlayerName
		{
			get
			{
				PlayerNameElement playerNameElement = base["PlayerName"] as PlayerNameElement;
				if (playerNameElement != null)
				{
					return playerNameElement;
				}
				return new PlayerNameElement();
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600011D RID: 285 RVA: 0x00016A74 File Offset: 0x00014C74
		[ConfigurationProperty("Character")]
		public CharacterElement Character
		{
			get
			{
				CharacterElement characterElement = base["Character"] as CharacterElement;
				if (characterElement != null)
				{
					return characterElement;
				}
				return new CharacterElement();
			}
		}
	}
}
