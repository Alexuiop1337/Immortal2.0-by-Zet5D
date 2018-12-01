using System;
using System.Collections.Generic;
using Microsoft.Win32;

// Token: 0x02000008 RID: 8
internal static class Class5
{
	// Token: 0x06000015 RID: 21
	public static string get_guid()
	{
		string result;
		try
		{
			using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
			{
				using (RegistryKey registryKey2 = registryKey.OpenSubKey("SOFTWARE\\Microsoft\\Cryptography"))
				{
					if (registryKey2 == null)
					{
						throw new KeyNotFoundException(string.Format("Key Not Found: {0}", "SOFTWARE\\Microsoft\\Cryptography"));
					}
					object value = registryKey2.GetValue("MachineGuid");
					if (value == null)
					{
						throw new IndexOutOfRangeException(string.Format("Index Not Found: {0}", "MachineGuid"));
					}
					result = value.ToString().ToUpper().Replace("-", string.Empty);
				}
			}
		}
		catch
		{
			result = "HWID not found";
		}
		return result;
	}
}
