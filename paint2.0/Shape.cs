using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
//using System.Linq;
//using System.Text;
namespace paint2._0
{
    abstract class Shape
    {
        //public Shape() { }
        abstract public Graphics DrawS(Graphics g);
        abstract public void PenS(Pen p);
        abstract public void SolidBrushS(SolidBrush b);
        abstract public void Points(int x1, int y1, int x2, int y2);
        abstract public void Points(Rectangle r);
        abstract public void Points(Point[] p);
    }

    class RectangleS : Shape
    {
        public Pen pen;
        public SolidBrush brush = null;
        public Rectangle rect;
        //public Pen pen;
        //public SolidBrush brush = null;
        public RectangleS(Pen p, SolidBrush b=null)
        {
            pen = p;
            brush = b;
        }
        public RectangleS(RectangleS r)
        {
            pen = r.pen;
            brush = r.brush;
            rect = r.rect;
        }
        public RectangleS(Pen p,int x1, int y1, int x2, int y2, SolidBrush b=null)
        {
            rect = new Rectangle(Math.Min(x1, x2), Math.Min(y1, y2), Math.Abs(x1 - x2), Math.Abs(y1 - y2));
            pen = p;
            brush = b;
        }
        public RectangleS(Pen p, Rectangle r, SolidBrush b=null)
        {
            brush = b;
            pen = p;
            rect = new Rectangle(Math.Min(r.X, r.Width), Math.Min(r.Y, r.Height), Math.Abs(r.X - r.Width), Math.Abs(r.Y - r.Height));
        }
        override public void PenS(Pen p)
        {
            pen = p;
        }
        override public void SolidBrushS(SolidBrush b)
        {
            brush = b;
        }
        override public void Points(int x1, int y1, int x2, int y2)
        {
            rect = new Rectangle(Math.Min(x1, x2), Math.Min(y1, y2), Math.Abs(x1 - x2), Math.Abs(y1 - y2));
        }
        override public void Points(Rectangle r)
        {
            rect = new Rectangle(Math.Min(r.X, r.Width), Math.Min(r.Y, r.Height), Math.Abs(r.X - r.Width), Math.Abs(r.Y - r.Height));
        }
        override public void Points(Point[] p)
        {
            rect = new Rectangle(Math.Min((int)p[0].X, (int)p[p.Length-1].X), Math.Min((int)p[0].Y, (int)p[p.Length - 1].Y), Math.Abs((int)p[0].X -(int)p[p.Length - 1].X), Math.Abs((int)p[0].Y - (int)p[p.Length - 1].Y));
        }
        public override Graphics DrawS(Graphics g)
        {
            //Graphics g = Graphics.FromImage(b);
            if (brush != null)
            {
                g.FillRectangle(brush, rect);
            }
            g.DrawRectangle(pen, rect);
            return g;
        }
    }
    class LineS : Shape
    {
        public Pen pen;
        public Point Start, End;

        public LineS(LineS r)
        {
            pen = r.pen;
            Start = r.Start;
            End = r.End;
        }
        public LineS(Pen p)
        {
            pen = p;
        }

