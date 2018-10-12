using System;
using System.Windows.Forms;

namespace SuperLobbyTool
{
	// Token: 0x02000012 RID: 18
	public class ListViewDoubleBuffered : ListView
	{
		// Token: 0x0600006B RID: 107 RVA: 0x0000C818 File Offset: 0x0000AA18
		public void New()
		{
			this.DoubleBuffered = true;
		}
	}
}
