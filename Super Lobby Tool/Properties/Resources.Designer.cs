using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace SuperLobbyTool.Properties
{
	// Token: 0x0200002D RID: 45
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x06000147 RID: 327 RVA: 0x00003D76 File Offset: 0x00001F76
		internal Resources()
		{
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000148 RID: 328 RVA: 0x00016F77 File Offset: 0x00015177
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					Resources.resourceMan = new ResourceManager("SuperLobbyTool.Properties.Resources", typeof(Resources).Assembly);
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000149 RID: 329 RVA: 0x00016FA3 File Offset: 0x000151A3
		// (set) Token: 0x0600014A RID: 330 RVA: 0x00016FAA File Offset: 0x000151AA
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x040001A6 RID: 422
		private static ResourceManager resourceMan;

		// Token: 0x040001A7 RID: 423
		private static CultureInfo resourceCulture;
	}
}
