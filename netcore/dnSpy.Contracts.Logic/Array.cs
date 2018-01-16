namespace dnSpy {
	public static class Array {
		public static T[] Empty<T>() {
			return new T[0];
		}

		public static int BinarySearch<T>(T[] array, T value) {
			return System.Array.BinarySearch(array, value);
		}

		public static void Sort<T>(T[] items, System.Collections.Generic.IComparer<T> comparer) {
			System.Array.Sort(items, comparer);
		}
	}
}
