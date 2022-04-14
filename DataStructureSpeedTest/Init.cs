using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureSpeedTest
{
	public class Init
	{

		public readonly int max;

		public Init(int max)
		{
			this.max = max;
		}

		public Task AddItemsAsync(ICollection<int> list)
		{
			return Task.Run(() =>
			{
				DateTime start = DateTime.UtcNow;

				for (int i = 1; i <= this.max; i++)
				{
					list.Add(i);  // THIS DOESN'T ADD TO LIST.  FIX IT!
				}

				DateTime end = DateTime.UtcNow;

				TimeSpan timeDiff = start - end;

				Console.WriteLine("{0}: {1} seconds", list.GetType().Name, timeDiff);
			});
		}

		public Task<int[]> AddItemsAsync(int[] list)
		{
			return Task.Run(() =>
			{
				DateTime start = DateTime.UtcNow;

				list = new int[this.max];

				for (int i = 0; i < this.max; i++)
				{
					list[i] = i;  // THIS DOESN'T ADD TO LIST.  FIX IT!
				}

				DateTime end = DateTime.UtcNow;

				TimeSpan timeDiff = start - end;

				Console.WriteLine("{0}: {1} seconds", list.GetType().Name, timeDiff);

				return list;
			});
		}

		public Task AddItemsAsync(Queue<int> list)
		{
			return Task.Run(() =>
			{
				DateTime start = DateTime.UtcNow;

				for (int i = 1; i <= this.max; i++)
				{
					list.Enqueue(i);  // THIS DOESN'T ADD TO LIST.  FIX IT!
				}

				DateTime end = DateTime.UtcNow;

				TimeSpan timeDiff = start - end;

				Console.WriteLine("{0}: {1} seconds", list.GetType().Name, timeDiff);
			});
		}

		public Task AddItemsAsync(Stack<int> list)
		{
			return Task.Run(() =>
			{
				DateTime start = DateTime.UtcNow;

				for (int i = 1; i <= this.max; i++)
				{
					list.Push(i);  // THIS DOESN'T ADD TO LIST.  FIX IT!
				}

				DateTime end = DateTime.UtcNow;

				TimeSpan timeDiff = start - end;

				Console.WriteLine("{0}: {1} seconds", list.GetType().Name, timeDiff);
			});
		}

		public Task AddItemsAsync(IDictionary<int, int> list)
		{
			return Task.Run(() =>
			{
				DateTime start = DateTime.UtcNow;

				for (int i = 1; i <= this.max; i++)
				{
					list.Add(i, i);
				}

				DateTime end = DateTime.UtcNow;

				TimeSpan timeDiff = start - end;

				Console.WriteLine("{0}: {1} seconds", list.GetType().Name, timeDiff);
			});
		}
	}
}
