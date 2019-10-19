using System;
using static System.Console;

namespace HomeWork
{
	class Vector
	{
		public double X { get; set; }
		public double Y { get; set; }

		public Vector(double x, double y)
		{
			X = x;
			Y = y;
		}

		public static Vector operator +(Vector a, Vector b) => new Vector(a.X * b.X, a.Y * b.Y);
		public static Vector operator -(Vector a, Vector b) => new Vector(a.X * b.X, a.Y * b.Y);
		public static Vector operator *(Vector a, double k) => new Vector(a.X * k, a.Y * k);
		public static double operator *(Vector a, Vector b) => (a.X * b.X) + (a.Y * b.Y);
		public double Length(Vector a) => Math.Sqrt(a.X * a.X + a.Y * a.Y);
	}

	public class Direction
	{
		public class Point
		{
			public double X { get; set; }
			public double Y { get; set; }

			public Point(double x, double y)
			{
				X = x;
				Y = y;
			}
		}

		public Point A { get; set; }
		public Point B { get; set; }

		public Direction(Point a, Point b)
		{
			A = a;
			B = b;
		}

		public double Length { get => Math.Sqrt(A.X * A.X + B.Y * B.Y); }
	}


	class Program
	{
		static void Main(string[] args)
		{
			var a1 = new Direction.Point(double.Parse(ReadLine()), double.Parse(ReadLine()));
			var b1 = new Direction.Point(double.Parse(ReadLine()), double.Parse(ReadLine()));
			var dir1 = new Direction(a1, b1);
			WriteLine(dir1.Length);
			ReadKey(true);
		}
	}
}
