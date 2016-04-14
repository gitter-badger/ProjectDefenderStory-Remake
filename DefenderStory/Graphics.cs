using DefenderStory.Api;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using static DxLibDLL.DX;

namespace DefenderStory
{
	/// <summary>
	/// Defender Story のグラフィクス API の実装を提供します．
	/// </summary>
	class Graphics : IGraphics
	{
		public static Graphics Instance => new Graphics();

		public void Line(Point p1, Point p2, Color c, int thickness = 1)
		{
			Line(p1.X, p1.Y, p2.X, p2.Y, c, thickness);
			
		}

		public void Line(int x1, int y1, int x2, int y2, Color c, int thickness = 1)
		{
			DrawLine(x1, y1, x2, y2, GetColor(c.R, c.G, c.B), thickness);
		}

		public void Box(Point p1, Point p2, Color c)
		{
			Box(p1.X, p1.Y, p2.X, p2.Y, c);
		}

		public void Box(int x1, int y1, int x2, int y2, Color c)
		{
			DrawBox(x1, y1, x2, y2, GetColor(c.R, c.G, c.B), FALSE);
		}

		public void FillBox(Point p1, Point p2, Color c)
		{
			FillBox(p1.X, p1.Y, p2.X, p2.Y, c);
		}

		public void FillBox(int x1, int y1, int x2, int y2, Color c)
		{
			DrawBox(x1, y1, x2, y2, GetColor(c.R, c.G, c.B), TRUE);
		}

		public void Circle(Point p, int r, Color c)
		{
			Circle(p.X, p.Y, r, c);
		}

		public void Circle(int x, int y, int r, Color c)
		{
			DrawCircle(x, y, r, GetColor(c.R, c.G, c.B));
		}

		public void FillCircle(Point p, int r, Color c)
		{
			FillCircle(p.X, p.Y, r, c);
		}

		public void FillCircle(int x, int y, int r, Color c)
		{
			DrawCircle(x, y, r, GetColor(c.R, c.G, c.B), TRUE);
		}



	}

}
