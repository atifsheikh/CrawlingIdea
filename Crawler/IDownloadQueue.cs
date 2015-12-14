namespace OneKey.Crawler
{
	/// <summary>
	/// download queue abstract;
	/// client post tasks and knows nothing about consequent destiny of tasks
	/// </summary>
	interface IDownloadQueue
	{
		void Enqueue(DT_Base task);
	}
}
