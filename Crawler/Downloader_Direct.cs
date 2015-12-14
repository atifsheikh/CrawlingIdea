using System.Net;

namespace OneKey.Crawler
{
	/// <summary>
	/// dumb stupid direct synchronous download
	/// </summary>
	class Downloader_Direct : IDownloader
	{
		public virtual string Download(string address)
		{
			var c = new System.Net.WebClient();
            c.Headers.Add("user-agent", "FM.com Alert Crawler (www.forummarketing.com/contact)");	// TODO: move to .config

			return c.DownloadString(address); 
		}
	}
}
