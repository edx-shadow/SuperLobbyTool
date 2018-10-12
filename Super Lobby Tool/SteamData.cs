using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SuperLobbyTool
{
	// Token: 0x02000014 RID: 20
	public static class SteamData
	{
		// Token: 0x06000071 RID: 113 RVA: 0x0000C993 File Offset: 0x0000AB93
		public static void Init()
		{
			DebugTools.Print("Startup: Initialising Steam data.");
			SteamData.GetFriendList();
			if (SteamData.errorCode == 0)
			{
				SteamData.GetLobbyList();
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000C9B0 File Offset: 0x0000ABB0
		public static string[] GetData(string args, string friendlyName)
		{
			DebugTools.Print("Steam Data: Retrieving...");
			string[] array = SteamData.CaptureConsoleOutput("Steam Communicator.exe", args).Split(new string[]
			{
				"\r\n"
			}, StringSplitOptions.None);
			SteamData.errorCode = Convert.ToInt32(array[0]);
			if (SteamData.errorCode > 0)
			{
				SteamData.errorCode = 0;
			}
			if (SteamData.errorCode == 0)
			{
				DebugTools.Print("Steam Data: Retrieved " + friendlyName + ".");
				MainForm.Message("Successfully retrieved " + friendlyName + ".", 50);
				return array;
			}
			DebugTools.Write("Steam Data: Failed to retrieve data, ");
			if (SteamData.errorCode == -1)
			{
				Debug.Print("Steam is not running.");
				MessageBox.Show("Steam is not running.", "Could not retrieve data.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			else if (SteamData.errorCode == -2)
			{
				Debug.Print("timed out.");
				MessageBox.Show("Steam did not respond within 5 seconds.", "Could not retireve data.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			return null;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000CA90 File Offset: 0x0000AC90
		public static void GetLobbyList()
		{
			string[] data = SteamData.GetData("lobbylist", "lobby list");
			if (data != null)
			{
				SteamData.ProcessLobbyList(data);
				return;
			}
			SteamData.LobbyList = new SteamData.Lobby[0];
			SteamData.lobbyCount = 0;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000CAC8 File Offset: 0x0000ACC8
		public static void GetLobbyPlayers(ulong lobbyId)
		{
			string[] data = SteamData.GetData("playerlist " + lobbyId, "lobby players");
			if (data != null)
			{
				SteamData.ProcessPlayerList(data);
				return;
			}
			SteamData.PlayerList = new SteamData.Player[0];
			SteamData.playerCount = 0;
			SteamData.lobbyFriendCount = 0;
			SteamData.lobbyBanCount = 0;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000CB18 File Offset: 0x0000AD18
		public static void GetFriendList()
		{
			string[] data = SteamData.GetData("friendlist", "friend list");
			if (data != null)
			{
				SteamData.ProcessFriendList(data);
				return;
			}
			SteamData.FriendList = new SteamData.Player[0];
			SteamData.friendCount = 0;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000CB50 File Offset: 0x0000AD50
		private static void ProcessFriendList(string[] lines)
		{
			DebugTools.Write("Steam Data: Processing friends list... ");
			SteamData.friendCount = Convert.ToInt32(lines[0]);
			SteamData.FriendList = new SteamData.Player[SteamData.friendCount];
			for (int i = 0; i < SteamData.friendCount; i++)
			{
				SteamData.FriendList[i] = new SteamData.Player
				{
					steamId = Convert.ToUInt64(lines[2 * i + 1]),
					name = lines[2 * i + 2]
				};
			}
			Debug.Print("done.");
			DebugTools.Print("Steam Data: Got " + SteamData.friendCount + " friends.");
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000CBF0 File Offset: 0x0000ADF0
		private static void ProcessPlayerList(string[] lines)
		{
			DebugTools.Write("Steam Data: Processing player list... ");
			SteamData.playerCount = Convert.ToInt32(lines[0]);
			SteamData.LobbyHost.steamId = Convert.ToUInt64(lines[1]);
			SteamData.LobbyHost.name = lines[2];
			SteamData.PlayerList = new SteamData.Player[SteamData.playerCount];
			SteamData.lobbyFriendCount = 0;
			SteamData.lobbyBanCount = 0;
			for (int i = 0; i < SteamData.playerCount; i++)
			{
				SteamData.PlayerList[i] = new SteamData.Player
				{
					steamId = Convert.ToUInt64(lines[2 * i + 3]),
					name = lines[2 * i + 4]
				};
				if (MainForm.BanlistUI.SearchList(SteamData.PlayerList[i]))
				{
					SteamData.lobbyBanCount++;
				}
				if (Array.IndexOf<SteamData.Player>(SteamData.FriendList, SteamData.PlayerList[i]) != -1)
				{
					SteamData.lobbyFriendCount++;
				}
			}
			Debug.Print("done.");
			DebugTools.Print("Steam Data: Processed " + SteamData.playerCount + " players.");
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000CD08 File Offset: 0x0000AF08
		private static void ProcessLobbyList(string[] lines)
		{
			DebugTools.Write("Steam Data: Processing lobby list... ");
			SteamData.lobbyCount = Convert.ToInt32(lines[0]);
			SteamData.LobbyList = new SteamData.Lobby[SteamData.lobbyCount];
			for (int i = 0; i < SteamData.lobbyCount; i++)
			{
				SteamData.Lobby lobby = new SteamData.Lobby
				{
					id = Convert.ToUInt64(lines[6 * i + 1]),
					creator = lines[6 * i + 2],
					typeId = Convert.ToByte(lines[6 * i + 3]),
					playerCount = Convert.ToByte(lines[6 * i + 4]),
					SLTProtected = (Convert.ToByte(lines[6 * i + 5]) > 10)
				};
				byte[] array = SteamData.DecodeInfo(lines[6 * i + 6]);
				if (array.Length != 0)
				{
					lobby.matchModeId = SteamData.ExtractByte(array, 8);
					lobby.raceProgress = SteamData.ExtractByte(array, 77);
					lobby.countdown = Convert.ToByte(SteamData.ExtractByte(array, 60) & 63);
					lobby.state = Convert.ToByte(SteamData.ExtractByte(array, 22) & 3);
					lobby.difficultyId = Convert.ToByte(SteamData.ExtractByte(array, 62) & 3);
				}
				else
				{
					lobby.state = 4;
				}
				SteamData.LobbyList[i] = lobby;
			}
			Debug.Print("done.");
			DebugTools.Print("Steam Data: Got " + SteamData.lobbyCount + " lobbies.");
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000CE5C File Offset: 0x0000B05C
		private static string CaptureConsoleOutput(string exeName, string args)
		{
			string result;
			using (Process process = new Process())
			{
				process.StartInfo.FileName = exeName;
				process.StartInfo.UseShellExecute = false;
				process.StartInfo.RedirectStandardOutput = true;
				process.StartInfo.CreateNoWindow = true;
				process.StartInfo.Arguments = args;
				process.Start();
				string text = process.StandardOutput.ReadToEnd();
				process.WaitForExit();
				result = text;
			}
			return result;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000CEE4 File Offset: 0x0000B0E4
		public static int CheckLobby(ulong Id)
		{
			DebugTools.Print("Begin lobby Check (" + Id + ")");
			SteamData.GetLobbyList();
			int lobbyIndex = SteamData.GetLobbyIndex(Id);
			if (lobbyIndex == -1)
			{
				DebugTools.Print("Lobby Check: The lobby does not exist.");
				return 1;
			}
			if (Id == GameData.lobbyId && GameData.onlinePlayerCount > 0)
			{
				DebugTools.Print("Lobby Check: You are in this lobby.");
				return 0;
			}
			SteamData.GetLobbyPlayers(Id);
			if (SteamData.playerCount < 0)
			{
				return SteamData.playerCount;
			}
			DebugTools.Write("Lobby Check: ");
			if (SteamData.lobbyFriendCount == 0 && SteamData.LobbyList[lobbyIndex].typeId == 3)
			{
				Debug.Print("You do not have permission to join this lobby.");
				return 2;
			}
			if (SteamData.lobbyBanCount > 0)
			{
				Debug.Print("This lobby contains a banned player.");
				return 3;
			}
			Debug.Print("No issues.");
			return 4;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000CFA8 File Offset: 0x0000B1A8
		private static byte[] DecodeInfo(string encodedInfo)
		{
			byte[] array = new byte[encodedInfo.Length / 4 * 3];
			for (int i = 0; i < encodedInfo.Length; i += 4)
			{
				int num = 0;
				for (int j = i; j < i + 4; j++)
				{
					num *= 64;
					int num2 = Array.IndexOf<char>(SteamData.characters, encodedInfo[j]);
					if (num2 != -1)
					{
						num += num2;
					}
				}
				byte[] bytes = BitConverter.GetBytes(num);
				for (int k = 0; k < 3; k++)
				{
					array[i / 4 * 3 + k] = bytes[2 - k];
				}
			}
			return array;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000D03C File Offset: 0x0000B23C
		public static byte ExtractByte(byte[] bytes, int bitOffset)
		{
			int num = bitOffset / 8;
			return (byte)(BitConverter.ToInt16(new byte[]
			{
				bytes[num + 1],
				bytes[num]
			}, 0) >> 8 - bitOffset % 8);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000D074 File Offset: 0x0000B274
		public static string GetActivity(SteamData.Lobby Lobby)
		{
			if (Lobby.state == 255)
			{
				return "Unknown";
			}
			if (Lobby.state == 0)
			{
				return "Waiting";
			}
			if (Lobby.state == 1)
			{
				return "Waiting (" + Lobby.countdown + "s)";
			}
			if (Lobby.state == 2)
			{
				return "Voting (" + Lobby.countdown + "s)";
			}
			if (Lobby.raceProgress == 0)
			{
				return "Race starting";
			}
			if (Lobby.raceProgress == 100)
			{
				return "Race finishing";
			}
			return "Racing (" + Lobby.raceProgress + "%)";
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000D124 File Offset: 0x0000B324
		public static int GetLobbyIndex(ulong Id)
		{
			for (int i = 0; i < SteamData.LobbyList.Length; i++)
			{
				if (SteamData.LobbyList[i].id == Id)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000D15C File Offset: 0x0000B35C
		public static SteamData.Lobby GetLobby(ulong Id)
		{
			int lobbyIndex = SteamData.GetLobbyIndex(Id);
			if (lobbyIndex > 0)
			{
				return SteamData.LobbyList[lobbyIndex];
			}
			return default(SteamData.Lobby);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000D18C File Offset: 0x0000B38C
		public static void MigrateHost(ulong steamId)
		{
			DebugTools.Print("Steam Data: Migrating host.");
			SteamData.CaptureConsoleOutput("Steam Communicator.exe", string.Concat(new object[]
			{
				"migratehost ",
				GameData.lobbyId,
				" ",
				steamId
			}));
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000D1E0 File Offset: 0x0000B3E0
		public static void SetPlayerLimit(int limit)
		{
			DebugTools.Print("Steam Data: Setting lobby player limit to " + limit + ".");
			SteamData.CaptureConsoleOutput("Steam Communicator.exe", string.Concat(new object[]
			{
				"setplayerlimit ",
				GameData.lobbyId,
				" ",
				limit
			}));
		}

		// Token: 0x040000C9 RID: 201
		public static string[] lobbyTypes = new string[]
		{
			"Matchmaking Race",
			"Matchmaking Arena",
			"Matchmaking Lucky Dip",
			"Custom Game",
			"Unknown"
		};

		// Token: 0x040000CA RID: 202
		private static readonly char[] characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/".ToCharArray();

		// Token: 0x040000CB RID: 203
		public static SteamData.Lobby[] LobbyList = new SteamData.Lobby[0];

		// Token: 0x040000CC RID: 204
		public static SteamData.Player LobbyHost;

		// Token: 0x040000CD RID: 205
		public static SteamData.Player[] PlayerList = new SteamData.Player[0];

		// Token: 0x040000CE RID: 206
		public static SteamData.Player[] FriendList = new SteamData.Player[0];

		// Token: 0x040000CF RID: 207
		public static int lobbyCount = 0;

		// Token: 0x040000D0 RID: 208
		public static int playerCount = 0;

		// Token: 0x040000D1 RID: 209
		public static int friendCount = 0;

		// Token: 0x040000D2 RID: 210
		public static int lobbyFriendCount = 0;

		// Token: 0x040000D3 RID: 211
		public static int lobbyBanCount = 0;

		// Token: 0x040000D4 RID: 212
		public static int errorCode = 0;

		// Token: 0x02000030 RID: 48
		public struct Lobby
		{
			// Token: 0x040001B2 RID: 434
			public ulong id;

			// Token: 0x040001B3 RID: 435
			public string creator;

			// Token: 0x040001B4 RID: 436
			public byte typeId;

			// Token: 0x040001B5 RID: 437
			public byte playerCount;

			// Token: 0x040001B6 RID: 438
			public bool SLTProtected;

			// Token: 0x040001B7 RID: 439
			public byte matchModeId;

			// Token: 0x040001B8 RID: 440
			public byte difficultyId;

			// Token: 0x040001B9 RID: 441
			public byte raceProgress;

			// Token: 0x040001BA RID: 442
			public byte countdown;

			// Token: 0x040001BB RID: 443
			public byte state;
		}

		// Token: 0x02000031 RID: 49
		public struct Player
		{
			// Token: 0x040001BC RID: 444
			public ulong steamId;

			// Token: 0x040001BD RID: 445
			public string name;
		}
	}
}
