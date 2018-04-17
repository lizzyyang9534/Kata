using System;
using System.Collections.Generic;

namespace CarParkEscape
{
	public class Car
	{
		private const int StartNum = 2;
		private const int StairNum = 1;
		private Position StartPosition;
		private List<Position> Staircases = new List<Position>();
		private List<string> Route = new List<string>();
		private int Down = 1;

		public string[] Escape(int[,] carpark)
		{
			MarkStartPositionAndStaircases(carpark);

			int currentSpace = StartPosition.Space;
			for (int i = StartPosition.Level; i < Staircases.Count; i++)
			{
				var dis = GetStep(currentSpace, Staircases[i].Space);
				RecordRoute(dis);
				currentSpace = Staircases[i].Space;
			}

			var last = GetStep(currentSpace, carpark.GetUpperBound(1));
			if (last != "D")
			{
				Route.Add(last);
			}

			return Route.ToArray();
		}

		private void MarkStartPositionAndStaircases(int[,] carpark)
		{
			var places = carpark.GetLength(1);
			for (int i = 0; i < carpark.GetLength(0); i++)
			{
				for (int j = 0; j < places; j++)
				{
					if (carpark[i, j] == StartNum)
					{
						StartPosition = new Position(i, j);

					}
					if (carpark[i, j] == StairNum)
					{
						Staircases.Add(new Position(i, j));
					}
				}
			}
		}

		private string GetStep(int startPlace, int endPlace)
		{
			var dis = startPlace - endPlace;
			if (dis == 0)
			{
				return "D";
			}
			else if (dis > 0)
			{
				return string.Concat("L", dis);
			}
			return string.Concat("R", Math.Abs(dis));
		}

		private void GoDown(int count)
		{
			if (count > 1)
			{
				Route.RemoveAt(Route.Count - 1);
				Route.Add("D" + count);
				return;
			}
			Route.Add("D1");
		}

		private void RecordRoute(string dis)
		{
			if (dis == "D")
			{
				Down++;
				GoDown(Down);
			}
			else
			{
				Route.Add(dis);
				Down = 1;
				GoDown(Down);
			}
		}
	}
	public class Position
	{
		public int Level { get; set; }
		public int Space { get; set; }

		public Position(int level, int space)
		{
			Level = level;
			Space = space;
		}
	}
}