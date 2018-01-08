using System;
using System.Collections.Generic;
using System.Text;

namespace dnSpy.Contracts.Utilities
{
	public class RegistryKey : IDisposable {

		public void Dispose() {
				
		}
		
		internal RegistryKey OpenSubKey(string k) {
			return new RegistryKey();
		}

		public object GetValue(string k) {
			return null;
		}
	}

	public class Registry {
		
		internal static readonly RegistryKey LocalMachine = new RegistryKey();
	}
}
