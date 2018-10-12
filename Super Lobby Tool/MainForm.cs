using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace SuperLobbyTool
{
	// Token: 0x02000015 RID: 21
	public partial class MainForm : Form
	{
		// Token: 0x06000083 RID: 131 RVA: 0x0000D2D8 File Offset: 0x0000B4D8
		public MainForm()
		{
			this.InitializeComponent();
			if (InternalConfig.Restricted)
			{
				this.Text += " (Public Edition)";
			}
			else
			{
				this.Text += " (Full Edition)";
			}
			MainForm._StatusBar = this.StatusBar;
			MainForm.CurrentLobbyUI = new CurrentLobbyUI(Program.Config.HostOptions, this.CurrentLobbyListView, this.CurrentLobbyCheckBoxSkipLobbySearch, this.CurrentLobbyCheckBoxDisableMirrorTracks, this.CurrentLobbyLabelLobbyIdValue, this.CurrentLobbyLabelHostValue, this.CurrentLobbyLabelPlayerTotalValue, this.CurrentLobbyLabelFriendsValue, this.CurrentLobbyLabelBannedPlayersValue, this.CurrentLobbyLabelSLTProtectedValue, this.CurrentLobbyLabelSLTProtected, this.CurrentLobbyButtonBan, this.CurrentLobbyButtonViewProfile, this.CurrentLobbyButtonMigrateHost);
			MainForm.AllLobbiesUI = new AllLobbiesUI(this.AllLobbiesListView, this.AllLobbiesButtonRefreshList, this.AllLobbiesButtonJoinLobby, this.AllLobbiesButtonViewPlayers, this.AllLobbiesButtonLink, this.AllLobbiesLabelLobbyCount, this.AllLobbiesLabelPlayerCount);
			MainForm.BanlistUI = new PlayerListUI("banlist", Color.Red, InternalConfig.Restricted, Program.Config.Banlist, this.BanlistListView, this.BanlistCheckBoxEnable, this.BanlistLabelPlayerCount, this.BanlistLabelBlockedConnections, this.BanlistButtonAdd, this.BanlistButtonRemove, this.BanlistButtonEdit, this.BanlistButtonViewProfile, this.BanlistButtonImport, this.BanlistButtonExport);
			MainForm.WhitelistUI = new PlayerListUI("whitelist", Color.Green, false, Program.Config.Whitelist, this.WhitelistListView, this.WhitelistCheckBoxEnable, this.WhitelistLabelPlayerCount, this.WhitelistLabelBlockedConnections, this.WhitelistButtonAdd, this.WhitelistButtonRemove, this.WhitelistButtonEdit, this.WhitelistButtonViewProfile, this.WhitelistButtonImport, this.WhitelistButtonExport);
			MainForm.OverlayUI = new OverlayUI(Program.Config.Overlay, this.OverlayListView, this.OverlayLabelHeaderFontPreview, this.OverlayLabelHeaderFontName, this.OverlayLabelDataFontPreview, this.OverlayLabelDataFontName, this.OverlayLabelBackgroundColourPreview, this.OverlayCheckBoxEnable, this.OverlayCheckBoxBackgroundEnable, this.OverlayNumericUpDownX, this.OverlayNumericUpDownY, this.OverlayTrackBarBackgroundOpacity, this.OverlayButtonEdit, this.OverlayButtonRemove, this.OverlayButtonMoveUp, this.OverlayButtonMoveDown);
			this.AboutTabInitialise();
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000D500 File Offset: 0x0000B700
		private void MainForm_Load(object sender, EventArgs e)
		{
			DebugTools.Write("Startup: Initialising timers... ");
			this._Timer = new Timer
			{
				Interval = this.tickInterval,
				Enabled = true
			};
			this._Timer.Tick += this.UpdateActive;
			Debug.Print("done.");
			DebugTools.Print("Startup: Complete!");
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0000D560 File Offset: 0x0000B760
		private void UpdateActive(object Object, EventArgs myEventArgs)
		{
			GameMemory.UpdateHandle();
			this.UpdateMessage();
			SoundEffects.UpdateSounds();
			if (MainForm.connectionBlockTimeout > 0)
			{
				MainForm.connectionBlockTimeout--;
			}
			MainForm.CurrentLobbyUI.UpdateActive();
			this.BanlistUpdateActive();
			this.WhitelistUpdateActive();
			EventListeners.Listen();
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0000D5AC File Offset: 0x0000B7AC
		public static void ViewProfile(ulong steamId)
		{
			DebugTools.Print("Request: Open profile page for Steam ID " + steamId);
			Process.Start("http://steamcommunity.com/profiles/" + steamId);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000D5D9 File Offset: 0x0000B7D9
		public static void ListViewFocus(ListView.ListViewItemCollection Items, int index, bool focus)
		{
			Items[index].Selected = focus;
			Items[index].Focused = focus;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000D5F5 File Offset: 0x0000B7F5
		public static void Message(string text, int time)
		{
			if (MainForm._StatusBar != null)
			{
				MainForm._StatusBar.Text = "Message: " + text;
				MainForm.messageTimeout = time;
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000D61C File Offset: 0x0000B81C
		private void UpdateMessage()
		{
			if (MainForm.messageTimeout > 0)
			{
				MainForm.messageTimeout--;
			}
			if (MainForm.messageTimeout == 0)
			{
				if (GameData.onlinePlayerCount > 0)
				{
					this.StatusBar.Text = "Important: Your ";
					if (GameData.lobbyTypeId != 3 || !Program.Config.Whitelist.Enabled)
					{
						StatusBar statusBar = this.StatusBar;
						statusBar.Text += "banlist ";
					}
					if (GameData.lobbyTypeId == 3)
					{
						if (!Program.Config.Whitelist.Enabled && !Program.Config.Banlist.Enabled)
						{
							StatusBar statusBar2 = this.StatusBar;
							statusBar2.Text += "and ";
						}
						if (Program.Config.Whitelist.Enabled || !Program.Config.Banlist.Enabled)
						{
							StatusBar statusBar3 = this.StatusBar;
							statusBar3.Text += "whitelist ";
						}
					}
					StatusBar statusBar4 = this.StatusBar;
					statusBar4.Text += "is ";
					if (!GameData.youAreHost || (!Program.Config.Whitelist.Enabled && !Program.Config.Banlist.Enabled) || (GameData.lobbyTypeId != 3 && !Program.Config.Banlist.Enabled))
					{
						StatusBar statusBar5 = this.StatusBar;
						statusBar5.Text += "NOT ";
					}
					StatusBar statusBar6 = this.StatusBar;
					statusBar6.Text += "active!";
					return;
				}
				this.StatusBar.Text = "";
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000D7BC File Offset: 0x0000B9BC
		private void CurrentLobbyButtonViewProfile_Click(object sender, EventArgs e)
		{
			MainForm.CurrentLobbyUI.ViewProfile();
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000D7C8 File Offset: 0x0000B9C8
		private void CurrentLobbyButtonBan_Click(object sender, EventArgs e)
		{
			MainForm.BanlistUI.AddPlayer(this.CurrentLobbyListView.SelectedIndices);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000D7DF File Offset: 0x0000B9DF
		private void CurrentLobbyButtonMigrateHost_Click(object sender, EventArgs e)
		{
			MainForm.CurrentLobbyUI.MigrateHost();
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000D7EB File Offset: 0x0000B9EB
		private void CurrentLobbyCheckBoxForceHost_Click(object sender, EventArgs e)
		{
			MainForm.CurrentLobbyUI.ToggleSkipLobbySearch();
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000D7F7 File Offset: 0x0000B9F7
		private void CurrentLobbyCheckBoxMirrorTracks_Click(object sender, EventArgs e)
		{
			MainForm.CurrentLobbyUI.ToggleMirrorTracks();
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000D803 File Offset: 0x0000BA03
		private void AllLobbiesButtonRefresh_Click(object sender, EventArgs e)
		{
			MainForm.AllLobbiesUI.RefreshList();
		}

		// Token: 0x06000090 RID: 144 RVA: 0x0000D80F File Offset: 0x0000BA0F
		private void AllLobbiesButtonViewPlayers_Click(object sender, EventArgs e)
		{
			MainForm.AllLobbiesUI.ViewLobbyDetails();
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0000D81B File Offset: 0x0000BA1B
		private void AllLobbiesButtonJoin_Click(object sender, EventArgs e)
		{
			MainForm.AllLobbiesUI.JoinLobby();
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000D827 File Offset: 0x0000BA27
		private void AllLobbiesButtonLink_Click(object sender, EventArgs e)
		{
			MainForm.AllLobbiesUI.GetLobbyLink();
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000D834 File Offset: 0x0000BA34
		private void BanlistUpdateActive()
		{
			bool flag = GameData.PlayerList.Length != 0 && GameData.youAreHost && Program.Config.Banlist.Enabled && (!Program.Config.Whitelist.Enabled || GameData.lobbyTypeId != 3);
			this.BanlistLabelActive.Text = string.Format("Banlist is active: {0}", flag ? "Yes" : "No");
			this.BanlistLabelActive.ForeColor = (flag ? Color.Green : Color.Black);
			if (flag && MainForm.connectionBlockTimeout == 0 && GameData.blockCount > GameData.blockCountOld)
			{
				MainForm.BanlistUI.ConnectionBlockedEvent();
				EventListeners.totalBlockCount++;
				MainForm.connectionBlockTimeout = 250;
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0000D8F8 File Offset: 0x0000BAF8
		private void CheckBoxBanlistEnable_Click(object sender, EventArgs e)
		{
			MainForm.BanlistUI.ToggleList();
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000D904 File Offset: 0x0000BB04
		private void BanlistListView_ItemChecked(object sender, ItemCheckedEventArgs e)
		{
			if (MainForm.BanlistUI != null)
			{
				MainForm.BanlistUI.TogglePlayer(e);
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000D918 File Offset: 0x0000BB18
		private void BanlistButtonRemove_Click(object sender, EventArgs e)
		{
			MainForm.BanlistUI.RemovePlayer();
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000D924 File Offset: 0x0000BB24
		private void BanlistButtonManualAdd_Click(object sender, EventArgs e)
		{
			MainForm.BanlistUI.AddPlayer();
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000D930 File Offset: 0x0000BB30
		private void BanlistButtonEdit_Click(object sender, EventArgs e)
		{
			MainForm.BanlistUI.EditPlayer();
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0000D93C File Offset: 0x0000BB3C
		private void BanlistButtonViewProfile_Click(object sender, EventArgs e)
		{
			MainForm.BanlistUI.ViewProfile();
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000D948 File Offset: 0x0000BB48
		private void BanlistButtonImport_Click(object sender, EventArgs e)
		{
			MainForm.BanlistUI.TextImport();
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0000D954 File Offset: 0x0000BB54
		private void BanlistButtonExport_Click(object sender, EventArgs e)
		{
			MainForm.BanlistUI.TextExport();
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000D960 File Offset: 0x0000BB60
		private void WhitelistUpdateActive()
		{
			bool flag = GameData.PlayerList.Length != 0 && GameData.youAreHost && Program.Config.Whitelist.Enabled && GameData.lobbyTypeId == 3;
			this.WhitelistLabelActive.Text = string.Format("Whitelist is active: {0}", flag ? "Yes" : "No");
			this.WhitelistLabelActive.ForeColor = (flag ? Color.Green : Color.Black);
			if (flag && MainForm.connectionBlockTimeout == 0 && GameData.blockCount > GameData.blockCountOld)
			{
				MainForm.WhitelistUI.ConnectionBlockedEvent();
				EventListeners.totalBlockCount++;
				MainForm.connectionBlockTimeout = 250;
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000DA0D File Offset: 0x0000BC0D
		private void WhitelistCheckBoxEnable_Click(object sender, EventArgs e)
		{
			MainForm.WhitelistUI.ToggleList();
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0000DA19 File Offset: 0x0000BC19
		private void WhitelistListView_ItemChecked(object sender, ItemCheckedEventArgs e)
		{
			if (MainForm.WhitelistUI != null)
			{
				MainForm.WhitelistUI.TogglePlayer(e);
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000DA2D File Offset: 0x0000BC2D
		private void WhitelistButtonRemove_Click(object sender, EventArgs e)
		{
			MainForm.WhitelistUI.RemovePlayer();
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0000DA3C File Offset: 0x0000BC3C
		private void WhitelistButtonManualAdd_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Do you want to add friends?", "Add Player", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
			{
				MainForm.WhitelistUI.AddPlayer();
				return;
			}
			SteamData.GetFriendList();
			if (SteamData.errorCode == 0)
			{
				MainForm.WhitelistUI.AddFriends();
				return;
			}
			MainForm.WhitelistUI.AddPlayer();
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000DA8A File Offset: 0x0000BC8A
		private void WhitelistButtonEdit_Click(object sender, EventArgs e)
		{
			MainForm.WhitelistUI.EditPlayer();
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0000DA96 File Offset: 0x0000BC96
		private void WhitelistButtonViewProfile_Click(object sender, EventArgs e)
		{
			MainForm.WhitelistUI.ViewProfile();
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0000DAA2 File Offset: 0x0000BCA2
		private void WhitelistButtonImport_Click(object sender, EventArgs e)
		{
			MainForm.WhitelistUI.TextImport();
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0000DAAE File Offset: 0x0000BCAE
		private void WhitelistButtonExport_Click(object sender, EventArgs e)
		{
			MainForm.WhitelistUI.TextExport();
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000DABA File Offset: 0x0000BCBA
		private void OverlayListView_ItemChecked(object sender, ItemCheckedEventArgs e)
		{
			if (MainForm.OverlayUI != null)
			{
				MainForm.OverlayUI.ToggleColumn(e);
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0000DACE File Offset: 0x0000BCCE
		private void OverlayNumericUpDownX_ValueChanged(object sender, EventArgs e)
		{
			if (MainForm.OverlayUI != null)
			{
				MainForm.OverlayUI.ChangePositionX();
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0000DAE1 File Offset: 0x0000BCE1
		private void OverlayNumericUpDownY_ValueChanged(object sender, EventArgs e)
		{
			if (MainForm.OverlayUI != null)
			{
				MainForm.OverlayUI.ChangePositionY();
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000DAF4 File Offset: 0x0000BCF4
		private void OverlayTrackBarBackgroundOpacity_ValueChanged(object sender, EventArgs e)
		{
			if (MainForm.OverlayUI != null)
			{
				MainForm.OverlayUI.ChangeBackgroundOpacity();
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0000DB07 File Offset: 0x0000BD07
		private void OverlayCheckBoxOverlayEnable_Click(object sender, EventArgs e)
		{
			MainForm.OverlayUI.ToggleOverlay();
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0000DB13 File Offset: 0x0000BD13
		private void OverlayCheckBoxBackgroundEnabled_Click(object sender, EventArgs e)
		{
			MainForm.OverlayUI.ToggleBackground();
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0000DB1F File Offset: 0x0000BD1F
		private void OverlayButtonColumnAdd_Click(object sender, EventArgs e)
		{
			MainForm.OverlayUI.AddColumn();
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0000DB2B File Offset: 0x0000BD2B
		private void OverlayButtonColumnEdit_Click(object sender, EventArgs e)
		{
			MainForm.OverlayUI.EditColumn();
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000DB37 File Offset: 0x0000BD37
		private void OverlayButtonColumnRemove_Click(object sender, EventArgs e)
		{
			MainForm.OverlayUI.RemoveColumn();
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000DB43 File Offset: 0x0000BD43
		private void OverlayButtonColumnUp_Click(object sender, EventArgs e)
		{
			MainForm.OverlayUI.MoveColumnUp();
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000DB4F File Offset: 0x0000BD4F
		private void OverlayButtonColumnDown_Click(object sender, EventArgs e)
		{
			MainForm.OverlayUI.MoveColumnDown();
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000DB5B File Offset: 0x0000BD5B
		private void OverlayButtonInfoFont_Click(object sender, EventArgs e)
		{
			MainForm.OverlayUI.ChangeInfoFont();
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000DB67 File Offset: 0x0000BD67
		private void OverlayButtonHeaderFont_Click(object sender, EventArgs e)
		{
			MainForm.OverlayUI.ChangeHeaderFont();
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000DB73 File Offset: 0x0000BD73
		private void OverlayButtonLobbyInfo_Click(object sender, EventArgs e)
		{
			MainForm.OverlayUI.ChangeLobbyInfo();
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000DB7F File Offset: 0x0000BD7F
		private void OverlayButtonBackgroundColour_Click(object sender, EventArgs e)
		{
			MainForm.OverlayUI.ChangeBackgroundColour();
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000DB8C File Offset: 0x0000BD8C
		private void AboutTabInitialise()
		{
			DebugTools.Write("About Tab: Initialising... ");
			FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location);
			string embeddedText = InternalConfig.GetEmbeddedText("AboutTabNotes.txt");
			string embeddedText2 = InternalConfig.GetEmbeddedText("BuildDate.txt");
			this.AboutTextBox.Text = string.Concat(new string[]
			{
				"\n~~~~ ",
				versionInfo.ProductName,
				" ~~~~\n\nMade By:\t",
				versionInfo.CompanyName,
				"\nVersion:\t\t",
				versionInfo.ProductVersion.Substring(0, 5),
				" - ",
				InternalConfig.Restricted ? "Public" : "Full",
				" Edition\nBuild Date:\t",
				embeddedText2.Substring(0, 19),
				"\n\n",
				embeddedText
			});
			Debug.Print("done.");
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000DC65 File Offset: 0x0000BE65
		private void AboutTextBox_LinkClicked(object sender, LinkClickedEventArgs e)
		{
			DebugTools.Print("Request: Open web link " + e.LinkText);
			Process.Start(e.LinkText);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000DC88 File Offset: 0x0000BE88
		private void AboutButtonViewChangelog_Click(object sender, EventArgs e)
		{
			DebugTools.Print("Open dialogue box: Changelog");
			using (DialogBoxChangelog dialogBoxChangelog = new DialogBoxChangelog())
			{
				dialogBoxChangelog.TextBoxChangelog.Text = InternalConfig.GetEmbeddedText("ChangeLog.txt");
				dialogBoxChangelog.ShowDialog();
			}
		}

		// Token: 0x040000D5 RID: 213
		private static int messageTimeout;

		// Token: 0x040000D6 RID: 214
		private static int connectionBlockTimeout;

		// Token: 0x040000D7 RID: 215
		private int tickInterval = 100;

		// Token: 0x040000D8 RID: 216
		public static CurrentLobbyUI CurrentLobbyUI;

		// Token: 0x040000D9 RID: 217
		public static AllLobbiesUI AllLobbiesUI;

		// Token: 0x040000DA RID: 218
		public static PlayerListUI BanlistUI;

		// Token: 0x040000DB RID: 219
		public static PlayerListUI WhitelistUI;

		// Token: 0x040000DC RID: 220
		public static OverlayUI OverlayUI;

		// Token: 0x040000DD RID: 221
		private static StatusBar _StatusBar;

		// Token: 0x040000DE RID: 222
		private Timer _Timer;
	}
}