        public LineS(Pen p, int x1, int y1, int x2, int y2)
        {
            Start = new Point(x1, y1);
            End = new Point(x2, y2);
            pen = p;
        }
        public LineS(Pen p, Point start,Point end)
        {
            Start = start;
            End = end;
            pen = p;
        }
        override public void PenS(Pen p)
        {
            pen = p;
        }
        override public void SolidBrushS(SolidBrush b)
        {
        }
        override public void Points(int x1, int y1, int x2, int y2)
        {
            Start = new Point(x1, y1);
            End = new Point(x2, y2);
        }
        override public void Points(Rectangle r)
        {
            //rect = new Rectangle(Math.Min(r.X, r.Width), Math.Min(r.Y, r.Height), Math.Abs(r.X - r.Width), Math.Abs(r.Y - r.Height));
        }
        override public void Points(Point[] p)
        {
            Start = p[0];
            End = p[p.Length-1];
            //rect = new Rectangle(Math.Min((int)p[0].X, (int)p[1].X), Math.Min((int)p[0].Y, (int)p[1].Y), Math.Abs((int)p[0].X, -(int)p[1].X,), Math.Abs((int)p[0].Y - (int)p[1].Y));
        }
        public override Graphics DrawS(Graphics g)
        {
            //Graphics g = Graphics.FromImage(b);
            g.DrawLine(pen,Start,End);
            return g;
        }
    }
    class EllipseS : Shape
    {
        public Pen pen;
        public SolidBrush brush = null;
        public Rectangle rect;
        public EllipseS(EllipseS r)
        {
            pen = r.pen;
            brush = r.brush;
            rect = r.rect;
        }
        public EllipseS(Pen p, SolidBrush b=null)
        {
            pen = p;
            brush = b;
        }
        public EllipseS(Pen p, int x1, int y1, int x2, int y2, SolidBrush b = null)
        {
            rect = new Rectangle(Math.Min(x1, x2), Math.Min(y1, y2), Math.Abs(x1 - x2), Math.Abs(y1 - y2));
            pen = p;
            brush = b;
        }
        public EllipseS(Pen p, Rectangle r, SolidBrush b = null)
        {
            brush = b;
            pen = p;
            rect = new Rectangle(Math.Min(r.X, r.Width), Math.Min(r.Y, r.Height), Math.Abs(r.X - r.Width), Math.Abs(r.Y - r.Height));
        }
        override public void PenS(Pen p)
        {
            pen = p;
        }
        override public void SolidBrushS(SolidBrush b)
        {
            brush = b;
        }
        override public void Points(int x1, int y1, int x2, int y2)
        {
            rect = new Rectangle(Math.Min(x1, x2), Math.Min(y1, y2), Math.Abs(x1 - x2), Math.Abs(y1 - y2));
        }
        override public void Points(Rectangle r)
        {
            rect = new Rectangle(Math.Min(r.X, r.Width), Math.Min(r.Y, r.Height), Math.Abs(r.X - r.Width), Math.Abs(r.Y - r.Height));
        }
        override public void Points(Point[] p)
        {
            rect = new Rectangle(Math.Min((int)p[0].X, (int)p[p.Length - 1].X)- Math.Abs((int)p[0].X - (int)p[p.Length - 1].X), Math.Min((int)p[0].Y, (int)p[p.Length - 1].Y)- Math.Abs((int)p[0].Y - (int)p[p.Length - 1].Y), Math.Abs((int)p[0].X -(int)p[p.Length - 1].X)+ Math.Abs((int)p[0].X - (int)p[p.Length - 1].X), Math.Abs((int)p[0].Y - (int)p[p.Length - 1].Y)+ Math.Abs((int)p[0].Y - (int)p[p.Length - 1].Y));
        }
        public override Graphics DrawS(Graphics g)
        {
            if(brush !=null){
                g.FillEllipse(brush, rect);
            }
            g.DrawEllipse(pen,rect);
            return g;
        }
    }
    class CircleS : Shape
    {
        public Pen pen;
        public SolidBrush brush = null;
        public Rectangle rect;
        public CircleS(CircleS r)
        {
            pen = r.pen;
            brush = r.brush;
            rect = r.rect;
        }
        public CircleS(Pen p, SolidBrush b = null)
        {
            pen = p;
            brush = b;
        }
        public CircleS(Pen p, int x1, int y1, int x2, int y2, SolidBrush b = null)
        {
            int r =(int) Math.Sqrt((x2-x1)*(x2 - x1) + (y1-y2)*(y1 - y2));
            rect = new Rectangle(x1-r, y1-r, r+r, r+r);
            pen = p;
            brush = b;
        }
        public CircleS(Pen p, Rectangle rect, SolidBrush b = null)
        {
            brush = b;
            pen = p;
            int r = (int)Math.Sqrt((rect.X - rect.Height) * (rect.X - rect.Height) + (rect.Y - rect.Width) * (rect.Y - rect.Width));
            rect = new Rectangle(rect.X - r, rect.Y - r, rect.X + r, rect.Y + r);
            //rect = new Rectangle(Math.Min(r.X, r.Width), Math.Min(r.Y, r.Height), Math.Abs(r.X - r.Width), Math.Abs(r.Y - r.Height));
        }
        override public void PenS(Pen p)
        {
            pen = p;
        }
        override public void SolidBrushS(SolidBrush b)
        {
            brush = b;
        }
        override public void Points(int x1, int y1, int x2, int y2)
        {
            int r = (int)Math.Sqrt((rect.X - rect.Height) * (rect.X - rect.Height) + (rect.Y - rect.Width) * (rect.Y - rect.Width));
            this.rect = new Rectangle(rect.X - r, rect.Y - r, r + r, r + r);
        }
        override public void Points(Rectangle rect)
        {
            int r = (int)Math.Sqrt((rect.X - rect.Height) * (rect.X - rect.Height) + (rect.Y - rect.Width) * (rect.Y - rect.Width));
            this.rect = new Rectangle(rect.X - r, rect.Y - r, r + r,r + r);
        }
        override public void Points(Point[] p)
        {
            int r = (int)Math.Sqrt((p[0].X - p[p.Length - 1].X) * (p[0].X - p[p.Length - 1].X) + (p[0].Y - p[p.Length - 1].Y) * (p[0].Y - p[p.Length-1].Y));
            this.rect = new Rectangle(p[0].X - r, p[0].Y - r, r + r, r + r);
            //rect = new Rectangle(Math.Min((int)p[0].X, (int)p[1].X), Math.Min((int)p[0].Y, (int)p[1].Y), Math.Abs((int)p[0].X, -(int)p[1].X,), Math.Abs((int)p[0].Y - (int)p[1].Y));
        }
        public override Graphics DrawS(Graphics g)
        {
            if (brush != null)
            {
                g.FillEllipse(brush, rect);
            }
            g.DrawEllipse(pen, rect);

            return g;
        }
    }
    class TriangleS : Shape
    {
        Point[] triangle = new Point[3];
        public Pen pen;
        public SolidBrush brush = null;
        public TriangleS(TriangleS r)
        {
            pen = r.pen;
            brush = r.brush;
            triangle = r.triangle;
        }
        public TriangleS(Pen p, SolidBrush b=null)
        {
            pen = p;
            brush = b;
        }
        public TriangleS(Pen p, int x1, int y1, int x2, int y2, SolidBrush b = null)
        {
            triangle[0] = new Point((int)x1, (int)y1);
            triangle[1] = new Point((int)x1, (int)y2);
            triangle[2] = new Point((int)x2, (int)y2);
            pen = p;
            brush = b;
        }
        override public void PenS(Pen p)
        {
            pen = p;
        }
        override public void SolidBrushS(SolidBrush b)
        {
            brush = b;
        }
        override public void Points(int x1, int y1, int x2, int y2)
        {
            triangle[0] = new Point((int)x1, (int)y1);
            triangle[1] = new Point((int)x1, (int)y2);
            triangle[2] = new Point((int)x2, (int)y2);
        }
        override public void Points(Rectangle r)
        {
            //rect = new Rectangle(Math.Min(r.X, r.Width), Math.Min(r.Y, r.Height), Math.Abs(r.X - r.Width), Math.Abs(r.Y - r.Height));
        }
        override public void Points(Point[] p)
        {
            triangle[0] = new Point((int)p[0].X, (int)p[0].Y);
            triangle[1] = new Point((int)(int)p[0].X, (int)p[p.Length - 1].Y);
            triangle[2] = new Point((int)p[p.Length - 1].X, (int)p[p.Length - 1].Y);
}
        public override Graphics DrawS(Graphics g)
        {
            if (brush != null)
            {
                g.FillPolygon(brush,triangle);
            }
            g.DrawPolygon(pen, triangle);

            return g;
        }
    }
    class LinesS : Shape
    {
        Point[] points;
        public Pen pen;
        public LinesS(LinesS r)
        {
            pen = r.pen;
            points = r.points;
        }
        public LinesS(Pen p)
        {
            pen = p;
        }
        override public void Points(int x1, int y1, int x2, int y2)
        {
        }
        override public void Points(Rectangle r)
        {
        }
        override public void PenS(Pen p)
        {
            pen = p;
        }
        override public void SolidBrushS(SolidBrush b)
        {
        }
        override public void Points(Point[] p)
        {
            points = p;
        }
        public override Graphics DrawS(Graphics g)
        {
            //Graphics g = Graphics.FromImage(b);
            g.DrawLines(pen, points);
            //g.DrawCurve(pen, points);
            return g;
        }
    }
    class FreeDrawS : Shape
    {
        Point[] points;
        public Pen pen;
        public FreeDrawS(FreeDrawS r)
        {
            pen = r.pen;
            points = r.points;
        }
        public FreeDrawS(Pen p)
        {
            pen = p;
        }
        override public void Points(int x1, int y1, int x2, int y2)
        {
        }
        override public void Points(Rectangle r)
        {
        }
        override public void PenS(Pen p)
        {
            pen = p;
        }
        override public void SolidBrushS(SolidBrush b)
        {
        }
        override public void Points(Point[] p)
        {
            points = p;
        }
        public override Graphics DrawS(Graphics g)
        {
            //Graphics g = Graphics.FromImage(b);
            g.DrawCurve(pen, points);
            return g;
        }
    }
    class PolygonS : Shape
    {
        Point[] points;
        Pen pen;
        SolidBrush brush=null;
        public PolygonS(PolygonS r)
        {
            pen = r.pen;
            
            points = r.points;
            brush = r.brush;
        }
        public PolygonS(Pen p, SolidBrush b=null)
        {
            pen = p;
            brush = b;
        }
        override public void Points(int x1, int y1, int x2, int y2)
        {
        }
        override public void Points(Rectangle r)
        {
        }
        override public void PenS(Pen p)
        {
            pen = p;
        }
        override public void SolidBrushS(SolidBrush b)
        {
            brush = b;
        }
        override public void Points(Point[] p)
        {
            points = p;
        }
        public override Graphics DrawS(Graphics g)
        {
            if (points.Length > 1)
            {
                if (brush != null)
                {
                    g.FillPolygon(brush, points);
                }
                g.DrawPolygon(pen, points);
                
            }
            return g;
        }
    }
    class ClearS : Shape
    {
        public SolidBrush brush;
        //public Pen pen;
        //public SolidBrush brush = null;
        public ClearS(SolidBrush b)
        {
            brush = b;
        }
        public ClearS(ClearS r)
        {
            brush = r.brush;
        }

