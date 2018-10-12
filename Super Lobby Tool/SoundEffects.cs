using System;
using System.Collections.Generic;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace SuperLobbyTool
{
	// Token: 0x02000013 RID: 19
	internal static class SoundEffects
	{
		// Token: 0x0600006D RID: 109
		[DllImport("winmm.dll")]
		private static extern uint mciSendString(string command, StringBuilder returnValue, int returnLength, IntPtr winHandle);

		// Token: 0x0600006E RID: 110 RVA: 0x0000C82C File Offset: 0x0000AA2C
		public static void UpdateSounds()
		{
			if (SoundEffects.soundTimeout == 0)
			{
				if (SoundEffects.soundQueue.Count > 0)
				{
					try
					{
						DebugTools.Print("Sound Effects: Playing " + SoundEffects.soundQueue[0] + ".wav");
						SoundEffects.filePath = Application.StartupPath + "/sounds/" + SoundEffects.soundQueue[0] + ".wav";
						SoundEffects.soundTimeout = SoundEffects.GetSoundLength(SoundEffects.filePath) / 100 + 1;
						SoundEffects.SoundPlayer.SoundLocation = SoundEffects.filePath;
						SoundEffects.SoundPlayer.Play();
					}
					catch
					{
						DebugTools.Print("Sound Effects: Error playing " + SoundEffects.soundQueue[0] + ".wav, skipping.");
					}
					SoundEffects.soundQueue.RemoveAt(0);
					return;
				}
			}
			else
			{
				SoundEffects.soundTimeout--;
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000C910 File Offset: 0x0000AB10
		public static int GetSoundLength(string fileName)
		{
			StringBuilder stringBuilder = new StringBuilder(32);
			SoundEffects.mciSendString(string.Format("open \"{0}\" type waveaudio alias wave", fileName), null, 0, IntPtr.Zero);
			SoundEffects.mciSendString("status wave length", stringBuilder, stringBuilder.Capacity, IntPtr.Zero);
			SoundEffects.mciSendString("close wave", null, 0, IntPtr.Zero);
			int result = 0;
			int.TryParse(stringBuilder.ToString(), out result);
			return result;
		}

		// Token: 0x040000C5 RID: 197
		private static SoundPlayer SoundPlayer = new SoundPlayer();

		// Token: 0x040000C6 RID: 198
		public static List<string> soundQueue = new List<string>();

		// Token: 0x040000C7 RID: 199
		private static string filePath;

		// Token: 0x040000C8 RID: 200
		private static int soundTimeout = 0;
	}
}
