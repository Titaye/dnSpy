using System;
using System.Collections.Generic;
using System.Text;

namespace dnSpy.Decompiler
{
	public class ResXResourceWriter : IDisposable {
		private string filename;

		public ResXResourceWriter(string filename) {
			this.filename = filename;
		}

		public void Dispose() {
			
		}

		internal void AddResource(ResXDataNode t) {
			
		}
	}
}
