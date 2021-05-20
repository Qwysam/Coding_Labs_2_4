using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace AnalogClock
{
    public partial class Form1 : Form
    {
        //Store color for clock elements
        public static Color LinearBrush1;
        public static Color Hour_Dash_Pen;
        public static Color MinutePen;
        public static Color SecondPen;
        public Form1()
        {
            InitializeComponent();
            //default colors
            LinearBrush1 = Color.Green;
            Hour_Dash_Pen = Color.White;
            MinutePen = Color.LightGray;
            SecondPen = Color.Red;
            //settings for style and event handler
            this.Paint += new PaintEventHandler(drawclock);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            buttonSettings.BringToFront();
        }
        //event to draw the clock
        private void drawclock(object sender, PaintEventArgs e)
        {
            //main graphic object
            Graphics g = e.Graphics;
            //rectangle to hold the circle
            Rectangle rec = new Rectangle(20, 20, 250, 250);
            //brush for circle
            SolidBrush linearbrush = new SolidBrush(LinearBrush1);
            //main circle
            g.FillEllipse(linearbrush, 20, 20, 174, 174);
            SolidBrush solidbrush = new SolidBrush(Color.White);
            //custom font
            Font textFont = new Font("Arial Bold", 12F);
            // Create Pens
            Pen hourPen = new Pen(Hour_Dash_Pen, 2);
            Pen minutePen = new Pen(MinutePen, 2);
            Pen secondPen = new Pen(SecondPen, 1);
            Pen dashPen = new Pen(Hour_Dash_Pen, 2);
            
            double angle = 0;
            //draw dashes
            for(int i = 0; i < 13; i++)
            {
                // circle center 
                int x = 107, y = 107;
                //line length
                int length = 86;
                if (i != 0 && i != 3 && i != 6 && i != 9 && i != 12)
                {
                    // Create points that define line.
                    Point point1 = new Point(x, y);
                    Point point2 = new Point((int)(x + Math.Cos(angle) * length), (int)(y + Math.Sin(angle) * length));
                    g.DrawLine(dashPen, point1, point2);
                }
                angle += 0.523599;
            }
            //main numbers
            g.DrawString("12", textFont, solidbrush, 96, 27);

            g.DrawString("9", textFont, solidbrush, 30, 97);

            g.DrawString("6", textFont, solidbrush, 100, 167);

            g.DrawString("3", textFont, solidbrush, 169, 97);
            //hide extra lines behind an ellipse
            g.FillEllipse(linearbrush, 40, 45, 130, 125);
            //change coordinate system center
            g.TranslateTransform(107, 107, MatrixOrder.Append);
            //update time
            int hour = DateTime.Now.Hour;
            int min = DateTime.Now.Minute;
            int sec = DateTime.Now.Second;

            // Create angles
            double secondAngle = 2.0 * Math.PI * sec / 60.0;
            double minuteAngle = 2.0 * Math.PI * (min + sec / 60.0) / 60.0;
            double hourAngle = 2.0 * Math.PI * (hour + min / 60.0) / 12.0;
            // Set centre point
            Point centre = new Point(0, 0);
            // Draw Hour Hand
            Point hourHand = new Point((int)(40 * Math.Sin(hourAngle)),
                                        (int)(-40 * Math.Cos(hourAngle)));
            g.DrawLine(hourPen, centre, hourHand);
            // Draw Minute Hand
            Point minHand = new Point((int)(70 * Math.Sin(minuteAngle)),
                                       (int)(-70 * Math.Cos(minuteAngle)));
            g.DrawLine(minutePen, centre, minHand);
            // Draw Second Hand
            Point secHand = new Point((int)(70 * Math.Sin(secondAngle)),
                                       (int)(-70 * Math.Cos(secondAngle)));
            g.DrawLine(secondPen, centre, secHand);
            Invalidate();
            //show button for form 2
            buttonSettings.BringToFront();
            buttonSettings.Show();

        }
        //go to form2
        private void buttonSettings_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
        //go to form 3
        private void buttonAuthor_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Text = "Автор";
            f.ShowDialog();
        }
    }
}
