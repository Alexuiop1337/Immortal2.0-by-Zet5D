using System;
using System.Reflection;

// Token: 0x0200001F RID: 31
internal class Class16
{
	// Token: 0x0600005B RID: 91 RVA: 0x00005E68 File Offset: 0x00004068
	internal static void QZsoVv11m68Vs(int typemdt)
	{
		Type type = Class16.module_0.ResolveType(33554432 + typemdt);
		foreach (FieldInfo fieldInfo in type.GetFields())
		{
			MethodInfo method = (MethodInfo)Class16.module_0.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	// Token: 0x0600005C RID: 92 RVA: 0x0000237E File Offset: 0x0000057E
	public Class16()
	{
		Class17.jLpoVv1z2TmaE();
		base..ctor();
	}

	// Token: 0x0600005D RID: 93 RVA: 0x00002484 File Offset: 0x00000684
	static Class16()
	{
		Class17.jLpoVv1z2TmaE();
		Class16.module_0 = typeof(Class16).Assembly.ManifestModule;
	}

	// Token: 0x0400002C RID: 44
	internal static Module module_0;

	// Token: 0x02000020 RID: 32
	// (Invoke) Token: 0x0600005F RID: 95
	internal delegate void Delegate0(object o);
}
