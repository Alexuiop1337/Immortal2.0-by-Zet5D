using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Immortal.Cards
{
	// Token: 0x02000019 RID: 25
	public class CardData
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600004B RID: 75 RVA: 0x0000242F File Offset: 0x0000062F
		// (set) Token: 0x0600004C RID: 76 RVA: 0x00002437 File Offset: 0x00000637
		public string Name { get; set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00002440 File Offset: 0x00000640
		// (set) Token: 0x0600004E RID: 78 RVA: 0x00002448 File Offset: 0x00000648
		public string Exp_m { get; set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00002451 File Offset: 0x00000651
		// (set) Token: 0x06000050 RID: 80 RVA: 0x00002459 File Offset: 0x00000659
		public string Exp_y { get; set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00002462 File Offset: 0x00000662
		// (set) Token: 0x06000052 RID: 82 RVA: 0x0000246A File Offset: 0x0000066A
		public string Number { get; set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00002473 File Offset: 0x00000673
		// (set) Token: 0x06000054 RID: 84 RVA: 0x0000247B File Offset: 0x0000067B
		public string Billing { get; set; }

		// Token: 0x06000055 RID: 85 RVA: 0x000056F8 File Offset: 0x000038F8
		public override string ToString()
		{
			return string.Format("{0}\t{1}/{2}\t{3}\t{4}\r\n******************************\r\n", new object[]
			{
				this.Name,
				this.Exp_m,
				this.Exp_y,
				this.Number,
				this.Billing
			});
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000237E File Offset: 0x0000057E
		public CardData()
		{
			Class17.jLpoVv1z2TmaE();
			base..ctor();
		}

		// Token: 0x04000026 RID: 38
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04000027 RID: 39
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string string_1;

		// Token: 0x04000028 RID: 40
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private string string_2;

		// Token: 0x04000029 RID: 41
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private string string_3;

		// Token: 0x0400002A RID: 42
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string string_4;
	}
}
