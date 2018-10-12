using System;
using System.Configuration;

namespace SuperLobbyTool
{
	// Token: 0x0200002A RID: 42
	public class PlayerNameElement : ConfigurationElementEx
	{
		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000134 RID: 308 RVA: 0x00016D4C File Offset: 0x00014F4C
		// (set) Token: 0x06000135 RID: 309 RVA: 0x00016AD4 File Offset: 0x00014CD4
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
	}
}
