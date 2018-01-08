using System;
using dnSpy.Contracts.Decompiler;
using dnSpy.Decompiler.ILSpy.Core.Settings;

namespace dnSpy.Decompiler.ILSpy.Core
{
    public static class DecompilerFactory
    {
		public static DecompilerSettingsBase CreateCSharpVBDecompilerSettings() {
			return new CSharpVBDecompilerSettings();
		}

		public static DecompilerBase CreateCSharpDecompiler(DecompilerSettingsBase settings) {
			return new CSharp.CSharpDecompiler(settings as CSharpVBDecompilerSettings ?? new CSharpVBDecompilerSettings(), 0);
		}
    }
}
