using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
namespace paint2._0
{
   
    public partial class Form1 : Form
    {
        bool record = false;
        bool mouseDownStarted = false;
        bool mouseDown= false;
        bool RecortPrintedPrev = false;
        //Pen BorderC;
        SolidBrush clear;// FillC;
        Graphics g;
        List<Shape> ShapesUndo = new List<Shape>();
        List<Shape> ShapesRedo = new List<Shape>();
        List<Shape> RecordDrawMain = new List<Shape>();
        List<Shape> RecordDrawTemp = new List<Shape>();
        List<Point> points = new List<Point>();
        List<Point> pointsTemp = new List<Point>();
        List<Point> pointsold = new List<Point>();
        Type[] multyPoint= { typeof(LinesS),typeof(PolygonS), typeof(ClosedCurvedS), typeof(CurveS) };
        Bitmap frameMain,tempframe;
        Shape curentShape,prevShape,clearShape;
        public Form1()
        {
            InitializeComponent();

            this.AllowDrop = true;
            clear = new SolidBrush(colorDialog3.Color);
            frameMain = new Bitmap(panel2.Size.Width, panel2.Size.Height);
            Graphics gTemp = Graphics.FromImage(frameMain);
            gTemp.Clear(clear.Color);
            color_border.BackColor = colorDialog1.Color;
            color_fill.BackColor = colorDialog2.Color;
            BackGround.BackColor = colorDialog3.Color;
            g = panel2.CreateGraphics() ;
            clearShape = new ClearS(clear);
            curentShape = prevShape = new FreeDrawS(new Pen(colorDialog1.Color, (float)numericUpDown1.Value));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BringToFront();
            this.Focus();
            this.KeyPreview = true;
            this.KeyUp += new KeyEventHandler(Form1_KeyUp);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown&& curentShape== prevShape) {
                if (curentShape.GetType() == typeof(FreeDrawS))
                {
                    points.Add(new Point(e.X, e.Y));
                }
                Prevew(e);
            }
            else if (multyPoint.Contains(curentShape.GetType()) && mouseDownStarted && curentShape == prevShape)
            {
                Prevew(e);
            } 
        }
        private void Prevew(MouseEventArgs e)
        {
            pointsTemp = new List<Point>(points);
            Bitmap frameTemp = new Bitmap(frameMain.Size.Width, frameMain.Size.Height);
            Graphics gTemp = Graphics.FromImage(frameTemp);
            gTemp.Clear(clear.Color);
            gTemp.DrawImage(frameMain, 0, 0);
            pointsTemp.Add(new Point(e.X, e.Y));
            curentShape.Points(pointsTemp.ToArray());
            gTemp = curentShape.DrawS(gTemp);
            g.DrawImage(frameTemp, 0, 0);
            gTemp.Dispose();
            frameTemp.Dispose();
        }
        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            points.Add(new Point(e.X,e.Y));
            if (multyPoint.Contains(curentShape.GetType()) && mouseDownStarted)
            {
                Prevew(e);
            }
            else
            {
                Graphics gTemp = Graphics.FromImage(frameMain);
                curentShape.Points(points.ToArray());
                gTemp = curentShape.DrawS(gTemp);
                g.DrawImage(frameMain, 0, 0);
                if (record)
                {
                    RecordDrawMain.Add((Shape)Activator.CreateInstance(curentShape.GetType(), curentShape));
                }
                else
                {
                    ShapesUndo.Add((Shape)Activator.CreateInstance(curentShape.GetType(), curentShape));
                }
                if (!multyPoint.Contains(curentShape.GetType()))
                {
                    mouseDownStarted = false;
                }
                mouseDown = false;
                gTemp.Dispose();
            }
        }
        private void UpdateCanvas(Graphics gTemp) {

            Bitmap frameTemp = new Bitmap(frameMain.Size.Width, frameMain.Size.Height);
            gTemp = Graphics.FromImage(frameTemp);
            gTemp.Clear(clear.Color);
            gTemp.DrawImage(frameMain, 0, 0);
            g.DrawImage(frameTemp, 0, 0);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            g.DrawImage(frameMain, 0, 0);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            curentShape.PenS( new Pen(colorDialog1.Color, (float)numericUpDown1.Value));
        }

        private void Triangle_Click(object sender, EventArgs e)
        {
            if (fill.Checked)
            {
                curentShape = new TriangleS(new Pen(colorDialog1.Color, (float)numericUpDown1.Value), new SolidBrush(colorDialog2.Color));
            }
            else
            {
                curentShape = new TriangleS(new Pen(colorDialog1.Color, (float)numericUpDown1.Value));
            }
        }

        private void Ellipse_Click(object sender, EventArgs e)
        {
            if (fill.Checked)
            {
                curentShape = new EllipseS(new Pen(colorDialog1.Color, (float)numericUpDown1.Value), new SolidBrush(colorDialog2.Color));
            }
            else
            {
                curentShape = new EllipseS(new Pen(colorDialog1.Color, (float)numericUpDown1.Value));
            }
        }

        private void Circle_Click(object sender, EventArgs e)
        {
            if (fill.Checked)
            {
                curentShape = new CircleS(new Pen(colorDialog1.Color, (float)numericUpDown1.Value), new SolidBrush(colorDialog2.Color));
            }
            else
            {
                curentShape = new CircleS(new Pen(colorDialog1.Color, (float)numericUpDown1.Value));
            }
        }

        private void fill_CheckedChanged(object sender, EventArgs e)
        {
            if (fill.Checked)
            {
                curentShape.SolidBrushS(new SolidBrush(colorDialog2.Color));
            }
            else
            {
                curentShape.SolidBrushS(null);
            }
        }

        private void Line_Click(object sender, EventArgs e)
        {
            curentShape = new LineS(new Pen(colorDialog1.Color, (float)numericUpDown1.Value));
        }

        private void Undo_Click(object sender, EventArgs e)
        {
            if (ShapesUndo.Count() > 0)
            {
                frameMain = new Bitmap(panel2.Size.Width, panel2.Size.Height);
                Graphics gTemp = Graphics.FromImage(frameMain);
                gTemp.Clear(clear.Color);
                Shape temp = ShapesUndo.Last();
                ShapesRedo.Add(temp);
                ShapesUndo.Remove(temp);
                if (points.Count() > 0)
                {
                    Point pT = points.Last();
                    pointsold.Add(pT);
                    points.Remove(pT);
                }
                foreach (Shape T in ShapesUndo)
                {
                    gTemp = T.DrawS(gTemp);
                }
                g.DrawImage(frameMain, 0, 0);
            }
        }

        private void Rectangle_Click(object sender, EventArgs e)
        {
            if (fill.Checked) {
                curentShape = new RectangleS(new Pen(colorDialog1.Color, (float)numericUpDown1.Value), new SolidBrush(colorDialog2.Color));
            }else
            {
                curentShape = new RectangleS(new Pen(colorDialog1.Color, (float)numericUpDown1.Value));
            }
        }

        private void Redo_Click(object sender, EventArgs e)
        {
            if (ShapesRedo.Count() > 0)
            {
                frameMain = new Bitmap(panel2.Size.Width, panel2.Size.Height);
                Graphics gTemp = Graphics.FromImage(frameMain);
                gTemp.Clear(clear.Color);
                Shape temp = ShapesRedo.Last();
                ShapesUndo.Add(temp);
                ShapesRedo.Remove(temp);
                if (pointsold.Count() > 0)
                {
                    Point pT = pointsold.Last();
                    points.Add(pT);
                    pointsold.Remove(pT);
                }
                foreach (Shape T in ShapesUndo)
                {
                    if (T.GetType() == typeof(ClearS))
                    {
                        T.SolidBrushS(clear);  
                    }
                    gTemp = T.DrawS(gTemp);
                }
                g.DrawImage(frameMain, 0, 0);
            }
        }


        private void Playback_Click(object sender, EventArgs e)
        {
            if (RecordDrawMain.Count > 0) {
                RecordDrawTemp = new List<Shape>(RecordDrawMain);
                PlayBackTimer.Enabled = true;
                tempframe = new Bitmap(panel2.Width, panel2.Height);
                Graphics gTemp = Graphics.FromImage(tempframe);
                gTemp.Clear(clear.Color);
                g.Clear(clear.Color);
                RecortPrintedPrev = false;
                gTemp.Dispose();
            }
        }

        private void RecordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            record = RecordCheckBox.Checked;
        }

        private void Lines_Click(object sender, EventArgs e)
        {
            curentShape = new LinesS(new Pen(colorDialog1.Color, (float)numericUpDown1.Value));
        }

        private void Free_sketch_Click(object sender, EventArgs e)
        {
            curentShape = new FreeDrawS(new Pen(colorDialog1.Color, (float)numericUpDown1.Value));
        }

        private void PlayBackTimer_Tick(object sender, EventArgs e)
        {
            Graphics gTemp = Graphics.FromImage(tempframe);
            if (!RecortPrintedPrev)
            {
                foreach (Shape T in ShapesUndo)
                {
                    gTemp = T.DrawS(gTemp);
                }
                RecortPrintedPrev = true;

                g.DrawImage(tempframe, 0, 0);
            }
            else if (RecordDrawTemp.Count>0) {
                

                Shape sTemp = RecordDrawTemp.First();
                gTemp = sTemp.DrawS(gTemp);
                g.DrawImage(tempframe,0,0);
                RecordDrawTemp.Remove(sTemp);
            }
            else
            {
                PlayBackTimer.Enabled = false;
            }
            gTemp.Dispose();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            curentShape.PenS( new Pen(colorDialog1.Color, (float)numericUpDown1.Value));
            color_border.BackColor = colorDialog1.Color;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            colorDialog2.ShowDialog();
            curentShape.SolidBrushS (new SolidBrush(colorDialog2.Color));
            color_fill.BackColor = colorDialog2.Color;
        }

        private void flowLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Polygon_Click(object sender, EventArgs e)
        {
            if (fill.Checked)
            {
                curentShape = new PolygonS(new Pen(colorDialog1.Color, (float)numericUpDown1.Value), new SolidBrush(colorDialog2.Color));
            }
            else
            {
                curentShape = new PolygonS(new Pen(colorDialog1.Color, (float)numericUpDown1.Value));
            }
        }

        private void ClearScreen_Click(object sender, EventArgs e)
        {
            Shape sTemp = new ClearS(new SolidBrush(clear.Color));
            Graphics gTemp = Graphics.FromImage(frameMain);
            clearShape.Points(0, 0,panel2.Size.Width, panel2.Size.Height);
            gTemp = clearShape.DrawS(gTemp);
            if (pointsTemp.Count>1 && multyPoint.Contains(curentShape.GetType())) {
                curentShape.Points(pointsTemp.ToArray());
                if (record)
                {
                    RecordDrawMain.Add((Shape)Activator.CreateInstance(curentShape.GetType(), curentShape));
                }
                else
                {
                    ShapesUndo.Add((Shape)Activator.CreateInstance(curentShape.GetType(), curentShape));
                }
            }
            mouseDownStarted = false;
            ShapesUndo.Add((Shape)Activator.CreateInstance(clearShape.GetType(), clearShape));
            g.DrawImage(frameMain, 0, 0);
            points = new List<Point>();
            pointsTemp = new List<Point>();
            curentShape = (Shape)Activator.CreateInstance(curentShape.GetType(), curentShape);
            //curentShape.Points(pointsTemp.ToArray());
        }

        private void House_Click(object sender, EventArgs e)
        {
            if (fill.Checked)
            {
                curentShape = new HouseS(new Pen(colorDialog1.Color, (float)numericUpDown1.Value), new SolidBrush(colorDialog2.Color));
            }
            else
            {
                curentShape = new HouseS(new Pen(colorDialog1.Color, (float)numericUpDown1.Value));
            }
        }
        private void Star_Click(object sender, EventArgs e)
        {
            
            if (fill.Checked)
            {
                curentShape = new StarS(new Pen(colorDialog1.Color, (float)numericUpDown1.Value), new SolidBrush(colorDialog2.Color));
            }
            else
            {
                curentShape = new StarS(new Pen(colorDialog1.Color, (float)numericUpDown1.Value));
            }
        }
        private void BadThing_Click(object sender, EventArgs e)
        {
            if (fill.Checked)
            {
                curentShape = new BadThingS(new Pen(colorDialog1.Color, (float)numericUpDown1.Value), new SolidBrush(colorDialog2.Color));
            }
            else
            {
                curentShape = new BadThingS(new Pen(colorDialog1.Color, (float)numericUpDown1.Value));
            }
        }
        private void TheX_Click(object sender, EventArgs e)
        {
            curentShape = new TheXS(new Pen(colorDialog1.Color, (float)numericUpDown1.Value));
        }
        private void ToFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (dialog.FileName.Substring(Math.Max(0, dialog.FileName.Length - 4)) == ".Bmp")
                {
                    frameMain.Save(dialog.FileName, ImageFormat.Bmp);
                }
                else
                {
                    frameMain.Save(dialog.FileName+".Bmp", ImageFormat.Bmp);
                }
            }
        }
        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            if (pointsTemp.Count > 1 && multyPoint.Contains(pointsTemp.GetType()))
            {
                Graphics gTemp = Graphics.FromImage(frameMain);
                curentShape.Points(pointsTemp.ToArray());
                gTemp = curentShape.DrawS(gTemp);
                g.DrawImage(frameMain, 0, 0);
                if (record)
                {
                    RecordDrawMain.Add((Shape)Activator.CreateInstance(curentShape.GetType(), curentShape));
                }
                else
                {
                    ShapesUndo.Add((Shape)Activator.CreateInstance(curentShape.GetType(), curentShape));
                }

            }

            points = new List<Point>();
            pointsTemp = new List<Point>();
            mouseDownStarted = false;
            mouseDown = false;
        }
        private void panel2_MouseEnter(object sender, EventArgs e)
        {

            if ((pointsTemp.Count() > 1) && (prevShape != curentShape))
            {

                Graphics gTemp = Graphics.FromImage(frameMain);
                prevShape.Points(points.ToArray());
                gTemp = prevShape.DrawS(gTemp);
                g.DrawImage(frameMain, 0, 0);
                if (record)
                {
                    RecordDrawMain.Add((Shape)Activator.CreateInstance(prevShape.GetType(), prevShape));
                }
                else
                {
                    ShapesUndo.Add((Shape)Activator.CreateInstance(prevShape.GetType(), prevShape));
                }
                points = new List<Point>();
                pointsTemp = new List<Point>();
                gTemp.Dispose();
            }
        }
        private void ClosedCurved_Click(object sender, EventArgs e)
        {

            if (fill.Checked)
            {
                curentShape = new ClosedCurvedS(new Pen(colorDialog1.Color, (float)numericUpDown1.Value), new SolidBrush(colorDialog2.Color));
            }
            else
            {
                curentShape = new ClosedCurvedS(new Pen(colorDialog1.Color, (float)numericUpDown1.Value));
            }
        }
        private void Curve_Click(object sender, EventArgs e)
        {

            curentShape = new CurveS(new Pen(colorDialog1.Color, (float)numericUpDown1.Value));
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
           if(e.KeyCode == Keys.Escape )
           {

                if ((pointsTemp.Count() > 1))
                {

                    Graphics gTemp = Graphics.FromImage(frameMain);
                    prevShape.Points(points.ToArray());
                    gTemp = prevShape.DrawS(gTemp);
                    g.DrawImage(frameMain, 0, 0);
                    if (record)
                    {
                        RecordDrawMain.Add((Shape)Activator.CreateInstance(prevShape.GetType(), prevShape));
                    }
                    else
                    {
                        ShapesUndo.Add((Shape)Activator.CreateInstance(prevShape.GetType(), prevShape));
                    }
                    points = new List<Point>();
                    pointsTemp = new List<Point>();
                    gTemp.Dispose();
                }
           }
           if (e.Control && e.KeyCode == Keys.S) ToFile.PerformClick();
           if (e.Control && e.KeyCode == Keys.Z) Undo.PerformClick();
           if (e.Control  && e.KeyCode == Keys.Y) Redo.PerformClick();
        }

        private void BackGround_Click(object sender, EventArgs e)
        {
            colorDialog3.ShowDialog();
            BackGround.BackColor = colorDialog3.Color;
            clear.Color = colorDialog3.Color;
            clearShape = new ClearS(clear);
            frameMain = new Bitmap(panel2.Size.Width, panel2.Size.Height);
            Graphics gTemp = Graphics.FromImage(frameMain);
            gTemp.Clear(clear.Color);
            if (ShapesUndo.Count>0) {
                Shape temp = ShapesUndo.Last();
                foreach (Shape T in ShapesUndo)
                {
                    gTemp = T.DrawS(gTemp);
                }
            }
            g.DrawImage(frameMain, 0, 0);
        }
        private void ReStart_Click(object sender, EventArgs e)
        {


            ShapesUndo.AddRange(RecordDrawMain);
            RecordDrawMain = new List<Shape>();
        }
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {

            if ((pointsTemp.Count()>1 )&& (prevShape != curentShape))
            {

                Graphics gTemp = Graphics.FromImage(frameMain);
                prevShape.Points(points.ToArray());
                gTemp = prevShape.DrawS(gTemp);
                g.DrawImage(frameMain, 0, 0);
                if (record)
                {
                    RecordDrawMain.Add((Shape)Activator.CreateInstance(prevShape.GetType(), prevShape));
                }
                else
                {
                    ShapesUndo.Add((Shape)Activator.CreateInstance(prevShape.GetType(), prevShape));
                }
                points = new List<Point>();
                pointsTemp = new List<Point>();
                gTemp.Dispose();
            }
            if (!mouseDownStarted || prevShape != curentShape)
            {
                points = new List<Point>();
                pointsTemp = new List<Point>();
            }
            if (multyPoint.Contains(curentShape.GetType()))
            {
                mouseDownStarted = true;
            }
            else
            {
                mouseDownStarted = false;

                points.Add(new Point(e.X, e.Y));
                pointsTemp.Add(new Point(e.X, e.Y));
            }
            prevShape = curentShape;
            mouseDown = true;
        }
    }
}
