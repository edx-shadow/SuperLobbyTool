namespace SuperLobbyTool
{
	// Token: 0x02000015 RID: 21
	public partial class MainForm : global::System.Windows.Forms.Form
	{
		// Token: 0x060000B7 RID: 183 RVA: 0x0000DCE0 File Offset: 0x0000BEE0
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000DD00 File Offset: 0x0000BF00
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SuperLobbyTool.MainForm));
			this.AboutTextBox = new global::System.Windows.Forms.RichTextBox();
			this.TableLayoutPanel1 = new global::System.Windows.Forms.TableLayoutPanel();
			this.BanlistLabelActive = new global::System.Windows.Forms.Label();
			this.BanlistLabelBlockedConnections = new global::System.Windows.Forms.Label();
			this.BanlistGroupBoxTextList = new global::System.Windows.Forms.GroupBox();
			this.tableLayoutPanel15 = new global::System.Windows.Forms.TableLayoutPanel();
			this.BanlistButtonImport = new global::System.Windows.Forms.Button();
			this.BanlistButtonExport = new global::System.Windows.Forms.Button();
			this.BanlistLabelPlayerCount = new global::System.Windows.Forms.Label();
			this.BanlistCheckBoxEnable = new global::System.Windows.Forms.CheckBox();
			this.BanlistGroupboxPlayerOptions = new global::System.Windows.Forms.GroupBox();
			this.TableLayoutPanel4 = new global::System.Windows.Forms.TableLayoutPanel();
			this.BanlistButtonAdd = new global::System.Windows.Forms.Button();
			this.BanlistButtonEdit = new global::System.Windows.Forms.Button();
			this.BanlistButtonRemove = new global::System.Windows.Forms.Button();
			this.BanlistButtonViewProfile = new global::System.Windows.Forms.Button();
            this.BanlistListView = new global::System.Windows.Forms.ListView();
			this.BanlistColumnName = new global::System.Windows.Forms.ColumnHeader();
			this.BanlistColumnSteamId = new global::System.Windows.Forms.ColumnHeader();
			this.OverlayTab = new global::System.Windows.Forms.TabPage();
			this.tableLayoutPanel7 = new global::System.Windows.Forms.TableLayoutPanel();
			this.OverlayCheckBoxEnable = new global::System.Windows.Forms.CheckBox();
            this.OverlayListView = new global::System.Windows.Forms.ListView();
			this.DataColumn = new global::System.Windows.Forms.ColumnHeader();
			this.WidthColumn = new global::System.Windows.Forms.ColumnHeader();
			this.HeaderColourColumn = new global::System.Windows.Forms.ColumnHeader();
			this.DataColourColumn = new global::System.Windows.Forms.ColumnHeader();
			this.OverlayGroupBoxColumnOptions = new global::System.Windows.Forms.GroupBox();
			this.tableLayoutPanel9 = new global::System.Windows.Forms.TableLayoutPanel();
			this.OverlayButtonLobbyInfo = new global::System.Windows.Forms.Button();
			this.OverlayButtonMoveUp = new global::System.Windows.Forms.Button();
			this.OverlayButtonMoveDown = new global::System.Windows.Forms.Button();
			this.OverlayButtonEdit = new global::System.Windows.Forms.Button();
			this.OverlayButtonRemove = new global::System.Windows.Forms.Button();
			this.OverlayButtonAdd = new global::System.Windows.Forms.Button();
			this.OverlayGroupBoxInfoFont = new global::System.Windows.Forms.GroupBox();
			this.tableLayoutPanel10 = new global::System.Windows.Forms.TableLayoutPanel();
			this.OverlayButtonInfoFont = new global::System.Windows.Forms.Button();
			this.OverlayLabelDataFontPreview = new global::System.Windows.Forms.Label();
			this.OverlayLabelDataFontName = new global::System.Windows.Forms.Label();
			this.OverlayGroupBoxHeaderFont = new global::System.Windows.Forms.GroupBox();
			this.tableLayoutPanel11 = new global::System.Windows.Forms.TableLayoutPanel();
			this.OverlayButtonHeaderFont = new global::System.Windows.Forms.Button();
			this.OverlayLabelHeaderFontPreview = new global::System.Windows.Forms.Label();
			this.OverlayLabelHeaderFontName = new global::System.Windows.Forms.Label();
			this.tableLayoutPanel12 = new global::System.Windows.Forms.TableLayoutPanel();
			this.OverlayGroupBoxBackground = new global::System.Windows.Forms.GroupBox();
			this.tableLayoutPanel13 = new global::System.Windows.Forms.TableLayoutPanel();
			this.OverlayTrackBarBackgroundOpacity = new global::System.Windows.Forms.TrackBar();
			this.OverlayLabelBackgroundColour = new global::System.Windows.Forms.Label();
			this.OverlayCheckBoxBackgroundEnable = new global::System.Windows.Forms.CheckBox();
			this.OverlayLabelBackgroundOpacity = new global::System.Windows.Forms.Label();
			this.OverlayLabelBackgroundEnabled = new global::System.Windows.Forms.Label();
			this.OverlayLabelBackgroundColourPreview = new global::System.Windows.Forms.Label();
			this.OverlayButtonBackgroundColour = new global::System.Windows.Forms.Button();
			this.OverlayGroupBoxPosition = new global::System.Windows.Forms.GroupBox();
			this.tableLayoutPanel14 = new global::System.Windows.Forms.TableLayoutPanel();
			this.OverlayNumericUpDownY = new global::System.Windows.Forms.NumericUpDown();
			this.OverlayLabelPositionInfo = new global::System.Windows.Forms.Label();
			this.OverlayLabelPositionY = new global::System.Windows.Forms.Label();
			this.OverlayLabelPositionX = new global::System.Windows.Forms.Label();
			this.OverlayNumericUpDownX = new global::System.Windows.Forms.NumericUpDown();
			this.BanlistTab = new global::System.Windows.Forms.TabPage();
			this.AboutTab = new global::System.Windows.Forms.TabPage();
			this.tableLayoutPanel19 = new global::System.Windows.Forms.TableLayoutPanel();
			this.AboutButtonViewChangelog = new global::System.Windows.Forms.Button();
			this.TableLayoutPanel5 = new global::System.Windows.Forms.TableLayoutPanel();
			this.StatusBar = new global::System.Windows.Forms.StatusBar();
			this.Tabs = new global::System.Windows.Forms.TabControl();
			this.CurrentLobbyTab = new global::System.Windows.Forms.TabPage();
			this.TableLayoutPanel8 = new global::System.Windows.Forms.TableLayoutPanel();
			this.CurrentLobbyGroupBoxLobbyInfo = new global::System.Windows.Forms.GroupBox();
			this.tableLayoutPanel16 = new global::System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel18 = new global::System.Windows.Forms.TableLayoutPanel();
			this.CurrentLobbyLabelPlayerTotal = new global::System.Windows.Forms.Label();
			this.CurrentLobbyLabelPlayerTotalValue = new global::System.Windows.Forms.Label();
			this.CurrentLobbyLabelBannedPlayersValue = new global::System.Windows.Forms.Label();
			this.CurrentLobbyLabelFriendsValue = new global::System.Windows.Forms.Label();
			this.CurrentLobbyLabelBannedPlayers = new global::System.Windows.Forms.Label();
			this.CurrentLobbyLabelFriends = new global::System.Windows.Forms.Label();
			this.tableLayoutPanel17 = new global::System.Windows.Forms.TableLayoutPanel();
			this.CurrentLobbyLabelSLTProtectedValue = new global::System.Windows.Forms.Label();
			this.CurrentLobbyLabelSLTProtected = new global::System.Windows.Forms.Label();
			this.CurrentLobbyLabelLobbyIdValue = new global::System.Windows.Forms.Label();
			this.CurrentLobbyLabelHostValue = new global::System.Windows.Forms.Label();
			this.CurrentLobbyLabelHost = new global::System.Windows.Forms.Label();
			this.CurrentLobbyLabelLobbyId = new global::System.Windows.Forms.Label();
			this.CurrentLobbyGroupBoxHostOptions = new global::System.Windows.Forms.GroupBox();
			this.tableLayoutPanel23 = new global::System.Windows.Forms.TableLayoutPanel();
			this.CurrentLobbyCheckBoxSkipLobbySearch = new global::System.Windows.Forms.CheckBox();
			this.CurrentLobbyCheckBoxDisableMirrorTracks = new global::System.Windows.Forms.CheckBox();
			this.CurrentLobbyButtonMigrateHost = new global::System.Windows.Forms.Button();
			this.CurrentLobbyGroupBoxPlayerOptions = new global::System.Windows.Forms.GroupBox();
			this.TableLayoutPanel3 = new global::System.Windows.Forms.TableLayoutPanel();
			this.CurrentLobbyButtonBan = new global::System.Windows.Forms.Button();
			this.CurrentLobbyButtonViewProfile = new global::System.Windows.Forms.Button();
            this.CurrentLobbyListView = new global::System.Windows.Forms.ListView();
			this.CurrentLobbyColumnName = new global::System.Windows.Forms.ColumnHeader();
			this.CurrentLobbyColumnSteamId = new global::System.Windows.Forms.ColumnHeader();
			this.CurrentLobbyColumnPing = new global::System.Windows.Forms.ColumnHeader();
			this.AllLobbiesTab = new global::System.Windows.Forms.TabPage();
			this.tableLayoutPanel2 = new global::System.Windows.Forms.TableLayoutPanel();
			this.AllLobbiesLabelLobbyCount = new global::System.Windows.Forms.Label();
			this.AllLobbiesLabelPlayerCount = new global::System.Windows.Forms.Label();
			this.GroupBoxLobbyListControls = new global::System.Windows.Forms.GroupBox();
			this.tableLayoutPanel6 = new global::System.Windows.Forms.TableLayoutPanel();
			this.AllLobbiesButtonLink = new global::System.Windows.Forms.Button();
			this.AllLobbiesButtonViewPlayers = new global::System.Windows.Forms.Button();
			this.AllLobbiesButtonRefreshList = new global::System.Windows.Forms.Button();
			this.AllLobbiesButtonJoinLobby = new global::System.Windows.Forms.Button();
            this.AllLobbiesListView = new global::System.Windows.Forms.ListView();
			this.AllLobbiesColumnCreator = new global::System.Windows.Forms.ColumnHeader();
			this.AllLobbiesColumnType = new global::System.Windows.Forms.ColumnHeader();
			this.AllLobbiesColumnPlayers = new global::System.Windows.Forms.ColumnHeader();
			this.AllLobbiesColumnActivity = new global::System.Windows.Forms.ColumnHeader();
			this.WhitelistTab = new global::System.Windows.Forms.TabPage();
			this.tableLayoutPanel20 = new global::System.Windows.Forms.TableLayoutPanel();
			this.WhitelistLabelBlockedConnections = new global::System.Windows.Forms.Label();
			this.WhitelistGroupBoxTextList = new global::System.Windows.Forms.GroupBox();
			this.tableLayoutPanel21 = new global::System.Windows.Forms.TableLayoutPanel();
			this.WhitelistButtonImport = new global::System.Windows.Forms.Button();
			this.WhitelistButtonExport = new global::System.Windows.Forms.Button();
			this.WhitelistLabelActive = new global::System.Windows.Forms.Label();
			this.WhitelistLabelPlayerCount = new global::System.Windows.Forms.Label();
			this.WhitelistCheckBoxEnable = new global::System.Windows.Forms.CheckBox();
			this.WhitelistGroupBoxPlayerOptions = new global::System.Windows.Forms.GroupBox();
			this.tableLayoutPanel22 = new global::System.Windows.Forms.TableLayoutPanel();
			this.WhitelistButtonAdd = new global::System.Windows.Forms.Button();
			this.WhitelistButtonEdit = new global::System.Windows.Forms.Button();
			this.WhitelistButtonRemove = new global::System.Windows.Forms.Button();
			this.WhitelistButtonViewProfile = new global::System.Windows.Forms.Button();
            this.WhitelistListView = new global::System.Windows.Forms.ListView();
			this.WhitelistColumnName = new global::System.Windows.Forms.ColumnHeader();
			this.WhitelistColumnSteamId = new global::System.Windows.Forms.ColumnHeader();
			this.ToolTip = new global::System.Windows.Forms.ToolTip(this.components);
			this.TableLayoutPanel1.SuspendLayout();
			this.BanlistGroupBoxTextList.SuspendLayout();
			this.tableLayoutPanel15.SuspendLayout();
			this.BanlistGroupboxPlayerOptions.SuspendLayout();
			this.TableLayoutPanel4.SuspendLayout();
			this.OverlayTab.SuspendLayout();
			this.tableLayoutPanel7.SuspendLayout();
			this.OverlayGroupBoxColumnOptions.SuspendLayout();
			this.tableLayoutPanel9.SuspendLayout();
			this.OverlayGroupBoxInfoFont.SuspendLayout();
			this.tableLayoutPanel10.SuspendLayout();
			this.OverlayGroupBoxHeaderFont.SuspendLayout();
			this.tableLayoutPanel11.SuspendLayout();
			this.tableLayoutPanel12.SuspendLayout();
			this.OverlayGroupBoxBackground.SuspendLayout();
			this.tableLayoutPanel13.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.OverlayTrackBarBackgroundOpacity).BeginInit();
			this.OverlayGroupBoxPosition.SuspendLayout();
			this.tableLayoutPanel14.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.OverlayNumericUpDownY).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.OverlayNumericUpDownX).BeginInit();
			this.BanlistTab.SuspendLayout();
			this.AboutTab.SuspendLayout();
			this.tableLayoutPanel19.SuspendLayout();
			this.TableLayoutPanel5.SuspendLayout();
			this.Tabs.SuspendLayout();
			this.CurrentLobbyTab.SuspendLayout();
			this.TableLayoutPanel8.SuspendLayout();
			this.CurrentLobbyGroupBoxLobbyInfo.SuspendLayout();
			this.tableLayoutPanel16.SuspendLayout();
			this.tableLayoutPanel18.SuspendLayout();
			this.tableLayoutPanel17.SuspendLayout();
			this.CurrentLobbyGroupBoxHostOptions.SuspendLayout();
			this.tableLayoutPanel23.SuspendLayout();
			this.CurrentLobbyGroupBoxPlayerOptions.SuspendLayout();
			this.TableLayoutPanel3.SuspendLayout();
			this.AllLobbiesTab.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.GroupBoxLobbyListControls.SuspendLayout();
			this.tableLayoutPanel6.SuspendLayout();
			this.WhitelistTab.SuspendLayout();
			this.tableLayoutPanel20.SuspendLayout();
			this.WhitelistGroupBoxTextList.SuspendLayout();
			this.tableLayoutPanel21.SuspendLayout();
			this.WhitelistGroupBoxPlayerOptions.SuspendLayout();
			this.tableLayoutPanel22.SuspendLayout();
			base.SuspendLayout();
			this.AboutTextBox.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.AboutTextBox.Location = new global::System.Drawing.Point(3, 3);
			this.AboutTextBox.Name = "AboutTextBox";
			this.AboutTextBox.ReadOnly = true;
			this.AboutTextBox.Size = new global::System.Drawing.Size(469, 481);
			this.AboutTextBox.TabIndex = 1;
			this.AboutTextBox.Text = "[Notes]";
			this.ToolTip.SetToolTip(this.AboutTextBox, "Useful notes about Super Lobby Tool.");
			this.AboutTextBox.LinkClicked += new global::System.Windows.Forms.LinkClickedEventHandler(this.AboutTextBox_LinkClicked);
			this.TableLayoutPanel1.ColumnCount = 4;
			this.TableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 33.33334f));
			this.TableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 16.66668f));
			this.TableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 16.66662f));
			this.TableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 33.33336f));
			this.TableLayoutPanel1.Controls.Add(this.BanlistLabelActive, 0, 2);
			this.TableLayoutPanel1.Controls.Add(this.BanlistLabelBlockedConnections, 2, 2);
			this.TableLayoutPanel1.Controls.Add(this.BanlistGroupBoxTextList, 4, 3);
			this.TableLayoutPanel1.Controls.Add(this.BanlistLabelPlayerCount, 1, 2);
			this.TableLayoutPanel1.Controls.Add(this.BanlistCheckBoxEnable, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.BanlistGroupboxPlayerOptions, 0, 3);
			this.TableLayoutPanel1.Controls.Add(this.BanlistListView, 0, 1);
			this.TableLayoutPanel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.TableLayoutPanel1.Location = new global::System.Drawing.Point(0, 0);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 4;
			this.TableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 35f));
			this.TableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.TableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 23f));
			this.TableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 122f));
			this.TableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.Size = new global::System.Drawing.Size(475, 528);
			this.TableLayoutPanel1.TabIndex = 3;
			this.BanlistLabelActive.AutoSize = true;
			this.BanlistLabelActive.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.BanlistLabelActive.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.BanlistLabelActive.Location = new global::System.Drawing.Point(3, 383);
			this.BanlistLabelActive.Name = "BanlistLabelActive";
			this.BanlistLabelActive.Padding = new global::System.Windows.Forms.Padding(3);
			this.BanlistLabelActive.Size = new global::System.Drawing.Size(152, 23);
			this.BanlistLabelActive.TabIndex = 32;
			this.BanlistLabelActive.Text = "Banlist is active:";
			this.ToolTip.SetToolTip(this.BanlistLabelActive, "Shows whether the banlist is being used in the current lobby.");
			this.BanlistLabelBlockedConnections.AutoSize = true;
			this.BanlistLabelBlockedConnections.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.BanlistLabelBlockedConnections.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.BanlistLabelBlockedConnections.ForeColor = global::System.Drawing.Color.Red;
			this.BanlistLabelBlockedConnections.Location = new global::System.Drawing.Point(319, 383);
			this.BanlistLabelBlockedConnections.Name = "BanlistLabelBlockedConnections";
			this.BanlistLabelBlockedConnections.Padding = new global::System.Windows.Forms.Padding(3);
			this.BanlistLabelBlockedConnections.Size = new global::System.Drawing.Size(153, 23);
			this.BanlistLabelBlockedConnections.TabIndex = 31;
			this.BanlistLabelBlockedConnections.Text = "Blocked Connections: 0";
			this.ToolTip.SetToolTip(this.BanlistLabelBlockedConnections, "Number of times a player has been blocked from entering your lobby.\r\nOnly counts blocks due to the banlist feature.\r\nIncludes multiple blocks from the same player.");
			this.BanlistGroupBoxTextList.Controls.Add(this.tableLayoutPanel15);
			this.BanlistGroupBoxTextList.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.BanlistGroupBoxTextList.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold);
			this.BanlistGroupBoxTextList.Location = new global::System.Drawing.Point(319, 409);
			this.BanlistGroupBoxTextList.Name = "BanlistGroupBoxTextList";
			this.BanlistGroupBoxTextList.Size = new global::System.Drawing.Size(153, 116);
			this.BanlistGroupBoxTextList.TabIndex = 30;
			this.BanlistGroupBoxTextList.TabStop = false;
			this.BanlistGroupBoxTextList.Text = "Text List";
			this.ToolTip.SetToolTip(this.BanlistGroupBoxTextList, "Tools for importing and exporting text banlists.");
			this.tableLayoutPanel15.ColumnCount = 1;
			this.tableLayoutPanel15.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanel15.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Absolute, 20f));
			this.tableLayoutPanel15.Controls.Add(this.BanlistButtonImport, 0, 0);
			this.tableLayoutPanel15.Controls.Add(this.BanlistButtonExport, 0, 1);
			this.tableLayoutPanel15.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel15.Location = new global::System.Drawing.Point(3, 19);
			this.tableLayoutPanel15.Name = "tableLayoutPanel15";
			this.tableLayoutPanel15.RowCount = 2;
			this.tableLayoutPanel15.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel15.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel15.Size = new global::System.Drawing.Size(147, 94);
			this.tableLayoutPanel15.TabIndex = 0;
			this.BanlistButtonImport.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.BanlistButtonImport.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.BanlistButtonImport.Location = new global::System.Drawing.Point(3, 3);
			this.BanlistButtonImport.Name = "BanlistButtonImport";
			this.BanlistButtonImport.Size = new global::System.Drawing.Size(141, 41);
			this.BanlistButtonImport.TabIndex = 7;
			this.BanlistButtonImport.Text = "Import";
			this.ToolTip.SetToolTip(this.BanlistButtonImport, "Import players from a text banlist.");
			this.BanlistButtonImport.UseVisualStyleBackColor = true;
			this.BanlistButtonImport.Click += new global::System.EventHandler(this.BanlistButtonImport_Click);
			this.BanlistButtonExport.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.BanlistButtonExport.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.BanlistButtonExport.Location = new global::System.Drawing.Point(3, 50);
			this.BanlistButtonExport.Name = "BanlistButtonExport";
			this.BanlistButtonExport.Size = new global::System.Drawing.Size(141, 41);
			this.BanlistButtonExport.TabIndex = 8;
			this.BanlistButtonExport.Text = "Export";
			this.ToolTip.SetToolTip(this.BanlistButtonExport, "Export players to a text banlist.");
			this.BanlistButtonExport.UseVisualStyleBackColor = true;
			this.BanlistButtonExport.Click += new global::System.EventHandler(this.BanlistButtonExport_Click);
			this.BanlistLabelPlayerCount.AutoSize = true;
			this.TableLayoutPanel1.SetColumnSpan(this.BanlistLabelPlayerCount, 2);
			this.BanlistLabelPlayerCount.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.BanlistLabelPlayerCount.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.BanlistLabelPlayerCount.Location = new global::System.Drawing.Point(161, 383);
			this.BanlistLabelPlayerCount.Name = "BanlistLabelPlayerCount";
			this.BanlistLabelPlayerCount.Padding = new global::System.Windows.Forms.Padding(3);
			this.BanlistLabelPlayerCount.Size = new global::System.Drawing.Size(152, 23);
			this.BanlistLabelPlayerCount.TabIndex = 28;
			this.BanlistLabelPlayerCount.Text = "Player Count:";
			this.ToolTip.SetToolTip(this.BanlistLabelPlayerCount, "Number of players on the banlist.");
			this.BanlistCheckBoxEnable.AutoSize = true;
			this.TableLayoutPanel1.SetColumnSpan(this.BanlistCheckBoxEnable, 4);
			this.BanlistCheckBoxEnable.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.BanlistCheckBoxEnable.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.BanlistCheckBoxEnable.Location = new global::System.Drawing.Point(3, 3);
			this.BanlistCheckBoxEnable.Name = "BanlistCheckBoxEnable";
			this.BanlistCheckBoxEnable.Padding = new global::System.Windows.Forms.Padding(3);
			this.BanlistCheckBoxEnable.Size = new global::System.Drawing.Size(469, 29);
			this.BanlistCheckBoxEnable.TabIndex = 1;
			this.BanlistCheckBoxEnable.Text = "Enable Banlist";
			this.ToolTip.SetToolTip(this.BanlistCheckBoxEnable, "When enabled, the banlist feature will be used.");
			this.BanlistCheckBoxEnable.UseVisualStyleBackColor = true;
			this.BanlistCheckBoxEnable.Click += new global::System.EventHandler(this.CheckBoxBanlistEnable_Click);
			this.TableLayoutPanel1.SetColumnSpan(this.BanlistGroupboxPlayerOptions, 3);
			this.BanlistGroupboxPlayerOptions.Controls.Add(this.TableLayoutPanel4);
			this.BanlistGroupboxPlayerOptions.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.BanlistGroupboxPlayerOptions.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold);
			this.BanlistGroupboxPlayerOptions.Location = new global::System.Drawing.Point(3, 409);
			this.BanlistGroupboxPlayerOptions.Name = "BanlistGroupboxPlayerOptions";
			this.BanlistGroupboxPlayerOptions.Size = new global::System.Drawing.Size(310, 116);
			this.BanlistGroupboxPlayerOptions.TabIndex = 15;
			this.BanlistGroupboxPlayerOptions.TabStop = false;
			this.BanlistGroupboxPlayerOptions.Text = "Player Options";
			this.ToolTip.SetToolTip(this.BanlistGroupboxPlayerOptions, "Options for the list of players shown above.");
			this.TableLayoutPanel4.ColumnCount = 2;
			this.TableLayoutPanel4.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.TableLayoutPanel4.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.TableLayoutPanel4.Controls.Add(this.BanlistButtonAdd, 1, 1);
			this.TableLayoutPanel4.Controls.Add(this.BanlistButtonEdit, 0, 0);
			this.TableLayoutPanel4.Controls.Add(this.BanlistButtonRemove, 1, 0);
			this.TableLayoutPanel4.Controls.Add(this.BanlistButtonViewProfile, 0, 1);
			this.TableLayoutPanel4.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.TableLayoutPanel4.Location = new global::System.Drawing.Point(3, 19);
			this.TableLayoutPanel4.Name = "TableLayoutPanel4";
			this.TableLayoutPanel4.RowCount = 2;
			this.TableLayoutPanel4.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.TableLayoutPanel4.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.TableLayoutPanel4.Size = new global::System.Drawing.Size(304, 94);
			this.TableLayoutPanel4.TabIndex = 0;
			this.BanlistButtonAdd.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.BanlistButtonAdd.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.BanlistButtonAdd.Location = new global::System.Drawing.Point(155, 50);
			this.BanlistButtonAdd.Name = "BanlistButtonAdd";
			this.BanlistButtonAdd.Size = new global::System.Drawing.Size(146, 41);
			this.BanlistButtonAdd.TabIndex = 6;
			this.BanlistButtonAdd.Text = "Add";
			this.ToolTip.SetToolTip(this.BanlistButtonAdd, "Add a new player to the banlist.");
			this.BanlistButtonAdd.UseVisualStyleBackColor = true;
			this.BanlistButtonAdd.Click += new global::System.EventHandler(this.BanlistButtonManualAdd_Click);
			this.BanlistButtonEdit.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.BanlistButtonEdit.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.BanlistButtonEdit.Location = new global::System.Drawing.Point(3, 3);
			this.BanlistButtonEdit.Name = "BanlistButtonEdit";
			this.BanlistButtonEdit.Size = new global::System.Drawing.Size(146, 41);
			this.BanlistButtonEdit.TabIndex = 3;
			this.BanlistButtonEdit.Text = "Edit";
			this.ToolTip.SetToolTip(this.BanlistButtonEdit, "Edit the selected players.");
			this.BanlistButtonEdit.UseVisualStyleBackColor = true;
			this.BanlistButtonEdit.Click += new global::System.EventHandler(this.BanlistButtonEdit_Click);
			this.BanlistButtonRemove.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.BanlistButtonRemove.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.BanlistButtonRemove.Location = new global::System.Drawing.Point(155, 3);
			this.BanlistButtonRemove.Name = "BanlistButtonRemove";
			this.BanlistButtonRemove.Size = new global::System.Drawing.Size(146, 41);
			this.BanlistButtonRemove.TabIndex = 4;
			this.BanlistButtonRemove.Text = "Remove";
			this.ToolTip.SetToolTip(this.BanlistButtonRemove, "Remove the selected players.");
			this.BanlistButtonRemove.UseVisualStyleBackColor = true;
			this.BanlistButtonRemove.Click += new global::System.EventHandler(this.BanlistButtonRemove_Click);
			this.BanlistButtonViewProfile.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.BanlistButtonViewProfile.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.BanlistButtonViewProfile.Location = new global::System.Drawing.Point(3, 50);
			this.BanlistButtonViewProfile.Name = "BanlistButtonViewProfile";
			this.BanlistButtonViewProfile.Size = new global::System.Drawing.Size(146, 41);
			this.BanlistButtonViewProfile.TabIndex = 5;
			this.BanlistButtonViewProfile.Text = "View Profile";
			this.ToolTip.SetToolTip(this.BanlistButtonViewProfile, "View the Steam profiles of the selected players.");
			this.BanlistButtonViewProfile.UseVisualStyleBackColor = true;
			this.BanlistButtonViewProfile.Click += new global::System.EventHandler(this.BanlistButtonViewProfile_Click);
			this.BanlistListView.CheckBoxes = true;
			this.BanlistListView.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.BanlistColumnName,
				this.BanlistColumnSteamId
			});
			this.TableLayoutPanel1.SetColumnSpan(this.BanlistListView, 4);
			this.BanlistListView.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.BanlistListView.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold);
			this.BanlistListView.FullRowSelect = true;
			this.BanlistListView.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.BanlistListView.HideSelection = false;
			this.BanlistListView.Location = new global::System.Drawing.Point(3, 38);
			this.BanlistListView.Name = "BanlistListView";
			this.BanlistListView.Size = new global::System.Drawing.Size(469, 342);
			this.BanlistListView.TabIndex = 2;
			this.ToolTip.SetToolTip(this.BanlistListView, "List of all players that will be blocked from lobbies hosted by you.\r\nThis list should contain cheaters only.");
			this.BanlistListView.UseCompatibleStateImageBehavior = false;
			this.BanlistListView.View = global::System.Windows.Forms.View.Details;
			this.BanlistListView.ItemChecked += new global::System.Windows.Forms.ItemCheckedEventHandler(this.BanlistListView_ItemChecked);
			this.BanlistColumnName.Text = "Name";
			this.BanlistColumnName.Width = 263;
			this.BanlistColumnSteamId.Text = "Steam ID";
			this.BanlistColumnSteamId.Width = 185;
			this.OverlayTab.Controls.Add(this.tableLayoutPanel7);
			this.OverlayTab.Location = new global::System.Drawing.Point(4, 24);
			this.OverlayTab.Name = "OverlayTab";
			this.OverlayTab.Size = new global::System.Drawing.Size(475, 528);
			this.OverlayTab.TabIndex = 2;
			this.OverlayTab.Text = "Overlay";
			this.OverlayTab.UseVisualStyleBackColor = true;
			this.tableLayoutPanel7.ColumnCount = 3;
			this.tableLayoutPanel7.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 33.33333f));
			this.tableLayoutPanel7.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 33.33334f));
			this.tableLayoutPanel7.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 33.33334f));
			this.tableLayoutPanel7.Controls.Add(this.OverlayCheckBoxEnable, 0, 0);
			this.tableLayoutPanel7.Controls.Add(this.OverlayListView, 0, 1);
			this.tableLayoutPanel7.Controls.Add(this.OverlayGroupBoxColumnOptions, 0, 2);
			this.tableLayoutPanel7.Controls.Add(this.OverlayGroupBoxInfoFont, 1, 3);
			this.tableLayoutPanel7.Controls.Add(this.OverlayGroupBoxHeaderFont, 0, 3);
			this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel12, 2, 2);
			this.tableLayoutPanel7.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel7.Location = new global::System.Drawing.Point(0, 0);
			this.tableLayoutPanel7.Margin = new global::System.Windows.Forms.Padding(0);
			this.tableLayoutPanel7.Name = "tableLayoutPanel7";
			this.tableLayoutPanel7.RowCount = 4;
			this.tableLayoutPanel7.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 35f));
			this.tableLayoutPanel7.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 57.89474f));
			this.tableLayoutPanel7.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 150f));
			this.tableLayoutPanel7.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 42.10526f));
			this.tableLayoutPanel7.Size = new global::System.Drawing.Size(475, 528);
			this.tableLayoutPanel7.TabIndex = 4;
			this.OverlayCheckBoxEnable.AutoSize = true;
			this.tableLayoutPanel7.SetColumnSpan(this.OverlayCheckBoxEnable, 3);
			this.OverlayCheckBoxEnable.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.OverlayCheckBoxEnable.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.OverlayCheckBoxEnable.Location = new global::System.Drawing.Point(3, 3);
			this.OverlayCheckBoxEnable.Name = "OverlayCheckBoxEnable";
			this.OverlayCheckBoxEnable.Padding = new global::System.Windows.Forms.Padding(3);
			this.OverlayCheckBoxEnable.Size = new global::System.Drawing.Size(469, 29);
			this.OverlayCheckBoxEnable.TabIndex = 1;
			this.OverlayCheckBoxEnable.Text = "Enable Overlay";
			//this.ToolTip.SetToolTip(this.OverlayCheckBoxEnable, componentResourceManager.GetString("OverlayCheckBoxEnable.ToolTip"));
			this.OverlayCheckBoxEnable.UseVisualStyleBackColor = true;
			this.OverlayCheckBoxEnable.Click += new global::System.EventHandler(this.OverlayCheckBoxOverlayEnable_Click);
			this.OverlayListView.CheckBoxes = true;
			this.OverlayListView.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.DataColumn,
				this.WidthColumn,
				this.HeaderColourColumn,
				this.DataColourColumn
			});
			this.tableLayoutPanel7.SetColumnSpan(this.OverlayListView, 3);
			this.OverlayListView.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.OverlayListView.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.OverlayListView.FullRowSelect = true;
			this.OverlayListView.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.OverlayListView.HideSelection = false;
			this.OverlayListView.Location = new global::System.Drawing.Point(3, 38);
			this.OverlayListView.Name = "OverlayListView";
			this.OverlayListView.Size = new global::System.Drawing.Size(469, 192);
			this.OverlayListView.TabIndex = 2;
			this.ToolTip.SetToolTip(this.OverlayListView, "List of columns to be shown in the overlay.\r\nNote: The topmost lobby is shown furthest to the left.");
			this.OverlayListView.UseCompatibleStateImageBehavior = false;
			this.OverlayListView.View = global::System.Windows.Forms.View.Details;
			this.OverlayListView.ItemChecked += new global::System.Windows.Forms.ItemCheckedEventHandler(this.OverlayListView_ItemChecked);
			this.DataColumn.Text = "Column Info";
			this.DataColumn.Width = 160;
			this.WidthColumn.Text = "Width";
			this.WidthColumn.Width = 47;
			this.HeaderColourColumn.Text = "Header Colour";
			this.HeaderColourColumn.Width = 131;
			this.DataColourColumn.Text = "Info Colour";
			this.DataColourColumn.Width = 110;
			this.tableLayoutPanel7.SetColumnSpan(this.OverlayGroupBoxColumnOptions, 2);
			this.OverlayGroupBoxColumnOptions.Controls.Add(this.tableLayoutPanel9);
			this.OverlayGroupBoxColumnOptions.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.OverlayGroupBoxColumnOptions.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.OverlayGroupBoxColumnOptions.Location = new global::System.Drawing.Point(3, 236);
			this.OverlayGroupBoxColumnOptions.Name = "OverlayGroupBoxColumnOptions";
			this.OverlayGroupBoxColumnOptions.Size = new global::System.Drawing.Size(310, 144);
			this.OverlayGroupBoxColumnOptions.TabIndex = 3;
			this.OverlayGroupBoxColumnOptions.TabStop = false;
			this.OverlayGroupBoxColumnOptions.Text = "Column Options";
			this.ToolTip.SetToolTip(this.OverlayGroupBoxColumnOptions, "Options for the list of columns shown above.");
			this.tableLayoutPanel9.ColumnCount = 3;
			this.tableLayoutPanel9.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel9.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Absolute, 10f));
			this.tableLayoutPanel9.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50.00001f));
			this.tableLayoutPanel9.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Absolute, 20f));
			this.tableLayoutPanel9.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Absolute, 20f));
			this.tableLayoutPanel9.Controls.Add(this.OverlayButtonLobbyInfo, 2, 2);
			this.tableLayoutPanel9.Controls.Add(this.OverlayButtonMoveUp, 2, 0);
			this.tableLayoutPanel9.Controls.Add(this.OverlayButtonMoveDown, 2, 1);
			this.tableLayoutPanel9.Controls.Add(this.OverlayButtonEdit, 0, 0);
			this.tableLayoutPanel9.Controls.Add(this.OverlayButtonRemove, 0, 1);
			this.tableLayoutPanel9.Controls.Add(this.OverlayButtonAdd, 0, 2);
			this.tableLayoutPanel9.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel9.Location = new global::System.Drawing.Point(3, 19);
			this.tableLayoutPanel9.Name = "tableLayoutPanel9";
			this.tableLayoutPanel9.RowCount = 3;
			this.tableLayoutPanel9.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 33.33333f));
			this.tableLayoutPanel9.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 33.33333f));
			this.tableLayoutPanel9.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 33.33333f));
			this.tableLayoutPanel9.Size = new global::System.Drawing.Size(304, 122);
			this.tableLayoutPanel9.TabIndex = 0;
			this.OverlayButtonLobbyInfo.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.OverlayButtonLobbyInfo.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.OverlayButtonLobbyInfo.Location = new global::System.Drawing.Point(159, 83);
			this.OverlayButtonLobbyInfo.Name = "OverlayButtonLobbyInfo";
			this.OverlayButtonLobbyInfo.Size = new global::System.Drawing.Size(142, 36);
			this.OverlayButtonLobbyInfo.TabIndex = 9;
			this.OverlayButtonLobbyInfo.Text = "Additional Options";
			this.ToolTip.SetToolTip(this.OverlayButtonLobbyInfo, "Additional options, specific to each colum.");
			this.OverlayButtonLobbyInfo.UseVisualStyleBackColor = true;
			this.OverlayButtonLobbyInfo.Click += new global::System.EventHandler(this.OverlayButtonLobbyInfo_Click);
			this.OverlayButtonMoveUp.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.OverlayButtonMoveUp.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.OverlayButtonMoveUp.Location = new global::System.Drawing.Point(159, 3);
			this.OverlayButtonMoveUp.Name = "OverlayButtonMoveUp";
			this.OverlayButtonMoveUp.Size = new global::System.Drawing.Size(142, 34);
			this.OverlayButtonMoveUp.TabIndex = 5;
			this.OverlayButtonMoveUp.Text = "▲ Move Up";
			this.ToolTip.SetToolTip(this.OverlayButtonMoveUp, "Move the selected column up the list.\r\nThis translates to moving it left in the overlay.");
			this.OverlayButtonMoveUp.UseVisualStyleBackColor = true;
			this.OverlayButtonMoveUp.Click += new global::System.EventHandler(this.OverlayButtonColumnUp_Click);
			this.OverlayButtonMoveDown.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.OverlayButtonMoveDown.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.OverlayButtonMoveDown.Location = new global::System.Drawing.Point(159, 43);
			this.OverlayButtonMoveDown.Name = "OverlayButtonMoveDown";
			this.OverlayButtonMoveDown.Size = new global::System.Drawing.Size(142, 34);
			this.OverlayButtonMoveDown.TabIndex = 7;
			this.OverlayButtonMoveDown.Text = " ▼ Move Down";
			this.ToolTip.SetToolTip(this.OverlayButtonMoveDown, "Move the selected column down the list.\r\nThis translates to moving it right in the overlay.");
			this.OverlayButtonMoveDown.UseVisualStyleBackColor = true;
			this.OverlayButtonMoveDown.Click += new global::System.EventHandler(this.OverlayButtonColumnDown_Click);
			this.OverlayButtonEdit.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.OverlayButtonEdit.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.OverlayButtonEdit.Location = new global::System.Drawing.Point(3, 3);
			this.OverlayButtonEdit.Name = "OverlayButtonEdit";
			this.OverlayButtonEdit.Size = new global::System.Drawing.Size(140, 34);
			this.OverlayButtonEdit.TabIndex = 4;
			this.OverlayButtonEdit.Text = "Edit";
			this.ToolTip.SetToolTip(this.OverlayButtonEdit, "Edit the selected columns.");
			this.OverlayButtonEdit.UseVisualStyleBackColor = true;
			this.OverlayButtonEdit.Click += new global::System.EventHandler(this.OverlayButtonColumnEdit_Click);
			this.OverlayButtonRemove.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.OverlayButtonRemove.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.OverlayButtonRemove.Location = new global::System.Drawing.Point(3, 43);
			this.OverlayButtonRemove.Name = "OverlayButtonRemove";
			this.OverlayButtonRemove.Size = new global::System.Drawing.Size(140, 34);
			this.OverlayButtonRemove.TabIndex = 6;
			this.OverlayButtonRemove.Text = "Remove";
			this.ToolTip.SetToolTip(this.OverlayButtonRemove, "Remove the selected columns.");
			this.OverlayButtonRemove.UseVisualStyleBackColor = true;
			this.OverlayButtonRemove.Click += new global::System.EventHandler(this.OverlayButtonColumnRemove_Click);
			this.OverlayButtonAdd.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.OverlayButtonAdd.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.OverlayButtonAdd.Location = new global::System.Drawing.Point(3, 83);
			this.OverlayButtonAdd.Name = "OverlayButtonAdd";
			this.OverlayButtonAdd.Size = new global::System.Drawing.Size(140, 36);
			this.OverlayButtonAdd.TabIndex = 8;
			this.OverlayButtonAdd.Text = "Add";
			this.ToolTip.SetToolTip(this.OverlayButtonAdd, "Add a new column to the overlay.");
			this.OverlayButtonAdd.UseVisualStyleBackColor = true;
			this.OverlayButtonAdd.Click += new global::System.EventHandler(this.OverlayButtonColumnAdd_Click);
			this.OverlayGroupBoxInfoFont.Controls.Add(this.tableLayoutPanel10);
			this.OverlayGroupBoxInfoFont.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.OverlayGroupBoxInfoFont.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.OverlayGroupBoxInfoFont.Location = new global::System.Drawing.Point(161, 386);
			this.OverlayGroupBoxInfoFont.Name = "OverlayGroupBoxInfoFont";
			this.OverlayGroupBoxInfoFont.Size = new global::System.Drawing.Size(152, 139);
			this.OverlayGroupBoxInfoFont.TabIndex = 15;
			this.OverlayGroupBoxInfoFont.TabStop = false;
			this.OverlayGroupBoxInfoFont.Text = "Data Font";
			this.ToolTip.SetToolTip(this.OverlayGroupBoxInfoFont, "Font used for the column data.");
			this.tableLayoutPanel10.ColumnCount = 1;
			this.tableLayoutPanel10.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanel10.Controls.Add(this.OverlayButtonInfoFont, 0, 2);
			this.tableLayoutPanel10.Controls.Add(this.OverlayLabelDataFontPreview, 0, 1);
			this.tableLayoutPanel10.Controls.Add(this.OverlayLabelDataFontName, 0, 0);
			this.tableLayoutPanel10.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel10.Location = new global::System.Drawing.Point(3, 19);
			this.tableLayoutPanel10.Name = "tableLayoutPanel10";
			this.tableLayoutPanel10.RowCount = 3;
			this.tableLayoutPanel10.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 30f));
			this.tableLayoutPanel10.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanel10.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 50f));
			this.tableLayoutPanel10.Size = new global::System.Drawing.Size(146, 117);
			this.tableLayoutPanel10.TabIndex = 17;
			this.OverlayButtonInfoFont.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.OverlayButtonInfoFont.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.OverlayButtonInfoFont.Location = new global::System.Drawing.Point(3, 70);
			this.OverlayButtonInfoFont.Name = "OverlayButtonInfoFont";
			this.OverlayButtonInfoFont.Size = new global::System.Drawing.Size(140, 44);
			this.OverlayButtonInfoFont.TabIndex = 16;
			this.OverlayButtonInfoFont.Text = "Change Font";
			this.ToolTip.SetToolTip(this.OverlayButtonInfoFont, "Change the font used for column data.");
			this.OverlayButtonInfoFont.UseVisualStyleBackColor = true;
			this.OverlayButtonInfoFont.Click += new global::System.EventHandler(this.OverlayButtonInfoFont_Click);
			this.OverlayLabelDataFontPreview.AutoSize = true;
			this.OverlayLabelDataFontPreview.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.OverlayLabelDataFontPreview.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.OverlayLabelDataFontPreview.Location = new global::System.Drawing.Point(3, 30);
			this.OverlayLabelDataFontPreview.Name = "OverlayLabelDataFontPreview";
			this.OverlayLabelDataFontPreview.Size = new global::System.Drawing.Size(140, 37);
			this.OverlayLabelDataFontPreview.TabIndex = 12;
			this.OverlayLabelDataFontPreview.Text = "Preview";
			this.OverlayLabelDataFontPreview.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.ToolTip.SetToolTip(this.OverlayLabelDataFontPreview, "Preview of the font used for column data.");
			this.OverlayLabelDataFontName.AutoSize = true;
			this.OverlayLabelDataFontName.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.OverlayLabelDataFontName.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.OverlayLabelDataFontName.Location = new global::System.Drawing.Point(3, 0);
			this.OverlayLabelDataFontName.Name = "OverlayLabelDataFontName";
			this.OverlayLabelDataFontName.Size = new global::System.Drawing.Size(140, 30);
			this.OverlayLabelDataFontName.TabIndex = 4;
			this.OverlayLabelDataFontName.Text = "Name:";
			this.OverlayLabelDataFontName.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.ToolTip.SetToolTip(this.OverlayLabelDataFontName, "Name of the font used for column data.");
			this.OverlayGroupBoxHeaderFont.Controls.Add(this.tableLayoutPanel11);
			this.OverlayGroupBoxHeaderFont.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.OverlayGroupBoxHeaderFont.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.OverlayGroupBoxHeaderFont.Location = new global::System.Drawing.Point(3, 386);
			this.OverlayGroupBoxHeaderFont.Name = "OverlayGroupBoxHeaderFont";
			this.OverlayGroupBoxHeaderFont.Size = new global::System.Drawing.Size(152, 139);
			this.OverlayGroupBoxHeaderFont.TabIndex = 13;
			this.OverlayGroupBoxHeaderFont.TabStop = false;
			this.OverlayGroupBoxHeaderFont.Text = "Header Font";
			this.ToolTip.SetToolTip(this.OverlayGroupBoxHeaderFont, "Font used for the column headers.");
			this.tableLayoutPanel11.ColumnCount = 1;
			this.tableLayoutPanel11.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanel11.Controls.Add(this.OverlayButtonHeaderFont, 0, 2);
			this.tableLayoutPanel11.Controls.Add(this.OverlayLabelHeaderFontPreview, 0, 1);
			this.tableLayoutPanel11.Controls.Add(this.OverlayLabelHeaderFontName, 0, 0);
			this.tableLayoutPanel11.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel11.Location = new global::System.Drawing.Point(3, 19);
			this.tableLayoutPanel11.Name = "tableLayoutPanel11";
			this.tableLayoutPanel11.RowCount = 3;
			this.tableLayoutPanel11.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 30f));
			this.tableLayoutPanel11.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanel11.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 50f));
			this.tableLayoutPanel11.Size = new global::System.Drawing.Size(146, 117);
			this.tableLayoutPanel11.TabIndex = 17;
			this.OverlayButtonHeaderFont.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.OverlayButtonHeaderFont.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.OverlayButtonHeaderFont.Location = new global::System.Drawing.Point(3, 70);
			this.OverlayButtonHeaderFont.Name = "OverlayButtonHeaderFont";
			this.OverlayButtonHeaderFont.Size = new global::System.Drawing.Size(140, 44);
			this.OverlayButtonHeaderFont.TabIndex = 14;
			this.OverlayButtonHeaderFont.Text = "Change Font";
			this.ToolTip.SetToolTip(this.OverlayButtonHeaderFont, "Change the font used for column headers.");
			this.OverlayButtonHeaderFont.UseVisualStyleBackColor = true;
			this.OverlayButtonHeaderFont.Click += new global::System.EventHandler(this.OverlayButtonHeaderFont_Click);
			this.OverlayLabelHeaderFontPreview.AutoSize = true;
			this.OverlayLabelHeaderFontPreview.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.OverlayLabelHeaderFontPreview.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.OverlayLabelHeaderFontPreview.Location = new global::System.Drawing.Point(3, 30);
			this.OverlayLabelHeaderFontPreview.Name = "OverlayLabelHeaderFontPreview";
			this.OverlayLabelHeaderFontPreview.Size = new global::System.Drawing.Size(140, 37);
			this.OverlayLabelHeaderFontPreview.TabIndex = 11;
			this.OverlayLabelHeaderFontPreview.Text = "Preview";
			this.OverlayLabelHeaderFontPreview.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.ToolTip.SetToolTip(this.OverlayLabelHeaderFontPreview, "Preview of the font used for column headers.");
			this.OverlayLabelHeaderFontName.AutoSize = true;
			this.OverlayLabelHeaderFontName.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.OverlayLabelHeaderFontName.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.OverlayLabelHeaderFontName.Location = new global::System.Drawing.Point(3, 0);
			this.OverlayLabelHeaderFontName.Name = "OverlayLabelHeaderFontName";
			this.OverlayLabelHeaderFontName.Size = new global::System.Drawing.Size(140, 30);
			this.OverlayLabelHeaderFontName.TabIndex = 4;
			this.OverlayLabelHeaderFontName.Text = "Name:";
			this.OverlayLabelHeaderFontName.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.ToolTip.SetToolTip(this.OverlayLabelHeaderFontName, "Name of the font used for column headers.");
			this.tableLayoutPanel12.ColumnCount = 1;
			this.tableLayoutPanel12.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanel12.Controls.Add(this.OverlayGroupBoxBackground, 0, 1);
			this.tableLayoutPanel12.Controls.Add(this.OverlayGroupBoxPosition, 0, 0);
			this.tableLayoutPanel12.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel12.Location = new global::System.Drawing.Point(316, 233);
			this.tableLayoutPanel12.Margin = new global::System.Windows.Forms.Padding(0);
			this.tableLayoutPanel12.Name = "tableLayoutPanel12";
			this.tableLayoutPanel12.RowCount = 2;
			this.tableLayoutPanel7.SetRowSpan(this.tableLayoutPanel12, 2);
			this.tableLayoutPanel12.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 40f));
			this.tableLayoutPanel12.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 60f));
			this.tableLayoutPanel12.Size = new global::System.Drawing.Size(159, 295);
			this.tableLayoutPanel12.TabIndex = 28;
			this.OverlayGroupBoxBackground.Controls.Add(this.tableLayoutPanel13);
			this.OverlayGroupBoxBackground.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.OverlayGroupBoxBackground.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.OverlayGroupBoxBackground.Location = new global::System.Drawing.Point(3, 121);
			this.OverlayGroupBoxBackground.Name = "OverlayGroupBoxBackground";
			this.OverlayGroupBoxBackground.Size = new global::System.Drawing.Size(153, 171);
			this.OverlayGroupBoxBackground.TabIndex = 17;
			this.OverlayGroupBoxBackground.TabStop = false;
			this.OverlayGroupBoxBackground.Text = "Overlay Background";
			this.ToolTip.SetToolTip(this.OverlayGroupBoxBackground, "The background to be shown behind the overlay text.");
			this.tableLayoutPanel13.ColumnCount = 2;
			this.tableLayoutPanel13.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 40f));
			this.tableLayoutPanel13.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 60f));
			this.tableLayoutPanel13.Controls.Add(this.OverlayTrackBarBackgroundOpacity, 1, 1);
			this.tableLayoutPanel13.Controls.Add(this.OverlayLabelBackgroundColour, 0, 2);
			this.tableLayoutPanel13.Controls.Add(this.OverlayCheckBoxBackgroundEnable, 1, 0);
			this.tableLayoutPanel13.Controls.Add(this.OverlayLabelBackgroundOpacity, 0, 1);
			this.tableLayoutPanel13.Controls.Add(this.OverlayLabelBackgroundEnabled, 0, 0);
			this.tableLayoutPanel13.Controls.Add(this.OverlayLabelBackgroundColourPreview, 1, 2);
			this.tableLayoutPanel13.Controls.Add(this.OverlayButtonBackgroundColour, 0, 3);
			this.tableLayoutPanel13.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel13.Location = new global::System.Drawing.Point(3, 19);
			this.tableLayoutPanel13.Name = "tableLayoutPanel13";
			this.tableLayoutPanel13.RowCount = 4;
			this.tableLayoutPanel13.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 30f));
			this.tableLayoutPanel13.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 30f));
			this.tableLayoutPanel13.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanel13.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 50f));
			this.tableLayoutPanel13.Size = new global::System.Drawing.Size(147, 149);
			this.tableLayoutPanel13.TabIndex = 17;
			this.OverlayTrackBarBackgroundOpacity.BackColor = global::System.Drawing.SystemColors.Window;
			this.OverlayTrackBarBackgroundOpacity.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.OverlayTrackBarBackgroundOpacity.LargeChange = 32;
			this.OverlayTrackBarBackgroundOpacity.Location = new global::System.Drawing.Point(61, 33);
			this.OverlayTrackBarBackgroundOpacity.Maximum = 255;
			this.OverlayTrackBarBackgroundOpacity.Name = "OverlayTrackBarBackgroundOpacity";
			this.OverlayTrackBarBackgroundOpacity.Size = new global::System.Drawing.Size(83, 24);
			this.OverlayTrackBarBackgroundOpacity.TabIndex = 19;
			this.OverlayTrackBarBackgroundOpacity.TickStyle = global::System.Windows.Forms.TickStyle.None;
			this.ToolTip.SetToolTip(this.OverlayTrackBarBackgroundOpacity, "Slide towards the left --> more transparent.\r\nSlide towards the right --> more opaque.\r\n");
			this.OverlayTrackBarBackgroundOpacity.ValueChanged += new global::System.EventHandler(this.OverlayTrackBarBackgroundOpacity_ValueChanged);
			this.OverlayLabelBackgroundColour.AutoSize = true;
			this.OverlayLabelBackgroundColour.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.OverlayLabelBackgroundColour.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.OverlayLabelBackgroundColour.Location = new global::System.Drawing.Point(3, 60);
			this.OverlayLabelBackgroundColour.Name = "OverlayLabelBackgroundColour";
			this.OverlayLabelBackgroundColour.Size = new global::System.Drawing.Size(52, 39);
			this.OverlayLabelBackgroundColour.TabIndex = 27;
			this.OverlayLabelBackgroundColour.Text = "Colour:";
			this.OverlayLabelBackgroundColour.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.ToolTip.SetToolTip(this.OverlayLabelBackgroundColour, "Preview of the colour used for the background.");
			this.OverlayCheckBoxBackgroundEnable.AutoSize = true;
			this.OverlayCheckBoxBackgroundEnable.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.OverlayCheckBoxBackgroundEnable.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.OverlayCheckBoxBackgroundEnable.Location = new global::System.Drawing.Point(61, 3);
			this.OverlayCheckBoxBackgroundEnable.Name = "OverlayCheckBoxBackgroundEnable";
			this.OverlayCheckBoxBackgroundEnable.Padding = new global::System.Windows.Forms.Padding(3);
			this.OverlayCheckBoxBackgroundEnable.Size = new global::System.Drawing.Size(83, 24);
			this.OverlayCheckBoxBackgroundEnable.TabIndex = 18;
			this.ToolTip.SetToolTip(this.OverlayCheckBoxBackgroundEnable, "When enabled, the background is shown.");
			this.OverlayCheckBoxBackgroundEnable.UseVisualStyleBackColor = true;
			this.OverlayCheckBoxBackgroundEnable.Click += new global::System.EventHandler(this.OverlayCheckBoxBackgroundEnabled_Click);
			this.OverlayLabelBackgroundOpacity.AutoSize = true;
			this.OverlayLabelBackgroundOpacity.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.OverlayLabelBackgroundOpacity.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.OverlayLabelBackgroundOpacity.Location = new global::System.Drawing.Point(3, 30);
			this.OverlayLabelBackgroundOpacity.Name = "OverlayLabelBackgroundOpacity";
			this.OverlayLabelBackgroundOpacity.Size = new global::System.Drawing.Size(52, 30);
			this.OverlayLabelBackgroundOpacity.TabIndex = 12;
			this.OverlayLabelBackgroundOpacity.Text = "Opacity:";
			this.OverlayLabelBackgroundOpacity.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.ToolTip.SetToolTip(this.OverlayLabelBackgroundOpacity, "Slide towards the left --> more transparent.\r\nSlide towards the right --> more opaque.");
			this.OverlayLabelBackgroundEnabled.AutoSize = true;
			this.OverlayLabelBackgroundEnabled.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.OverlayLabelBackgroundEnabled.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.OverlayLabelBackgroundEnabled.Location = new global::System.Drawing.Point(3, 0);
			this.OverlayLabelBackgroundEnabled.Name = "OverlayLabelBackgroundEnabled";
			this.OverlayLabelBackgroundEnabled.Size = new global::System.Drawing.Size(52, 30);
			this.OverlayLabelBackgroundEnabled.TabIndex = 11;
			this.OverlayLabelBackgroundEnabled.Text = "Enabled:";
			this.OverlayLabelBackgroundEnabled.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.ToolTip.SetToolTip(this.OverlayLabelBackgroundEnabled, "When enabled, the background is shown.");
			this.OverlayLabelBackgroundColourPreview.AutoSize = true;
			this.OverlayLabelBackgroundColourPreview.BackColor = global::System.Drawing.Color.Red;
			this.OverlayLabelBackgroundColourPreview.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.OverlayLabelBackgroundColourPreview.Location = new global::System.Drawing.Point(61, 60);
			this.OverlayLabelBackgroundColourPreview.Name = "OverlayLabelBackgroundColourPreview";
			this.OverlayLabelBackgroundColourPreview.Size = new global::System.Drawing.Size(83, 39);
			this.OverlayLabelBackgroundColourPreview.TabIndex = 10;
			this.ToolTip.SetToolTip(this.OverlayLabelBackgroundColourPreview, "Preview of the colour used for the background.");
			this.tableLayoutPanel13.SetColumnSpan(this.OverlayButtonBackgroundColour, 2);
			this.OverlayButtonBackgroundColour.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.OverlayButtonBackgroundColour.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.OverlayButtonBackgroundColour.Location = new global::System.Drawing.Point(3, 102);
			this.OverlayButtonBackgroundColour.Name = "OverlayButtonBackgroundColour";
			this.OverlayButtonBackgroundColour.Size = new global::System.Drawing.Size(141, 44);
			this.OverlayButtonBackgroundColour.TabIndex = 20;
			this.OverlayButtonBackgroundColour.Text = "Change Colour";
			this.ToolTip.SetToolTip(this.OverlayButtonBackgroundColour, "Change the colour used for the background.");
			this.OverlayButtonBackgroundColour.UseVisualStyleBackColor = true;
			this.OverlayButtonBackgroundColour.Click += new global::System.EventHandler(this.OverlayButtonBackgroundColour_Click);
			this.OverlayGroupBoxPosition.Controls.Add(this.tableLayoutPanel14);
			this.OverlayGroupBoxPosition.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.OverlayGroupBoxPosition.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.OverlayGroupBoxPosition.Location = new global::System.Drawing.Point(3, 3);
			this.OverlayGroupBoxPosition.Name = "OverlayGroupBoxPosition";
			this.OverlayGroupBoxPosition.Size = new global::System.Drawing.Size(153, 112);
			this.OverlayGroupBoxPosition.TabIndex = 10;
			this.OverlayGroupBoxPosition.TabStop = false;
			this.OverlayGroupBoxPosition.Text = "Overlay Position";
			this.ToolTip.SetToolTip(this.OverlayGroupBoxPosition, "The position of the top left corner of the overlay.\r\n");
			this.tableLayoutPanel14.ColumnCount = 2;
			this.tableLayoutPanel14.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Absolute, 40f));
			this.tableLayoutPanel14.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanel14.Controls.Add(this.OverlayNumericUpDownY, 1, 2);
			this.tableLayoutPanel14.Controls.Add(this.OverlayLabelPositionInfo, 0, 0);
			this.tableLayoutPanel14.Controls.Add(this.OverlayLabelPositionY, 0, 2);
			this.tableLayoutPanel14.Controls.Add(this.OverlayLabelPositionX, 0, 1);
			this.tableLayoutPanel14.Controls.Add(this.OverlayNumericUpDownX, 1, 1);
			this.tableLayoutPanel14.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel14.Location = new global::System.Drawing.Point(3, 19);
			this.tableLayoutPanel14.Name = "tableLayoutPanel14";
			this.tableLayoutPanel14.RowCount = 3;
			this.tableLayoutPanel14.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 30f));
			this.tableLayoutPanel14.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel14.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel14.Size = new global::System.Drawing.Size(147, 90);
			this.tableLayoutPanel14.TabIndex = 0;
			this.OverlayNumericUpDownY.Anchor = (global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.OverlayNumericUpDownY.Location = new global::System.Drawing.Point(43, 63);
			global::System.Windows.Forms.NumericUpDown overlayNumericUpDownY = this.OverlayNumericUpDownY;
			int[] array = new int[4];
			array[0] = 10000;
			overlayNumericUpDownY.Maximum = new decimal(array);
			this.OverlayNumericUpDownY.Name = "OverlayNumericUpDownY";
			this.OverlayNumericUpDownY.Size = new global::System.Drawing.Size(101, 23);
			this.OverlayNumericUpDownY.TabIndex = 12;
			this.ToolTip.SetToolTip(this.OverlayNumericUpDownY, "The vertical distance from the top of the screen, in pixels.");
			this.OverlayNumericUpDownY.ValueChanged += new global::System.EventHandler(this.OverlayNumericUpDownY_ValueChanged);
			this.OverlayLabelPositionInfo.AutoSize = true;
			this.tableLayoutPanel14.SetColumnSpan(this.OverlayLabelPositionInfo, 2);
			this.OverlayLabelPositionInfo.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.OverlayLabelPositionInfo.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.OverlayLabelPositionInfo.Location = new global::System.Drawing.Point(3, 0);
			this.OverlayLabelPositionInfo.Name = "OverlayLabelPositionInfo";
			this.OverlayLabelPositionInfo.Size = new global::System.Drawing.Size(141, 30);
			this.OverlayLabelPositionInfo.TabIndex = 2;
			this.OverlayLabelPositionInfo.Text = "Displacement from the top left of the screen:";
			this.OverlayLabelPositionInfo.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.ToolTip.SetToolTip(this.OverlayLabelPositionInfo, "The position of the top left corner of the overlay.");
			this.OverlayLabelPositionY.AutoSize = true;
			this.OverlayLabelPositionY.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.OverlayLabelPositionY.Location = new global::System.Drawing.Point(3, 60);
			this.OverlayLabelPositionY.Name = "OverlayLabelPositionY";
			this.OverlayLabelPositionY.Size = new global::System.Drawing.Size(34, 30);
			this.OverlayLabelPositionY.TabIndex = 1;
			this.OverlayLabelPositionY.Text = "Y = ";
			this.OverlayLabelPositionY.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.ToolTip.SetToolTip(this.OverlayLabelPositionY, "The vertical distance from the top of the screen, in pixels.");
			this.OverlayLabelPositionX.AutoSize = true;
			this.OverlayLabelPositionX.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.OverlayLabelPositionX.Location = new global::System.Drawing.Point(3, 30);
			this.OverlayLabelPositionX.Name = "OverlayLabelPositionX";
			this.OverlayLabelPositionX.Size = new global::System.Drawing.Size(34, 30);
			this.OverlayLabelPositionX.TabIndex = 0;
			this.OverlayLabelPositionX.Text = "X = ";
			this.OverlayLabelPositionX.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.ToolTip.SetToolTip(this.OverlayLabelPositionX, "The horizontal distance from the left of the screen, in pixels.");
			this.OverlayNumericUpDownX.Anchor = (global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.OverlayNumericUpDownX.Location = new global::System.Drawing.Point(43, 33);
			global::System.Windows.Forms.NumericUpDown overlayNumericUpDownX = this.OverlayNumericUpDownX;
			int[] array2 = new int[4];
			array2[0] = 10000;
			overlayNumericUpDownX.Maximum = new decimal(array2);
			this.OverlayNumericUpDownX.Name = "OverlayNumericUpDownX";
			this.OverlayNumericUpDownX.Size = new global::System.Drawing.Size(101, 23);
			this.OverlayNumericUpDownX.TabIndex = 11;
			this.ToolTip.SetToolTip(this.OverlayNumericUpDownX, "The horizontal distance from the left of the screen, in pixels.");
			this.OverlayNumericUpDownX.ValueChanged += new global::System.EventHandler(this.OverlayNumericUpDownX_ValueChanged);
			this.BanlistTab.Controls.Add(this.TableLayoutPanel1);
			this.BanlistTab.Location = new global::System.Drawing.Point(4, 24);
			this.BanlistTab.Name = "BanlistTab";
			this.BanlistTab.Size = new global::System.Drawing.Size(475, 528);
			this.BanlistTab.TabIndex = 1;
			this.BanlistTab.Text = "Banlist";
			this.BanlistTab.UseVisualStyleBackColor = true;
			this.AboutTab.Controls.Add(this.tableLayoutPanel19);
			this.AboutTab.Location = new global::System.Drawing.Point(4, 24);
			this.AboutTab.Name = "AboutTab";
			this.AboutTab.Size = new global::System.Drawing.Size(475, 528);
			this.AboutTab.TabIndex = 3;
			this.AboutTab.Text = "About";
			this.AboutTab.UseVisualStyleBackColor = true;
			this.tableLayoutPanel19.ColumnCount = 1;
			this.tableLayoutPanel19.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanel19.Controls.Add(this.AboutButtonViewChangelog, 0, 1);
			this.tableLayoutPanel19.Controls.Add(this.AboutTextBox, 0, 0);
			this.tableLayoutPanel19.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel19.Location = new global::System.Drawing.Point(0, 0);
			this.tableLayoutPanel19.Name = "tableLayoutPanel19";
			this.tableLayoutPanel19.RowCount = 2;
			this.tableLayoutPanel19.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanel19.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 41f));
			this.tableLayoutPanel19.Size = new global::System.Drawing.Size(475, 528);
			this.tableLayoutPanel19.TabIndex = 1;
			this.AboutButtonViewChangelog.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.AboutButtonViewChangelog.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.AboutButtonViewChangelog.Location = new global::System.Drawing.Point(3, 490);
			this.AboutButtonViewChangelog.Name = "AboutButtonViewChangelog";
			this.AboutButtonViewChangelog.Size = new global::System.Drawing.Size(469, 35);
			this.AboutButtonViewChangelog.TabIndex = 2;
			this.AboutButtonViewChangelog.Text = "View Changelog";
			this.ToolTip.SetToolTip(this.AboutButtonViewChangelog, "Opens a detailed log of all the changes made to Super Lobby Tool.");
			this.AboutButtonViewChangelog.UseVisualStyleBackColor = true;
			this.AboutButtonViewChangelog.Click += new global::System.EventHandler(this.AboutButtonViewChangelog_Click);
			this.TableLayoutPanel5.ColumnCount = 1;
			this.TableLayoutPanel5.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.TableLayoutPanel5.Controls.Add(this.StatusBar, 0, 0);
			this.TableLayoutPanel5.Controls.Add(this.Tabs, 0, 0);
			this.TableLayoutPanel5.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.TableLayoutPanel5.Location = new global::System.Drawing.Point(0, 0);
			this.TableLayoutPanel5.Name = "TableLayoutPanel5";
			this.TableLayoutPanel5.RowCount = 1;
			this.TableLayoutPanel5.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.TableLayoutPanel5.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 30f));
			this.TableLayoutPanel5.Size = new global::System.Drawing.Size(489, 592);
			this.TableLayoutPanel5.TabIndex = 9;
			this.StatusBar.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.StatusBar.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold);
			this.StatusBar.Location = new global::System.Drawing.Point(3, 565);
			this.StatusBar.Name = "StatusBar";
			this.StatusBar.Size = new global::System.Drawing.Size(483, 24);
			this.StatusBar.TabIndex = 13;
			this.StatusBar.Text = "Important:";
			this.ToolTip.SetToolTip(this.StatusBar, "Some useful messages will show here.");
			this.Tabs.Controls.Add(this.CurrentLobbyTab);
			this.Tabs.Controls.Add(this.AllLobbiesTab);
			this.Tabs.Controls.Add(this.BanlistTab);
			this.Tabs.Controls.Add(this.WhitelistTab);
			this.Tabs.Controls.Add(this.OverlayTab);
			this.Tabs.Controls.Add(this.AboutTab);
			this.Tabs.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Tabs.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Tabs.Location = new global::System.Drawing.Point(3, 3);
			this.Tabs.Name = "Tabs";
			this.Tabs.SelectedIndex = 0;
			this.Tabs.Size = new global::System.Drawing.Size(483, 556);
			this.Tabs.TabIndex = 0;
			this.CurrentLobbyTab.Controls.Add(this.TableLayoutPanel8);
			this.CurrentLobbyTab.Location = new global::System.Drawing.Point(4, 24);
			this.CurrentLobbyTab.Name = "CurrentLobbyTab";
			this.CurrentLobbyTab.Size = new global::System.Drawing.Size(475, 528);
			this.CurrentLobbyTab.TabIndex = 0;
			this.CurrentLobbyTab.Text = "Current Lobby";
			this.CurrentLobbyTab.UseVisualStyleBackColor = true;
			this.TableLayoutPanel8.ColumnCount = 2;
			this.TableLayoutPanel8.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 69.47369f));
			this.TableLayoutPanel8.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 30.52632f));
			this.TableLayoutPanel8.Controls.Add(this.CurrentLobbyGroupBoxLobbyInfo, 0, 2);
			this.TableLayoutPanel8.Controls.Add(this.CurrentLobbyGroupBoxHostOptions, 1, 1);
			this.TableLayoutPanel8.Controls.Add(this.CurrentLobbyGroupBoxPlayerOptions, 0, 1);
			this.TableLayoutPanel8.Controls.Add(this.CurrentLobbyListView, 0, 0);
			this.TableLayoutPanel8.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.TableLayoutPanel8.Location = new global::System.Drawing.Point(0, 0);
			this.TableLayoutPanel8.Name = "TableLayoutPanel8";
			this.TableLayoutPanel8.RowCount = 3;
			this.TableLayoutPanel8.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.TableLayoutPanel8.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 75f));
			this.TableLayoutPanel8.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 109f));
			this.TableLayoutPanel8.Size = new global::System.Drawing.Size(475, 528);
			this.TableLayoutPanel8.TabIndex = 1;
			this.CurrentLobbyGroupBoxLobbyInfo.Controls.Add(this.tableLayoutPanel16);
			this.CurrentLobbyGroupBoxLobbyInfo.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.CurrentLobbyGroupBoxLobbyInfo.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold);
			this.CurrentLobbyGroupBoxLobbyInfo.Location = new global::System.Drawing.Point(3, 422);
			this.CurrentLobbyGroupBoxLobbyInfo.Name = "CurrentLobbyGroupBoxLobbyInfo";
			this.CurrentLobbyGroupBoxLobbyInfo.Padding = new global::System.Windows.Forms.Padding(5);
			this.CurrentLobbyGroupBoxLobbyInfo.Size = new global::System.Drawing.Size(323, 103);
			this.CurrentLobbyGroupBoxLobbyInfo.TabIndex = 13;
			this.CurrentLobbyGroupBoxLobbyInfo.TabStop = false;
			this.CurrentLobbyGroupBoxLobbyInfo.Text = "Lobby Info";
			this.ToolTip.SetToolTip(this.CurrentLobbyGroupBoxLobbyInfo, "Useful information about this lobby.");
			this.tableLayoutPanel16.CellBorderStyle = global::System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
			this.tableLayoutPanel16.ColumnCount = 2;
			this.tableLayoutPanel16.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 74.19355f));
			this.tableLayoutPanel16.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 25.80645f));
			this.tableLayoutPanel16.Controls.Add(this.tableLayoutPanel18, 1, 0);
			this.tableLayoutPanel16.Controls.Add(this.tableLayoutPanel17, 0, 0);
			this.tableLayoutPanel16.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel16.Location = new global::System.Drawing.Point(5, 21);
			this.tableLayoutPanel16.Name = "tableLayoutPanel16";
			this.tableLayoutPanel16.RowCount = 1;
			this.tableLayoutPanel16.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanel16.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 74f));
			this.tableLayoutPanel16.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 74f));
			this.tableLayoutPanel16.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 74f));
			this.tableLayoutPanel16.Size = new global::System.Drawing.Size(313, 77);
			this.tableLayoutPanel16.TabIndex = 4;
			this.tableLayoutPanel18.ColumnCount = 2;
			this.tableLayoutPanel18.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanel18.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Absolute, 19f));
			this.tableLayoutPanel18.Controls.Add(this.CurrentLobbyLabelPlayerTotal, 0, 2);
			this.tableLayoutPanel18.Controls.Add(this.CurrentLobbyLabelPlayerTotalValue, 1, 2);
			this.tableLayoutPanel18.Controls.Add(this.CurrentLobbyLabelBannedPlayersValue, 1, 1);
			this.tableLayoutPanel18.Controls.Add(this.CurrentLobbyLabelFriendsValue, 1, 0);
			this.tableLayoutPanel18.Controls.Add(this.CurrentLobbyLabelBannedPlayers, 0, 1);
			this.tableLayoutPanel18.Controls.Add(this.CurrentLobbyLabelFriends, 0, 0);
			this.tableLayoutPanel18.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel18.Location = new global::System.Drawing.Point(234, 6);
			this.tableLayoutPanel18.Name = "tableLayoutPanel18";
			this.tableLayoutPanel18.RowCount = 3;
			this.tableLayoutPanel18.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 33.33333f));
			this.tableLayoutPanel18.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 33.33333f));
			this.tableLayoutPanel18.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 33.33333f));
			this.tableLayoutPanel18.Size = new global::System.Drawing.Size(73, 65);
			this.tableLayoutPanel18.TabIndex = 10;
			this.CurrentLobbyLabelPlayerTotal.AutoSize = true;
			this.CurrentLobbyLabelPlayerTotal.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.CurrentLobbyLabelPlayerTotal.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.CurrentLobbyLabelPlayerTotal.Location = new global::System.Drawing.Point(0, 42);
			this.CurrentLobbyLabelPlayerTotal.Margin = new global::System.Windows.Forms.Padding(0);
			this.CurrentLobbyLabelPlayerTotal.Name = "CurrentLobbyLabelPlayerTotal";
			this.CurrentLobbyLabelPlayerTotal.Size = new global::System.Drawing.Size(54, 23);
			this.CurrentLobbyLabelPlayerTotal.TabIndex = 15;
			this.CurrentLobbyLabelPlayerTotal.Text = "Total:";
			this.CurrentLobbyLabelPlayerTotal.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.ToolTip.SetToolTip(this.CurrentLobbyLabelPlayerTotal, "Total number of players in this lobby.\r\nNote: This does not count splitscreen players.");
			this.CurrentLobbyLabelPlayerTotalValue.AutoSize = true;
			this.CurrentLobbyLabelPlayerTotalValue.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.CurrentLobbyLabelPlayerTotalValue.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.CurrentLobbyLabelPlayerTotalValue.Location = new global::System.Drawing.Point(54, 42);
			this.CurrentLobbyLabelPlayerTotalValue.Margin = new global::System.Windows.Forms.Padding(0);
			this.CurrentLobbyLabelPlayerTotalValue.Name = "CurrentLobbyLabelPlayerTotalValue";
			this.CurrentLobbyLabelPlayerTotalValue.Size = new global::System.Drawing.Size(19, 23);
			this.CurrentLobbyLabelPlayerTotalValue.TabIndex = 13;
			this.CurrentLobbyLabelPlayerTotalValue.Text = "10";
			this.CurrentLobbyLabelPlayerTotalValue.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.ToolTip.SetToolTip(this.CurrentLobbyLabelPlayerTotalValue, "Total number of players in this lobby.\r\nNote: This does not count splitscreen players.");
			this.CurrentLobbyLabelBannedPlayersValue.AutoSize = true;
			this.CurrentLobbyLabelBannedPlayersValue.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.CurrentLobbyLabelBannedPlayersValue.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.CurrentLobbyLabelBannedPlayersValue.ForeColor = global::System.Drawing.Color.Red;
			this.CurrentLobbyLabelBannedPlayersValue.Location = new global::System.Drawing.Point(54, 21);
			this.CurrentLobbyLabelBannedPlayersValue.Margin = new global::System.Windows.Forms.Padding(0);
			this.CurrentLobbyLabelBannedPlayersValue.Name = "CurrentLobbyLabelBannedPlayersValue";
			this.CurrentLobbyLabelBannedPlayersValue.Size = new global::System.Drawing.Size(19, 21);
			this.CurrentLobbyLabelBannedPlayersValue.TabIndex = 12;
			this.CurrentLobbyLabelBannedPlayersValue.Text = "10";
			this.CurrentLobbyLabelBannedPlayersValue.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.ToolTip.SetToolTip(this.CurrentLobbyLabelBannedPlayersValue, "Number of players in this lobby that are on your banlist.\r\nThese players are highlighted in red in the above list.");
			this.CurrentLobbyLabelFriendsValue.AutoSize = true;
			this.CurrentLobbyLabelFriendsValue.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.CurrentLobbyLabelFriendsValue.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.CurrentLobbyLabelFriendsValue.ForeColor = global::System.Drawing.Color.Green;
			this.CurrentLobbyLabelFriendsValue.Location = new global::System.Drawing.Point(54, 0);
			this.CurrentLobbyLabelFriendsValue.Margin = new global::System.Windows.Forms.Padding(0);
			this.CurrentLobbyLabelFriendsValue.Name = "CurrentLobbyLabelFriendsValue";
			this.CurrentLobbyLabelFriendsValue.Size = new global::System.Drawing.Size(19, 21);
			this.CurrentLobbyLabelFriendsValue.TabIndex = 11;
			this.CurrentLobbyLabelFriendsValue.Text = "10";
			this.CurrentLobbyLabelFriendsValue.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.ToolTip.SetToolTip(this.CurrentLobbyLabelFriendsValue, "Number of players in this lobby that are on your Steam friend list.\r\nThese players are highlighted in green in the above list.");
			this.CurrentLobbyLabelBannedPlayers.AutoSize = true;
			this.CurrentLobbyLabelBannedPlayers.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.CurrentLobbyLabelBannedPlayers.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.CurrentLobbyLabelBannedPlayers.ForeColor = global::System.Drawing.Color.Red;
			this.CurrentLobbyLabelBannedPlayers.Location = new global::System.Drawing.Point(0, 21);
			this.CurrentLobbyLabelBannedPlayers.Margin = new global::System.Windows.Forms.Padding(0);
			this.CurrentLobbyLabelBannedPlayers.Name = "CurrentLobbyLabelBannedPlayers";
			this.CurrentLobbyLabelBannedPlayers.Size = new global::System.Drawing.Size(54, 21);
			this.CurrentLobbyLabelBannedPlayers.TabIndex = 9;
			this.CurrentLobbyLabelBannedPlayers.Text = "Banned:";
			this.CurrentLobbyLabelBannedPlayers.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.ToolTip.SetToolTip(this.CurrentLobbyLabelBannedPlayers, "Number of players in this lobby that are on your banlist.\r\nThese players are highlighted in red in the above list.");
			this.CurrentLobbyLabelFriends.AutoSize = true;
			this.CurrentLobbyLabelFriends.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.CurrentLobbyLabelFriends.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.CurrentLobbyLabelFriends.ForeColor = global::System.Drawing.Color.Green;
			this.CurrentLobbyLabelFriends.Location = new global::System.Drawing.Point(0, 0);
			this.CurrentLobbyLabelFriends.Margin = new global::System.Windows.Forms.Padding(0);
			this.CurrentLobbyLabelFriends.Name = "CurrentLobbyLabelFriends";
			this.CurrentLobbyLabelFriends.Size = new global::System.Drawing.Size(54, 21);
			this.CurrentLobbyLabelFriends.TabIndex = 8;
			this.CurrentLobbyLabelFriends.Text = "Friends:";
			this.CurrentLobbyLabelFriends.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.ToolTip.SetToolTip(this.CurrentLobbyLabelFriends, "Number of players in this lobby that are on your Steam friend list.\r\nThese players are highlighted in green in the above list.");
			this.tableLayoutPanel17.ColumnCount = 2;
			this.tableLayoutPanel17.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Absolute, 89f));
			this.tableLayoutPanel17.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanel17.Controls.Add(this.CurrentLobbyLabelSLTProtectedValue, 1, 1);
			this.tableLayoutPanel17.Controls.Add(this.CurrentLobbyLabelSLTProtected, 0, 1);
			this.tableLayoutPanel17.Controls.Add(this.CurrentLobbyLabelLobbyIdValue, 1, 2);
			this.tableLayoutPanel17.Controls.Add(this.CurrentLobbyLabelHostValue, 1, 0);
			this.tableLayoutPanel17.Controls.Add(this.CurrentLobbyLabelHost, 0, 0);
			this.tableLayoutPanel17.Controls.Add(this.CurrentLobbyLabelLobbyId, 0, 2);
			this.tableLayoutPanel17.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel17.Location = new global::System.Drawing.Point(6, 6);
			this.tableLayoutPanel17.Name = "tableLayoutPanel17";
			this.tableLayoutPanel17.RowCount = 3;
			this.tableLayoutPanel17.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 33.33333f));
			this.tableLayoutPanel17.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 33.33333f));
			this.tableLayoutPanel17.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 33.33333f));
			this.tableLayoutPanel17.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 20f));
			this.tableLayoutPanel17.Size = new global::System.Drawing.Size(219, 65);
			this.tableLayoutPanel17.TabIndex = 9;
			this.CurrentLobbyLabelSLTProtectedValue.AutoSize = true;
			this.CurrentLobbyLabelSLTProtectedValue.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.CurrentLobbyLabelSLTProtectedValue.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.CurrentLobbyLabelSLTProtectedValue.ForeColor = global::System.Drawing.Color.Black;
			this.CurrentLobbyLabelSLTProtectedValue.Location = new global::System.Drawing.Point(89, 21);
			this.CurrentLobbyLabelSLTProtectedValue.Margin = new global::System.Windows.Forms.Padding(0);
			this.CurrentLobbyLabelSLTProtectedValue.Name = "CurrentLobbyLabelSLTProtectedValue";
			this.CurrentLobbyLabelSLTProtectedValue.Size = new global::System.Drawing.Size(130, 21);
			this.CurrentLobbyLabelSLTProtectedValue.TabIndex = 12;
			this.CurrentLobbyLabelSLTProtectedValue.Text = "[SLT Protected]";
			this.CurrentLobbyLabelSLTProtectedValue.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.ToolTip.SetToolTip(this.CurrentLobbyLabelSLTProtectedValue, "Shows if the current host is using Super Lobby Tool.");
			this.CurrentLobbyLabelSLTProtected.AutoSize = true;
			this.CurrentLobbyLabelSLTProtected.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.CurrentLobbyLabelSLTProtected.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.CurrentLobbyLabelSLTProtected.ForeColor = global::System.Drawing.Color.Black;
			this.CurrentLobbyLabelSLTProtected.Location = new global::System.Drawing.Point(0, 21);
			this.CurrentLobbyLabelSLTProtected.Margin = new global::System.Windows.Forms.Padding(0);
			this.CurrentLobbyLabelSLTProtected.Name = "CurrentLobbyLabelSLTProtected";
			this.CurrentLobbyLabelSLTProtected.Size = new global::System.Drawing.Size(89, 21);
			this.CurrentLobbyLabelSLTProtected.TabIndex = 9;
			this.CurrentLobbyLabelSLTProtected.Text = "SLT Protected:";
			this.CurrentLobbyLabelSLTProtected.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.ToolTip.SetToolTip(this.CurrentLobbyLabelSLTProtected, "Shows if the current host is using Super Lobby Tool.");
			this.CurrentLobbyLabelLobbyIdValue.AutoSize = true;
			this.CurrentLobbyLabelLobbyIdValue.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.CurrentLobbyLabelLobbyIdValue.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.CurrentLobbyLabelLobbyIdValue.ForeColor = global::System.Drawing.Color.Black;
			this.CurrentLobbyLabelLobbyIdValue.Location = new global::System.Drawing.Point(89, 42);
			this.CurrentLobbyLabelLobbyIdValue.Margin = new global::System.Windows.Forms.Padding(0);
			this.CurrentLobbyLabelLobbyIdValue.Name = "CurrentLobbyLabelLobbyIdValue";
			this.CurrentLobbyLabelLobbyIdValue.Size = new global::System.Drawing.Size(130, 23);
			this.CurrentLobbyLabelLobbyIdValue.TabIndex = 8;
			this.CurrentLobbyLabelLobbyIdValue.Text = "000000000000000000";
			this.CurrentLobbyLabelLobbyIdValue.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.ToolTip.SetToolTip(this.CurrentLobbyLabelLobbyIdValue, "Unique identifier of this lobby.");
			this.CurrentLobbyLabelHostValue.AutoSize = true;
			this.CurrentLobbyLabelHostValue.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.CurrentLobbyLabelHostValue.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.CurrentLobbyLabelHostValue.ForeColor = global::System.Drawing.Color.Magenta;
			this.CurrentLobbyLabelHostValue.Location = new global::System.Drawing.Point(89, 0);
			this.CurrentLobbyLabelHostValue.Margin = new global::System.Windows.Forms.Padding(0);
			this.CurrentLobbyLabelHostValue.Name = "CurrentLobbyLabelHostValue";
			this.CurrentLobbyLabelHostValue.Size = new global::System.Drawing.Size(130, 21);
			this.CurrentLobbyLabelHostValue.TabIndex = 7;
			this.CurrentLobbyLabelHostValue.Text = "[Host]";
			this.CurrentLobbyLabelHostValue.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.ToolTip.SetToolTip(this.CurrentLobbyLabelHostValue, "Player that currently has host control.");
			this.CurrentLobbyLabelHost.AutoSize = true;
			this.CurrentLobbyLabelHost.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.CurrentLobbyLabelHost.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.CurrentLobbyLabelHost.ForeColor = global::System.Drawing.Color.Magenta;
			this.CurrentLobbyLabelHost.Location = new global::System.Drawing.Point(0, 0);
			this.CurrentLobbyLabelHost.Margin = new global::System.Windows.Forms.Padding(0);
			this.CurrentLobbyLabelHost.Name = "CurrentLobbyLabelHost";
			this.CurrentLobbyLabelHost.Size = new global::System.Drawing.Size(89, 21);
			this.CurrentLobbyLabelHost.TabIndex = 5;
			this.CurrentLobbyLabelHost.Text = "Host:";
			this.CurrentLobbyLabelHost.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.ToolTip.SetToolTip(this.CurrentLobbyLabelHost, "Player that currently has host control.\r\nThis player is highlighted in magenta in the above list.");
			this.CurrentLobbyLabelLobbyId.AutoSize = true;
			this.CurrentLobbyLabelLobbyId.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.CurrentLobbyLabelLobbyId.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.CurrentLobbyLabelLobbyId.ForeColor = global::System.Drawing.Color.Black;
			this.CurrentLobbyLabelLobbyId.Location = new global::System.Drawing.Point(0, 42);
			this.CurrentLobbyLabelLobbyId.Margin = new global::System.Windows.Forms.Padding(0);
			this.CurrentLobbyLabelLobbyId.Name = "CurrentLobbyLabelLobbyId";
			this.CurrentLobbyLabelLobbyId.Size = new global::System.Drawing.Size(89, 23);
			this.CurrentLobbyLabelLobbyId.TabIndex = 2;
			this.CurrentLobbyLabelLobbyId.Text = "Lobby ID:";
			this.CurrentLobbyLabelLobbyId.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.ToolTip.SetToolTip(this.CurrentLobbyLabelLobbyId, "Unique identifier of this lobby.");
			this.CurrentLobbyGroupBoxHostOptions.Controls.Add(this.tableLayoutPanel23);
			this.CurrentLobbyGroupBoxHostOptions.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.CurrentLobbyGroupBoxHostOptions.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold);
			this.CurrentLobbyGroupBoxHostOptions.Location = new global::System.Drawing.Point(332, 347);
			this.CurrentLobbyGroupBoxHostOptions.Name = "CurrentLobbyGroupBoxHostOptions";
			this.TableLayoutPanel8.SetRowSpan(this.CurrentLobbyGroupBoxHostOptions, 2);
			this.CurrentLobbyGroupBoxHostOptions.Size = new global::System.Drawing.Size(140, 178);
			this.CurrentLobbyGroupBoxHostOptions.TabIndex = 17;
			this.CurrentLobbyGroupBoxHostOptions.TabStop = false;
			this.CurrentLobbyGroupBoxHostOptions.Text = "Host Options";
			this.ToolTip.SetToolTip(this.CurrentLobbyGroupBoxHostOptions, "Options which can be used when you are the host.");
			this.tableLayoutPanel23.ColumnCount = 1;
			this.tableLayoutPanel23.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanel23.Controls.Add(this.CurrentLobbyCheckBoxSkipLobbySearch, 0, 1);
			this.tableLayoutPanel23.Controls.Add(this.CurrentLobbyCheckBoxDisableMirrorTracks, 0, 2);
			this.tableLayoutPanel23.Controls.Add(this.CurrentLobbyButtonMigrateHost, 0, 0);
			this.tableLayoutPanel23.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel23.Location = new global::System.Drawing.Point(3, 19);
			this.tableLayoutPanel23.Name = "tableLayoutPanel23";
			this.tableLayoutPanel23.RowCount = 4;
			this.tableLayoutPanel23.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 65f));
			this.tableLayoutPanel23.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 31f));
			this.tableLayoutPanel23.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 46f));
			this.tableLayoutPanel23.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanel23.Size = new global::System.Drawing.Size(134, 156);
			this.tableLayoutPanel23.TabIndex = 9;
			this.CurrentLobbyCheckBoxSkipLobbySearch.AutoSize = true;
			this.CurrentLobbyCheckBoxSkipLobbySearch.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.CurrentLobbyCheckBoxSkipLobbySearch.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.CurrentLobbyCheckBoxSkipLobbySearch.Location = new global::System.Drawing.Point(3, 68);
			this.CurrentLobbyCheckBoxSkipLobbySearch.Name = "CurrentLobbyCheckBoxSkipLobbySearch";
			this.CurrentLobbyCheckBoxSkipLobbySearch.Padding = new global::System.Windows.Forms.Padding(3);
			this.CurrentLobbyCheckBoxSkipLobbySearch.Size = new global::System.Drawing.Size(128, 25);
			this.CurrentLobbyCheckBoxSkipLobbySearch.TabIndex = 9;
			this.CurrentLobbyCheckBoxSkipLobbySearch.Text = "Skip lobby search";
			this.CurrentLobbyCheckBoxSkipLobbySearch.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.ToolTip.SetToolTip(this.CurrentLobbyCheckBoxSkipLobbySearch, "When enabled, the game will always create an empty lobby when you go into matchmaking.");
			this.CurrentLobbyCheckBoxSkipLobbySearch.UseVisualStyleBackColor = true;
			this.CurrentLobbyCheckBoxSkipLobbySearch.Click += new global::System.EventHandler(this.CurrentLobbyCheckBoxForceHost_Click);
			this.CurrentLobbyCheckBoxDisableMirrorTracks.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.CurrentLobbyCheckBoxDisableMirrorTracks.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.CurrentLobbyCheckBoxDisableMirrorTracks.Location = new global::System.Drawing.Point(3, 99);
			this.CurrentLobbyCheckBoxDisableMirrorTracks.Name = "CurrentLobbyCheckBoxDisableMirrorTracks";
			this.CurrentLobbyCheckBoxDisableMirrorTracks.Padding = new global::System.Windows.Forms.Padding(3);
			this.CurrentLobbyCheckBoxDisableMirrorTracks.Size = new global::System.Drawing.Size(128, 40);
			this.CurrentLobbyCheckBoxDisableMirrorTracks.TabIndex = 8;
			this.CurrentLobbyCheckBoxDisableMirrorTracks.Text = "Disable\r\nMirror Tracks";
			this.CurrentLobbyCheckBoxDisableMirrorTracks.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.ToolTip.SetToolTip(this.CurrentLobbyCheckBoxDisableMirrorTracks, "When enabled (and you are host), the game will never select a mirror track in matchmaking.");
			this.CurrentLobbyCheckBoxDisableMirrorTracks.UseVisualStyleBackColor = true;
			this.CurrentLobbyCheckBoxDisableMirrorTracks.Click += new global::System.EventHandler(this.CurrentLobbyCheckBoxMirrorTracks_Click);
			this.CurrentLobbyButtonMigrateHost.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.CurrentLobbyButtonMigrateHost.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.CurrentLobbyButtonMigrateHost.Location = new global::System.Drawing.Point(3, 3);
			this.CurrentLobbyButtonMigrateHost.Name = "CurrentLobbyButtonMigrateHost";
			this.CurrentLobbyButtonMigrateHost.Size = new global::System.Drawing.Size(128, 59);
			this.CurrentLobbyButtonMigrateHost.TabIndex = 7;
			this.CurrentLobbyButtonMigrateHost.Text = "Migrate Host\r\n (to selected player)";
			this.ToolTip.SetToolTip(this.CurrentLobbyButtonMigrateHost, "The role of host will be passed from you to the currently selected player.");
			this.CurrentLobbyButtonMigrateHost.UseVisualStyleBackColor = true;
			this.CurrentLobbyButtonMigrateHost.Click += new global::System.EventHandler(this.CurrentLobbyButtonMigrateHost_Click);
			this.CurrentLobbyGroupBoxPlayerOptions.Controls.Add(this.TableLayoutPanel3);
			this.CurrentLobbyGroupBoxPlayerOptions.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.CurrentLobbyGroupBoxPlayerOptions.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold);
			this.CurrentLobbyGroupBoxPlayerOptions.Location = new global::System.Drawing.Point(3, 347);
			this.CurrentLobbyGroupBoxPlayerOptions.Name = "CurrentLobbyGroupBoxPlayerOptions";
			this.CurrentLobbyGroupBoxPlayerOptions.Size = new global::System.Drawing.Size(323, 69);
			this.CurrentLobbyGroupBoxPlayerOptions.TabIndex = 15;
			this.CurrentLobbyGroupBoxPlayerOptions.TabStop = false;
			this.CurrentLobbyGroupBoxPlayerOptions.Text = "Player Options";
			this.ToolTip.SetToolTip(this.CurrentLobbyGroupBoxPlayerOptions, "Options for the list of players shown above.");
			this.TableLayoutPanel3.ColumnCount = 2;
			this.TableLayoutPanel3.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.TableLayoutPanel3.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.TableLayoutPanel3.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel3.Controls.Add(this.CurrentLobbyButtonBan, 1, 0);
			this.TableLayoutPanel3.Controls.Add(this.CurrentLobbyButtonViewProfile, 0, 0);
			this.TableLayoutPanel3.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.TableLayoutPanel3.Location = new global::System.Drawing.Point(3, 19);
			this.TableLayoutPanel3.Name = "TableLayoutPanel3";
			this.TableLayoutPanel3.RowCount = 1;
			this.TableLayoutPanel3.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.TableLayoutPanel3.Size = new global::System.Drawing.Size(317, 47);
			this.TableLayoutPanel3.TabIndex = 0;
			this.CurrentLobbyButtonBan.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.CurrentLobbyButtonBan.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.CurrentLobbyButtonBan.Location = new global::System.Drawing.Point(161, 3);
			this.CurrentLobbyButtonBan.Name = "CurrentLobbyButtonBan";
			this.CurrentLobbyButtonBan.Size = new global::System.Drawing.Size(153, 41);
			this.CurrentLobbyButtonBan.TabIndex = 2;
			this.CurrentLobbyButtonBan.Text = "Ban Player";
			this.ToolTip.SetToolTip(this.CurrentLobbyButtonBan, "Add the currently selected players to the banlist.\r\nIf you are host, the players will be kicked from the lobby immediately.");
			this.CurrentLobbyButtonBan.UseVisualStyleBackColor = true;
			this.CurrentLobbyButtonBan.Click += new global::System.EventHandler(this.CurrentLobbyButtonBan_Click);
			this.CurrentLobbyButtonViewProfile.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.CurrentLobbyButtonViewProfile.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.CurrentLobbyButtonViewProfile.Location = new global::System.Drawing.Point(3, 3);
			this.CurrentLobbyButtonViewProfile.Name = "CurrentLobbyButtonViewProfile";
			this.CurrentLobbyButtonViewProfile.Size = new global::System.Drawing.Size(152, 41);
			this.CurrentLobbyButtonViewProfile.TabIndex = 3;
			this.CurrentLobbyButtonViewProfile.Text = "View Profile";
			this.ToolTip.SetToolTip(this.CurrentLobbyButtonViewProfile, "View the steam profiles of the currently selected players.");
			this.CurrentLobbyButtonViewProfile.UseVisualStyleBackColor = true;
			this.CurrentLobbyButtonViewProfile.Click += new global::System.EventHandler(this.CurrentLobbyButtonViewProfile_Click);
			this.CurrentLobbyListView.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.CurrentLobbyColumnName,
				this.CurrentLobbyColumnSteamId,
				this.CurrentLobbyColumnPing
			});
			this.TableLayoutPanel8.SetColumnSpan(this.CurrentLobbyListView, 2);
			this.CurrentLobbyListView.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.CurrentLobbyListView.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold);
			this.CurrentLobbyListView.FullRowSelect = true;
			this.CurrentLobbyListView.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.CurrentLobbyListView.HideSelection = false;
			this.CurrentLobbyListView.Location = new global::System.Drawing.Point(3, 3);
			this.CurrentLobbyListView.Name = "CurrentLobbyListView";
			this.CurrentLobbyListView.Size = new global::System.Drawing.Size(469, 338);
			this.CurrentLobbyListView.TabIndex = 1;
			this.ToolTip.SetToolTip(this.CurrentLobbyListView, "List of players in the current lobby.\r\nNote: This does not show all splitscreen players.");
			this.CurrentLobbyListView.UseCompatibleStateImageBehavior = false;
			this.CurrentLobbyListView.View = global::System.Windows.Forms.View.Details;
			this.CurrentLobbyColumnName.Text = "Name";
			this.CurrentLobbyColumnName.Width = 260;
			this.CurrentLobbyColumnSteamId.Text = "Steam ID";
			this.CurrentLobbyColumnSteamId.Width = 136;
			this.CurrentLobbyColumnPing.Text = "Ping";
			this.CurrentLobbyColumnPing.Width = 52;
			this.AllLobbiesTab.Controls.Add(this.tableLayoutPanel2);
			this.AllLobbiesTab.Location = new global::System.Drawing.Point(4, 24);
			this.AllLobbiesTab.Name = "AllLobbiesTab";
			this.AllLobbiesTab.Size = new global::System.Drawing.Size(475, 528);
			this.AllLobbiesTab.TabIndex = 4;
			this.AllLobbiesTab.Text = "All Lobbies";
			this.AllLobbiesTab.UseVisualStyleBackColor = true;
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel2.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel2.Controls.Add(this.AllLobbiesLabelLobbyCount, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.AllLobbiesLabelPlayerCount, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.GroupBoxLobbyListControls, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.AllLobbiesListView, 0, 0);
			this.tableLayoutPanel2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new global::System.Drawing.Point(0, 0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 3;
			this.tableLayoutPanel2.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanel2.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 23f));
			this.tableLayoutPanel2.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 122f));
			this.tableLayoutPanel2.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 20f));
			this.tableLayoutPanel2.Size = new global::System.Drawing.Size(475, 528);
			this.tableLayoutPanel2.TabIndex = 2;
			this.AllLobbiesLabelLobbyCount.AutoSize = true;
			this.AllLobbiesLabelLobbyCount.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.AllLobbiesLabelLobbyCount.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.AllLobbiesLabelLobbyCount.Location = new global::System.Drawing.Point(240, 383);
			this.AllLobbiesLabelLobbyCount.Name = "AllLobbiesLabelLobbyCount";
			this.AllLobbiesLabelLobbyCount.Padding = new global::System.Windows.Forms.Padding(3);
			this.AllLobbiesLabelLobbyCount.Size = new global::System.Drawing.Size(232, 23);
			this.AllLobbiesLabelLobbyCount.TabIndex = 20;
			this.AllLobbiesLabelLobbyCount.Text = "Lobby Total:";
			this.ToolTip.SetToolTip(this.AllLobbiesLabelLobbyCount, "Total number of active lobbies.");
			this.AllLobbiesLabelPlayerCount.AccessibleDescription = "";
			this.AllLobbiesLabelPlayerCount.AutoSize = true;
			this.AllLobbiesLabelPlayerCount.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.AllLobbiesLabelPlayerCount.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.AllLobbiesLabelPlayerCount.Location = new global::System.Drawing.Point(3, 383);
			this.AllLobbiesLabelPlayerCount.Name = "AllLobbiesLabelPlayerCount";
			this.AllLobbiesLabelPlayerCount.Padding = new global::System.Windows.Forms.Padding(3);
			this.AllLobbiesLabelPlayerCount.Size = new global::System.Drawing.Size(231, 23);
			this.AllLobbiesLabelPlayerCount.TabIndex = 19;
			this.AllLobbiesLabelPlayerCount.Text = "Player Total:";
			this.ToolTip.SetToolTip(this.AllLobbiesLabelPlayerCount, "Number of players currently playing online.\r\nNote: This does not count splitscreen players.");
			this.tableLayoutPanel2.SetColumnSpan(this.GroupBoxLobbyListControls, 2);
			this.GroupBoxLobbyListControls.Controls.Add(this.tableLayoutPanel6);
			this.GroupBoxLobbyListControls.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.GroupBoxLobbyListControls.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.GroupBoxLobbyListControls.Location = new global::System.Drawing.Point(3, 409);
			this.GroupBoxLobbyListControls.Name = "GroupBoxLobbyListControls";
			this.GroupBoxLobbyListControls.Size = new global::System.Drawing.Size(469, 116);
			this.GroupBoxLobbyListControls.TabIndex = 15;
			this.GroupBoxLobbyListControls.TabStop = false;
			this.GroupBoxLobbyListControls.Text = "Controls";
			this.tableLayoutPanel6.ColumnCount = 2;
			this.tableLayoutPanel6.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel6.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel6.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Absolute, 20f));
			this.tableLayoutPanel6.Controls.Add(this.AllLobbiesButtonLink, 0, 1);
			this.tableLayoutPanel6.Controls.Add(this.AllLobbiesButtonViewPlayers, 0, 0);
			this.tableLayoutPanel6.Controls.Add(this.AllLobbiesButtonRefreshList, 0, 0);
			this.tableLayoutPanel6.Controls.Add(this.AllLobbiesButtonJoinLobby, 0, 1);
			this.tableLayoutPanel6.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel6.Location = new global::System.Drawing.Point(3, 19);
			this.tableLayoutPanel6.Name = "tableLayoutPanel6";
			this.tableLayoutPanel6.RowCount = 2;
			this.tableLayoutPanel6.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel6.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel6.Size = new global::System.Drawing.Size(463, 94);
			this.tableLayoutPanel6.TabIndex = 0;
			this.AllLobbiesButtonLink.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.AllLobbiesButtonLink.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.AllLobbiesButtonLink.Location = new global::System.Drawing.Point(234, 50);
			this.AllLobbiesButtonLink.Name = "AllLobbiesButtonLink";
			this.AllLobbiesButtonLink.Size = new global::System.Drawing.Size(226, 41);
			this.AllLobbiesButtonLink.TabIndex = 5;
			this.AllLobbiesButtonLink.Text = "Get Lobby Link";
			this.ToolTip.SetToolTip(this.AllLobbiesButtonLink, "Get a link to the currently selected lobby.\r\nThis can be sent to other players so that they can join.");
			this.AllLobbiesButtonLink.UseVisualStyleBackColor = true;
			this.AllLobbiesButtonLink.Click += new global::System.EventHandler(this.AllLobbiesButtonLink_Click);
			this.AllLobbiesButtonViewPlayers.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.AllLobbiesButtonViewPlayers.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.AllLobbiesButtonViewPlayers.Location = new global::System.Drawing.Point(234, 3);
			this.AllLobbiesButtonViewPlayers.Name = "AllLobbiesButtonViewPlayers";
			this.AllLobbiesButtonViewPlayers.Size = new global::System.Drawing.Size(226, 41);
			this.AllLobbiesButtonViewPlayers.TabIndex = 3;
			this.AllLobbiesButtonViewPlayers.Text = "View Lobby Details";
			this.ToolTip.SetToolTip(this.AllLobbiesButtonViewPlayers, "View details of the currently selected lobby.");
			this.AllLobbiesButtonViewPlayers.UseVisualStyleBackColor = true;
			this.AllLobbiesButtonViewPlayers.Click += new global::System.EventHandler(this.AllLobbiesButtonViewPlayers_Click);
			this.AllLobbiesButtonRefreshList.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.AllLobbiesButtonRefreshList.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.AllLobbiesButtonRefreshList.Location = new global::System.Drawing.Point(3, 3);
			this.AllLobbiesButtonRefreshList.Name = "AllLobbiesButtonRefreshList";
			this.AllLobbiesButtonRefreshList.Size = new global::System.Drawing.Size(225, 41);
			this.AllLobbiesButtonRefreshList.TabIndex = 2;
			this.AllLobbiesButtonRefreshList.Text = "Refresh List";
			this.ToolTip.SetToolTip(this.AllLobbiesButtonRefreshList, "Refresh the list of lobbies.");
			this.AllLobbiesButtonRefreshList.UseVisualStyleBackColor = true;
			this.AllLobbiesButtonRefreshList.Click += new global::System.EventHandler(this.AllLobbiesButtonRefresh_Click);
			this.AllLobbiesButtonJoinLobby.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.AllLobbiesButtonJoinLobby.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.AllLobbiesButtonJoinLobby.Location = new global::System.Drawing.Point(3, 50);
			this.AllLobbiesButtonJoinLobby.Name = "AllLobbiesButtonJoinLobby";
			this.AllLobbiesButtonJoinLobby.Size = new global::System.Drawing.Size(225, 41);
			this.AllLobbiesButtonJoinLobby.TabIndex = 4;
			this.AllLobbiesButtonJoinLobby.Text = "Join Lobby";
			this.ToolTip.SetToolTip(this.AllLobbiesButtonJoinLobby, "Join the currently selected lobby.");
			this.AllLobbiesButtonJoinLobby.UseVisualStyleBackColor = true;
			this.AllLobbiesButtonJoinLobby.Click += new global::System.EventHandler(this.AllLobbiesButtonJoin_Click);
			this.AllLobbiesListView.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.AllLobbiesColumnCreator,
				this.AllLobbiesColumnType,
				this.AllLobbiesColumnPlayers,
				this.AllLobbiesColumnActivity
			});
			this.tableLayoutPanel2.SetColumnSpan(this.AllLobbiesListView, 2);
			this.AllLobbiesListView.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.AllLobbiesListView.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.AllLobbiesListView.FullRowSelect = true;
			this.AllLobbiesListView.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.AllLobbiesListView.HideSelection = false;
			this.AllLobbiesListView.Location = new global::System.Drawing.Point(3, 3);
			this.AllLobbiesListView.MultiSelect = false;
			this.AllLobbiesListView.Name = "AllLobbiesListView";
			this.AllLobbiesListView.Size = new global::System.Drawing.Size(469, 377);
			this.AllLobbiesListView.TabIndex = 1;
			this.ToolTip.SetToolTip(this.AllLobbiesListView, "List of all the currently active lobbies.\r\nLobbies coloured green are protected by Super Lobby Tool.\r\nNote: Full lobbies without SLT protection will not show here.");
			this.AllLobbiesListView.UseCompatibleStateImageBehavior = false;
			this.AllLobbiesListView.View = global::System.Windows.Forms.View.Details;
			this.AllLobbiesColumnCreator.Text = "Creator";
			this.AllLobbiesColumnCreator.Width = 141;
			this.AllLobbiesColumnType.Text = "Type";
			this.AllLobbiesColumnType.Width = 166;
			this.AllLobbiesColumnPlayers.Text = "Players";
			this.AllLobbiesColumnPlayers.Width = 51;
			this.AllLobbiesColumnActivity.Text = "Activity";
			this.AllLobbiesColumnActivity.Width = 90;
			this.WhitelistTab.Controls.Add(this.tableLayoutPanel20);
			this.WhitelistTab.Location = new global::System.Drawing.Point(4, 24);
			this.WhitelistTab.Name = "WhitelistTab";
			this.WhitelistTab.Size = new global::System.Drawing.Size(475, 528);
			this.WhitelistTab.TabIndex = 5;
			this.WhitelistTab.Text = "Whitelist";
			this.WhitelistTab.UseVisualStyleBackColor = true;
			this.tableLayoutPanel20.ColumnCount = 4;
			this.tableLayoutPanel20.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 33.33334f));
			this.tableLayoutPanel20.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 16.66668f));
			this.tableLayoutPanel20.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 16.66662f));
			this.tableLayoutPanel20.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 33.33336f));
			this.tableLayoutPanel20.Controls.Add(this.WhitelistLabelBlockedConnections, 2, 2);
			this.tableLayoutPanel20.Controls.Add(this.WhitelistGroupBoxTextList, 4, 3);
			this.tableLayoutPanel20.Controls.Add(this.WhitelistLabelActive, 0, 2);
			this.tableLayoutPanel20.Controls.Add(this.WhitelistLabelPlayerCount, 1, 2);
			this.tableLayoutPanel20.Controls.Add(this.WhitelistCheckBoxEnable, 0, 0);
			this.tableLayoutPanel20.Controls.Add(this.WhitelistGroupBoxPlayerOptions, 0, 3);
			this.tableLayoutPanel20.Controls.Add(this.WhitelistListView, 0, 1);
			this.tableLayoutPanel20.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel20.Location = new global::System.Drawing.Point(0, 0);
			this.tableLayoutPanel20.Name = "tableLayoutPanel20";
			this.tableLayoutPanel20.RowCount = 4;
			this.tableLayoutPanel20.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 35f));
			this.tableLayoutPanel20.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanel20.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 23f));
			this.tableLayoutPanel20.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 122f));
			this.tableLayoutPanel20.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 20f));
			this.tableLayoutPanel20.Size = new global::System.Drawing.Size(475, 528);
			this.tableLayoutPanel20.TabIndex = 4;
			this.WhitelistLabelBlockedConnections.AutoSize = true;
			this.WhitelistLabelBlockedConnections.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.WhitelistLabelBlockedConnections.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.WhitelistLabelBlockedConnections.ForeColor = global::System.Drawing.Color.Red;
			this.WhitelistLabelBlockedConnections.Location = new global::System.Drawing.Point(319, 383);
			this.WhitelistLabelBlockedConnections.Name = "WhitelistLabelBlockedConnections";
			this.WhitelistLabelBlockedConnections.Padding = new global::System.Windows.Forms.Padding(3);
			this.WhitelistLabelBlockedConnections.Size = new global::System.Drawing.Size(153, 23);
			this.WhitelistLabelBlockedConnections.TabIndex = 31;
			this.WhitelistLabelBlockedConnections.Text = "Blocked Connections: 0";
			this.ToolTip.SetToolTip(this.WhitelistLabelBlockedConnections, "Number of times a player has been blocked from entering your lobby.\r\nOnly counts blocks due to the witelist feature.\r\nIncludes multiple blocks from the same player.");
			this.WhitelistGroupBoxTextList.Controls.Add(this.tableLayoutPanel21);
			this.WhitelistGroupBoxTextList.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.WhitelistGroupBoxTextList.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold);
			this.WhitelistGroupBoxTextList.Location = new global::System.Drawing.Point(319, 409);
			this.WhitelistGroupBoxTextList.Name = "WhitelistGroupBoxTextList";
			this.WhitelistGroupBoxTextList.Size = new global::System.Drawing.Size(153, 116);
			this.WhitelistGroupBoxTextList.TabIndex = 30;
			this.WhitelistGroupBoxTextList.TabStop = false;
			this.WhitelistGroupBoxTextList.Text = "Text List";
			this.ToolTip.SetToolTip(this.WhitelistGroupBoxTextList, "Tools for importing and exporting text whitelists.");
			this.tableLayoutPanel21.ColumnCount = 1;
			this.tableLayoutPanel21.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanel21.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Absolute, 20f));
			this.tableLayoutPanel21.Controls.Add(this.WhitelistButtonImport, 0, 0);
			this.tableLayoutPanel21.Controls.Add(this.WhitelistButtonExport, 0, 1);
			this.tableLayoutPanel21.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel21.Location = new global::System.Drawing.Point(3, 19);
			this.tableLayoutPanel21.Name = "tableLayoutPanel21";
			this.tableLayoutPanel21.RowCount = 2;
			this.tableLayoutPanel21.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel21.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel21.Size = new global::System.Drawing.Size(147, 94);
			this.tableLayoutPanel21.TabIndex = 0;
			this.WhitelistButtonImport.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.WhitelistButtonImport.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.WhitelistButtonImport.Location = new global::System.Drawing.Point(3, 3);
			this.WhitelistButtonImport.Name = "WhitelistButtonImport";
			this.WhitelistButtonImport.Size = new global::System.Drawing.Size(141, 41);
			this.WhitelistButtonImport.TabIndex = 7;
			this.WhitelistButtonImport.Text = "Import";
			this.ToolTip.SetToolTip(this.WhitelistButtonImport, "Import players from a text whitelist.");
			this.WhitelistButtonImport.UseVisualStyleBackColor = true;
			this.WhitelistButtonImport.Click += new global::System.EventHandler(this.WhitelistButtonImport_Click);
			this.WhitelistButtonExport.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.WhitelistButtonExport.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.WhitelistButtonExport.Location = new global::System.Drawing.Point(3, 50);
			this.WhitelistButtonExport.Name = "WhitelistButtonExport";
			this.WhitelistButtonExport.Size = new global::System.Drawing.Size(141, 41);
			this.WhitelistButtonExport.TabIndex = 8;
			this.WhitelistButtonExport.Text = "Export";
			this.ToolTip.SetToolTip(this.WhitelistButtonExport, "Export players to a text whitelist.");
			this.WhitelistButtonExport.UseVisualStyleBackColor = true;
			this.WhitelistButtonExport.Click += new global::System.EventHandler(this.WhitelistButtonExport_Click);
			this.WhitelistLabelActive.AutoSize = true;
			this.WhitelistLabelActive.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.WhitelistLabelActive.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.WhitelistLabelActive.Location = new global::System.Drawing.Point(3, 383);
			this.WhitelistLabelActive.Name = "WhitelistLabelActive";
			this.WhitelistLabelActive.Padding = new global::System.Windows.Forms.Padding(3);
			this.WhitelistLabelActive.Size = new global::System.Drawing.Size(152, 23);
			this.WhitelistLabelActive.TabIndex = 29;
			this.WhitelistLabelActive.Text = "Whitelist is active:";
			this.ToolTip.SetToolTip(this.WhitelistLabelActive, "Shows whether the whitelist is being used in the current lobby.");
			this.WhitelistLabelPlayerCount.AutoSize = true;
			this.tableLayoutPanel20.SetColumnSpan(this.WhitelistLabelPlayerCount, 2);
			this.WhitelistLabelPlayerCount.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.WhitelistLabelPlayerCount.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.WhitelistLabelPlayerCount.Location = new global::System.Drawing.Point(161, 383);
			this.WhitelistLabelPlayerCount.Name = "WhitelistLabelPlayerCount";
			this.WhitelistLabelPlayerCount.Padding = new global::System.Windows.Forms.Padding(3);
			this.WhitelistLabelPlayerCount.Size = new global::System.Drawing.Size(152, 21);
			this.WhitelistLabelPlayerCount.TabIndex = 28;
			this.WhitelistLabelPlayerCount.Text = "Player Count: 0";
			this.ToolTip.SetToolTip(this.WhitelistLabelPlayerCount, "Number of players on the whitelist.");
			this.WhitelistCheckBoxEnable.AutoSize = true;
			this.tableLayoutPanel20.SetColumnSpan(this.WhitelistCheckBoxEnable, 4);
			this.WhitelistCheckBoxEnable.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.WhitelistCheckBoxEnable.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.WhitelistCheckBoxEnable.Location = new global::System.Drawing.Point(3, 3);
			this.WhitelistCheckBoxEnable.Name = "WhitelistCheckBoxEnable";
			this.WhitelistCheckBoxEnable.Padding = new global::System.Windows.Forms.Padding(3);
			this.WhitelistCheckBoxEnable.Size = new global::System.Drawing.Size(469, 29);
			this.WhitelistCheckBoxEnable.TabIndex = 1;
			this.WhitelistCheckBoxEnable.Text = "Enable Whitelist";
			this.ToolTip.SetToolTip(this.WhitelistCheckBoxEnable, "When enabled, the whitelist feature will be used.\r\nThis feature works only in custom lobbies.\r\nIt will override your banlist.");
			this.WhitelistCheckBoxEnable.UseVisualStyleBackColor = true;
			this.WhitelistCheckBoxEnable.Click += new global::System.EventHandler(this.WhitelistCheckBoxEnable_Click);
			this.tableLayoutPanel20.SetColumnSpan(this.WhitelistGroupBoxPlayerOptions, 3);
			this.WhitelistGroupBoxPlayerOptions.Controls.Add(this.tableLayoutPanel22);
			this.WhitelistGroupBoxPlayerOptions.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.WhitelistGroupBoxPlayerOptions.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold);
			this.WhitelistGroupBoxPlayerOptions.Location = new global::System.Drawing.Point(3, 409);
			this.WhitelistGroupBoxPlayerOptions.Name = "WhitelistGroupBoxPlayerOptions";
			this.WhitelistGroupBoxPlayerOptions.Size = new global::System.Drawing.Size(310, 116);
			this.WhitelistGroupBoxPlayerOptions.TabIndex = 15;
			this.WhitelistGroupBoxPlayerOptions.TabStop = false;
			this.WhitelistGroupBoxPlayerOptions.Text = "Player Options";
			this.ToolTip.SetToolTip(this.WhitelistGroupBoxPlayerOptions, "Options for the list of players shown above.");
			this.tableLayoutPanel22.ColumnCount = 2;
			this.tableLayoutPanel22.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel22.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel22.Controls.Add(this.WhitelistButtonAdd, 1, 1);
			this.tableLayoutPanel22.Controls.Add(this.WhitelistButtonEdit, 0, 0);
			this.tableLayoutPanel22.Controls.Add(this.WhitelistButtonRemove, 1, 0);
			this.tableLayoutPanel22.Controls.Add(this.WhitelistButtonViewProfile, 0, 1);
			this.tableLayoutPanel22.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel22.Location = new global::System.Drawing.Point(3, 19);
			this.tableLayoutPanel22.Name = "tableLayoutPanel22";
			this.tableLayoutPanel22.RowCount = 2;
			this.tableLayoutPanel22.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel22.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel22.Size = new global::System.Drawing.Size(304, 94);
			this.tableLayoutPanel22.TabIndex = 0;
			this.WhitelistButtonAdd.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.WhitelistButtonAdd.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.WhitelistButtonAdd.Location = new global::System.Drawing.Point(155, 50);
			this.WhitelistButtonAdd.Name = "WhitelistButtonAdd";
			this.WhitelistButtonAdd.Size = new global::System.Drawing.Size(146, 41);
			this.WhitelistButtonAdd.TabIndex = 6;
			this.WhitelistButtonAdd.Text = "Add";
			this.ToolTip.SetToolTip(this.WhitelistButtonAdd, "Add a new player to the whitelist.");
			this.WhitelistButtonAdd.UseVisualStyleBackColor = true;
			this.WhitelistButtonAdd.Click += new global::System.EventHandler(this.WhitelistButtonManualAdd_Click);
			this.WhitelistButtonEdit.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.WhitelistButtonEdit.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.WhitelistButtonEdit.Location = new global::System.Drawing.Point(3, 3);
			this.WhitelistButtonEdit.Name = "WhitelistButtonEdit";
			this.WhitelistButtonEdit.Size = new global::System.Drawing.Size(146, 41);
			this.WhitelistButtonEdit.TabIndex = 3;
			this.WhitelistButtonEdit.Text = "Edit";
			this.ToolTip.SetToolTip(this.WhitelistButtonEdit, "Edit the selected players.");
			this.WhitelistButtonEdit.UseVisualStyleBackColor = true;
			this.WhitelistButtonEdit.Click += new global::System.EventHandler(this.WhitelistButtonEdit_Click);
			this.WhitelistButtonRemove.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.WhitelistButtonRemove.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.WhitelistButtonRemove.Location = new global::System.Drawing.Point(155, 3);
			this.WhitelistButtonRemove.Name = "WhitelistButtonRemove";
			this.WhitelistButtonRemove.Size = new global::System.Drawing.Size(146, 41);
			this.WhitelistButtonRemove.TabIndex = 4;
			this.WhitelistButtonRemove.Text = "Remove";
			this.ToolTip.SetToolTip(this.WhitelistButtonRemove, "Remove the selected players.");
			this.WhitelistButtonRemove.UseVisualStyleBackColor = true;
			this.WhitelistButtonRemove.Click += new global::System.EventHandler(this.WhitelistButtonRemove_Click);
			this.WhitelistButtonViewProfile.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.WhitelistButtonViewProfile.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.WhitelistButtonViewProfile.Location = new global::System.Drawing.Point(3, 50);
			this.WhitelistButtonViewProfile.Name = "WhitelistButtonViewProfile";
			this.WhitelistButtonViewProfile.Size = new global::System.Drawing.Size(146, 41);
			this.WhitelistButtonViewProfile.TabIndex = 5;
			this.WhitelistButtonViewProfile.Text = "View Profile";
			this.ToolTip.SetToolTip(this.WhitelistButtonViewProfile, "View the Steam profiles of the selected players.");
			this.WhitelistButtonViewProfile.UseVisualStyleBackColor = true;
			this.WhitelistButtonViewProfile.Click += new global::System.EventHandler(this.WhitelistButtonViewProfile_Click);
			this.WhitelistListView.CheckBoxes = true;
			this.WhitelistListView.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.WhitelistColumnName,
				this.WhitelistColumnSteamId
			});
			this.tableLayoutPanel20.SetColumnSpan(this.WhitelistListView, 4);
			this.WhitelistListView.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.WhitelistListView.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold);
			this.WhitelistListView.FullRowSelect = true;
			this.WhitelistListView.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.WhitelistListView.HideSelection = false;
			this.WhitelistListView.Location = new global::System.Drawing.Point(3, 38);
			this.WhitelistListView.Name = "WhitelistListView";
			this.WhitelistListView.Size = new global::System.Drawing.Size(469, 342);
			this.WhitelistListView.TabIndex = 2;
			this.ToolTip.SetToolTip(this.WhitelistListView, "List of all players that are allowed entry to your lobby.\r\nAnybody not on this list will be blocked.");
			this.WhitelistListView.UseCompatibleStateImageBehavior = false;
			this.WhitelistListView.View = global::System.Windows.Forms.View.Details;
			this.WhitelistListView.ItemChecked += new global::System.Windows.Forms.ItemCheckedEventHandler(this.WhitelistListView_ItemChecked);
			this.WhitelistColumnName.Text = "Name";
			this.WhitelistColumnName.Width = 263;
			this.WhitelistColumnSteamId.Text = "Steam ID";
			this.WhitelistColumnSteamId.Width = 185;
			this.ToolTip.AutoPopDelay = 7000;
			this.ToolTip.InitialDelay = 500;
			this.ToolTip.ReshowDelay = 100;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(96f, 96f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Dpi;
			base.ClientSize = new global::System.Drawing.Size(489, 592);
			base.Controls.Add(this.TableLayoutPanel5);
			this.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			//base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "MainForm";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Super Lobby Tool";
			base.Load += new global::System.EventHandler(this.MainForm_Load);
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			this.BanlistGroupBoxTextList.ResumeLayout(false);
			this.tableLayoutPanel15.ResumeLayout(false);
			this.BanlistGroupboxPlayerOptions.ResumeLayout(false);
			this.TableLayoutPanel4.ResumeLayout(false);
			this.OverlayTab.ResumeLayout(false);
			this.tableLayoutPanel7.ResumeLayout(false);
			this.tableLayoutPanel7.PerformLayout();
			this.OverlayGroupBoxColumnOptions.ResumeLayout(false);
			this.tableLayoutPanel9.ResumeLayout(false);
			this.OverlayGroupBoxInfoFont.ResumeLayout(false);
			this.tableLayoutPanel10.ResumeLayout(false);
			this.tableLayoutPanel10.PerformLayout();
			this.OverlayGroupBoxHeaderFont.ResumeLayout(false);
			this.tableLayoutPanel11.ResumeLayout(false);
			this.tableLayoutPanel11.PerformLayout();
			this.tableLayoutPanel12.ResumeLayout(false);
			this.OverlayGroupBoxBackground.ResumeLayout(false);
			this.tableLayoutPanel13.ResumeLayout(false);
			this.tableLayoutPanel13.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.OverlayTrackBarBackgroundOpacity).EndInit();
			this.OverlayGroupBoxPosition.ResumeLayout(false);
			this.tableLayoutPanel14.ResumeLayout(false);
			this.tableLayoutPanel14.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.OverlayNumericUpDownY).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.OverlayNumericUpDownX).EndInit();
			this.BanlistTab.ResumeLayout(false);
			this.AboutTab.ResumeLayout(false);
			this.tableLayoutPanel19.ResumeLayout(false);
			this.TableLayoutPanel5.ResumeLayout(false);
			this.Tabs.ResumeLayout(false);
			this.CurrentLobbyTab.ResumeLayout(false);
			this.TableLayoutPanel8.ResumeLayout(false);
			this.CurrentLobbyGroupBoxLobbyInfo.ResumeLayout(false);
			this.tableLayoutPanel16.ResumeLayout(false);
			this.tableLayoutPanel18.ResumeLayout(false);
			this.tableLayoutPanel18.PerformLayout();
			this.tableLayoutPanel17.ResumeLayout(false);
			this.tableLayoutPanel17.PerformLayout();
			this.CurrentLobbyGroupBoxHostOptions.ResumeLayout(false);
			this.tableLayoutPanel23.ResumeLayout(false);
			this.tableLayoutPanel23.PerformLayout();
			this.CurrentLobbyGroupBoxPlayerOptions.ResumeLayout(false);
			this.TableLayoutPanel3.ResumeLayout(false);
			this.AllLobbiesTab.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.GroupBoxLobbyListControls.ResumeLayout(false);
			this.tableLayoutPanel6.ResumeLayout(false);
			this.WhitelistTab.ResumeLayout(false);
			this.tableLayoutPanel20.ResumeLayout(false);
			this.tableLayoutPanel20.PerformLayout();
			this.WhitelistGroupBoxTextList.ResumeLayout(false);
			this.tableLayoutPanel21.ResumeLayout(false);
			this.WhitelistGroupBoxPlayerOptions.ResumeLayout(false);
			this.tableLayoutPanel22.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040000DF RID: 223
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040000E0 RID: 224
		internal global::System.Windows.Forms.RichTextBox AboutTextBox;

		// Token: 0x040000E1 RID: 225
		internal global::System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;

		// Token: 0x040000E2 RID: 226
		internal global::System.Windows.Forms.Button BanlistButtonAdd;

		// Token: 0x040000E3 RID: 227
		internal global::System.Windows.Forms.GroupBox BanlistGroupboxPlayerOptions;

		// Token: 0x040000E4 RID: 228
		internal global::System.Windows.Forms.TableLayoutPanel TableLayoutPanel4;

		// Token: 0x040000E5 RID: 229
		internal global::System.Windows.Forms.Button BanlistButtonEdit;

		// Token: 0x040000E6 RID: 230
		internal global::System.Windows.Forms.Button BanlistButtonRemove;

		// Token: 0x040000E7 RID: 231
	    //internal global::SuperLobbyTool.ListViewDoubleBuffered BanlistListView;
        internal global::System.Windows.Forms.ListView BanlistListView;

        // Token: 0x040000E8 RID: 232
        internal global::System.Windows.Forms.ColumnHeader BanlistColumnName;

		// Token: 0x040000E9 RID: 233
		internal global::System.Windows.Forms.ColumnHeader BanlistColumnSteamId;

		// Token: 0x040000EA RID: 234
		internal global::System.Windows.Forms.TabPage BanlistTab;

		// Token: 0x040000EB RID: 235
		internal global::System.Windows.Forms.TabPage AboutTab;

		// Token: 0x040000EC RID: 236
		internal global::System.Windows.Forms.TableLayoutPanel TableLayoutPanel5;

		// Token: 0x040000ED RID: 237
		internal global::System.Windows.Forms.StatusBar StatusBar;

		// Token: 0x040000EE RID: 238
		internal global::System.Windows.Forms.TabControl Tabs;

		// Token: 0x040000EF RID: 239
		internal global::System.Windows.Forms.TabPage CurrentLobbyTab;

		// Token: 0x040000F0 RID: 240
		internal global::System.Windows.Forms.TableLayoutPanel TableLayoutPanel8;

		// Token: 0x040000F1 RID: 241
		internal global::System.Windows.Forms.GroupBox CurrentLobbyGroupBoxLobbyInfo;

		// Token: 0x040000F2 RID: 242
		internal global::System.Windows.Forms.GroupBox CurrentLobbyGroupBoxHostOptions;

		// Token: 0x040000F3 RID: 243
		internal global::System.Windows.Forms.GroupBox CurrentLobbyGroupBoxPlayerOptions;

		// Token: 0x040000F4 RID: 244
		internal global::System.Windows.Forms.TableLayoutPanel TableLayoutPanel3;

		// Token: 0x040000F5 RID: 245
		internal global::System.Windows.Forms.Button CurrentLobbyButtonBan;

        // Token: 0x040000F6 RID: 246
        internal global::System.Windows.Forms.ListView CurrentLobbyListView;

		// Token: 0x040000F7 RID: 247
		internal global::System.Windows.Forms.ColumnHeader CurrentLobbyColumnName;

		// Token: 0x040000F8 RID: 248
		internal global::System.Windows.Forms.ColumnHeader CurrentLobbyColumnSteamId;

		// Token: 0x040000F9 RID: 249
		internal global::System.Windows.Forms.ColumnHeader CurrentLobbyColumnPing;

		// Token: 0x040000FA RID: 250
		internal global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

		// Token: 0x040000FB RID: 251
		internal global::System.Windows.Forms.GroupBox GroupBoxLobbyListControls;

		// Token: 0x040000FC RID: 252
		internal global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;

		// Token: 0x040000FD RID: 253
		internal global::System.Windows.Forms.Button AllLobbiesButtonRefreshList;

        // Token: 0x040000FE RID: 254
        internal global::System.Windows.Forms.ListView AllLobbiesListView;

		// Token: 0x040000FF RID: 255
		internal global::System.Windows.Forms.ColumnHeader AllLobbiesColumnCreator;

		// Token: 0x04000100 RID: 256
		internal global::System.Windows.Forms.ColumnHeader AllLobbiesColumnType;

		// Token: 0x04000101 RID: 257
		private global::System.Windows.Forms.ColumnHeader AllLobbiesColumnPlayers;

		// Token: 0x04000102 RID: 258
		internal global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;

		// Token: 0x04000103 RID: 259
		private global::System.Windows.Forms.GroupBox OverlayGroupBoxHeaderFont;

		// Token: 0x04000104 RID: 260
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;

		// Token: 0x04000105 RID: 261
		private global::System.Windows.Forms.Label OverlayLabelHeaderFontPreview;

		// Token: 0x04000106 RID: 262
		private global::System.Windows.Forms.Label OverlayLabelHeaderFontName;

		// Token: 0x04000107 RID: 263
		internal global::System.Windows.Forms.CheckBox OverlayCheckBoxEnable;

        // Token: 0x04000108 RID: 264
        internal global::System.Windows.Forms.ListView OverlayListView;

		// Token: 0x04000109 RID: 265
		internal global::System.Windows.Forms.ColumnHeader DataColumn;

		// Token: 0x0400010A RID: 266
		internal global::System.Windows.Forms.ColumnHeader WidthColumn;

		// Token: 0x0400010B RID: 267
		private global::System.Windows.Forms.ColumnHeader HeaderColourColumn;

		// Token: 0x0400010C RID: 268
		private global::System.Windows.Forms.ColumnHeader DataColourColumn;

		// Token: 0x0400010D RID: 269
		internal global::System.Windows.Forms.GroupBox OverlayGroupBoxColumnOptions;

		// Token: 0x0400010E RID: 270
		internal global::System.Windows.Forms.Button OverlayButtonAdd;

		// Token: 0x0400010F RID: 271
		internal global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;

		// Token: 0x04000110 RID: 272
		internal global::System.Windows.Forms.Button OverlayButtonMoveUp;

		// Token: 0x04000111 RID: 273
		internal global::System.Windows.Forms.Button OverlayButtonMoveDown;

		// Token: 0x04000112 RID: 274
		internal global::System.Windows.Forms.Button OverlayButtonEdit;

		// Token: 0x04000113 RID: 275
		internal global::System.Windows.Forms.Button OverlayButtonRemove;

		// Token: 0x04000114 RID: 276
		private global::System.Windows.Forms.Button OverlayButtonHeaderFont;

		// Token: 0x04000115 RID: 277
		internal global::System.Windows.Forms.Button OverlayButtonLobbyInfo;

		// Token: 0x04000116 RID: 278
		internal global::System.Windows.Forms.Button CurrentLobbyButtonViewProfile;

		// Token: 0x04000117 RID: 279
		internal global::System.Windows.Forms.TabPage OverlayTab;

		// Token: 0x04000118 RID: 280
		internal global::System.Windows.Forms.TabPage AllLobbiesTab;

		// Token: 0x04000119 RID: 281
		private global::System.Windows.Forms.GroupBox OverlayGroupBoxInfoFont;

		// Token: 0x0400011A RID: 282
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;

		// Token: 0x0400011B RID: 283
		private global::System.Windows.Forms.Button OverlayButtonInfoFont;

		// Token: 0x0400011C RID: 284
		private global::System.Windows.Forms.Label OverlayLabelDataFontPreview;

		// Token: 0x0400011D RID: 285
		private global::System.Windows.Forms.Label OverlayLabelDataFontName;

		// Token: 0x0400011E RID: 286
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;

		// Token: 0x0400011F RID: 287
		private global::System.Windows.Forms.GroupBox OverlayGroupBoxBackground;

		// Token: 0x04000120 RID: 288
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;

		// Token: 0x04000121 RID: 289
		internal global::System.Windows.Forms.CheckBox OverlayCheckBoxBackgroundEnable;

		// Token: 0x04000122 RID: 290
		private global::System.Windows.Forms.Label OverlayLabelBackgroundOpacity;

		// Token: 0x04000123 RID: 291
		private global::System.Windows.Forms.Label OverlayLabelBackgroundEnabled;

		// Token: 0x04000124 RID: 292
		public global::System.Windows.Forms.Label OverlayLabelBackgroundColourPreview;

		// Token: 0x04000125 RID: 293
		private global::System.Windows.Forms.Button OverlayButtonBackgroundColour;

		// Token: 0x04000126 RID: 294
		private global::System.Windows.Forms.GroupBox OverlayGroupBoxPosition;

		// Token: 0x04000127 RID: 295
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;

		// Token: 0x04000128 RID: 296
		private global::System.Windows.Forms.NumericUpDown OverlayNumericUpDownY;

		// Token: 0x04000129 RID: 297
		private global::System.Windows.Forms.Label OverlayLabelPositionInfo;

		// Token: 0x0400012A RID: 298
		private global::System.Windows.Forms.Label OverlayLabelPositionY;

		// Token: 0x0400012B RID: 299
		private global::System.Windows.Forms.Label OverlayLabelPositionX;

		// Token: 0x0400012C RID: 300
		private global::System.Windows.Forms.NumericUpDown OverlayNumericUpDownX;

		// Token: 0x0400012D RID: 301
		private global::System.Windows.Forms.Label OverlayLabelBackgroundColour;

		// Token: 0x0400012E RID: 302
		private global::System.Windows.Forms.TrackBar OverlayTrackBarBackgroundOpacity;

		// Token: 0x0400012F RID: 303
		internal global::System.Windows.Forms.CheckBox BanlistCheckBoxEnable;

		// Token: 0x04000130 RID: 304
		internal global::System.Windows.Forms.Button BanlistButtonViewProfile;

		// Token: 0x04000131 RID: 305
		internal global::System.Windows.Forms.Button AllLobbiesButtonViewPlayers;

		// Token: 0x04000132 RID: 306
		internal global::System.Windows.Forms.GroupBox BanlistGroupBoxTextList;

		// Token: 0x04000133 RID: 307
		internal global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel15;

		// Token: 0x04000134 RID: 308
		internal global::System.Windows.Forms.Button BanlistButtonImport;

		// Token: 0x04000135 RID: 309
		internal global::System.Windows.Forms.Button BanlistButtonExport;

		// Token: 0x04000136 RID: 310
		internal global::System.Windows.Forms.Label AllLobbiesLabelLobbyCount;

		// Token: 0x04000137 RID: 311
		internal global::System.Windows.Forms.Label AllLobbiesLabelPlayerCount;

		// Token: 0x04000138 RID: 312
		internal global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel16;

		// Token: 0x04000139 RID: 313
		internal global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel17;

		// Token: 0x0400013A RID: 314
		internal global::System.Windows.Forms.Label CurrentLobbyLabelHost;

		// Token: 0x0400013B RID: 315
		internal global::System.Windows.Forms.Label CurrentLobbyLabelLobbyId;

		// Token: 0x0400013C RID: 316
		internal global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel18;

		// Token: 0x0400013D RID: 317
		internal global::System.Windows.Forms.Label CurrentLobbyLabelBannedPlayers;

		// Token: 0x0400013E RID: 318
		internal global::System.Windows.Forms.Label CurrentLobbyLabelFriends;

		// Token: 0x0400013F RID: 319
		internal global::System.Windows.Forms.Label CurrentLobbyLabelFriendsValue;

		// Token: 0x04000140 RID: 320
		internal global::System.Windows.Forms.Label CurrentLobbyLabelHostValue;

		// Token: 0x04000141 RID: 321
		internal global::System.Windows.Forms.Label CurrentLobbyLabelBannedPlayersValue;

		// Token: 0x04000142 RID: 322
		internal global::System.Windows.Forms.Label CurrentLobbyLabelPlayerTotalValue;

		// Token: 0x04000143 RID: 323
		internal global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel19;

		// Token: 0x04000144 RID: 324
		internal global::System.Windows.Forms.Button AboutButtonViewChangelog;

		// Token: 0x04000145 RID: 325
		internal global::System.Windows.Forms.Button AllLobbiesButtonLink;

		// Token: 0x04000146 RID: 326
		internal global::System.Windows.Forms.Button AllLobbiesButtonJoinLobby;

		// Token: 0x04000147 RID: 327
		private global::System.Windows.Forms.TabPage WhitelistTab;

		// Token: 0x04000148 RID: 328
		internal global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel20;

		// Token: 0x04000149 RID: 329
		internal global::System.Windows.Forms.GroupBox WhitelistGroupBoxTextList;

		// Token: 0x0400014A RID: 330
		internal global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel21;

		// Token: 0x0400014B RID: 331
		internal global::System.Windows.Forms.Button WhitelistButtonImport;

		// Token: 0x0400014C RID: 332
		internal global::System.Windows.Forms.Button WhitelistButtonExport;

		// Token: 0x0400014D RID: 333
		internal global::System.Windows.Forms.Label WhitelistLabelActive;

		// Token: 0x0400014E RID: 334
		internal global::System.Windows.Forms.Label WhitelistLabelPlayerCount;

		// Token: 0x0400014F RID: 335
		internal global::System.Windows.Forms.CheckBox WhitelistCheckBoxEnable;

		// Token: 0x04000150 RID: 336
		internal global::System.Windows.Forms.GroupBox WhitelistGroupBoxPlayerOptions;

		// Token: 0x04000151 RID: 337
		internal global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel22;

		// Token: 0x04000152 RID: 338
		internal global::System.Windows.Forms.Button WhitelistButtonAdd;

		// Token: 0x04000153 RID: 339
		internal global::System.Windows.Forms.Button WhitelistButtonEdit;

		// Token: 0x04000154 RID: 340
		internal global::System.Windows.Forms.Button WhitelistButtonRemove;

		// Token: 0x04000155 RID: 341
		internal global::System.Windows.Forms.Button WhitelistButtonViewProfile;

        // Token: 0x04000156 RID: 342
        internal global::System.Windows.Forms.ListView WhitelistListView;

		// Token: 0x04000157 RID: 343
		internal global::System.Windows.Forms.ColumnHeader WhitelistColumnName;

		// Token: 0x04000158 RID: 344
		internal global::System.Windows.Forms.ColumnHeader WhitelistColumnSteamId;

		// Token: 0x04000159 RID: 345
		private global::System.Windows.Forms.ColumnHeader AllLobbiesColumnActivity;

		// Token: 0x0400015A RID: 346
		internal global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel23;

		// Token: 0x0400015B RID: 347
		internal global::System.Windows.Forms.CheckBox CurrentLobbyCheckBoxSkipLobbySearch;

		// Token: 0x0400015C RID: 348
		internal global::System.Windows.Forms.Button CurrentLobbyButtonMigrateHost;

		// Token: 0x0400015D RID: 349
		internal global::System.Windows.Forms.CheckBox CurrentLobbyCheckBoxDisableMirrorTracks;

		// Token: 0x0400015E RID: 350
		internal global::System.Windows.Forms.Label WhitelistLabelBlockedConnections;

		// Token: 0x0400015F RID: 351
		internal global::System.Windows.Forms.Label CurrentLobbyLabelLobbyIdValue;

		// Token: 0x04000160 RID: 352
		internal global::System.Windows.Forms.Label CurrentLobbyLabelSLTProtected;

		// Token: 0x04000161 RID: 353
		internal global::System.Windows.Forms.Label CurrentLobbyLabelPlayerTotal;

		// Token: 0x04000162 RID: 354
		internal global::System.Windows.Forms.Label CurrentLobbyLabelSLTProtectedValue;

		// Token: 0x04000163 RID: 355
		internal global::System.Windows.Forms.Label BanlistLabelActive;

		// Token: 0x04000164 RID: 356
		internal global::System.Windows.Forms.Label BanlistLabelBlockedConnections;

		// Token: 0x04000165 RID: 357
		internal global::System.Windows.Forms.Label BanlistLabelPlayerCount;

		// Token: 0x04000166 RID: 358
		private global::System.Windows.Forms.ToolTip ToolTip;
	}
}
