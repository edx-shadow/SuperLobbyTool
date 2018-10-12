using System;
using System.Configuration;

namespace SuperLobbyTool
{
	// Token: 0x0200002B RID: 43
	public class CharacterElement : ConfigurationElementEx
	{
		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000137 RID: 311 RVA: 0x00016D84 File Offset: 0x00014F84
		// (set) Token: 0x06000138 RID: 312 RVA: 0x00016AD4 File Offset: 0x00014CD4
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
