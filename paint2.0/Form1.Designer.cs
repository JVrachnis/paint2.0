namespace paint2._0
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.Undo = new System.Windows.Forms.Button();
            this.RecordCheckBox = new System.Windows.Forms.CheckBox();
            this.Redo = new System.Windows.Forms.Button();
            this.Playback = new System.Windows.Forms.Button();
            this.ToFile = new System.Windows.Forms.Button();
            this.ReStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.House = new System.Windows.Forms.Button();
            this.Star = new System.Windows.Forms.Button();
            this.BadThing = new System.Windows.Forms.Button();
            this.TheX = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.Rectangle = new System.Windows.Forms.Button();
            this.Triangle = new System.Windows.Forms.Button();
            this.Ellipse = new System.Windows.Forms.Button();
            this.Line = new System.Windows.Forms.Button();
            this.circle = new System.Windows.Forms.Button();
            this.Lines = new System.Windows.Forms.Button();
            this.Polygon = new System.Windows.Forms.Button();
            this.Curve = new System.Windows.Forms.Button();
            this.ClosedCurved = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.color_border = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.color_fill = new System.Windows.Forms.Button();
            this.fill = new System.Windows.Forms.CheckBox();
            this.BackGround = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Free_sketch = new System.Windows.Forms.Button();
            this.ClearScreen = new System.Windows.Forms.Button();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.colorDialog3 = new System.Windows.Forms.ColorDialog();
            this.PlayBackTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 445);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.AllowDrop = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1169, 827);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseEnter += new System.EventHandler(this.panel2_MouseEnter);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.groupBox4);
            this.flowLayoutPanel2.Controls.Add(this.groupBox1);
            this.flowLayoutPanel2.Controls.Add(this.groupBox3);
            this.flowLayoutPanel2.Controls.Add(this.groupBox2);
            this.flowLayoutPanel2.Controls.Add(this.groupBox5);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(826, 94);
            this.flowLayoutPanel2.TabIndex = 9;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.flowLayoutPanel4);
            this.groupBox4.Location = new System.Drawing.Point(680, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(143, 84);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Controls";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoScroll = true;
            this.flowLayoutPanel4.Controls.Add(this.Undo);
            this.flowLayoutPanel4.Controls.Add(this.RecordCheckBox);
            this.flowLayoutPanel4.Controls.Add(this.Redo);
            this.flowLayoutPanel4.Controls.Add(this.Playback);
            this.flowLayoutPanel4.Controls.Add(this.ToFile);
            this.flowLayoutPanel4.Controls.Add(this.ReStart);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 19);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(143, 59);
            this.flowLayoutPanel4.TabIndex = 1;
            // 
            // Undo
            // 
            this.Undo.Location = new System.Drawing.Point(3, 3);
            this.Undo.Name = "Undo";
            this.Undo.Size = new System.Drawing.Size(45, 23);
            this.Undo.TabIndex = 0;
            this.Undo.Text = "Undo";
            this.Undo.UseVisualStyleBackColor = true;
            this.Undo.Click += new System.EventHandler(this.Undo_Click);
            // 
            // RecordCheckBox
            // 
            this.RecordCheckBox.AutoSize = true;
            this.RecordCheckBox.Location = new System.Drawing.Point(54, 3);
            this.RecordCheckBox.Name = "RecordCheckBox";
            this.RecordCheckBox.Size = new System.Drawing.Size(61, 17);
            this.RecordCheckBox.TabIndex = 4;
            this.RecordCheckBox.Text = "Record";
            this.RecordCheckBox.UseVisualStyleBackColor = true;
            this.RecordCheckBox.CheckedChanged += new System.EventHandler(this.RecordCheckBox_CheckedChanged);
            // 
            // Redo
            // 
            this.Redo.Location = new System.Drawing.Point(3, 32);
            this.Redo.Name = "Redo";
            this.Redo.Size = new System.Drawing.Size(45, 23);
            this.Redo.TabIndex = 2;
            this.Redo.Text = "Redo";
            this.Redo.UseVisualStyleBackColor = true;
            this.Redo.Click += new System.EventHandler(this.Redo_Click);
            // 
            // Playback
            // 
            this.Playback.Location = new System.Drawing.Point(54, 32);
            this.Playback.Name = "Playback";
            this.Playback.Size = new System.Drawing.Size(63, 23);
            this.Playback.TabIndex = 3;
            this.Playback.Text = "Playback";
            this.Playback.UseVisualStyleBackColor = true;
            this.Playback.Click += new System.EventHandler(this.Playback_Click);
            // 
            // ToFile
            // 
            this.ToFile.Location = new System.Drawing.Point(3, 61);
            this.ToFile.Name = "ToFile";
            this.ToFile.Size = new System.Drawing.Size(45, 23);
            this.ToFile.TabIndex = 10;
            this.ToFile.Text = "Save";
            this.ToFile.UseVisualStyleBackColor = true;
            this.ToFile.Click += new System.EventHandler(this.ToFile_Click);
            // 
            // ReStart
            // 
            this.ReStart.Location = new System.Drawing.Point(54, 61);
            this.ReStart.Name = "ReStart";
            this.ReStart.Size = new System.Drawing.Size(63, 23);
            this.ReStart.TabIndex = 5;
            this.ReStart.Text = "ReStart";
            this.ReStart.UseVisualStyleBackColor = true;
            this.ReStart.Click += new System.EventHandler(this.ReStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel3);
            this.groupBox1.Location = new System.Drawing.Point(512, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 84);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PreFixed";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.House);
            this.flowLayoutPanel3.Controls.Add(this.Star);
            this.flowLayoutPanel3.Controls.Add(this.BadThing);
            this.flowLayoutPanel3.Controls.Add(this.TheX);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 19);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(162, 59);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // House
            // 
            this.House.Location = new System.Drawing.Point(3, 3);
            this.House.Name = "House";
            this.House.Size = new System.Drawing.Size(75, 23);
            this.House.TabIndex = 1;
            this.House.Text = "House";
            this.House.UseVisualStyleBackColor = true;
            this.House.Click += new System.EventHandler(this.House_Click);
            // 
            // Star
            // 
            this.Star.Location = new System.Drawing.Point(84, 3);
            this.Star.Name = "Star";
            this.Star.Size = new System.Drawing.Size(75, 23);
            this.Star.TabIndex = 2;
            this.Star.Text = "Star";
            this.Star.UseVisualStyleBackColor = true;
            this.Star.Click += new System.EventHandler(this.Star_Click);
            // 
            // BadThing
            // 
            this.BadThing.Location = new System.Drawing.Point(3, 32);
            this.BadThing.Name = "BadThing";
            this.BadThing.Size = new System.Drawing.Size(75, 23);
            this.BadThing.TabIndex = 3;
            this.BadThing.Text = "BadThing";
            this.BadThing.UseVisualStyleBackColor = true;
            this.BadThing.Click += new System.EventHandler(this.BadThing_Click);
            // 
            // TheX
            // 
            this.TheX.Location = new System.Drawing.Point(84, 32);
            this.TheX.Name = "TheX";
            this.TheX.Size = new System.Drawing.Size(75, 23);
            this.TheX.TabIndex = 4;
            this.TheX.Text = "The X";
            this.TheX.UseVisualStyleBackColor = true;
            this.TheX.Click += new System.EventHandler(this.TheX_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.flowLayoutPanel5);
            this.groupBox3.Location = new System.Drawing.Point(326, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(180, 84);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Shapes";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoScroll = true;
            this.flowLayoutPanel5.Controls.Add(this.Rectangle);
            this.flowLayoutPanel5.Controls.Add(this.Triangle);
            this.flowLayoutPanel5.Controls.Add(this.Ellipse);
            this.flowLayoutPanel5.Controls.Add(this.Line);
            this.flowLayoutPanel5.Controls.Add(this.circle);
            this.flowLayoutPanel5.Controls.Add(this.Lines);
            this.flowLayoutPanel5.Controls.Add(this.Polygon);
            this.flowLayoutPanel5.Controls.Add(this.Curve);
            this.flowLayoutPanel5.Controls.Add(this.ClosedCurved);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(0, 19);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(180, 59);
            this.flowLayoutPanel5.TabIndex = 2;
            this.flowLayoutPanel5.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel5_Paint);
            // 
            // Rectangle
            // 
            this.Rectangle.Location = new System.Drawing.Point(3, 3);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(75, 23);
            this.Rectangle.TabIndex = 2;
            this.Rectangle.Text = "Rectangle";
            this.Rectangle.UseVisualStyleBackColor = true;
            this.Rectangle.Click += new System.EventHandler(this.Rectangle_Click);
            // 
            // Triangle
            // 
            this.Triangle.Location = new System.Drawing.Point(84, 3);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(75, 23);
            this.Triangle.TabIndex = 6;
            this.Triangle.Text = "Triangle";
            this.Triangle.UseVisualStyleBackColor = true;
            this.Triangle.Click += new System.EventHandler(this.Triangle_Click);
            // 
            // Ellipse
            // 
            this.Ellipse.Location = new System.Drawing.Point(3, 32);
            this.Ellipse.Name = "Ellipse";
            this.Ellipse.Size = new System.Drawing.Size(75, 23);
            this.Ellipse.TabIndex = 3;
            this.Ellipse.Text = "Ellipse";
            this.Ellipse.UseVisualStyleBackColor = true;
            this.Ellipse.Click += new System.EventHandler(this.Ellipse_Click);
            // 
            // Line
            // 
            this.Line.Location = new System.Drawing.Point(84, 32);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(75, 23);
            this.Line.TabIndex = 1;
            this.Line.Text = "Line";
            this.Line.UseVisualStyleBackColor = true;
            this.Line.Click += new System.EventHandler(this.Line_Click);
            // 
            // circle
            // 
            this.circle.Location = new System.Drawing.Point(3, 61);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(75, 23);
            this.circle.TabIndex = 4;
            this.circle.Text = "Circle";
            this.circle.UseVisualStyleBackColor = true;
            this.circle.Click += new System.EventHandler(this.Circle_Click);
            // 
            // Lines
            // 
            this.Lines.Location = new System.Drawing.Point(84, 61);
            this.Lines.Name = "Lines";
            this.Lines.Size = new System.Drawing.Size(75, 23);
            this.Lines.TabIndex = 8;
            this.Lines.Text = "LAL";
            this.Lines.UseVisualStyleBackColor = true;
            this.Lines.Click += new System.EventHandler(this.Lines_Click);
            // 
            // Polygon
            // 
            this.Polygon.Location = new System.Drawing.Point(3, 90);
            this.Polygon.Name = "Polygon";
            this.Polygon.Size = new System.Drawing.Size(75, 23);
            this.Polygon.TabIndex = 9;
            this.Polygon.Text = "Polygon";
            this.Polygon.UseVisualStyleBackColor = true;
            this.Polygon.Click += new System.EventHandler(this.Polygon_Click);
            // 
            // Curve
            // 
            this.Curve.Location = new System.Drawing.Point(84, 90);
            this.Curve.Name = "Curve";
            this.Curve.Size = new System.Drawing.Size(75, 23);
            this.Curve.TabIndex = 10;
            this.Curve.Text = "Curve";
            this.Curve.UseVisualStyleBackColor = true;
            this.Curve.Click += new System.EventHandler(this.Curve_Click);
            // 
            // ClosedCurved
            // 
            this.ClosedCurved.Location = new System.Drawing.Point(3, 119);
            this.ClosedCurved.Name = "ClosedCurved";
            this.ClosedCurved.Size = new System.Drawing.Size(75, 23);
            this.ClosedCurved.TabIndex = 11;
            this.ClosedCurved.Text = "ClosedCurved";
            this.ClosedCurved.UseVisualStyleBackColor = true;
            this.ClosedCurved.Click += new System.EventHandler(this.ClosedCurved_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flowLayoutPanel6);
            this.groupBox2.Location = new System.Drawing.Point(152, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 84);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Colors";
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.color_border);
            this.flowLayoutPanel6.Controls.Add(this.textBox1);
            this.flowLayoutPanel6.Controls.Add(this.numericUpDown1);
            this.flowLayoutPanel6.Controls.Add(this.color_fill);
            this.flowLayoutPanel6.Controls.Add(this.fill);
            this.flowLayoutPanel6.Controls.Add(this.BackGround);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(10, 19);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(152, 59);
            this.flowLayoutPanel6.TabIndex = 2;
            // 
            // color_border
            // 
            this.color_border.Location = new System.Drawing.Point(3, 3);
            this.color_border.Name = "color_border";
            this.color_border.Size = new System.Drawing.Size(48, 23);
            this.color_border.TabIndex = 2;
            this.color_border.Text = "Border";
            this.color_border.UseVisualStyleBackColor = true;
            this.color_border.Click += new System.EventHandler(this.button13_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(57, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(27, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Size:";
            this.textBox1.WordWrap = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(90, 3);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(57, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // color_fill
            // 
            this.color_fill.Location = new System.Drawing.Point(3, 32);
            this.color_fill.Name = "color_fill";
            this.color_fill.Size = new System.Drawing.Size(27, 23);
            this.color_fill.TabIndex = 3;
            this.color_fill.Text = "Fill";
            this.color_fill.UseVisualStyleBackColor = true;
            this.color_fill.Click += new System.EventHandler(this.button14_Click);
            // 
            // fill
            // 
            this.fill.AutoSize = true;
            this.fill.Location = new System.Drawing.Point(36, 32);
            this.fill.Name = "fill";
            this.fill.Size = new System.Drawing.Size(15, 14);
            this.fill.TabIndex = 7;
            this.fill.UseVisualStyleBackColor = true;
            this.fill.CheckedChanged += new System.EventHandler(this.fill_CheckedChanged);
            // 
            // BackGround
            // 
            this.BackGround.Location = new System.Drawing.Point(57, 32);
            this.BackGround.Name = "BackGround";
            this.BackGround.Size = new System.Drawing.Size(90, 23);
            this.BackGround.TabIndex = 8;
            this.BackGround.Text = "BackGround";
            this.BackGround.UseVisualStyleBackColor = true;
            this.BackGround.Click += new System.EventHandler(this.BackGround_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.flowLayoutPanel1);
            this.groupBox5.Location = new System.Drawing.Point(23, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(123, 84);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tools";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.Free_sketch);
            this.flowLayoutPanel1.Controls.Add(this.ClearScreen);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(111, 59);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Free_sketch
            // 
            this.Free_sketch.Location = new System.Drawing.Point(3, 3);
            this.Free_sketch.Name = "Free_sketch";
            this.Free_sketch.Size = new System.Drawing.Size(87, 23);
            this.Free_sketch.TabIndex = 7;
            this.Free_sketch.Text = "Free sketch";
            this.Free_sketch.UseVisualStyleBackColor = true;
            this.Free_sketch.Click += new System.EventHandler(this.Free_sketch_Click);
            // 
            // ClearScreen
            // 
            this.ClearScreen.Location = new System.Drawing.Point(3, 32);
            this.ClearScreen.Name = "ClearScreen";
            this.ClearScreen.Size = new System.Drawing.Size(87, 23);
            this.ClearScreen.TabIndex = 9;
            this.ClearScreen.Text = "Clear Screen";
            this.ClearScreen.UseVisualStyleBackColor = true;
            this.ClearScreen.Click += new System.EventHandler(this.ClearScreen_Click);
            // 
            // colorDialog2
            // 
            this.colorDialog2.Color = System.Drawing.Color.White;
            // 
            // colorDialog3
            // 
            this.colorDialog3.Color = System.Drawing.Color.White;
            // 
            // PlayBackTimer
            // 
            this.PlayBackTimer.Interval = 500;
            this.PlayBackTimer.Tick += new System.EventHandler(this.PlayBackTimer_Tick);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(844, 561);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(860, 600);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button House;
        private System.Windows.Forms.Button Star;
        private System.Windows.Forms.Button BadThing;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button Undo;
        private System.Windows.Forms.Button Redo;
        private System.Windows.Forms.Button Playback;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Button Line;
        private System.Windows.Forms.Button Rectangle;
        private System.Windows.Forms.Button Ellipse;
        private System.Windows.Forms.Button circle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Button color_fill;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Triangle;
        private System.Windows.Forms.Button Free_sketch;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox fill;
        private System.Windows.Forms.Button color_border;
        private System.Windows.Forms.Button BackGround;
        private System.Windows.Forms.ColorDialog colorDialog3;
        private System.Windows.Forms.Button TheX;
        private System.Windows.Forms.Button Lines;
        private System.Windows.Forms.Timer PlayBackTimer;
        private System.Windows.Forms.CheckBox RecordCheckBox;
        private System.Windows.Forms.Button ClearScreen;
        private System.Windows.Forms.Button Polygon;
        private System.Windows.Forms.Button ToFile;
        private System.Windows.Forms.Button ReStart;
        private System.Windows.Forms.Button Curve;
        private System.Windows.Forms.Button ClosedCurved;
    }
}

