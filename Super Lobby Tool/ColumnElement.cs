using System;
using System.Configuration;
using System.Drawing;
using Overlay.Interface;

namespace SuperLobbyTool
{
	// Token: 0x0200002C RID: 44
	public class ColumnElement : ConfigurationElementEx
	{
		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600013A RID: 314 RVA: 0x00016DBC File Offset: 0x00014FBC
		// (set) Token: 0x0600013B RID: 315 RVA: 0x000165FC File Offset: 0x000147FC
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

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600013C RID: 316 RVA: 0x00016DF4 File Offset: 0x00014FF4
		// (set) Token: 0x0600013D RID: 317 RVA: 0x00016E2C File Offset: 0x0001502C
		[ConfigurationProperty("Width", DefaultValue = 0)]
		public int Width
		{
			get
			{
				int result;
				try
				{
					result = (int)base["Width"];
				}
				catch
				{
					result = 0;
				}
				return result;
			}
			set
			{
				base["Width"] = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600013E RID: 318 RVA: 0x00016E40 File Offset: 0x00015040
		// (set) Token: 0x0600013F RID: 319 RVA: 0x00016E78 File Offset: 0x00015078
		[ConfigurationProperty("Data", DefaultValue = DataSourceEnum.Nothing)]
		public DataSourceEnum Data
		{
			get
			{
				DataSourceEnum result;
				try
				{
					result = (DataSourceEnum)base["Data"];
				}
				catch
				{
					result = DataSourceEnum.Nothing;
				}
				return result;
			}
			set
			{
				base["Data"] = value;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000140 RID: 320 RVA: 0x00016E8C File Offset: 0x0001508C
		// (set) Token: 0x06000141 RID: 321 RVA: 0x00016EC4 File Offset: 0x000150C4
		[ConfigurationProperty("ShowHeader")]
		public bool ShowHeader
		{
			get
			{
				bool result;
				try
				{
					result = (bool)base["ShowHeader"];
				}
				catch
				{
					result = true;
				}
				return result;
			}
			set
			{
				base["ShowHeader"] = value;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000142 RID: 322 RVA: 0x00016ED8 File Offset: 0x000150D8
		// (set) Token: 0x06000143 RID: 323 RVA: 0x00016F14 File Offset: 0x00015114
		[ConfigurationProperty("HeaderColour")]
		public Color HeaderColour
		{
			get
			{
				Color result;
				try
				{
					result = (Color)base["HeaderColour"];
				}
				catch
				{
					result = Color.Purple;
				}
				return result;
			}
			set
			{
				base["HeaderColour"] = value;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000144 RID: 324 RVA: 0x00016F28 File Offset: 0x00015128
		// (set) Token: 0x06000145 RID: 325 RVA: 0x00016F64 File Offset: 0x00015164
		[ConfigurationProperty("DataColour")]
		public Color DataColour
		{
			get
			{
				Color result;
				try
				{
					result = (Color)base["DataColour"];
				}
				catch
				{
					result = Color.Purple;
				}
				return result;
			}
			set
			{
				base["DataColour"] = value;
			}
		}
	}
}
