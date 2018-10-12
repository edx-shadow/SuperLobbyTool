using System;
using System.Diagnostics;

namespace SuperLobbyTool
{
	// Token: 0x02000004 RID: 4
	internal static class DebugTools
	{
		// Token: 0x06000012 RID: 18 RVA: 0x00002CE4 File Offset: 0x00000EE4
		public static void Write(string text)
		{
			Debug.Write("[" + DateTime.Now.ToString(DebugTools.dateFormat) + "] " + text);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002D18 File Offset: 0x00000F18
		public static void Print(string text)
		{
			Debug.Print("[" + DateTime.Now.ToString(DebugTools.dateFormat) + "] " + text);
		}

		// Token: 0x04000016 RID: 22
		private static string dateFormat = "yyyy-MM-dd HH:mm:ss.fff";
	}
}
