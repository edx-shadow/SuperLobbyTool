using System;
using System.Configuration;

namespace SuperLobbyTool
{
	// Token: 0x02000029 RID: 41
	public class LobbyMatchModeElement : ConfigurationElementEx
	{
		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600012D RID: 301 RVA: 0x00016C68 File Offset: 0x00014E68
		// (set) Token: 0x0600012E RID: 302 RVA: 0x00016CA0 File Offset: 0x00014EA0
		[ConfigurationProperty("Event", DefaultValue = true)]
		public bool Event
		{
			get
			{
				bool result;
				try
				{
					result = (bool)base["Event"];
				}
				catch
				{
					result = true;
				}
				return result;
			}
			set
			{
				base["Event"] = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600012F RID: 303 RVA: 0x00016CB4 File Offset: 0x00014EB4
		// (set) Token: 0x06000130 RID: 304 RVA: 0x00016CEC File Offset: 0x00014EEC
		[ConfigurationProperty("Track", DefaultValue = true)]
		public bool Track
		{
			get
			{
				bool result;
				try
				{
					result = (bool)base["Track"];
				}
				catch
				{
					result = true;
				}
				return result;
			}
			set
			{
				base["Track"] = value;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000131 RID: 305 RVA: 0x00016D00 File Offset: 0x00014F00
		// (set) Token: 0x06000132 RID: 306 RVA: 0x00016D38 File Offset: 0x00014F38
		[ConfigurationProperty("Difficulty", DefaultValue = false)]
		public bool Difficulty
		{
			get
			{
				bool result;
				try
				{
					result = (bool)base["Difficulty"];
				}
				catch
				{
					result = false;
				}
				return result;
			}
			set
			{
				base["Difficulty"] = value;
			}
		}
	}
}
