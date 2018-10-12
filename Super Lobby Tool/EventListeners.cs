using System;

namespace SuperLobbyTool
{
	// Token: 0x02000007 RID: 7
	internal static class EventListeners
	{
		// Token: 0x0600001E RID: 30 RVA: 0x00003998 File Offset: 0x00001B98
		public static void Listen()
		{
			EventListeners.ListenLobbyEnter();
			EventListeners.ListenLobbyLeave();
			EventListeners.ListenHostMigration();
			EventListeners.ListenBecomeHost();
			EventListeners.ListenBlockedConnection();
			EventListeners.totalBlockCountOld = EventListeners.totalBlockCount;
			EventListeners.onlinePlayerCountOld = (ulong)GameData.onlinePlayerCount;
			EventListeners.youAreHostOld = GameData.youAreHost;
			EventListeners.hostSteamIdOld = GameData.Host.SteamId;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000039EC File Offset: 0x00001BEC
		private static void ListenLobbyEnter()
		{
			if (EventListeners.onlinePlayerCountOld == 0UL && GameData.onlinePlayerCount > 0)
			{
				DebugTools.Print("Event Listener: Joined a lobby.");
				MainForm.Message("You have joined a lobby.", 50);
				SoundEffects.soundQueue.Add("join");
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003A22 File Offset: 0x00001C22
		private static void ListenLobbyLeave()
		{
			if (EventListeners.onlinePlayerCountOld > 0UL && GameData.onlinePlayerCount == 0)
			{
				MainForm.Message("You have left a lobby.", 50);
				DebugTools.Print("Event Listener: Left a lobby.");
				SoundEffects.soundQueue.Add("leave");
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003A59 File Offset: 0x00001C59
		private static void ListenHostMigration()
		{
			if (GameData.onlinePlayerCount > 0 && GameData.Host.SteamId != EventListeners.hostSteamIdOld && EventListeners.hostSteamIdOld != 0UL)
			{
				DebugTools.Print("Event Listener: Host migration.");
				MainForm.Message("Lobby host has migrated!", 50);
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003A91 File Offset: 0x00001C91
		private static void ListenBecomeHost()
		{
			if (!EventListeners.youAreHostOld && GameData.youAreHost)
			{
				DebugTools.Print("Event Listener: You are now the host.");
				MainForm.Message("You are now the host!", 50);
				SoundEffects.soundQueue.Add("enabledashost");
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003AC6 File Offset: 0x00001CC6
		private static void ListenBlockedConnection()
		{
			if (EventListeners.totalBlockCount > EventListeners.totalBlockCountOld)
			{
				DebugTools.Print("Event Listener: A player connection was blocked.");
				MainForm.Message("A player connection was blocked!", 50);
				SoundEffects.soundQueue.Add("accessdenied");
			}
		}

		// Token: 0x04000026 RID: 38
		public static int totalBlockCount;

		// Token: 0x04000027 RID: 39
		private static int totalBlockCountOld;

		// Token: 0x04000028 RID: 40
		public static ulong onlinePlayerCountOld;

		// Token: 0x04000029 RID: 41
		public static bool youAreHostOld;

		// Token: 0x0400002A RID: 42
		private static ulong hostSteamIdOld;
	}
}
