using System.Net;

namespace OneKey.Crawler
{
	/// <summary>
	/// base class for all the download tasks
	/// 
	/// just alike value type struct, but we need hierarchy
	/// </summary>
	class DT_Base
	{
		// we are passing downloader througn the whole hierarhy instead of getting it via _q.downloader
		// due to queue for all forums has separate downloader for each forum
		protected IDownloader Downloader
		{
			get { return _downloader; }
		}

		public DT_Base(IDownloader downloader, string uri = "")
		{
			_downloader = downloader;
			_uri = uri;
            //Download();
		}	// not nullable: to use in generic collections

		#region props
		public virtual string Uri 
		{
			get { return _uri;} 
			protected set { _uri = value; }
		}

		/// <summary>
		/// the whole uri content downloaded
		/// </summary>
		public string Result { get; set; }

		/// <summary>
		/// Take into account server response code, network failures, etc.
		/// </summary>
		public StatusCode Status { get; protected set; }
		#endregion

		public enum StatusCode
		{ 
			NotSend,
			DownloadedOK,
			NetworkError,
			ForumError,
//			  ParsingError,
			UnknownError,
		}

		
		/// <returns>true on success</returns>
		public virtual bool IsSuccess()
		{
			return Status == StatusCode.DownloadedOK;
		}

		/// <summary>
		/// download the uri specified
		/// do block the : ing framework if elsewhere; 
		/// until implemented scheduling of tasks async is harmful here
		/// </summary>
		public virtual void Download()
		{
			if (!IsSuccess())
			{
				try
				{
					Result = Downloader.Download(Uri);
					Status = StatusCode.DownloadedOK;
				}
				catch (WebException e)
				{
					// TODO: handle cases when error is planned: network/forum failures on consequent try, etc.
					//((App)App.Current).Log(e.ToString());  // TODO: manage log: in proper form and frequency
				}
			}
		}

		private string _uri;
		private readonly IDownloader _downloader;
	}
}
