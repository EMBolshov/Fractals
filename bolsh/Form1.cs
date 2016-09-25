using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bolsh
{

    public partial class Form1 : Form
    {
        private float m_X, m_Y;
        private Bitmap m_Bm;
        private int it;
        private Bitmap m_Bm1;
        int n;
        static Pen pen1, pen2;
        private Bitmap m_Bm2;
        public Form1()
        {
            InitializeComponent();
        }
        void btn_Draw_Click(object sender, EventArgs e)
        {
            try
            {
                int depth = Convert.ToInt32(textbox_it.Text);

                float total_length, start_x, start_y, start_length;  // параметры для рис

                if (pictureBox1.ClientSize.Height < pictureBox1.ClientSize.Width) //размер рисунка
                {
                    total_length = (float)(0.9 * pictureBox1.ClientSize.Height);
                }
                else
                {
                    total_length = (float)(0.9 * pictureBox1.ClientSize.Width);
                }

                start_x = (pictureBox1.ClientSize.Width - total_length) / 2;
                start_y = (pictureBox1.ClientSize.Height - total_length) / 2;

                start_length = (float)(total_length / (Math.Pow(2, depth) - 1));

                m_Bm = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
                pictureBox1.Image = m_Bm;

                using (Graphics gr = Graphics.FromImage(m_Bm))
                {
                    gr.Clear(pictureBox1.BackColor); //рисуем кривую
                    m_X = (int)start_x;
                    m_Y = (int)start_y;
                    Hilbert(gr, depth, start_length, 0);
                    gr.Dispose();
                }

                pictureBox1.Refresh(); //выводим рез-тат
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)

            { MessageBox.Show(ex.Message.ToString()); }

        }
        private void Hilbert(Graphics gr, int depth, float dx, float dy)   // Draw a Hilbert curve.
        {
            if (depth > 1) Hilbert(gr, depth - 1, dy, dx);
            DrawRelative(gr, dx, dy);
            if (depth > 1) Hilbert(gr, depth - 1, dx, dy);
            DrawRelative(gr, dy, dx);
            if (depth > 1) Hilbert(gr, depth - 1, dx, dy);
            DrawRelative(gr, -dx, -dy);
            if (depth > 1) Hilbert(gr, depth - 1, -dy, -dx);
        }

        // Draw the line (m_X, m_Y)-(m_X + dx, m_Y + dy) and
        // update m_X = m_X + dx, m_Y = m_Y + dy.
        private void DrawRelative(Graphics gr, float dx, float dy)
        {
            gr.DrawLine(Pens.Black, m_X, m_Y, m_X + dx, m_Y + dy);
            m_X = m_X + dx;
            m_Y = m_Y + dy;
        }

        /////////////////////////////////// SERPINSKIY ///////////////////////
        private void serp1_Click(object sender, EventArgs e)
        {
            try
            {
                it = Convert.ToInt32(textBox1s.Text);



                m_Bm1 = new Bitmap(pictureBox1s.ClientSize.Width, pictureBox1s.ClientSize.Height);
                pictureBox1s.Image = m_Bm1;

                using (Graphics gr = Graphics.FromImage(m_Bm1))
                {
                    gr.Clear(Color.Black);
                    //   serp(80, 80, 400, 400, it, gr);
                    serp(0, 0, pictureBox1s.ClientSize.Width, pictureBox1s.ClientSize.Height, it, gr);
                    gr.Dispose();
                }
            }
            catch (OutOfMemoryException ex)

            { MessageBox.Show(ex.Message.ToString()); }

                      catch (Exception ex)

            { MessageBox.Show(ex.Message.ToString()); }
        }
               void serp(float x1, float y1, float x2, float y2, int n, Graphics g)
        {
            float x1n, y1n, x2n, y2n;
            if (n > 0)
            {
                x1n = 2 * x1 / 3 + x2 / 3;
                x2n = x1 / 3 + 2 * x2 / 3;
                y1n = 2 * y1 / 3 + y2 / 3;
                y2n = y1 / 3 + 2 * y2 / 3;
                g.FillRectangle(new SolidBrush(Color.Red), x1n, y1n, x2n - x1n, y2n - y1n);
                serp(x1, y1, x1n, y1n, n - 1, g);
                serp(x1n, y1, x2n, y1n, n - 1, g);
                serp(x2n, y1, x2, y1n, n - 1, g);
                serp(x1, y1n, x1n, y2n, n - 1, g);
                serp(x2n, y1n, x2, y2n, n - 1, g);
                serp(x1, y2n, x1n, y2, n - 1, g);
                serp(x1n, y2n, x2n, y2, n - 1, g);
                serp(x2n, y2n, x2, y2, n - 1, g);
            }
        }

          
        ////////////////////////////////////////////////////// КАНТОР
          
               private void drawButtonk_Click(object sender, EventArgs e)
               {
                   try
                   {
                       int size = resultPBk.ClientSize.Width / 2;
                       int n = Convert.ToInt32(textBox1k.Text);
                       var stack = new Stack<Rectangle>();
                       Rectangle item = GetRectangle(resultPBk.Width / 2, resultPBk.Height / 2, size);
                       stack.Push(item);

                       var list = new List<Rectangle> { item };
                       size /= 4;
                       for (int i = 1; i < n && size > 1; i++, size /= 4)
                       {
                           var temp = new List<Rectangle>();
                           foreach (Rectangle rectangle in list)
                           {
                               temp.Add(GetRectangle(rectangle.Left, rectangle.Top, size));
                               temp.Add(GetRectangle(rectangle.Right, rectangle.Top, size));
                               temp.Add(GetRectangle(rectangle.Left, rectangle.Bottom, size));
                               temp.Add(GetRectangle(rectangle.Right, rectangle.Bottom, size));
                           }
                           foreach (Rectangle rectangle in temp)
                           {
                               stack.Push(rectangle);
                           }
                           list = temp;
                       }

                       var bmp = new Bitmap(resultPBk.Width, resultPBk.Height);

                       var pen = new SolidBrush(resultPBk.BackColor);
                       using (var g = Graphics.FromImage(bmp))
                       {
                           foreach (Rectangle rectangle in stack)
                           {
                               g.FillRectangle(pen, rectangle);
                               g.DrawRectangle(Pens.BlueViolet, rectangle);
                           }
                           g.Dispose();
                       }
                       if (resultPBk.Image != null)
                           resultPBk.Image.Dispose();
                       resultPBk.Image = bmp;
                   }
                   catch (Exception ex)
                   { MessageBox.Show(ex.Message); }
               }
               private Rectangle GetRectangle(int centerX, int centerY, int right)
               {
                   var rectangle = new Rectangle(centerX - right / 2, centerY - right / 2, right, right);
                   return rectangle;
               }
        ////////////////////////////////// КОХ
               static int Fractal(PointF p1, PointF p2, PointF p3, int n, Graphics gr)
               {

                   if (n > 0)
                   {

                       var p4 = new PointF((p2.X + 2 * p1.X) / 3, (p2.Y + 2 * p1.Y) / 3);
                       var p5 = new PointF((2 * p2.X + p1.X) / 3, (p1.Y + 2 * p2.Y) / 3);
                       var ps = new PointF((p2.X + p1.X) / 2, (p2.Y + p1.Y) / 2);
                       var pn = new PointF((4 * ps.X - p3.X) / 3, (4 * ps.Y - p3.Y) / 3);

                       gr.DrawLine(pen1, p4, pn);
                       gr.DrawLine(pen1, p5, pn);
                       gr.DrawLine(pen2, p4, p5);

                       Fractal(p4, pn, p5, n - 1, gr);
                       Fractal(pn, p5, p4, n - 1, gr);
                       Fractal(p1, p4, new PointF((2 * p1.X + p3.X) / 3, (2 * p1.Y + p3.Y) / 3), n - 1, gr);
                       Fractal(p5, p2, new PointF((2 * p2.X + p3.X) / 3, (2 * p2.Y + p3.Y) / 3), n - 1, gr);

                   }
                   return n;
               }
               private void button1h_Click(object sender, EventArgs e)
               {
                   try
                   {
                       n = Convert.ToInt32(textBox1h.Text);
                       pen1 = new Pen(Color.Black, 1.5F);
                       pen2 = new Pen(SystemColors.Control, 1.6F);
                       //  pen2 = new Pen(Color.Black, 1.4F);

                       m_Bm2 = new Bitmap(pictureBox1h.ClientSize.Width, pictureBox1h.ClientSize.Height);
                       pictureBox1h.Image = m_Bm2;

                       // gr = CreateGraphics();
                       var p1 = new PointF(50, 70);
                       var p2 = new PointF(350, 70);
                       var p3 = new PointF(200, 270);
                       /*   var p1 = new PointF(100, 100);
                          var p2 = new PointF(400, 100);
                          var p3 = new PointF(250, 300);*/
                       using (Graphics gr = Graphics.FromImage(m_Bm2))
                       {
                           gr.Clear(pictureBox1h.BackColor);
                           gr.DrawLine(pen1, p1, p2);
                           gr.DrawLine(pen1, p2, p3);
                           gr.DrawLine(pen1, p3, p1);
                           Fractal(p1, p2, p3, n, gr);
                           Fractal(p2, p3, p1, n, gr);
                           Fractal(p3, p1, p2, n, gr);

                           gr.Dispose();
                       }
                   }
                   catch (Exception ex)

                   { MessageBox.Show(ex.Message.ToString()); }

               }
        }
    }

