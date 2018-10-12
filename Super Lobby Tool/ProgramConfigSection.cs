using System;
using System.Configuration;

namespace SuperLobbyTool
{
	// Token: 0x0200001D RID: 29
	public class ProgramConfigSection : ConfigurationSectionEx
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x060000EB RID: 235 RVA: 0x0001647C File Offset: 0x0001467C
		[ConfigurationProperty("HostOptions")]
		public HostOptionsElement HostOptions
		{
			get
			{
				HostOptionsElement hostOptionsElement = base["HostOptions"] as HostOptionsElement;
				if (hostOptionsElement != null)
				{
					return hostOptionsElement;
				}
				return new HostOptionsElement();
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x060000EC RID: 236 RVA: 0x000164A4 File Offset: 0x000146A4
		[ConfigurationProperty("Banlist")]
		public PlayerListElement Banlist
		{
			get
			{
				PlayerListElement playerListElement = base["Banlist"] as PlayerListElement;
				if (playerListElement != null)
				{
					return playerListElement;
				}
				return new PlayerListElement();
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x060000ED RID: 237 RVA: 0x000164CC File Offset: 0x000146CC
		[ConfigurationProperty("Whitelist")]
		public PlayerListElement Whitelist
		{
			get
			{
				PlayerListElement playerListElement = base["Whitelist"] as PlayerListElement;
				if (playerListElement != null)
				{
					return playerListElement;
				}
				return new PlayerListElement();
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x060000EE RID: 238 RVA: 0x000164F4 File Offset: 0x000146F4
		[ConfigurationProperty("Overlay")]
		public OverlayElement Overlay
		{
			get
			{
				OverlayElement overlayElement = base["Overlay"] as OverlayElement;
				if (overlayElement != null)
				{
					return overlayElement;
				}
				return new OverlayElement();
			}
		}
	}
}
