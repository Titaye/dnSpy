namespace ICSharpCode {
	public static class Array {
		public static T[] Empty<T>() {
			return new T[0];
		}

		public static void Sort<T>(T[] items, System.Collections.Generic.IComparer<T> comparer) {
			System.Array.Sort(items, comparer);
		}

		public static void Copy(System.Array source, System.Array destination, int length) {
			System.Array.Copy(source, destination, length);
		}

		public static int IndexOf<T>(T[] source, T item) {
			return System.Array.IndexOf(source, item);
		}
	}
}
