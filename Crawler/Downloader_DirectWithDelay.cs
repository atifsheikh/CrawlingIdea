using System;
using System.Text;

namespace OneKey.Crawler
{
	/// <summary>
	/// dumb direct downloader that can wait until next download action
	/// </summary>
	class Downloader_DirectWithDelay : Downloader_Direct
	{
		public Downloader_DirectWithDelay(TimeSpan interval) { _interval = interval; }

		public override string Download(string address)
		{
			if (_prev != null)
			{
				TimeSpan dif = DateTime.UtcNow - (DateTime)_prev;
				if (dif < _interval) // do wait
				{
					System.Threading.Thread.Sleep(_interval - dif);
				}
			}
			string s = base.Download(address);
			_prev = DateTime.UtcNow;	// set the time at the end of downloading (rather than beginning): to ensure time strobbing
			return s;
		}

		readonly TimeSpan _interval;
		private DateTime? _prev = null;
	}
}
