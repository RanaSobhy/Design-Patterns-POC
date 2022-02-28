using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
	public class NewsAgency : ISubject
	{
		private String breakingNews;
		private readonly List<IObserver> channelList;

		public NewsAgency()
		{
			channelList = new List<IObserver>();
		} 
		public void Register(IObserver observer)
		{
			channelList.Add(observer);
		}

		public void Unregister(IObserver observer)
		{
			channelList.Remove(observer);
		}

		public void NotifyObservers()
		{
			foreach(var channel in channelList)
			{
				channel.Update(this.breakingNews);
			}
		}

		public void UpdateNews(String lastNews)
		{
			this.breakingNews = lastNews;
			NotifyObservers();
		}
	}
}
