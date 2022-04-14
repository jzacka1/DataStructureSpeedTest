using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureSpeedTest
{
	public interface ISpeedTest{

	}

	public static class SpeedTest
	{

		public static Task TimeMethod<T>(this IEnumerable<T> myIEnumerable, 
											Func<IEnumerable<T>> method)
		{
			return Task.Run(() =>
			{
				DateTime start = DateTime.UtcNow;

				method();

				DateTime end = DateTime.UtcNow;

				TimeSpan timeDiff = start - end;

				Console.WriteLine("{0}: {1} seconds", myIEnumerable.GetType().Name, timeDiff);
			});
		}

		public static Task TimeMethod<T>(this IEnumerable<T> myIEnumerable, 
											Func<T> method)
		{
			return Task.Run(() =>
			{
				DateTime start = DateTime.UtcNow;

				method();

				DateTime end = DateTime.UtcNow;

				TimeSpan timeDiff = start - end;

				Console.WriteLine("{0}: {1} seconds", myIEnumerable.GetType().Name, timeDiff);
			});
		}

		public static Task TimeMethod<T, U>(this IEnumerable<T> myIEnumerable, 
											Func<T, U> method, 
											T val) {
			return Task.Run(() =>
			{
				DateTime start = DateTime.UtcNow;

				method(val);

				DateTime end = DateTime.UtcNow;

				TimeSpan timeDiff = start - end;

				Console.WriteLine("{0}: {1} seconds", myIEnumerable.GetType().Name, timeDiff);
			});
		}

		public static Task TimeMethod<T, U, V>(this IDictionary<T,U> myIDictionary, 
												Func<T, V> method, 
												T val)
		{
			return Task.Run(() =>
			{
				DateTime start = DateTime.UtcNow;

				method(val);

				DateTime end = DateTime.UtcNow;

				TimeSpan timeDiff = start - end;

				Console.WriteLine("{0}: {1} seconds", myIDictionary.GetType().Name, timeDiff);
			});
		}
	}
}
