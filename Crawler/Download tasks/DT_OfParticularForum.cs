namespace OneKey.Crawler
{
	/// <summary>
	/// base for all the download tasks for a particular forum;
	/// will be in an associative array against forum reference; 
	/// and the only queue for a particular forum
	/// </summary>
	class DT_OfParticularForum : DT_Base
	{
		public DT_OfParticularForum(IDownloader downloader, string uri = "") 
			: base(downloader, uri) 
		{ }

		// TODO: not implemented

	}
}
