using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace OneKey.Crawler
{
	/// <summary>
	/// handle all the types of download for a particular forum
	/// </summary>
	class DQ_ParticularForum : IDownloadQueue
	{
		/// <summary>
		/// actual processor; now just a single : to not hurt remote server; moreover: do delay before the requests to the same host
		/// </summary>
		private System.Threading.Thread _t = null;
		private Queue<DT_Base> _q = new Queue<DT_Base>();			// tasks for processing;
		private Object _csQu = new Object();  // its CS
		private List<DT_Base> _results = new List<DT_Base>();		// storage for results; task stores results itself, just keep it here
		private Object _csRes = new Object();  // its CS

        //public bool IsAlive
        //{ 
        //    get { return _t.IsAlive; }   
        //}

		// TODO: DQ_ParticularForum() : ref to statistics
		public DQ_ParticularForum(IDownloader downloader)
		//	: 
		{
			Downloader = downloader;
		}

		/// <summary>
		/// the only downloader for the whole forum
		/// </summary>
		public IDownloader Downloader { get; private set; }

		#region IDownloadQueue
		public void Enqueue(DT_Base task)
		{
			// TODO: ask statistics: whether do download?

			lock (_csQu)
			{
                //bool AlreadyQueued = false;
                //foreach (var _qloop in _q)
                //{
                //    if (_qloop.Uri == task.Uri)
                //    {
                //        AlreadyQueued = true;
                //        break;
                //    }
                //}
                //if (AlreadyQueued == false)
                    _q.Enqueue(task);	// post to queueu; worker  will eat it
			}

		}
		#endregion

		public void Start()
		{
            _t = new Thread(QueueReader);

            //_t.Start(this);



//			var session = new DbSession();
//			session.RunAsync(() => QueueReader(this)); 
		}

		static void QueueReader(object _this)
		{
			var This = (DQ_ParticularForum)_this;
			while (true)
			{
				DT_Base task;
				lock (This._csQu)
				{
					if (This._q.Count <=  0) break;		// TODO: wait some time for new tasks
					task = This._q.Dequeue();
				}
				task.Download();

				// TODO: task contains result: handle result
			}
		}
	}
}