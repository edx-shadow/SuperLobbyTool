using System;
using System.IO;
using System.Reflection;

namespace SuperLobbyTool
{
	// Token: 0x0200000E RID: 14
	public static class InternalConfig
	{
		// Token: 0x0600005E RID: 94 RVA: 0x00009064 File Offset: 0x00007264
		public static string GetEmbeddedText(string filename)
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			string name = "SuperLobbyTool.Resources." + filename;
			string result;
			using (Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(name))
			{
				using (StreamReader streamReader = new StreamReader(manifestResourceStream))
				{
					result = streamReader.ReadToEnd();
				}
			}
			return result;
		}

		// Token: 0x04000086 RID: 134
		public static bool Restricted = true;

		// Token: 0x04000087 RID: 135
		public static readonly ulong[] GoldList = new ulong[]
		{
			76561198024504670UL,
			76561198401029844UL,
			76561198021505002UL,
			76561198028822780UL,
			76561198129813529UL,
			76561198024430592UL,
			76561198032041391UL,
			76561197996342971UL,
			76561198071898924UL,
			76561198055432195UL,
			76561197979990639UL,
			76561198118325104UL,
			76561198082983121UL,
			76561198032750811UL,
			76561198184121330UL,
			76561198311652434UL,
			76561198347259925UL,
			76561198082882838UL,
			76561198053280840UL,
			76561198184344869UL,
			76561198053518759UL,
			76561198165462935UL,
			76561198066178024UL,
			76561197990677248UL,
			76561198334737066UL,
			76561198103203780UL,
			76561198115358003UL,
			76561198258104981UL,
			76561198149764395UL,
			76561198011609109UL,
			76561198057874769UL,
			76561198045346411UL,
			76561198029537360UL
		};
	}
}
