using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using Overlay;
using Overlay.Interface;

namespace SuperLobbyTool
{
	// Token: 0x02000016 RID: 22
	public static class GameMemory
	{
		// Token: 0x060000BA RID: 186
		[DllImport("kernel32")]
		private static extern int OpenProcess(int dwDesiredAccess, int bInheritHandle, int dwProcessId);

		// Token: 0x060000BB RID: 187
		[DllImport("kernel32")]
		private static extern bool WriteProcessMemory(int hProcess, int lpBaseAddress, byte[] lpBuffer, int nSize, int lpNumberOfBytesWritten);

		// Token: 0x060000BC RID: 188 RVA: 0x000150B0 File Offset: 0x000132B0
		public static void UpdateHandle()
		{
			Process[] processesByName = Process.GetProcessesByName("ASN_App_PcDx9_Final");
			if (processesByName.Length != 0)
			{
				if (GameMemory.gameHandle == 0)
				{
					DebugTools.Print("Update handle: Found new game handle.");
					GameMemory.processId = processesByName[0].Id;
					GameMemory.gameHandle = GameMemory.OpenProcess(56, 0, GameMemory.processId);
					DebugTools.Print("Update handle: Will wait " + GameMemory.newHandleTime * 100 + "ms before loading game config.");
				}
			}
			else
			{
				GameMemory.gameHandle = 0;
				GameMemory.processId = 0;
				if (GameMemory._OverlayProcess != null)
				{
					DebugTools.Print("Update handle: Lost game handle.");
					GameMemory.OverlayUnload();
				}
			}
			if (GameMemory.gameHandle > 0)
			{
				GameData.Update();
				if (GameMemory.newHandleTime > 0)
				{
					GameMemory.newHandleTime--;
					if (GameMemory.newHandleTime == 0)
					{
						MainForm.AllLobbiesUI.RefreshList();
						GameData.Update();
						if (SteamData.errorCode == 0 && GameData.youAreHost)
						{
							SteamData.SetPlayerLimit(20);
						}
						GameMemory.ListCheckerLoad();
						GameMemory.FullLobbyFixLoad();
						GameMemory.HostMigrationFixLoad();
						GameMemory.SLTCheckerLoad();
						GameMemory.OptionsUpdate();
						GameMemory.OverlayLoad();
						return;
					}
				}
			}
			else
			{
				GameMemory.newHandleTime = 50;
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000151B4 File Offset: 0x000133B4
		public static void OptionsUpdate()
		{
			if (GameMemory.gameHandle > 0)
			{
				DebugTools.Print("Game Memory: Begin configuration update.");
				if (Program.Config.HostOptions.SkipLobbySearch)
				{
					GameMemory.SetBytes(4759930, GameMemory.bytesSkipSearchEnable);
				}
				else
				{
					GameMemory.SetBytes(4759930, GameMemory.bytesSkipSearchDisable);
				}
				if (Program.Config.HostOptions.DisableMirrorTracks)
				{
					GameMemory.SetBytes(8661919, GameMemory.bytesMirrorDisable);
				}
				else
				{
					GameMemory.SetBytes(8661919, GameMemory.bytesMirrorEnable);
				}
				GameMemory.totalPlayerCount = 0;
				if (Program.Config.Banlist.Enabled)
				{
					GameMemory.ListLoad(Program.Config.Banlist, "banlist", true, 103, 17, 22);
				}
				else
				{
					GameMemory.SetBytes(10193008, new byte[1]);
				}
				if (Program.Config.Whitelist.Enabled)
				{
					GameMemory.SetBytes(10192999, new byte[]
					{
						3
					});
					GameMemory.ListLoad(Program.Config.Whitelist, "whitelist", false, 103, 29, 34);
					return;
				}
				GameMemory.SetBytes(10192999, new byte[]
				{
					4
				});
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000152D4 File Offset: 0x000134D4
		public static void ListCheckerLoad()
		{
			DebugTools.Write("Game Memory: Initialising banlist/whitelist system... ");
			GameMemory.SetBytes(4699264, GameMemory.bytesDetour1);
			GameMemory.SetBytes(4699250, GameMemory.bytesDetour2);
			GameMemory.SetBytes(10192986, GameMemory.bytesListChecker);
			GameMemory.SetBytes(10192993, BitConverter.GetBytes(GameData.GetLobbyTypeAddress()));
			Debug.Print("done.");
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00015336 File Offset: 0x00013536
		public static void FullLobbyFixLoad()
		{
			DebugTools.Write("Game Memory: Applying full lobby fix... ");
			GameMemory.SetBytes(4652369, new byte[]
			{
				20
			});
			GameMemory.SetBytes(4688226, new byte[]
			{
				20
			});
			Debug.Print("done.");
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00015376 File Offset: 0x00013576
		public static void HostMigrationFixLoad()
		{
			DebugTools.Write("Game Memory: Applying host migration fix... ");
			GameMemory.SetBytes(4688306, new byte[]
			{
				3
			});
			Debug.Print("done.");
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000153A0 File Offset: 0x000135A0
		public static void SLTCheckerLoad()
		{
			DebugTools.Write("Game Memory: Initialising the SLT protection checker... ");
			GameMemory.SetBytes(4688654, GameMemory.bytesSLTChecker1);
			GameMemory.SetBytes(10202730, GameMemory.bytesSLTChecker2);
			Debug.Print("done. ");
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000153D4 File Offset: 0x000135D4
		public static void ListLoad(PlayerListElement PlayerList, string listName, bool validation, int listOffset, int listPointerOffset, int countOffset)
		{
			DebugTools.Write("Game Memory: Loading " + listName + " players ... ");
			int num = 10192986 + listOffset + GameMemory.totalPlayerCount * 8;
			int num2 = num;
			int num3 = GameMemory.totalPlayerCount;
			foreach (object obj in PlayerList.Players)
			{
				PlayerElement playerElement = (PlayerElement)obj;
				if ((!validation || Array.IndexOf<ulong>(InternalConfig.GoldList, playerElement.SteamId) == -1) && playerElement.Enabled)
				{
					GameMemory.SetBytes(num2, BitConverter.GetBytes(playerElement.SteamId));
					num2 += 8;
					GameMemory.totalPlayerCount++;
				}
			}
			GameMemory.SetBytes(10192986 + listPointerOffset, BitConverter.GetBytes(num));
			GameMemory.SetBytes(10192986 + countOffset, new byte[]
			{
				Convert.ToByte(GameMemory.totalPlayerCount - num3)
			});
			Debug.Print("done.");
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000154D8 File Offset: 0x000136D8
		public static void OverlayLoad()
		{
			GameMemory.PackageOverlayConfig(Program.Config.Overlay);
			DebugTools.Write("Game Memory: Injecting overlay... ");
			GameMemory._OverlayProcess = new OverlayProcess(GameMemory.processId, GameMemory._OverlayConfigPackage, new DebugMessageEvent(GameMemory.OverlayDebugMessage));
			DebugTools.Print("done.");
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00015528 File Offset: 0x00013728
		public static void OverlayUnload()
		{
			DebugTools.Write("Game Memory: Unloading overlay... ");
			if (GameMemory.gameHandle != 0)
			{
				GameMemory._OverlayProcess.OverlayInterface.Disconnect();
			}
			GameMemory._OverlayProcess = null;
			Debug.Print("done.");
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0001555A File Offset: 0x0001375A
		public static void OverlayUpdateConfig()
		{
			if (GameMemory._OverlayProcess != null)
			{
				GameMemory.PackageOverlayConfig(Program.Config.Overlay);
				GameMemory._OverlayProcess.OverlayInterface.UpdateOverlayConfig(GameMemory._OverlayConfigPackage);
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00015586 File Offset: 0x00013786
		public static void OverlayDebugMessage(DebugMessageEventArgs message)
		{
			DebugTools.Print("Overlay: " + message.Text);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000155A0 File Offset: 0x000137A0
		public static void PackageOverlayConfig(OverlayElement OverlayConfig)
		{
			DebugTools.Write("Game Memory: Packaging overlay configuration... ");
			List<TableStruct> list = new List<TableStruct>();
			List<ColumnStruct> list2 = new List<ColumnStruct>();
			List<int> list3 = new List<int>();
			if (OverlayConfig.Columns.Additional.LobbyInfo.Basic.Id)
			{
				list3.Add(0);
			}
			if (OverlayConfig.Columns.Additional.LobbyInfo.Basic.Type)
			{
				list3.Add(1);
			}
			if (OverlayConfig.Columns.Additional.LobbyInfo.Basic.Host)
			{
				list3.Add(2);
			}
			if (OverlayConfig.Columns.Additional.LobbyInfo.Basic.PlayerCount)
			{
				list3.Add(3);
			}
			int count = list3.Count;
			if (OverlayConfig.Columns.Additional.LobbyInfo.MatchMode.Event)
			{
				list3.Add(4);
			}
			if (OverlayConfig.Columns.Additional.LobbyInfo.MatchMode.Track)
			{
				list3.Add(5);
			}
			if (OverlayConfig.Columns.Additional.LobbyInfo.MatchMode.Difficulty)
			{
				list3.Add(6);
			}
			if (count > 0 && count < list3.Count)
			{
				list3.Insert(count, -1);
			}
			foreach (object obj in OverlayConfig.Columns.ColumnList)
			{
				ColumnElement columnElement = (ColumnElement)obj;
				if (columnElement.Enabled)
				{
					CellStruct[] array = new CellStruct[11];
					CellStruct cellStruct = default(CellStruct);
					cellStruct.BackgroundColour = Color.FromArgb(OverlayConfig.Background.Opacity, OverlayConfig.Background.Colour);
					cellStruct.BackgroundHidden = !OverlayConfig.Background.Enabled;
					cellStruct.BackgroundFitTable = new bool[]
					{
						true,
						true
					};
					cellStruct.Colour = columnElement.HeaderColour;
					cellStruct.Font = OverlayConfig.Fonts.Header;
					int[] array2 = new int[4];
					array2[0] = 5;
					array2[1] = 5;
					cellStruct.Padding = array2;
					cellStruct.ManualDimensions = new Size(columnElement.Width, 0);
					CellStruct cellStruct2 = cellStruct;
					array[0] = cellStruct2;
					cellStruct2.Colour = columnElement.DataColour;
					cellStruct2.Font = OverlayConfig.Fonts.Data;
					for (int i = 1; i < 11; i++)
					{
						array[i] = cellStruct2;
						if (count > 0 && count < list3.Count && columnElement.Data == DataSourceEnum.LobbyInfo && i == count + 1)
						{
							CellStruct[] array3 = array;
							int num = i;
							int[] array4 = new int[4];
							array4[2] = 20;
							array3[num].Padding = array4;
						}
					}
					list2.Add(new ColumnStruct
					{
						DataSource = columnElement.Data,
						HeaderHidden = !columnElement.ShowHeader,
						CellFormats = array
					});
				}
			}
			if (OverlayConfig.Enabled)
			{
				list.Add(new TableStruct
				{
					Position = new Point(OverlayConfig.Position.X, OverlayConfig.Position.Y),
					Transposed = false,
					Columns = new ColumnsStruct
					{
						ColumnList = list2,
						Additional = new AdditionalStruct
						{
							LobbyInfo = list3,
							Ping = new PingStruct
							{
								EnableThresholds = false
							},
							ShortPlayerNames = OverlayConfig.Columns.Additional.PlayerName.ShortNames,
							ShortCharacterNames = OverlayConfig.Columns.Additional.Character.ShortNames,
							ShortLobbyInfoNames = OverlayConfig.Columns.Additional.LobbyInfo.ShortNames
						}
					},
					PlayerOrder = new SortStruct
					{
						DataSource = DataSourceEnum.Rating,
						increasing = false
					},
					Visibility = new bool[]
					{
						false,
						true,
						true,
						true
					},
					CustomRows = new List<CustomRowStruct>(),
					Background = new RectangleStruct
					{
						Hidden = true
					}
				});
			}
			GameMemory._OverlayConfigPackage = new OverlayConfig
			{
				UpdateRate = 500,
				PlayerTables = list
			};
			Debug.Print("done.");
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00015A28 File Offset: 0x00013C28
		public static void SetBytes(int Address, byte[] Bytes)
		{
			GameMemory.WriteProcessMemory(GameMemory.gameHandle, Address, Bytes, Bytes.Length, 0);
		}

		// Token: 0x04000167 RID: 359
		private const int addressSkipSearch = 4759930;

		// Token: 0x04000168 RID: 360
		private const int addressMirror = 8661919;

		// Token: 0x04000169 RID: 361
		private const int addressDetour1 = 4699264;

		// Token: 0x0400016A RID: 362
		private const int addressDetour2 = 4699250;

		// Token: 0x0400016B RID: 363
		private const int addressListChecker = 10192986;

		// Token: 0x0400016C RID: 364
		private const int addressFullLobbyFix1 = 4652369;

		// Token: 0x0400016D RID: 365
		private const int addressFullLobbyFix2 = 4688226;

		// Token: 0x0400016E RID: 366
		private const int addressSLTChecker1 = 4688654;

		// Token: 0x0400016F RID: 367
		private const int addressSLTChecker2 = 10202730;

		// Token: 0x04000170 RID: 368
		private const int addressHostMigrationFix = 4688306;

		// Token: 0x04000171 RID: 369
		private const int offsetListStart = 103;

		// Token: 0x04000172 RID: 370
		private const int offsetBanlistCount = 22;

		// Token: 0x04000173 RID: 371
		private const int offsetWhitelistCount = 34;

		// Token: 0x04000174 RID: 372
		private const int offsetWhitelistToggle = 13;

		// Token: 0x04000175 RID: 373
		private const int offsetLobbyTypePointer = 7;

		// Token: 0x04000176 RID: 374
		private const int offsetBanlistPointer = 17;

		// Token: 0x04000177 RID: 375
		private const int offsetWhitelistPointer = 29;

		// Token: 0x04000178 RID: 376
		private static readonly byte[] bytesDetour1 = new byte[]
		{
			235,
			240,
			144
		};

		// Token: 0x04000179 RID: 377
		private static readonly byte[] bytesDetour2 = new byte[]
		{
			232,
			227,
			211,
			83,
			0,
			85,
			139,
			236,
			235,
			7
		};

		// Token: 0x0400017A RID: 378
		private static readonly byte[] bytesListChecker = new byte[]
		{
			80,
			83,
			81,
			82,
			86,
			138,
			29,
			108,
			218,
			227,
			5,
			192,
			227,
			4,
			49,
			201,
			184,
			0,
			0,
			0,
			0,
			181,
			1,
			128,
			251,
			128,
			117,
			7,
			184,
			0,
			0,
			0,
			0,
			181,
			1,
			128,
			253,
			0,
			116,
			34,
			139,
			116,
			36,
			28,
			139,
			16,
			59,
			150,
			132,
			43,
			0,
			0,
			117,
			11,
			139,
			80,
			4,
			59,
			150,
			136,
			43,
			0,
			0,
			116,
			16,
			254,
			193,
			131,
			192,
			8,
			56,
			233,
			124,
			226,
			128,
			251,
			128,
			117,
			18,
			235,
			5,
			128,
			251,
			128,
			116,
			11,
			198,
			68,
			36,
			32,
			69,
			byte.MaxValue,
			5,
			248,
			byte.MaxValue,
			1,
			0,
			94,
			90,
			89,
			91,
			88,
			195
		};

		// Token: 0x0400017B RID: 379
		private static readonly byte[] bytesSkipSearchEnable = new byte[]
		{
			7
		};

		// Token: 0x0400017C RID: 380
		private static readonly byte[] bytesMirrorDisable = new byte[]
		{
			144,
			144,
			144,
			144,
			144,
			144
		};

		// Token: 0x0400017D RID: 381
		private static readonly byte[] bytesSLTChecker1 = new byte[]
		{
			233,
			87,
			35,
			84,
			0,
			144
		};

		// Token: 0x0400017E RID: 382
		private static readonly byte[] bytesSLTChecker2 = new byte[]
		{
			byte.MaxValue,
			21,
			76,
			180,
			155,
			0,
			80,
			139,
			147,
			240,
			2,
			0,
			0,
			139,
			179,
			244,
			2,
			0,
			0,
			131,
			236,
			8,
			139,
			204,
			137,
			17,
			137,
			113,
			4,
			139,
			16,
			139,
			200,
			139,
			146,
			128,
			0,
			0,
			0,
			byte.MaxValue,
			210,
			163,
			244,
			byte.MaxValue,
			1,
			0,
			88,
			233,
			118,
			220,
			171,
			byte.MaxValue
		};

		// Token: 0x0400017F RID: 383
		private static readonly byte[] bytesSkipSearchDisable = new byte[]
		{
			6
		};

		// Token: 0x04000180 RID: 384
		private static readonly byte[] bytesMirrorEnable = new byte[]
		{
			1,
			5,
			8,
			26,
			197,
			0
		};

		// Token: 0x04000181 RID: 385
		public static OverlayConfig _OverlayConfigPackage;

		// Token: 0x04000182 RID: 386
		public static OverlayProcess _OverlayProcess;

		// Token: 0x04000183 RID: 387
		public static int processId = 0;

		// Token: 0x04000184 RID: 388
		public static int gameHandle = 0;

		// Token: 0x04000185 RID: 389
		public static int newHandleTime = 1;

		// Token: 0x04000186 RID: 390
		public static int totalPlayerCount;
	}
}