        override public void PenS(Pen p)
        {
            //pen = p;
        }
        override public void SolidBrushS(SolidBrush b)
        {
            brush = b;
        }
        override public void Points(int x1, int y1, int x2, int y2)
        {
           // rect = new Rectangle(Math.Min(x1, x2), Math.Min(y1, y2), Math.Abs(x1 - x2), Math.Abs(y1 - y2));
        }
        override public void Points(Rectangle r)
        {
            //rect = new Rectangle(Math.Min(r.X, r.Width), Math.Min(r.Y, r.Height), Math.Abs(r.X - r.Width), Math.Abs(r.Y - r.Height));
        }
        override public void Points(Point[] p)
        {
           // rect = new Rectangle(Math.Min((int)p[0].X, (int)p[p.Length - 1].X), Math.Min((int)p[0].Y, (int)p[p.Length - 1].Y), Math.Abs((int)p[0].X - (int)p[p.Length - 1].X), Math.Abs((int)p[0].Y - (int)p[p.Length - 1].Y));
        }
        public override Graphics DrawS(Graphics g)
        {
            //Graphics g = Graphics.FromImage(b);
            g.Clear(brush.Color);
            return g;
        }
    }
    class HouseS : Shape
    {
        public Pen pen;
        public SolidBrush brush = null;
        public Rectangle rect;
        //public Pen pen;
        //public SolidBrush brush = null;
        public HouseS(Pen p, SolidBrush b = null)
        {
            pen = p;
            brush = b;
        }
        public HouseS(HouseS r)
        {
            pen = r.pen;
            brush = r.brush;
            rect = r.rect;
        }
        public HouseS(Pen p, int x1, int y1, int x2, int y2, SolidBrush b = null)
        {
            rect = new Rectangle(Math.Min(x1, x2), Math.Min(y1, y2), Math.Abs(x1 - x2), Math.Abs(y1 - y2));
            pen = p;
            brush = b;
        }
        public HouseS(Pen p, Rectangle r, SolidBrush b = null)
        {
            brush = b;
            pen = p;
            rect = new Rectangle(Math.Min(r.X, r.Width), Math.Min(r.Y, r.Height), Math.Abs(r.X - r.Width), Math.Abs(r.Y - r.Height));
        }
        override public void PenS(Pen p)
        {
            pen = p;
        }
        override public void SolidBrushS(SolidBrush b)
        {
            brush = b;
        }
        override public void Points(int x1, int y1, int x2, int y2)
        {
            rect = new Rectangle(Math.Min(x1, x2), Math.Min(y1, y2), Math.Abs(x1 - x2), Math.Abs(y1 - y2));
        }
        override public void Points(Rectangle r)
        {
            rect = new Rectangle(Math.Min(r.X, r.Width), Math.Min(r.Y, r.Height), Math.Abs(r.X - r.Width), Math.Abs(r.Y - r.Height));
        }
        override public void Points(Point[] p)
        {
            rect = new Rectangle(Math.Min((int)p[0].X, (int)p[p.Length - 1].X), Math.Min((int)p[0].Y, (int)p[p.Length - 1].Y), Math.Abs((int)p[0].X - (int)p[p.Length - 1].X), Math.Abs((int)p[0].Y - (int)p[p.Length - 1].Y));
        }
        public override Graphics DrawS(Graphics g)
        {
            //Graphics g = Graphics.FromImage(b);
            Point[] points = { new Point(rect.X, rect.Y), new Point(rect.X+rect.Width, rect.Y), new Point(rect.X+(rect.Width)/2, rect.Y- rect.Height / 3) };
            if (brush != null)
            {
                g.FillRectangle(brush, rect.X,rect.Y,rect.Width,rect.Height*2/3);
                g.FillPolygon(brush, points);
            }
            g.DrawRectangle(pen, rect.X + rect.Width * 2 / 5, rect.Y + rect.Height * 1/3, rect.Width * 1 / 5, rect.Height * 1/3);
            g.DrawRectangle(pen, rect.X + rect.Width * 10 / 15, rect.Y + rect.Height * 2 / 15, rect.Width * 3 / 15, rect.Height * 3 / 15);
            g.DrawRectangle(pen, rect.X + rect.Width * 2 / 15, rect.Y + rect.Height * 2 / 15, rect.Width * 3 / 15, rect.Height * 3 / 15);
            g.DrawRectangle(pen, rect.X, rect.Y, rect.Width, rect.Height * 2 / 3);
            g.DrawPolygon(pen, points);
            return g;
        }
    }
    class StarS : Shape
    {
        public Pen pen;
        public SolidBrush brush = null;
        public Rectangle rect;
        //public Pen pen;
        //public SolidBrush brush = null;
        public StarS(Pen p, SolidBrush b = null)
        {
            pen = p;
            brush = b;
        }
        public StarS(StarS r)
        {
            pen = r.pen;
            brush = r.brush;
            rect = r.rect;
        }
        public StarS(Pen p, int x1, int y1, int x2, int y2, SolidBrush b = null)
        {
            rect = new Rectangle(Math.Min(x1, x2), Math.Min(y1, y2), Math.Abs(x1 - x2), Math.Abs(y1 - y2));
            pen = p;
            brush = b;
        }
        public StarS(Pen p, Rectangle r, SolidBrush b = null)
        {
            brush = b;
            pen = p;
            rect = new Rectangle(Math.Min(r.X, r.Width), Math.Min(r.Y, r.Height), Math.Abs(r.X - r.Width), Math.Abs(r.Y - r.Height));
        }
        override public void PenS(Pen p)
        {
            pen = p;
        }
        override public void SolidBrushS(SolidBrush b)
        {
            brush = b;
        }
        override public void Points(int x1, int y1, int x2, int y2)
        {
            rect = new Rectangle(Math.Min(x1, x2), Math.Min(y1, y2), Math.Abs(x1 - x2), Math.Abs(y1 - y2));
        }
        override public void Points(Rectangle r)
        {
            rect = new Rectangle(Math.Min(r.X, r.Width), Math.Min(r.Y, r.Height), Math.Abs(r.X - r.Width), Math.Abs(r.Y - r.Height));
        }
        override public void Points(Point[] p)
        {
            rect = new Rectangle(Math.Min((int)p[0].X, (int)p[p.Length - 1].X), Math.Min((int)p[0].Y, (int)p[p.Length - 1].Y), Math.Abs((int)p[0].X - (int)p[p.Length - 1].X), Math.Abs((int)p[0].Y - (int)p[p.Length - 1].Y));
        }
        public override Graphics DrawS(Graphics g)
        {
            //Graphics g = Graphics.FromImage(b);
            Point[] points = {
                new Point(rect.X, rect.Y),
                new Point(rect.X + rect.Width, rect.Y),
                new Point(rect.X + rect.Width * 1 / 5, rect.Y +  rect.Height),
                new Point(rect.X + rect.Width/2, rect.Y - rect.Height*2/5),
                new Point(rect.X + rect.Width * 4 / 5, rect.Y +  rect.Height),
                new Point(rect.X,rect.Y),
            };
            if (brush != null)
            {
                g.FillPolygon(brush, points);
            }
            g.DrawPolygon(pen, points);
            return g;
        }
    }
    class BadThingS : Shape
    {
        public Pen pen;
        public SolidBrush brush = null;
        public Rectangle rect;
        //public Pen pen;
        //public SolidBrush brush = null;
        public BadThingS(Pen p, SolidBrush b = null)
        {
            pen = p;
            brush = b;
        }
        public BadThingS(BadThingS r)
        {
            pen = r.pen;
            brush = r.brush;
            rect = r.rect;
        }
        public BadThingS(Pen p, int x1, int y1, int x2, int y2, SolidBrush b = null)
        {
            rect = new Rectangle(Math.Min(x1, x2), Math.Min(y1, y2), Math.Abs(x1 - x2), Math.Abs(y1 - y2));
            pen = p;
            brush = b;
        }
        public BadThingS(Pen p, Rectangle r, SolidBrush b = null)
        {
            brush = b;
            pen = p;
            rect = new Rectangle(Math.Min(r.X, r.Width), Math.Min(r.Y, r.Height), Math.Abs(r.X - r.Width), Math.Abs(r.Y - r.Height));
        }
        override public void PenS(Pen p)
        {
            pen = p;
        }
        override public void SolidBrushS(SolidBrush b)
        {
            brush = b;
        }
        override public void Points(int x1, int y1, int x2, int y2)
        {
            rect = new Rectangle(Math.Min(x1, x2), Math.Min(y1, y2), Math.Abs(x1 - x2), Math.Abs(y1 - y2));
        }
        override public void Points(Rectangle r)
        {
            rect = new Rectangle(Math.Min(r.X, r.Width), Math.Min(r.Y, r.Height), Math.Abs(r.X - r.Width), Math.Abs(r.Y - r.Height));
        }
        override public void Points(Point[] p)
        {
            rect = new Rectangle(Math.Min((int)p[0].X, (int)p[p.Length - 1].X), Math.Min((int)p[0].Y, (int)p[p.Length - 1].Y), Math.Abs((int)p[0].X - (int)p[p.Length - 1].X), Math.Abs((int)p[0].Y - (int)p[p.Length - 1].Y));
        }
        public override Graphics DrawS(Graphics g)
        {
            //Graphics g = Graphics.FromImage(b);
            Point[] points = {
                new Point(rect.X, rect.Y),
                new Point(rect.X + rect.Width, rect.Y),
                new Point(rect.X + rect.Width * 1 / 5, rect.Y +  rect.Height),
                new Point(rect.X + rect.Width/2, rect.Y - rect.Height*2/5),
                new Point(rect.X + rect.Width * 4 / 5, rect.Y +  rect.Height),
                new Point(rect.X,rect.Y),
            };
            if (brush != null)
            {
                g.FillPolygon(brush, points);
            }

            g.DrawPolygon(pen, points);
            g.DrawEllipse(pen, rect.X, rect.Y - rect.Height * 2 / 5, rect.Width, rect.Height*7/5);
            return g;
        }
    }
    class TheXS : Shape
    {
        public Pen pen;
        public Point Start, End;

