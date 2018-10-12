using System;
using System.Configuration;
using System.Drawing;

namespace SuperLobbyTool
{
	// Token: 0x02000024 RID: 36
	public class FontsElement : ConfigurationElementEx
	{
		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000113 RID: 275 RVA: 0x0001694C File Offset: 0x00014B4C
		// (set) Token: 0x06000114 RID: 276 RVA: 0x0001697F File Offset: 0x00014B7F
		[ConfigurationProperty("Header")]
		public Font Header
		{
			get
			{
				Font font = base["Header"] as Font;
				if (font != null)
				{
					return font;
				}
				return new Font("Lucida Sans Unicode", 26.25f, FontStyle.Bold);
			}
			set
			{
				base["Header"] = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000115 RID: 277 RVA: 0x00016990 File Offset: 0x00014B90
		// (set) Token: 0x06000116 RID: 278 RVA: 0x000169C3 File Offset: 0x00014BC3
		[ConfigurationProperty("Data")]
		public Font Data
		{
			get
			{
				Font font = base["Data"] as Font;
				if (font != null)
				{
					return font;
				}
				return new Font("Courier New", 21.75f, FontStyle.Bold);
			}
			set
			{
				base["Data"] = value;
			}
		}
	}
}
