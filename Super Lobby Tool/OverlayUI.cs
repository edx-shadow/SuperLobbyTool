using System;
using System.Diagnostics;
using System.Windows.Forms;
using Overlay.Interface;

namespace SuperLobbyTool
{
	// Token: 0x02000009 RID: 9
	public class OverlayUI
	{
		// Token: 0x0600002A RID: 42 RVA: 0x00003D80 File Offset: 0x00001F80
		public OverlayUI(OverlayElement _Config, ListView _ListView, Label _LabelHeaderFontPreview, Label _LabelHeaderFontName, Label _LabelDataFontPreview, Label _LabelDataFontName, Label _LabelBackgroundColourPreview, CheckBox _CheckBoxEnable, CheckBox _CheckBoxBackgroundEnable, NumericUpDown _NumericUpDownX, NumericUpDown _NumericUpDownY, TrackBar _TrackBarBackgroundOpacity, Button _ButtonEdit, Button _ButtonRemove, Button _ButtonMoveUp, Button _ButtonMoveDown)
		{
			DebugTools.Print("Startup: Initialising overlay user interface.");
			this.Config = _Config;
			this.ListView = _ListView;
			this.LabelHeaderFontPreview = _LabelHeaderFontPreview;
			this.LabelHeaderFontName = _LabelHeaderFontName;
			this.LabelDataFontPreview = _LabelDataFontPreview;
			this.LabelDataFontName = _LabelDataFontName;
			this.LabelBackgroundColourPreview = _LabelBackgroundColourPreview;
			this.CheckBoxEnable = _CheckBoxEnable;
			this.CheckBoxBackgroundEnable = _CheckBoxBackgroundEnable;
			this.NumericUpDownX = _NumericUpDownX;
			this.NumericUpDownY = _NumericUpDownY;
			this.TrackBarBackgroundOpacity = _TrackBarBackgroundOpacity;
			this.ButtonEdit = _ButtonEdit;
			this.ButtonRemove = _ButtonRemove;
			this.ButtonMoveUp = _ButtonMoveUp;
			this.ButtonMoveDown = _ButtonMoveDown;
			this.UpdateStatic();
			this.ListView.CreateGraphics();
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003E2C File Offset: 0x0000202C
		public void UpdateStatic()
		{
			DebugTools.Write("Overlay: Updating user interface static elements... ");
			this.settingValues = true;
			int num = -1;
			if (this.ListView.SelectedIndices.Count == 1)
			{
				num = this.ListView.SelectedItems[0].Index;
			}
			this.ListView.Items.Clear();
			if (this.Config.Columns.ColumnList.Count > 0)
			{
				foreach (object obj in this.Config.Columns.ColumnList)
				{
					ColumnElement columnElement = (ColumnElement)obj;
					this.ListView.Items.Add(new ListViewItem(new string[]
					{
						columnElement.Data.GetDescription(),
						columnElement.Width.ToString(),
						columnElement.HeaderColour.Name,
						columnElement.DataColour.Name
					})
					{
						Checked = columnElement.Enabled
					});
				}
				if (num >= 0 && num < this.ListView.Items.Count)
				{
					MainForm.ListViewFocus(this.ListView.Items, num, true);
				}
			}
			this.LabelHeaderFontPreview.Font = this.Config.Fonts.Header;
			this.LabelHeaderFontName.Text = string.Concat(new object[]
			{
				"Name: ",
				this.Config.Fonts.Header.Name,
				" ",
				this.Config.Fonts.Header.Style
			});
			this.LabelDataFontPreview.Font = this.Config.Fonts.Data;
			this.LabelDataFontName.Text = string.Concat(new object[]
			{
				"Name: ",
				this.Config.Fonts.Data.Name,
				" ",
				this.Config.Fonts.Data.Style
			});
			this.LabelBackgroundColourPreview.BackColor = this.Config.Background.Colour;
			this.CheckBoxEnable.Checked = this.Config.Enabled;
			this.CheckBoxBackgroundEnable.Checked = this.Config.Background.Enabled;
			this.LabelBackgroundColourPreview.BackColor = this.Config.Background.Colour;
			this.NumericUpDownX.Value = this.Config.Position.X;
			this.NumericUpDownY.Value = this.Config.Position.Y;
			this.TrackBarBackgroundOpacity.Value = this.Config.Background.Opacity;
			this.ButtonEdit.Enabled = (this.Config.Columns.ColumnList.Count > 0);
			this.ButtonRemove.Enabled = (this.Config.Columns.ColumnList.Count > 0);
			this.ButtonMoveUp.Enabled = (this.Config.Columns.ColumnList.Count > 0);
			this.ButtonMoveDown.Enabled = (this.Config.Columns.ColumnList.Count > 0);
			this.settingValues = false;
			Debug.Print("done.");
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000041DC File Offset: 0x000023DC
		private bool ColumnSwap(int Position1, int Position2)
		{
			if (Position2 < Position1)
			{
				int num = Position1;
				Position1 = Position2;
				Position2 = num;
			}
			if (Position1 >= 0 & Position2 < this.ListView.Items.Count)
			{
				ColumnElement element = this.Config.Columns.ColumnList[Position1];
				ColumnElement element2 = this.Config.Columns.ColumnList[Position2];
				this.Config.Columns.ColumnList.RemoveAt(Position1);
				this.Config.Columns.ColumnList.RemoveAt(Position2 - 1);
				this.Config.Columns.ColumnList.AddAt(Position1, element2);
				this.Config.Columns.ColumnList.AddAt(Position2, element);
				return true;
			}
			return false;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000042A0 File Offset: 0x000024A0
		public void ToggleColumn(ItemCheckedEventArgs e)
		{
			if (!this.settingValues)
			{
				DebugTools.Print("Option change: Toggle overlay column");
				this.Config.Columns.ColumnList[e.Item.Index].Enabled = e.Item.Checked;
				GameMemory.OverlayUpdateConfig();
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000042F4 File Offset: 0x000024F4
		public void ChangePositionX()
		{
			if (!this.settingValues)
			{
				DebugTools.Print("Option change: Overlay X position");
				this.Config.Position.X = Convert.ToInt32(this.NumericUpDownX.Value);
				GameMemory.OverlayUpdateConfig();
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0000432D File Offset: 0x0000252D
		public void ChangePositionY()
		{
			if (!this.settingValues)
			{
				DebugTools.Print("Option change: Overlay Y position");
				this.Config.Position.Y = Convert.ToInt32(this.NumericUpDownY.Value);
				GameMemory.OverlayUpdateConfig();
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00004366 File Offset: 0x00002566
		public void ChangeBackgroundOpacity()
		{
			if (!this.settingValues)
			{
				DebugTools.Print("Option change: Overlay background opacity");
				this.Config.Background.Opacity = Convert.ToInt32(this.TrackBarBackgroundOpacity.Value);
				GameMemory.OverlayUpdateConfig();
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0000439F File Offset: 0x0000259F
		public void ToggleOverlay()
		{
			DebugTools.Print("Option change: Toggle overlay");
			this.Config.Enabled = !this.Config.Enabled;
			GameMemory.OverlayUpdateConfig();
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000043C9 File Offset: 0x000025C9
		public void ToggleBackground()
		{
			DebugTools.Print("Option change: Toggle overlay background");
			this.Config.Background.Enabled = !this.Config.Background.Enabled;
			GameMemory.OverlayUpdateConfig();
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00004400 File Offset: 0x00002600
		public void AddColumn()
		{
			using (DialogBoxOverlayColumn dialogBoxOverlayColumn = new DialogBoxOverlayColumn())
			{
				DebugTools.Print("Open dialog box: Add overlay column (DialogBoxOverlayColumn)");
				dialogBoxOverlayColumn.Text = "Add Column";
				dialogBoxOverlayColumn.ButtonColumnConfirm.Text = "Add";
				if (dialogBoxOverlayColumn.ShowDialog() == DialogResult.OK)
				{
					DebugTools.Print("Option change: Add overlay column");
					this.Config.Columns.ColumnList.Add(new ColumnElement
					{
						Enabled = true,
						Data = (DataSourceEnum)dialogBoxOverlayColumn.ComboBoxColumnData.SelectedIndex,
						Width = Convert.ToInt32(dialogBoxOverlayColumn.NumericUpDownColumnWidth.Value),
						ShowHeader = dialogBoxOverlayColumn.CheckBoxShowHeader.Checked,
						HeaderColour = dialogBoxOverlayColumn.LabelHeaderColourPreview.BackColor,
						DataColour = dialogBoxOverlayColumn.LabelDataColourPreview.BackColor
					});
					GameMemory.OverlayUpdateConfig();
					this.UpdateStatic();
				}
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000044F0 File Offset: 0x000026F0
		public void EditColumn()
		{
			foreach (object obj in this.ListView.SelectedIndices)
			{
				int index = (int)obj;
				ColumnElement columnElement = this.Config.Columns.ColumnList[index];
				DebugTools.Print("Open dialog box: Edit overlay column (DialogBoxOverlayColumn)");
				using (DialogBoxOverlayColumn dialogBoxOverlayColumn = new DialogBoxOverlayColumn())
				{
					dialogBoxOverlayColumn.Text = "Edit Column";
					dialogBoxOverlayColumn.CheckboxColumnEnabled.Checked = columnElement.Enabled;
					dialogBoxOverlayColumn.NumericUpDownColumnWidth.Value = columnElement.Width;
					dialogBoxOverlayColumn.ComboBoxColumnData.SelectedIndex = (int)columnElement.Data;
					dialogBoxOverlayColumn.CheckBoxShowHeader.Checked = columnElement.ShowHeader;
					dialogBoxOverlayColumn.LabelHeaderColourPreview.BackColor = columnElement.HeaderColour;
					dialogBoxOverlayColumn.LabelDataColourPreview.BackColor = columnElement.DataColour;
					dialogBoxOverlayColumn.ButtonColumnConfirm.Text = "Confirm";
					if (dialogBoxOverlayColumn.ShowDialog() == DialogResult.OK)
					{
						DebugTools.Print("Option change: Edit overlay column");
						columnElement.Enabled = dialogBoxOverlayColumn.CheckboxColumnEnabled.Checked;
						columnElement.Width = (int)dialogBoxOverlayColumn.NumericUpDownColumnWidth.Value;
						columnElement.Data = (DataSourceEnum)dialogBoxOverlayColumn.ComboBoxColumnData.SelectedIndex;
						columnElement.ShowHeader = dialogBoxOverlayColumn.CheckBoxShowHeader.Checked;
						columnElement.HeaderColour = dialogBoxOverlayColumn.LabelHeaderColourPreview.BackColor;
						columnElement.DataColour = dialogBoxOverlayColumn.LabelDataColourPreview.BackColor;
						GameMemory.OverlayUpdateConfig();
						this.UpdateStatic();
					}
				}
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000046BC File Offset: 0x000028BC
		public void RemoveColumn()
		{
			for (int i = this.ListView.SelectedIndices.Count - 1; i >= 0; i--)
			{
				int index = this.ListView.SelectedIndices[i];
				DebugTools.Print("Option change: Remove overlay column (" + this.ListView.Items[index].SubItems[0].Text + ")");
				this.Config.Columns.ColumnList.RemoveAt(index);
			}
			GameMemory.OverlayUpdateConfig();
			this.UpdateStatic();
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00004750 File Offset: 0x00002950
		public void MoveColumnUp()
		{
			if (this.ListView.SelectedIndices.Count == 1)
			{
				DebugTools.Print("Option change: Move overlay column up");
				if (this.ColumnSwap(this.ListView.FocusedItem.Index - 1, this.ListView.FocusedItem.Index))
				{
					int num = this.ListView.SelectedIndices[0];
					MainForm.ListViewFocus(this.ListView.Items, num, false);
					MainForm.ListViewFocus(this.ListView.Items, num - 1, true);
					GameMemory.OverlayUpdateConfig();
					this.UpdateStatic();
					return;
				}
			}
			else
			{
				MessageBox.Show("Please select a single column.", "Multiple Selections", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000047FC File Offset: 0x000029FC
		public void MoveColumnDown()
		{
			if (this.ListView.SelectedIndices.Count == 1)
			{
				DebugTools.Print("Option change: Move overlay column down");
				if (this.ColumnSwap(this.ListView.FocusedItem.Index, this.ListView.FocusedItem.Index + 1))
				{
					int num = this.ListView.SelectedIndices[0];
					MainForm.ListViewFocus(this.ListView.Items, num, false);
					MainForm.ListViewFocus(this.ListView.Items, num + 1, true);
					this.UpdateStatic();
					GameMemory.OverlayUpdateConfig();
					return;
				}
			}
			else
			{
				MessageBox.Show("Please select a single column.", "Multiple Selections", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000048A8 File Offset: 0x00002AA8
		public void ChangeInfoFont()
		{
			DebugTools.Print("Open dialog box: Overlay info font (FontDialog)");
			using (FontDialog fontDialog = new FontDialog())
			{
				fontDialog.Font = this.Config.Fonts.Data;
				if (fontDialog.ShowDialog() == DialogResult.OK)
				{
					DebugTools.Print("Option change: Overlay info font");
					this.Config.Fonts.Data = fontDialog.Font;
					this.UpdateStatic();
					GameMemory.OverlayUpdateConfig();
				}
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000492C File Offset: 0x00002B2C
		public void ChangeHeaderFont()
		{
			DebugTools.Print("Open dialog box: Overlay header font (FontDialog)");
			using (FontDialog fontDialog = new FontDialog())
			{
				fontDialog.Font = this.Config.Fonts.Header;
				if (fontDialog.ShowDialog() == DialogResult.OK)
				{
					DebugTools.Print("Option change: Overlay header font");
					this.Config.Fonts.Header = fontDialog.Font;
					this.UpdateStatic();
					GameMemory.OverlayUpdateConfig();
				}
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000049B0 File Offset: 0x00002BB0
		public void ChangeLobbyInfo()
		{
			DebugTools.Print("Open dialog box: Overlay lobby info configuration (DialogBoxLobbyInfo)");
			using (DialogBoxColumnAdditional dialogBoxColumnAdditional = new DialogBoxColumnAdditional())
			{
				dialogBoxColumnAdditional.CheckBoxShortLobbyInfoNames.Checked = this.Config.Columns.Additional.LobbyInfo.ShortNames;
				dialogBoxColumnAdditional.CheckBoxId.Checked = this.Config.Columns.Additional.LobbyInfo.Basic.Id;
				dialogBoxColumnAdditional.CheckBoxType.Checked = this.Config.Columns.Additional.LobbyInfo.Basic.Type;
				dialogBoxColumnAdditional.CheckBoxHost.Checked = this.Config.Columns.Additional.LobbyInfo.Basic.Host;
				dialogBoxColumnAdditional.CheckBoxPlayerCount.Checked = this.Config.Columns.Additional.LobbyInfo.Basic.PlayerCount;
				dialogBoxColumnAdditional.CheckBoxEvent.Checked = this.Config.Columns.Additional.LobbyInfo.MatchMode.Event;
				dialogBoxColumnAdditional.CheckBoxTrack.Checked = this.Config.Columns.Additional.LobbyInfo.MatchMode.Track;
				dialogBoxColumnAdditional.CheckBoxDifficulty.Checked = this.Config.Columns.Additional.LobbyInfo.MatchMode.Difficulty;
				dialogBoxColumnAdditional.CheckBoxShortPlayerNames.Checked = this.Config.Columns.Additional.PlayerName.ShortNames;
				dialogBoxColumnAdditional.CheckBoxShortCharacterNames.Checked = this.Config.Columns.Additional.Character.ShortNames;
				if (dialogBoxColumnAdditional.ShowDialog() == DialogResult.OK)
				{
					DebugTools.Print("Option change: Overlay additional column options");
					this.Config.Columns.Additional.LobbyInfo.ShortNames = dialogBoxColumnAdditional.CheckBoxShortLobbyInfoNames.Checked;
					this.Config.Columns.Additional.LobbyInfo.Basic.Id = dialogBoxColumnAdditional.CheckBoxId.Checked;
					this.Config.Columns.Additional.LobbyInfo.Basic.Type = dialogBoxColumnAdditional.CheckBoxType.Checked;
					this.Config.Columns.Additional.LobbyInfo.Basic.Host = dialogBoxColumnAdditional.CheckBoxHost.Checked;
					this.Config.Columns.Additional.LobbyInfo.Basic.PlayerCount = dialogBoxColumnAdditional.CheckBoxPlayerCount.Checked;
					this.Config.Columns.Additional.LobbyInfo.MatchMode.Event = dialogBoxColumnAdditional.CheckBoxEvent.Checked;
					this.Config.Columns.Additional.LobbyInfo.MatchMode.Track = dialogBoxColumnAdditional.CheckBoxTrack.Checked;
					this.Config.Columns.Additional.LobbyInfo.MatchMode.Difficulty = dialogBoxColumnAdditional.CheckBoxDifficulty.Checked;
					this.Config.Columns.Additional.PlayerName.ShortNames = dialogBoxColumnAdditional.CheckBoxShortPlayerNames.Checked;
					this.Config.Columns.Additional.Character.ShortNames = dialogBoxColumnAdditional.CheckBoxShortCharacterNames.Checked;
					GameMemory.OverlayUpdateConfig();
				}
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00004D3C File Offset: 0x00002F3C
		public void ChangeBackgroundColour()
		{
			DebugTools.Print("Open dialog box: Overlay background colour (ColourDialog)");
			using (ColorDialog colorDialog = new ColorDialog())
			{
				colorDialog.Color = this.Config.Background.Colour;
				if (colorDialog.ShowDialog() == DialogResult.OK)
				{
					DebugTools.Print("Option change: Overlay background colour (ColourDialog)");
					this.Config.Background.Colour = colorDialog.Color;
					this.UpdateStatic();
					GameMemory.OverlayUpdateConfig();
				}
			}
		}

		// Token: 0x0400002D RID: 45
		private bool settingValues;

		// Token: 0x0400002E RID: 46
		private OverlayElement Config;

		// Token: 0x0400002F RID: 47
		private ListView ListView;

		// Token: 0x04000030 RID: 48
		private Label LabelHeaderFontPreview;

		// Token: 0x04000031 RID: 49
		private Label LabelHeaderFontName;

		// Token: 0x04000032 RID: 50
		private Label LabelDataFontPreview;

		// Token: 0x04000033 RID: 51
		private Label LabelDataFontName;

		// Token: 0x04000034 RID: 52
		private Label LabelBackgroundColourPreview;

		// Token: 0x04000035 RID: 53
		private CheckBox CheckBoxEnable;

		// Token: 0x04000036 RID: 54
		private CheckBox CheckBoxBackgroundEnable;

		// Token: 0x04000037 RID: 55
		private NumericUpDown NumericUpDownX;

		// Token: 0x04000038 RID: 56
		private NumericUpDown NumericUpDownY;

		// Token: 0x04000039 RID: 57
		private TrackBar TrackBarBackgroundOpacity;

		// Token: 0x0400003A RID: 58
		private Button ButtonEdit;

		// Token: 0x0400003B RID: 59
		private Button ButtonRemove;

		// Token: 0x0400003C RID: 60
		private Button ButtonMoveUp;

		// Token: 0x0400003D RID: 61
		private Button ButtonMoveDown;
	}
}
