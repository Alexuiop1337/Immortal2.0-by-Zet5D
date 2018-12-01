using System;
using System.IO;

// Token: 0x0200000E RID: 14
internal static class Class8
{
	// Token: 0x0600001E RID: 30
	public static string Random_string()
	{
		return Path.GetRandomFileName().Replace(".", "");
	}
}
