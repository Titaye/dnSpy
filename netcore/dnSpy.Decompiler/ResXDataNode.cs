using System;
using System.Collections.Generic;
using System.Text;

namespace dnSpy.Decompiler
{
	public class ResXDataNode {
		private string key;
		private object value;

		public ResXDataNode(string key, object value) {
			this.key = key;
			this.value = value;
		}
	}
}
