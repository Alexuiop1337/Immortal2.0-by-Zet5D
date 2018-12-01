using System;
using System.Reflection;
using System.Windows.Forms;

// Token: 0x02000022 RID: 34
internal static class Class18
{
	// Token: 0x06000064 RID: 100
	internal static string get_path(Assembly assembly)
	{
		if (assembly == typeof(Class18).Assembly)
		{
			return Application.ExecutablePath;
		}
		return assembly.Location;
	}
}
