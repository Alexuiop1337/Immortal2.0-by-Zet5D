using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Immortal.Forms
{
	// Token: 0x02000018 RID: 24
	public class FormData
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000045 RID: 69 RVA: 0x0000240D File Offset: 0x0000060D
		// (set) Token: 0x06000046 RID: 70 RVA: 0x00002415 File Offset: 0x00000615
		public string Name { get; set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000047 RID: 71 RVA: 0x0000241E File Offset: 0x0000061E
		// (set) Token: 0x06000048 RID: 72 RVA: 0x00002426 File Offset: 0x00000626
		public string Value { get; set; }

		// Token: 0x06000049 RID: 73 RVA: 0x000056D0 File Offset: 0x000038D0
		public override string ToString()
		{
			return string.Format("Name: {0}\r\nValue: {1}\r\n----------------------------\r\n", this.Name, this.Value);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000237E File Offset: 0x0000057E
		public FormData()
		{
			Class17.jLpoVv1z2TmaE();
			base..ctor();
		}

		// Token: 0x04000024 RID: 36
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string string_0;

		// Token: 0x04000025 RID: 37
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string string_1;
	}
}
