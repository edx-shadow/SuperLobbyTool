using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SuperLobbyTool
{
	// Token: 0x02000002 RID: 2
	public class AllLobbiesUI
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public AllLobbiesUI(ListView _ListView, Button _ButtonRefreshList, Button _ButtonJoinLobby, Button _ButtonViewPlayers, Button _ButtonLink, Label _LabelLobbyCount, Label _LabelPlayerCount)
		{
			DebugTools.Print("Startup: Initialising all lobbies user interface.");
			this.ListView = _ListView;
			this.ButtonRefreshList = _ButtonRefreshList;
			this.ButtonJoinLobby = _ButtonJoinLobby;
			this.ButtonViewPlayers = _ButtonViewPlayers;
			this.ButtonLink = _ButtonLink;
			this.LabelLobbyCount = _LabelLobbyCount;
			this.LabelPlayerCount = _LabelPlayerCount;
			this.UpdateStatic();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000020A8 File Offset: 0x000002A8
		public void UpdateStatic()
		{
			DebugTools.Write("All lobbies: Updating user interface static elements... ");
			int num = 0;
			int num2 = -1;
			if (this.ListView.FocusedItem != null)
			{
				num2 = this.ListView.FocusedItem.Index;
			}
			this.ListView.Items.Clear();
			if (SteamData.lobbyCount > 0)
			{
				foreach (SteamData.Lobby lobby in SteamData.LobbyList)
				{
					string[] array = new string[4];
					array[0] = lobby.creator;
					array[1] = SteamData.lobbyTypes[(int)lobby.typeId];
					int num3 = 2;
					byte playerCount = lobby.playerCount;
					array[num3] = playerCount.ToString();
					array[3] = SteamData.GetActivity(lobby);
					ListViewItem listViewItem = new ListViewItem(array);
					if (lobby.SLTProtected)
					{
						listViewItem.ForeColor = Color.Green;
					}
					this.ListView.Items.Add(listViewItem);
					num += (int)lobby.playerCount;
				}
				if (num2 >= 0 && num2 < this.ListView.Items.Count)
				{
					MainForm.ListViewFocus(this.ListView.Items, num2, true);
				}
			}
			this.ButtonJoinLobby.Enabled = (SteamData.lobbyCount > 0);
			this.ButtonViewPlayers.Enabled = (SteamData.lobbyCount > 0);
			this.ButtonLink.Enabled = (SteamData.lobbyCount > 0);
			this.LabelLobbyCount.Text = string.Format("Lobby Total: {0}", (SteamData.errorCode == 0) ? SteamData.lobbyCount.ToString() : "");
			this.LabelPlayerCount.Text = string.Format("Player Total: {0}", (SteamData.errorCode == 0) ? num.ToString() : "");
			Debug.Print("done.");
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002258 File Offset: 0x00000458
		public static void JoinLobby(ulong lobbyId)
		{
			DebugTools.Print("Joining a lobby: " + lobbyId);
			Process.Start("steam://joinlobby/212480/" + lobbyId);
			MainForm.Message("Attempted to join a lobby. ( Id = " + lobbyId + " )", 50);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000022AC File Offset: 0x000004AC
		public static void LaunchGame()
		{
			DebugTools.Print("Launching the game.");
			Process.Start("steam://rungameid/212480");
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000022C4 File Offset: 0x000004C4
		public void RefreshList()
		{
			DebugTools.Print("Request: Refresh all lobbies list.");
			this.ButtonRefreshList.Enabled = false;
			this.ButtonRefreshList.Text = "Refreshing...";
			this.ButtonRefreshList.Update();
			SteamData.GetLobbyList();
			this.UpdateStatic();
			this.ButtonRefreshList.Enabled = true;
			this.ButtonRefreshList.Text = "Refresh List";
			this.ButtonRefreshList.Update();
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002334 File Offset: 0x00000534
		public void ViewLobbyDetails()
		{
			if (this.ListView.FocusedItem != null)
			{
				using (DialogBoxLobbyDetails dialogBoxLobbyDetails = new DialogBoxLobbyDetails(SteamData.LobbyList[this.ListView.FocusedItem.Index].id))
				{
					dialogBoxLobbyDetails.ShowDialog();
				}
			}
			this.UpdateStatic();
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000239C File Offset: 0x0000059C
		public void JoinLobby()
		{
			if (this.ListView.FocusedItem != null)
			{
				DebugTools.Print("Request: Join lobby");
				if (GameMemory.gameHandle == 0)
				{
					DebugTools.Print("Warning: The game is not running. Skip joining lobby.");
					if (MessageBox.Show("You must be ingame to join lobbies.\nDo you want to start the game now?", "Game not running", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						AllLobbiesUI.LaunchGame();
						return;
					}
				}
				else
				{
					this.ButtonJoinLobby.Enabled = false;
					this.ButtonJoinLobby.Text = "Checking lobby...";
					this.ButtonJoinLobby.Update();
					ulong id = SteamData.LobbyList[this.ListView.FocusedItem.Index].id;
					int num = SteamData.CheckLobby(id);
					this.UpdateStatic();
					this.ButtonJoinLobby.Text = "Join Lobby";
					switch (num)
					{
					case 0:
						if (MessageBox.Show("You are already in this lobby!\nDo you want to rejoin?", "Rejoin Lobby", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
						{
							DebugTools.Print("Rejoining the lobby.");
							AllLobbiesUI.JoinLobby(id);
							return;
						}
						break;
					case 1:
						MessageBox.Show("This lobby no longer exists.", "Could not join lobby.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						return;
					case 2:
						DebugTools.Print("Warning: Skip joining lobby.");
						MessageBox.Show("This is a private lobby which contains none of your friends.\nTo join this lobby, please ask a player in the lobby for a lobby/friend invitation.", "Could not join lobby.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						return;
					case 3:
						if (MessageBox.Show("This lobby contains players on your banlist!\nAre you sure you want to join?", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
						{
							DebugTools.Print("Joining anyway...");
							AllLobbiesUI.JoinLobby(id);
							return;
						}
						break;
					default:
						AllLobbiesUI.JoinLobby(id);
						break;
					}
				}
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000024F4 File Offset: 0x000006F4
		public void GetLobbyLink()
		{
			if (this.ListView.FocusedItem != null)
			{
				DebugTools.Print("Checking the lobby...");
				this.ButtonLink.Enabled = false;
				this.ButtonLink.Text = "Checking lobby...";
				this.ButtonLink.Update();
				ulong id = SteamData.LobbyList[this.ListView.FocusedItem.Index].id;
				int num = SteamData.CheckLobby(id);
				this.UpdateStatic();
				this.ButtonLink.Text = "Get Lobby Link";
				if (num == 1)
				{
					MessageBox.Show("This lobby no longer exists.", "Could not get link.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				if (num == 2)
				{
					DebugTools.Print("Warning: Skip generating link.");
					MessageBox.Show("This is a private lobby which contains none of your friends.\nTo get a link, please ask a player in the lobby for a lobby/friend invitation.", "Could not get link.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				DebugTools.Print("Open dialog box: Lobby link (DialogBoxLobbyLink)");
				using (DialogBoxLobbyLink dialogBoxLobbyLink = new DialogBoxLobbyLink())
				{
					dialogBoxLobbyLink.TextBoxLink.Text = "steam://joinlobby/212480/" + id;
					dialogBoxLobbyLink.ShowDialog();
				}
			}
		}

		// Token: 0x04000001 RID: 1
		private ListView ListView;

		// Token: 0x04000002 RID: 2
		private Button ButtonRefreshList;

		// Token: 0x04000003 RID: 3
		private Button ButtonJoinLobby;

		// Token: 0x04000004 RID: 4
		private Button ButtonViewPlayers;

		// Token: 0x04000005 RID: 5
		private Button ButtonLink;

		// Token: 0x04000006 RID: 6
		private Label LabelLobbyCount;

		// Token: 0x04000007 RID: 7
		private Label LabelPlayerCount;
	}
}
