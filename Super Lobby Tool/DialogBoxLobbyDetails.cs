using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Overlay.Hook.Lobby;

namespace SuperLobbyTool
{
	// Token: 0x0200000C RID: 12
	public partial class DialogBoxLobbyDetails : Form
	{
		// Token: 0x06000052 RID: 82 RVA: 0x000062BF File Offset: 0x000044BF
		public DialogBoxLobbyDetails(ulong lobbyId)
		{
			this.InitializeComponent();
			this.lobbyId = lobbyId;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000062D4 File Offset: 0x000044D4
		private void DialogBoxLobbyDetails_Shown(object sender, EventArgs e)
		{
			base.Update();
			this.ButtonRefresh_Click(null, null);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000062E4 File Offset: 0x000044E4
		private void ButtonViewProfile_Click(object sender, EventArgs e)
		{
			foreach (object obj in this.ListViewPlayers.SelectedIndices)
			{
				int num = (int)obj;
				MainForm.ViewProfile(SteamData.PlayerList[num].steamId);
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00006350 File Offset: 0x00004550
		private void ButtonRefresh_Click(object sender, EventArgs e)
		{
			this.ButtonRefresh.Enabled = false;
			this.ButtonRefresh.Text = "Refreshing...";
			this.ButtonRefresh.Update();
			int checkResult = SteamData.CheckLobby(this.lobbyId);
			MainForm.AllLobbiesUI.UpdateStatic();
			this.ButtonRefresh.Enabled = true;
			this.ButtonRefresh.Text = "Refresh";
			switch (checkResult)
			{
			case -2:
				base.Close();
				return;
			case -1:
				base.Close();
				return;
			case 0:
				DebugTools.Print("Warning: Will not retrieve lobby details.");
				MessageBox.Show("You are already in this lobby.", "Lobby details unneccesary.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				base.Close();
				return;
			case 1:
				MessageBox.Show("This lobby no longer exists.", "Could not retrieve details.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				base.Close();
				return;
			default:
			{
				SteamData.Lobby lobby = SteamData.LobbyList[SteamData.GetLobbyIndex(this.lobbyId)];
				this.InfoTabUpdate(lobby, checkResult);
				this.HostDetailsTabUpdate(lobby, checkResult);
				this.PlayerTabUpdate(checkResult);
				return;
			}
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000644C File Offset: 0x0000464C
		private void InfoTabUpdate(SteamData.Lobby Lobby, int CheckResult)
		{
			if (CheckResult != 2 || !InternalConfig.Restricted)
			{
				this.LabelIdValue.Text = Lobby.id.ToString();
			}
			else
			{
				this.LabelIdValue.Text = "Private";
			}
			this.LabelTypeValue.Text = SteamData.lobbyTypes[(int)Lobby.typeId];
			this.LabelCreatorValue.Text = Lobby.creator;
			this.LabelPlayerCountValue.Text = Lobby.playerCount.ToString();
			if (Lobby.state != 4)
			{
				this.LabelActivityValue.Text = SteamData.GetActivity(Lobby);
				this.LabelEventValue.Text = PlayerTable.GetEvent(Lobby.typeId, Lobby.matchModeId, false);
				string[] array = PlayerTable.GetTrack(Lobby.typeId, Lobby.matchModeId, false).Split(" ".ToCharArray(), 2);
				this.LabelTrack.Text = array[0];
				this.LabelTrackValue.Text = array[1];
				this.LabelDifficultyValue.Text = PlayerTable.GetDifficulty(Lobby.difficultyId, false);
				return;
			}
			this.LabelActivityValue.Text = "Unknown";
			this.LabelEventValue.Text = "Unknown";
			this.LabelTrackValue.Text = "Unknown";
			this.LabelDifficultyValue.Text = "Unknown";
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000065A0 File Offset: 0x000047A0
		private void HostDetailsTabUpdate(SteamData.Lobby Lobby, int CheckResult)
		{
			this.LabelHostNameValue.Text = SteamData.LobbyHost.name;
			if (CheckResult != 2 || !InternalConfig.Restricted)
			{
				this.LabelHostSteamIdValue.Text = SteamData.LobbyHost.steamId.ToString();
			}
			else
			{
				this.LabelHostSteamIdValue.Text = "Private";
			}
			this.LabelSLTProtectedValue.Text = (Lobby.SLTProtected ? "Yes" : "No");
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00006618 File Offset: 0x00004818
		private void PlayerTabUpdate(int CheckResult)
		{
			this.ListViewPlayers.Items.Clear();
			foreach (SteamData.Player player in SteamData.PlayerList)
			{
				string[] array = new string[2];
				array[0] = player.name;
				int num = 1;
				ulong steamId = player.steamId;
				array[num] = steamId.ToString();
				ListViewItem listViewItem = new ListViewItem(array);
				if (CheckResult == 2 && InternalConfig.Restricted)
				{
					listViewItem.SubItems[1].Text = "Private";
				}
				if (player.steamId == SteamData.LobbyHost.steamId)
				{
					listViewItem.ForeColor = Color.Magenta;
				}
				else if (CurrentLobbyUI.CheckFriend(player.steamId))
				{
					listViewItem.ForeColor = Color.Green;
				}
				else if (CurrentLobbyUI.CheckBan(player.steamId))
				{
					listViewItem.ForeColor = Color.Red;
				}
				this.ListViewPlayers.Items.Add(listViewItem);
			}
			this.LabelPlayerTotal.Text = "Player Total: " + SteamData.playerCount;
			this.LabelFriends.Text = "Friends: " + SteamData.lobbyFriendCount;
			this.LabelBannedPlayers.Text = "Banned Players: " + SteamData.lobbyBanCount;
			this.ButtonViewProfile.Enabled = (CheckResult != 2 || !InternalConfig.Restricted);
		}

		// Token: 0x04000053 RID: 83
		private ulong lobbyId;
	}
}
