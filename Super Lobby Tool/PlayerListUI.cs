using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SuperLobbyTool
{
	// Token: 0x0200000A RID: 10
	public class PlayerListUI
	{
		// Token: 0x0600003C RID: 60 RVA: 0x00004DC0 File Offset: 0x00002FC0
		public PlayerListUI(string _listName, Color _listColour, bool _restricted, PlayerListElement _Config, ListView _ListView, CheckBox _CheckBoxEnable, Label _LabelCount, Label _LabelBlockedConnections, Button _ButtonAdd, Button _ButtonRemove, Button _ButtonEdit, Button _ButtonViewProfile, Button _ButtonImport, Button _ButtonExport)
		{
			DebugTools.Print("Startup: Initialising " + _listName + " user interface.");
			this.listName = _listName;
			this.listColour = _listColour;
			this.restricted = _restricted;
			this.Config = _Config;
			this.ListView = _ListView;
			this.LabelCount = _LabelCount;
			this.LabelBlockedConnections = _LabelBlockedConnections;
			this.CheckBoxEnable = _CheckBoxEnable;
			this.ButtonAdd = _ButtonAdd;
			this.ButtonRemove = _ButtonRemove;
			this.ButtonEdit = _ButtonEdit;
			this.ButtonViewProfile = _ButtonViewProfile;
			this.ButtonImport = _ButtonImport;
			this.ButtonExport = _ButtonExport;
			string path = Application.StartupPath + "/" + this.listName + "_encrypted.txt";
			if (this.restricted)
			{
				this.Config.Players.Clear();
				if (File.Exists(path))
				{
					DebugTools.Print(PlayerListUI.UppercaseFirst(this.listName) + ": Importing from encrypted text file.");
					string text = RijndaelManagedEncryption.DecryptRijndael(File.ReadAllText(path));
					if (text != "")
					{
						this.TextImport(text.Split("\n".ToCharArray()));
					}
					else
					{
						MessageBox.Show(string.Concat(new string[]
						{
							"Failed to load ",
							this.listName,
							" from ",
							this.listName,
							"_encrypted.txt"
						}), PlayerListUI.UppercaseFirst(this.listName), MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
				}
				else
				{
					MessageBox.Show(string.Concat(new string[]
					{
						"Could not find: ",
						this.listName,
						"_encrypted.txt\n\nNo ",
						this.listName,
						" has been loaded."
					}), PlayerListUI.UppercaseFirst(this.listName), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
			this.UpdateStatic();
			this.ListView.CreateGraphics();
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00004F8C File Offset: 0x0000318C
		public bool SearchList(SteamData.Player player)
		{
			for (int i = 0; i < this.Config.Players.Count; i++)
			{
				if (player.steamId == this.Config.Players[i].SteamId)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00004FD8 File Offset: 0x000031D8
		public void UpdateStatic()
		{
			DebugTools.Write(PlayerListUI.UppercaseFirst(this.listName) + ": Updating user interface static elements... ");
			this.settingValues = true;
			this.CheckBoxEnable.Checked = this.Config.Enabled;
			int num = -1;
			if (this.ListView.SelectedIndices.Count == 1)
			{
				num = this.ListView.SelectedItems[0].Index;
			}
			this.ListView.Items.Clear();
			if (this.Config.Players.Count > 0)
			{
				foreach (object obj in this.Config.Players)
				{
					PlayerElement playerElement = (PlayerElement)obj;
					this.ListView.Items.Add(new ListViewItem(new string[]
					{
						playerElement.Name,
						playerElement.SteamId.ToString()
					})
					{
						Checked = playerElement.Enabled,
						ForeColor = this.listColour
					});
				}
				if (num >= 0 && num < this.ListView.Items.Count)
				{
					MainForm.ListViewFocus(this.ListView.Items, num, true);
				}
			}
			this.ButtonAdd.Enabled = !this.restricted;
			this.ButtonRemove.Enabled = (this.Config.Players.Count > 0);
			this.ButtonEdit.Enabled = (this.Config.Players.Count > 0);
			this.ButtonViewProfile.Enabled = (this.Config.Players.Count > 0);
			this.ButtonExport.Enabled = (this.Config.Players.Count > 0);
			this.LabelCount.Text = "Player Total: " + this.Config.Players.Count;
			this.settingValues = false;
			Debug.Print("done.");
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000051FC File Offset: 0x000033FC
		public void ToggleList()
		{
			DebugTools.Print("Option change: Toggle " + this.listName);
			this.Config.Enabled = !this.Config.Enabled;
			GameMemory.OptionsUpdate();
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00005234 File Offset: 0x00003434
		public void TogglePlayer(ItemCheckedEventArgs e)
		{
			if (!this.settingValues)
			{
				DebugTools.Print("Option change: Toggle " + this.listName + " entry");
				this.Config.Players[e.Item.Index].Enabled = !this.Config.Players[e.Item.Index].Enabled;
				GameMemory.OptionsUpdate();
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000052AC File Offset: 0x000034AC
		public void RemovePlayer()
		{
			int count = this.ListView.SelectedIndices.Count;
			for (int i = this.ListView.SelectedItems.Count - 1; i >= 0; i--)
			{
				int index = this.ListView.SelectedIndices[i];
				DebugTools.Print("Option change: Remove " + PlayerListUI.UppercaseFirst(this.listName) + " entry.");
				this.Config.Players.RemoveAt(index);
				MainForm.Message(this.ListView.Items[index].SubItems[0].Text + " was removed from the " + this.listName, 50);
			}
			this.UpdateStatic();
			GameMemory.OptionsUpdate();
			if (count > 1)
			{
				MainForm.Message(string.Concat(new object[]
				{
					"Removed ",
					count,
					" players from the ",
					this.listName,
					"."
				}), 50);
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000053B0 File Offset: 0x000035B0
		public void AddPlayer()
		{
			DebugTools.Print("Open dialog box: Add " + this.listName + " entry (DialogBoxPlayer)");
			using (DialogBoxPlayer dialogBoxPlayer = new DialogBoxPlayer())
			{
				dialogBoxPlayer.Text = "Add Player";
				dialogBoxPlayer.LabelTitle.Text = "Add this player to the " + this.listName + ":";
				dialogBoxPlayer.ButtonConfirm.Text = "Add";
				dialogBoxPlayer.TextBoxPlayerName.Select();
				bool flag = false;
				while (!flag)
				{
					try
					{
						if (dialogBoxPlayer.ShowDialog() == DialogResult.OK)
						{
							this.AddPlayer(dialogBoxPlayer.TextBoxPlayerName.Text, Convert.ToUInt64(dialogBoxPlayer.TextBoxPlayerSteamID.Text), dialogBoxPlayer.CheckBoxPlayerEnabled.Checked);
							this.UpdateStatic();
							GameMemory.OptionsUpdate();
						}
						flag = true;
					}
					catch
					{
						DebugTools.Print("Error: Failed to add player to the " + this.listName + ", invalid Steam ID.");
						MessageBox.Show("The Steam ID is invalid.", "Could not add player.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
				}
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000054C8 File Offset: 0x000036C8
		public void AddFriends()
		{
			DebugTools.Print("Open dialog box: Add friends (DialogBoxAddFriends)");
			using (DialogBoxAddFriends dialogBoxAddFriends = new DialogBoxAddFriends())
			{
				foreach (SteamData.Player player in SteamData.FriendList)
				{
					dialogBoxAddFriends.ListView.Items.Add(new ListViewItem(player.name));
				}
				if (dialogBoxAddFriends.ShowDialog() == DialogResult.OK)
				{
					foreach (object obj in dialogBoxAddFriends.ListView.SelectedIndices)
					{
						int num = (int)obj;
						this.AddPlayer(SteamData.FriendList[num].name, SteamData.FriendList[num].steamId, true);
					}
					this.UpdateStatic();
					GameMemory.OptionsUpdate();
					if (dialogBoxAddFriends.ListView.SelectedIndices.Count > 1)
					{
						MainForm.Message(string.Concat(new object[]
						{
							"Added ",
							dialogBoxAddFriends.ListView.SelectedIndices.Count,
							" friends to the ",
							this.listName,
							"."
						}), 50);
						DebugTools.Print(string.Concat(new object[]
						{
							PlayerListUI.UppercaseFirst(this.listName),
							": Added ",
							dialogBoxAddFriends.ListView.SelectedIndices.Count,
							" friends."
						}));
					}
				}
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00005688 File Offset: 0x00003888
		public void EditPlayer()
		{
			foreach (object obj in this.ListView.SelectedIndices)
			{
				int index = (int)obj;
				DebugTools.Print("Open dialog box: Edit " + this.listName + " entry (DialogBoxPlayer)");
				using (DialogBoxPlayer dialogBoxPlayer = new DialogBoxPlayer())
				{
					dialogBoxPlayer.Text = "Edit Player";
					dialogBoxPlayer.LabelTitle.Text = string.Concat(new string[]
					{
						"Edit ",
						this.Config.Players[index].Name,
						"'s ",
						this.listName,
						" entry:"
					});
					dialogBoxPlayer.ButtonConfirm.Text = "Confirm";
					dialogBoxPlayer.TextBoxPlayerName.Select();
					dialogBoxPlayer.TextBoxPlayerName.Text = this.Config.Players[index].Name;
					dialogBoxPlayer.TextBoxPlayerSteamID.Text = this.Config.Players[index].SteamId.ToString();
					dialogBoxPlayer.CheckBoxPlayerEnabled.Checked = this.Config.Players[index].Enabled;
					dialogBoxPlayer.TextBoxPlayerSteamID.Enabled = !this.restricted;
					for (;;)
					{
						try
						{
							if (dialogBoxPlayer.ShowDialog() == DialogResult.OK)
							{
								this.EditPlayer(dialogBoxPlayer.TextBoxPlayerName.Text, Convert.ToUInt64(dialogBoxPlayer.TextBoxPlayerSteamID.Text), dialogBoxPlayer.CheckBoxPlayerEnabled.Checked, index);
								this.UpdateStatic();
								GameMemory.OptionsUpdate();
							}
							break;
						}
						catch
						{
							DebugTools.Print("Error: Failed to edit " + this.listName + " entry, invalid Steam ID.");
							MessageBox.Show("The Steam ID is invalid.", "Could not edit player.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						}
					}
				}
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000058B8 File Offset: 0x00003AB8
		public void ViewProfile()
		{
			foreach (object obj in this.ListView.SelectedIndices)
			{
				int index = (int)obj;
				MainForm.ViewProfile(this.Config.Players[index].SteamId);
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0000592C File Offset: 0x00003B2C
		public void TextImport()
		{
			DebugTools.Print("Open dialog box: " + PlayerListUI.UppercaseFirst(this.listName) + " Import (DialogBoxImportExport)");
			using (DialogBoxImportExport dialogBoxImportExport = new DialogBoxImportExport())
			{
				dialogBoxImportExport.Text = PlayerListUI.UppercaseFirst(this.listName) + " Import";
				dialogBoxImportExport.ButtonImport.Visible = true;
				dialogBoxImportExport.ButtonCancel.Text = "Cancel";
				if (this.restricted)
				{
					dialogBoxImportExport.CheckBoxEncryptedText.Enabled = false;
					dialogBoxImportExport.CheckBoxEncryptedText.Checked = true;
				}
				if (dialogBoxImportExport.ShowDialog() == DialogResult.OK)
				{
					if (dialogBoxImportExport.CheckBoxEncryptedText.Checked)
					{
						dialogBoxImportExport.DecryptTextBox();
					}
					this.TextImport(dialogBoxImportExport.TextBoxImportExport.Lines);
					this.UpdateStatic();
					GameMemory.OptionsUpdate();
				}
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00005A0C File Offset: 0x00003C0C
		private int TextImport(string[] lines)
		{
			DebugTools.Print(PlayerListUI.UppercaseFirst(this.listName) + ": Begin text import.");
			int num = 0;
			foreach (string text in lines)
			{
				if (text != "")
				{
					try
					{
						this.AddPlayer(text.Substring(20), Convert.ToUInt64(text.Substring(0, 17)), true);
						num++;
					}
					catch
					{
						DebugTools.Print("Error: Unable to process a line (" + text + ")");
						MessageBox.Show("There was a problem processing this line:\n\n " + text, "Text Import", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
				}
			}
			if (num > 1)
			{
				MainForm.Message(string.Concat(new object[]
				{
					"Imported ",
					num,
					" players to the ",
					this.listName,
					"."
				}), 50);
				DebugTools.Print(string.Concat(new object[]
				{
					PlayerListUI.UppercaseFirst(this.listName),
					": Imported ",
					num,
					" players to the ",
					this.listName,
					"."
				}));
			}
			return num;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00005B48 File Offset: 0x00003D48
		public void TextExport()
		{
			DebugTools.Print("Open dialog box: " + PlayerListUI.UppercaseFirst(this.listName) + " Export (DialogBoxImportExport)");
			using (DialogBoxImportExport dialogBoxImportExport = new DialogBoxImportExport())
			{
				dialogBoxImportExport.Text = PlayerListUI.UppercaseFirst(this.listName) + " Export";
				dialogBoxImportExport.ButtonImport.Visible = false;
				dialogBoxImportExport.ButtonCancel.Text = "Close";
				if (this.restricted)
				{
					dialogBoxImportExport.TextBoxImportExport.ReadOnly = true;
				}
				dialogBoxImportExport.TextBoxImportExport.Lines = PlayerListUI.TextExport(this.listName, this.Config.Players);
				dialogBoxImportExport.ShowDialog();
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00005C0C File Offset: 0x00003E0C
		public static string[] TextExport(string listName, GenericConfigurationElementCollection<PlayerElement> Players)
		{
			DebugTools.Write(PlayerListUI.UppercaseFirst(listName) + ": Generating text list... ");
			string[] array = new string[Players.Count];
			for (int i = 0; i < Players.Count; i++)
			{
				array[i] = Players[i].SteamId + " # " + Players[i].Name;
			}
			Debug.Print("done.");
			return array;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00005C80 File Offset: 0x00003E80
		public void AddPlayer(string name, ulong steamId, bool enabled)
		{
			DebugTools.Print("Option change: Add " + this.listName + " entry.");
			this.Config.Players.Add(new PlayerElement
			{
				Name = name,
				SteamId = steamId,
				Enabled = enabled
			});
			MainForm.Message(name + " was added to the " + this.listName + ".", 50);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00005CF0 File Offset: 0x00003EF0
		public void AddPlayer(ListView.SelectedIndexCollection indices)
		{
			foreach (object obj in indices)
			{
				int num = (int)obj;
				GameData.PlayerOnline playerOnline = GameData.PlayerList[num];
				this.AddPlayer(playerOnline.LocalList[(int)(playerOnline.LocalCount - 1)].Name, playerOnline.SteamId, true);
			}
			this.UpdateStatic();
			GameMemory.OptionsUpdate();
			if (indices.Count > 1)
			{
				MainForm.Message(string.Concat(new object[]
				{
					"Added ",
					indices.Count,
					" players to the ",
					this.listName,
					"."
				}), 50);
				DebugTools.Print(string.Concat(new object[]
				{
					PlayerListUI.UppercaseFirst(this.listName),
					": Added ",
					indices.Count,
					" players."
				}));
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00005E00 File Offset: 0x00004000
		public void EditPlayer(string name, ulong steamId, bool enabled, int index)
		{
			DebugTools.Print("Option change: Edit " + this.listName + " entry.");
			this.Config.Players[index].Name = name;
			this.Config.Players[index].SteamId = steamId;
			this.Config.Players[index].Enabled = enabled;
			MainForm.Message(string.Concat(new string[]
			{
				"A ",
				this.listName,
				" entry was edited (",
				name,
				")."
			}), 50);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00005EA8 File Offset: 0x000040A8
		public void ConnectionBlockedEvent()
		{
			DebugTools.Print(PlayerListUI.UppercaseFirst(this.listName) + ": A player connection has been blocked.");
			MainForm.Message("A player on the " + this.listName + " has been blocked.", 50);
			this.blockedConnections++;
			this.LabelBlockedConnections.Text = "Blocked Connections: " + this.blockedConnections;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00005F1C File Offset: 0x0000411C
		public static string UppercaseFirst(string s)
		{
			if (string.IsNullOrEmpty(s))
			{
				return string.Empty;
			}
			char[] array = s.ToCharArray();
			array[0] = char.ToUpper(array[0]);
			return new string(array);
		}

		// Token: 0x0400003E RID: 62
		private bool restricted;

		// Token: 0x0400003F RID: 63
		private readonly string listName;

		// Token: 0x04000040 RID: 64
		private bool settingValues;

		// Token: 0x04000041 RID: 65
		private int blockedConnections;

		// Token: 0x04000042 RID: 66
		private PlayerListElement Config;

		// Token: 0x04000043 RID: 67
		private Color listColour;

		// Token: 0x04000044 RID: 68
		private ListView ListView;

		// Token: 0x04000045 RID: 69
		private Label LabelCount;

		// Token: 0x04000046 RID: 70
		private Label LabelBlockedConnections;

		// Token: 0x04000047 RID: 71
		private CheckBox CheckBoxEnable;

		// Token: 0x04000048 RID: 72
		private Button ButtonAdd;

		// Token: 0x04000049 RID: 73
		private Button ButtonRemove;

		// Token: 0x0400004A RID: 74
		private Button ButtonEdit;

		// Token: 0x0400004B RID: 75
		private Button ButtonViewProfile;

		// Token: 0x0400004C RID: 76
		private Button ButtonImport;

		// Token: 0x0400004D RID: 77
		private Button ButtonExport;
	}
}
