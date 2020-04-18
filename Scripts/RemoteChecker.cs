namespace UniRemoteChecker
{
	/// <summary>
	/// Unity Remote 5 が接続されているかどうか確認するクラス
	/// </summary>
	public static class RemoteChecker
	{
		/// <summary>
		/// <para>接続されている場合 true を返す</para>
		/// <para>接続されていても、Unity 再生直後の数フレームは false を返すことがあります</para>
		/// </summary>
		public static bool IsRemote
		{
			get
			{
#if UNITY_EDITOR
				return UnityEditor.EditorApplication.isRemoteConnected;
#else
				return false;
#endif
			}
		}
	}
}