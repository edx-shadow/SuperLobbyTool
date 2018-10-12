using System;
using System.Configuration;

namespace SuperLobbyTool
{
	// Token: 0x02000028 RID: 40
	public class LobbyBasicElement : ConfigurationElementEx
	{
		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000124 RID: 292 RVA: 0x00016B38 File Offset: 0x00014D38
		// (set) Token: 0x06000125 RID: 293 RVA: 0x00016B70 File Offset: 0x00014D70
		[ConfigurationProperty("Id", DefaultValue = false)]
		public bool Id
		{
			get
			{
				bool result;
				try
				{
					result = (bool)base["Id"];
				}
				catch
				{
					result = false;
				}
				return result;
			}
			set
			{
				base["Id"] = value;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000126 RID: 294 RVA: 0x00016B84 File Offset: 0x00014D84
		// (set) Token: 0x06000127 RID: 295 RVA: 0x00016BBC File Offset: 0x00014DBC
		[ConfigurationProperty("Type", DefaultValue = true)]
		public bool Type
		{
			get
			{
				bool result;
				try
				{
					result = (bool)base["Type"];
				}
				catch
				{
					result = true;
				}
				return result;
			}
			set
			{
				base["Type"] = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000128 RID: 296 RVA: 0x00016BD0 File Offset: 0x00014DD0
		// (set) Token: 0x06000129 RID: 297 RVA: 0x00016C08 File Offset: 0x00014E08
		[ConfigurationProperty("Host", DefaultValue = true)]
		public bool Host
		{
			get
			{
				bool result;
				try
				{
					result = (bool)base["Host"];
				}
				catch
				{
					result = true;
				}
				return result;
			}
			set
			{
				base["Host"] = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600012A RID: 298 RVA: 0x00016C1C File Offset: 0x00014E1C
		// (set) Token: 0x0600012B RID: 299 RVA: 0x00016C54 File Offset: 0x00014E54
		[ConfigurationProperty("PlayerCount", DefaultValue = true)]
		public bool PlayerCount
		{
			get
			{
				bool result;
				try
				{
					result = (bool)base["PlayerCount"];
				}
				catch
				{
					result = true;
				}
				return result;
			}
			set
			{
				base["PlayerCount"] = value;
			}
		}
	}
}
