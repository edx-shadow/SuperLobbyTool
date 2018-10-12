using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace SuperLobbyTool
{
	// Token: 0x02000017 RID: 23
	public static class GameData
	{
		// Token: 0x060000CA RID: 202
		[DllImport("kernel32.dll")]
		private static extern bool ReadProcessMemory(int hProcess, int lpBaseAddress, byte[] lpBuffer, int dwSize, int lpNumberOfBytesRead);

		// Token: 0x060000CB RID: 203 RVA: 0x00015B18 File Offset: 0x00013D18
		public static void Init()
		{
			DebugTools.Write("Startup: Initialising game data... ");
			for (byte b = 0; b < 10; b += 1)
			{
				GameData.PlayerList[(int)b].LocalList = new GameData.PlayerLocal[4];
			}
			Debug.Print("done.");
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00015B60 File Offset: 0x00013D60
		public static void Update()
		{
			int gameHandle = GameMemory.gameHandle;
			GameData.addressA1 = GameData.ReadInteger(gameHandle, 15473288);
			GameData.lobbyId = (ulong)GameData.ReadLong(gameHandle, GameData.addressA1 + 760);
			GameData.onlinePlayerCount = GameData.ReadByte(gameHandle, GameData.addressA1 + 1317);
			GameData.youAreHost = (Convert.ToBoolean((int)(GameData.ReadByte(gameHandle, GameData.addressA1 + 1260) & 1)) && GameData.onlinePlayerCount > 0);
			GameData.totalPlayerCount = 0;
			GameData.blockCountOld = GameData.blockCount;
			GameData.blockCount = GameData.ReadInteger(gameHandle, 131064);
			GameData.SLTProtected = (GameData.ReadInteger(gameHandle, 131060) > 10);
			int num = GameData.ReadInteger(gameHandle, GameData.addressA1 + 1376);
			short num2 = GameData.ReadShort(gameHandle, num + 106);
			short num3 = GameData.ReadShort(gameHandle, GameData.addressA1 + 1056108);
			GameData.lobbyTypeId = (byte)((num3 & 63) - 13);
			GameData.matchModeId = (byte)((num3 & 16320) >> 6);
			GameData.difficultyId = (byte)(((int)num3 & 49152) >> 14);
			for (byte b = 0; b < GameData.onlinePlayerCount; b += 1)
			{
				int num4 = GameData.ReadInteger(gameHandle, GameData.addressA1 + 1317 + (int)(4 * b) + 3);
				GameData.PlayerList[(int)b].Ping = GameData.ReadShort(gameHandle, num4 + 12);
				short num5 = GameData.ReadShort(gameHandle, num4 + 106);
				GameData.PlayerList[(int)b].PlayerId = num5;
				GameData.PlayerList[(int)b].LocalCount = GameData.ReadByte(gameHandle, num4 + 9680);
				GameData.totalPlayerCount += GameData.PlayerList[(int)b].LocalCount;
				GameData.PlayerList[(int)b].SteamId = (ulong)GameData.ReadLong(gameHandle, num4 + 11248);
				for (int i = 0; i < (int)GameData.PlayerList[(int)b].LocalCount; i++)
				{
					GameData.PlayerList[(int)b].LocalList[i].Name = GameData.ReadString(gameHandle, num4 + 9688 + 384 * i, 16);
					GameData.PlayerList[(int)b].LocalList[i].Rating = GameData.ReadInteger(gameHandle, num4 + 9688 + 384 * i + 36) / 100000;
					GameData.PlayerList[(int)b].LocalList[i].CharacterId = GameData.ReadByte(gameHandle, num4 + 9688 + 384 * i + 74);
					GameData.PlayerList[(int)b].LocalList[i].Score = GameData.ReadShort(gameHandle, num4 + 9688 + 384 * i + 80);
				}
				if (num5 == num2)
				{
					GameData.Host = GameData.PlayerList[(int)b];
					GameData.hostIndex = b;
				}
			}
			if (GameData.onlinePlayerCount == 0)
			{
				GameData.Host = default(GameData.PlayerOnline);
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00015E57 File Offset: 0x00014057
		public static int GetLobbyTypeAddress()
		{
			return GameData.ReadInteger(GameMemory.gameHandle, 15473288) + 1056108;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00015E70 File Offset: 0x00014070
		public static byte[] ReadBytes(int Handle, int Address, int ByteCount)
		{
			byte[] array = new byte[ByteCount];
			GameData.ReadProcessMemory(Handle, Address, array, ByteCount, 0);
			return array;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00015E90 File Offset: 0x00014090
		public static byte ReadByte(int Handle, int Address)
		{
			return GameData.ReadBytes(Handle, Address, 1)[0];
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00015E9C File Offset: 0x0001409C
		public static short ReadShort(int Handle, int Address)
		{
			return BitConverter.ToInt16(GameData.ReadBytes(Handle, Address, 2), 0);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00015EAC File Offset: 0x000140AC
		public static int ReadInteger(int Handle, int Address)
		{
			return BitConverter.ToInt32(GameData.ReadBytes(Handle, Address, 4), 0);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00015EBC File Offset: 0x000140BC
		public static long ReadLong(int Handle, int Address)
		{
			return BitConverter.ToInt64(GameData.ReadBytes(Handle, Address, 8), 0);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00015ECC File Offset: 0x000140CC
		public static string ReadString(int Handle, int Address, int ByteCount)
		{
			string @string = Encoding.UTF8.GetString(GameData.ReadBytes(Handle, Address, ByteCount));
			if (@string.IndexOf('\0') >= 0)
			{
				return @string.Substring(0, @string.IndexOf('\0'));
			}
			return @string.TrimEnd(new char[]
			{
				"�".ToCharArray()[0]
			});
		}

		// Token: 0x04000187 RID: 391
		public static ulong lobbyId = 0UL;

		// Token: 0x04000188 RID: 392
		public static byte onlinePlayerCount = 0;

		// Token: 0x04000189 RID: 393
		public static byte totalPlayerCount = 0;

		// Token: 0x0400018A RID: 394
		public static bool youAreHost = false;

		// Token: 0x0400018B RID: 395
		public static byte hostIndex = 0;

		// Token: 0x0400018C RID: 396
		public static byte lobbyTypeId = 0;

		// Token: 0x0400018D RID: 397
		public static byte matchModeId = 0;

		// Token: 0x0400018E RID: 398
		public static byte difficultyId = 0;

		// Token: 0x0400018F RID: 399
		public static int blockCount = 0;

		// Token: 0x04000190 RID: 400
		public static int blockCountOld = 0;

		// Token: 0x04000191 RID: 401
		public static bool SLTProtected = false;

		// Token: 0x04000192 RID: 402
		public static GameData.PlayerOnline Host;

		// Token: 0x04000193 RID: 403
		public static GameData.PlayerOnline[] PlayerList = new GameData.PlayerOnline[10];

		// Token: 0x04000194 RID: 404
		public const int pointerA1 = 15473288;

		// Token: 0x04000195 RID: 405
		private static int addressA1;

		// Token: 0x04000196 RID: 406
		private const int offsetB1 = 760;

		// Token: 0x04000197 RID: 407
		private const int offsetB2 = 1260;

		// Token: 0x04000198 RID: 408
		private const int offsetB3 = 1317;

		// Token: 0x04000199 RID: 409
		private const int offsetB4 = 1376;

		// Token: 0x0400019A RID: 410
		private const int offsetB5 = 1056108;

		// Token: 0x0400019B RID: 411
		private const int offsetC1 = 12;

		// Token: 0x0400019C RID: 412
		private const int offsetC2 = 106;

		// Token: 0x0400019D RID: 413
		private const int offsetC3 = 9680;

		// Token: 0x0400019E RID: 414
		private const int offsetC4 = 11248;

		// Token: 0x0400019F RID: 415
		private const int offsetC5 = 9688;

		// Token: 0x040001A0 RID: 416
		private const int offsetD1 = 384;

		// Token: 0x040001A1 RID: 417
		private const int offsetD2 = 36;

		// Token: 0x040001A2 RID: 418
		private const int offsetD3 = 74;

		// Token: 0x040001A3 RID: 419
		private const int offsetD4 = 80;

		// Token: 0x02000032 RID: 50
		public struct PlayerOnline
		{
			// Token: 0x040001BE RID: 446
			public short Ping;

			// Token: 0x040001BF RID: 447
			public short PlayerId;

			// Token: 0x040001C0 RID: 448
			public byte LocalCount;

			// Token: 0x040001C1 RID: 449
			public ulong SteamId;

			// Token: 0x040001C2 RID: 450
			public GameData.PlayerLocal[] LocalList;
		}

		// Token: 0x02000033 RID: 51
		public struct PlayerLocal
		{
			// Token: 0x040001C3 RID: 451
			public string Name;

			// Token: 0x040001C4 RID: 452
			public int Rating;

			// Token: 0x040001C5 RID: 453
			public byte CharacterId;

			// Token: 0x040001C6 RID: 454
			public short Score;
		}
	}
}
