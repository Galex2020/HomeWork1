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

		public double Length { get => Math.Sqrt(X * X + Y * Y); }
	}

	public class LineSegment
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

		public LineSegment(Point a, Point b)
		{
			A = a;
			B = b;
		}

        public double Length { get => Math.Sqrt(A.X * A.X + B.Y * B.Y); }

        // Ну, я хоя бы пытался.
        public static void AreTheyCrossing (LineSegment a, LineSegment b)
        {
            double v1 = (b.B.X - b.A.X) * (a.B.Y - b.A.Y) + (b.B.Y - b.A.Y) * (b.B.X - b.A.X);
            double v2 = (b.B.X - b.A.X) * (a.B.Y - b.A.Y) + (b.B.Y - b.A.Y) * (b.B.X - b.A.X);
            double v3 = (a.B.X - b.A.X) * (b.B.Y - b.A.Y) + (a.B.Y - b.A.Y) * (a.B.X - b.A.X);
            double v4 = (a.B.X - b.A.X) * (b.B.Y - b.A.Y) + (a.B.Y - b.A.Y) * (a.B.X - b.A.X);

            if (v1 * v2 < 0 && v3 * v4 < 0)
                WriteLine("Пересекаются!");
            else
                WriteLine("Не пересекаются!");
        }
	}


	class Program
	{
		static void Main(string[] args)
		{
			var a11 = new LineSegment.Point(double.Parse(ReadLine()), double.Parse(ReadLine()));
			var b12 = new LineSegment.Point(double.Parse(ReadLine()), double.Parse(ReadLine()));
            var a21 = new LineSegment.Point(double.Parse(ReadLine()), double.Parse(ReadLine()));
            var b22 = new LineSegment.Point(double.Parse(ReadLine()), double.Parse(ReadLine()));

            var ls1 = new LineSegment(a11, b12);
            var ls2 = new LineSegment(a21, b22);

            LineSegment.AreTheyCrossing(ls1, ls2);

			ReadKey(true);
		}
	}
}
