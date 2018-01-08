// dnlib: See LICENSE.txt for more info

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using dnlib.PE;
using dnlib.Utils;
using dnlib.IO;
using dnlib.DotNet.MD;
using dnlib.DotNet.Emit;
using dnlib.DotNet.Pdb;
using dnlib.W32Resources;

using DNW = dnlib.DotNet.Writer;
using dnlib.DotNet.Pdb.Symbols;

namespace dnlib.DotNet {
	/// <summary>
	/// Created from a row in the Module table
	/// </summary>
	public static class ModuleDefMDExtensions {
		/// <summary>
		/// Creates a <see cref="ModuleDefMD"/> instance from a reflection module
		/// </summary>
		/// <param name="mod">An existing reflection module</param>
		/// <param name="context">Module context or <c>null</c></param>
		/// <param name="imageLayout">Image layout of the module in memory</param>
		/// <returns>A new <see cref="ModuleDefMD"/> instance</returns>
		public static ModuleDefMD Load(System.Reflection.Module mod, ModuleContext context, ImageLayout imageLayout) {
			return Load(mod, new ModuleCreationOptions(context), imageLayout);
		}

		/// <summary>
		/// Creates a <see cref="ModuleDefMD"/> instance from a reflection module
		/// </summary>
		/// <param name="mod">An existing reflection module</param>
		/// <param name="options">Module creation options or <c>null</c></param>
		/// <param name="imageLayout">Image layout of the module in memory</param>
		/// <returns>A new <see cref="ModuleDefMD"/> instance</returns>
		public static ModuleDefMD Load(System.Reflection.Module mod, ModuleCreationOptions options, ImageLayout imageLayout) {
			IntPtr addr = Marshal.GetHINSTANCE(mod);
			if (addr == new IntPtr(-1))
				throw new InvalidOperationException(string.Format("Module {0} has no HINSTANCE", mod));
			return Load(addr, options, imageLayout);
		}

		
		/// <summary>
		/// Creates a <see cref="ModuleDefMD"/> instance from a reflection module
		/// </summary>
		/// <param name="mod">An existing reflection module</param>
		/// <returns>A new <see cref="ModuleDefMD"/> instance</returns>
		public static ModuleDefMD Load(System.Reflection.Module mod) {
			return Load(mod, (ModuleCreationOptions)null, GetImageLayout(mod));
		}

		/// <summary>
		/// Creates a <see cref="ModuleDefMD"/> instance from a reflection module
		/// </summary>
		/// <param name="mod">An existing reflection module</param>
		/// <param name="context">Module context or <c>null</c></param>
		/// <returns>A new <see cref="ModuleDefMD"/> instance</returns>
		public static ModuleDefMD Load(System.Reflection.Module mod, ModuleContext context) {
			return Load(mod, new ModuleCreationOptions(context), GetImageLayout(mod));
		}

		/// <summary>
		/// Creates a <see cref="ModuleDefMD"/> instance from a reflection module
		/// </summary>
		/// <param name="mod">An existing reflection module</param>
		/// <param name="options">Module creation options or <c>null</c></param>
		/// <returns>A new <see cref="ModuleDefMD"/> instance</returns>
		public static ModuleDefMD Load(System.Reflection.Module mod, ModuleCreationOptions options) {
			return Load(mod, options, GetImageLayout(mod));
		}

}
