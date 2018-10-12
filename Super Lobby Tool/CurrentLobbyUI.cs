using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SuperLobbyTool
{
	// Token: 0x02000003 RID: 3
	public class CurrentLobbyUI
	{
		// Token: 0x06000009 RID: 9 RVA: 0x0000260C File Offset: 0x0000080C
		public CurrentLobbyUI(HostOptionsElement _Config, ListView _ListView, CheckBox _CheckBoxForceHost, CheckBox _CheckBoxMirrorTracks, Label _LabelLobbyIdValue, Label _LabelHostValue, Label _LabelPlayerTotalValue, Label _LabelFriendsValue, Label _LabelBannedPlayersValue, Label _LabelSLTProtectedValue, Label _LabelSLTProtected, Button _ButtonAdd, Button _ButtonViewProfile, Button _ButtonMigrateHost)
		{
			DebugTools.Print("Startup: Initialising current lobby user interface.");
			this.Config = _Config;
			this.ListView = _ListView;
			this.CheckBoxForceHost = _CheckBoxForceHost;
			this.CheckBoxMirrorTracks = _CheckBoxMirrorTracks;
			this.LabelLobbyIdValue = _LabelLobbyIdValue;
			this.LabelHostValue = _LabelHostValue;
			this.LabelPlayerTotalValue = _LabelPlayerTotalValue;
			this.LabelFriendsValue = _LabelFriendsValue;
			this.LabelBannedPlayersValue = _LabelBannedPlayersValue;
			this.LabelSLTProtectedValue = _LabelSLTProtectedValue;
			this.LabelSLTProtected = _LabelSLTProtected;
			this.ButtonAdd = _ButtonAdd;
			this.ButtonViewProfile = _ButtonViewProfile;
			this.ButtonMigrateHost = _ButtonMigrateHost;
			this.UpdateStatic();
			this.UpdateActive();
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000026A4 File Offset: 0x000008A4
		public void UpdateStatic()
		{
			DebugTools.Write("Current Lobby: Updating user interface static elements... ");
			this.CheckBoxForceHost.Checked = this.Config.SkipLobbySearch;
			this.CheckBoxMirrorTracks.Checked = this.Config.DisableMirrorTracks;
			Debug.Print("done.");
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000026F4 File Offset: 0x000008F4
		public void UpdateActive()
		{
			int num = this.ListView.Items.Count - 1;
			if ((int)GameData.onlinePlayerCount < this.ListView.Items.Count)
			{
				for (int i = (int)GameData.onlinePlayerCount; i <= num; i++)
				{
					this.ListView.Items.RemoveAt((int)GameData.onlinePlayerCount);
				}
			}
			else if ((int)GameData.onlinePlayerCount > this.ListView.Items.Count)
			{
				for (int j = this.ListView.Items.Count; j <= (int)(GameData.onlinePlayerCount - 1); j++)
				{
					ListViewItem value = new ListViewItem(new string[]
					{
						"",
						"",
						"",
						""
					});
					this.ListView.Items.Add(value);
				}
			}
			if (GameData.onlinePlayerCount > 0)
			{
				int num2 = 0;
				int num3 = 0;
				for (int k = 0; k <= (int)(GameData.onlinePlayerCount - 1); k++)
				{
					this.ListView.Items[k].SubItems[0].Text = GameData.PlayerList[k].LocalList[Math.Max((int)(GameData.PlayerList[k].LocalCount - 1), 0)].Name;
					this.ListView.Items[k].SubItems[1].Text = GameData.PlayerList[k].SteamId.ToString();
					this.ListView.Items[k].SubItems[2].Text = GameData.PlayerList[k].Ping + "ms";
					if (k == (int)GameData.hostIndex)
					{
						this.ListView.Items[k].ForeColor = Color.Magenta;
					}
					else if (CurrentLobbyUI.CheckBan(GameData.PlayerList[k].SteamId))
					{
						num2++;
						this.ListView.Items[k].ForeColor = Color.Red;
					}
					else if (CurrentLobbyUI.CheckFriend(GameData.PlayerList[k].SteamId))
					{
						num3++;
						this.ListView.Items[k].ForeColor = Color.Green;
					}
					else
					{
						this.ListView.Items[k].ForeColor = Color.Black;
					}
				}
				this.LabelLobbyIdValue.Text = GameData.lobbyId.ToString();
				this.LabelHostValue.Text = GameData.Host.LocalList[Math.Max((int)(GameData.Host.LocalCount - 1), 0)].Name;
				this.LabelSLTProtectedValue.Text = (GameData.SLTProtected ? "Yes" : "No");
				this.LabelSLTProtectedValue.ForeColor = (GameData.SLTProtected ? Color.Green : Color.Red);
				this.LabelSLTProtected.ForeColor = (GameData.SLTProtected ? Color.Green : Color.Red);
				this.LabelPlayerTotalValue.Text = GameData.totalPlayerCount.ToString();
				this.LabelFriendsValue.Text = num3.ToString();
				this.LabelBannedPlayersValue.Text = num2.ToString();
				this.ButtonAdd.Enabled = !InternalConfig.Restricted;
				this.ButtonViewProfile.Enabled = true;
				this.ButtonMigrateHost.Enabled = GameData.youAreHost;
				return;
			}
			this.LabelLobbyIdValue.Text = "";
			this.LabelHostValue.Text = "";
			this.LabelSLTProtectedValue.Text = "";
			this.LabelSLTProtected.ForeColor = Color.Black;
			this.LabelFriendsValue.Text = "";
			this.LabelBannedPlayersValue.Text = "";
			this.LabelPlayerTotalValue.Text = "";
			this.ButtonAdd.Enabled = false;
			this.ButtonViewProfile.Enabled = false;
			this.ButtonMigrateHost.Enabled = false;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002B20 File Offset: 0x00000D20
		public static bool CheckFriend(ulong steamId)
		{
			if (SteamData.FriendList != null)
			{
				SteamData.Player[] friendList = SteamData.FriendList;
				for (int i = 0; i < friendList.Length; i++)
				{
					if (friendList[i].steamId == steamId)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002B5C File Offset: 0x00000D5C
		public static bool CheckBan(ulong steamId)
		{
            foreach(IEnumerable enumerator in Program.Config.Banlist.Players)
            {
                //if (((PlayerElement)enumerator.Current).SteamId == steamId)
                if (((PlayerElement)enumerator).SteamId == steamId)
                    {
                    return true;
                }
            }
/*			using (IEnumerator enumerator = Program.Config.Banlist.Players.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (((PlayerElement)enumerator.Current).SteamId == steamId)
					{
						return true;
					}
				}
			}*/
			return false;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002BC8 File Offset: 0x00000DC8
		public void ViewProfile()
		{
			foreach (object obj in this.ListView.SelectedIndices)
			{
				int num = (int)obj;
				MainForm.ViewProfile(GameData.PlayerList[num].SteamId);
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002C34 File Offset: 0x00000E34
		public void MigrateHost()
		{
			if (this.ListView.SelectedIndices.Count == 1)
			{
				SteamData.MigrateHost(GameData.PlayerList[this.ListView.SelectedIndices[0]].SteamId);
				return;
			}
			MessageBox.Show("Please select a single player.", "Multiple Selections", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002C8D File Offset: 0x00000E8D
		public void ToggleSkipLobbySearch()
		{
			DebugTools.Print("Option change: Toggle skip lobby search");
			this.Config.SkipLobbySearch = !this.Config.SkipLobbySearch;
			GameMemory.OptionsUpdate();
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002CB7 File Offset: 0x00000EB7
		public void ToggleMirrorTracks()
		{
			DebugTools.Print("Option change: Toggle mirror tracks");
			this.Config.DisableMirrorTracks = !this.Config.DisableMirrorTracks;
			GameMemory.OptionsUpdate();
		}

		// Token: 0x04000008 RID: 8
		private HostOptionsElement Config;

		// Token: 0x04000009 RID: 9
		private ListView ListView;

		// Token: 0x0400000A RID: 10
		private CheckBox CheckBoxForceHost;

		// Token: 0x0400000B RID: 11
		private CheckBox CheckBoxMirrorTracks;

		// Token: 0x0400000C RID: 12
		private Label LabelLobbyIdValue;

		// Token: 0x0400000D RID: 13
		private Label LabelHostValue;

		// Token: 0x0400000E RID: 14
		private Label LabelPlayerTotalValue;

		// Token: 0x0400000F RID: 15
		private Label LabelFriendsValue;

		// Token: 0x04000010 RID: 16
		private Label LabelBannedPlayersValue;

		// Token: 0x04000011 RID: 17
		private Label LabelSLTProtectedValue;

		// Token: 0x04000012 RID: 18
		private Label LabelSLTProtected;

		// Token: 0x04000013 RID: 19
		private Button ButtonAdd;

		// Token: 0x04000014 RID: 20
		private Button ButtonViewProfile;

		// Token: 0x04000015 RID: 21
		private Button ButtonMigrateHost;
	}
}