        public TheXS(TheXS r)
        {
            pen = r.pen;
            Start = r.Start;
            End = r.End;
        }
        public TheXS(Pen p)
        {
            pen = p;
        }

        public TheXS(Pen p, int x1, int y1, int x2, int y2)
        {
            Start = new Point(x1, y1);
            End = new Point(x2, y2);
            pen = p;
        }
        public TheXS(Pen p, Point start, Point end)
        {
            Start = start;
            End = end;
            pen = p;
        }
        override public void PenS(Pen p)
        {
            pen = p;
        }
        override public void SolidBrushS(SolidBrush b)
        {
        }
        override public void Points(int x1, int y1, int x2, int y2)
        {
            Start = new Point(x1, y1);
            End = new Point(x2, y2);
        }
        override public void Points(Rectangle r)
        {
            //rect = new Rectangle(Math.Min(r.X, r.Width), Math.Min(r.Y, r.Height), Math.Abs(r.X - r.Width), Math.Abs(r.Y - r.Height));
        }
        override public void Points(Point[] p)
        {
            Start = p[0];
            End = p[p.Length - 1];
            //rect = new Rectangle(Math.Min((int)p[0].X, (int)p[1].X), Math.Min((int)p[0].Y, (int)p[1].Y), Math.Abs((int)p[0].X, -(int)p[1].X,), Math.Abs((int)p[0].Y - (int)p[1].Y));
        }
        public override Graphics DrawS(Graphics g)
        {
            //Graphics g = Graphics.FromImage(b);
            g.DrawLine(pen, Start, End);
            g.DrawLine(pen, Start.X, End.Y, End.X, Start.Y);
            return g;
        }
    }
    class CurveS : Shape
    {
        Point[] points;
        public Pen pen;
        public CurveS(CurveS r)
        {
            pen = r.pen;
            points = r.points;
        }
        public CurveS(Pen p)
        {
            pen = p;
        }
        override public void Points(int x1, int y1, int x2, int y2)
        {
        }
        override public void Points(Rectangle r)
        {
        }
        override public void PenS(Pen p)
        {
            pen = p;
        }
        override public void SolidBrushS(SolidBrush b)
        {
        }
        override public void Points(Point[] p)
        {
            points = p;
        }
        public override Graphics DrawS(Graphics g)
        {
            if (points.Length > 1)
            {
                g.DrawCurve(pen, points);
            }

            return g;
        }
    }
    class ClosedCurvedS : Shape
    {
        Point[] points;
        Pen pen;
        SolidBrush brush = null;
        public ClosedCurvedS(ClosedCurvedS r)
        {
            pen = r.pen;

            points = r.points;
            brush = r.brush;
        }
        public ClosedCurvedS(Pen p, SolidBrush b = null)
        {
            pen = p;
            brush = b;
        }
        override public void Points(int x1, int y1, int x2, int y2)
        {
        }
        override public void Points(Rectangle r)
        {
        }
        override public void PenS(Pen p)
        {
            pen = p;
        }
        override public void SolidBrushS(SolidBrush b)
        {
            brush = b;
        }
        override public void Points(Point[] p)
        {
            points = p;
        }
        public override Graphics DrawS(Graphics g)
        {
            if (points.Length > 2)
            {
                if (brush != null)
                {
                    g.FillClosedCurve(brush, points);
                }
                //g.DrawClosedCurve();
                g.DrawClosedCurve(pen, points);

            }
            return g;
        }
    }

}

