using System;
using System.Drawing;
using System.Windows.Forms;

namespace task_4_geom
{
    public partial class Form1 : Form
    {

        struct Vector
        {
            public double x, y, z, f;
        }

        struct Side
        {
            public Vector[] vectors;
            public Point[] points;
        }

        double xMin, yMin, xMax, yMax;

        int iMin, jMin, iMax, jMax;

        int shiftUp, shiftDown;

        double r;

        double alf, beta, gam;

        Graphics g;

        Pen pen;

        Side[] sides;
        public Form1()
        {
            InitializeComponent();

            alf = 49;
            beta = 72;
            gam = 17;

            xMin = -1;
            yMin = -1;

            xMax = 1;
            yMax = 1;

            iMin = 0;
            jMin = 0;

            iMax = 300;
            jMax = 200;

            shiftUp = 600;
            shiftDown = 600;

            r = 0.8;

            g = CreateGraphics();

            pen = new Pen(Color.Black);


        }

        void Draw(double r)
        {
            
            Model(r);

            Vector T = new Vector();
            int L = sides.Length;
            for (int i = 0; i < L; i++)
            {
                sides[i].points = new Point[4];
                for (int j = 0; j < 4; j++)
                {
                    T = sides[i].vectors[j];
                    sides[i].vectors[j] = Rotate(alf, beta, gam, T);
                    sides[i].points[j].X = (int)((iMax - iMin) * (sides[i].vectors[j].x - xMin)/(xMax - xMin)) + shiftUp;
                    sides[i].points[j].Y = (int)((jMax - jMin) * (sides[i].vectors[j].y - yMax)/(yMax - yMin)) + shiftDown;
                }
            }
            
            
            for (int i = 0; i < L; i++)
            {
                g.DrawPolygon(pen, sides[i].points);
            }
        }

        private Vector Rotate(double alf, double beta, double gam, Vector V)
        {
            double x, y, z, t;
            Vector res = new Vector();
            x = V.x * Math.Cos(gam) - V.y * Math.Sin(gam);
            y = V.x * Math.Sin(gam) + V.y * Math.Cos(gam);
            z = V.z;
            t = V.f;

            V.x = x;
            V.y = y;
            V.z = z;
            V.f = t;

            x = V.x * Math.Cos(beta) + V.z * Math.Sin(beta);
            y = V.y;
            z = V.x * Math.Sin(beta) * (-1) + V.z * Math.Cos(beta);
            t = V.f;

            V.x = x;
            V.y = y;
            V.z = z;
            V.f = t;

            x = V.x;
            y = V.y * Math.Cos(alf) - V.y * Math.Sin(alf);
            z = V.y * Math.Sin(alf) + V.z * Math.Cos(alf);
            t = V.f;

            res.x = x;
            res.y = y;
            res.z = z;
            res.f = t;

            return res;
        }

        void Model(double r)
        {
            int n = 20;
            int m = 72;
            double a1 = 0, a2 = Math.PI;
            double b1 = 0, b2 = 2 * Math.PI;

            int q, L;

            double t1, t2, h1, h2;

            h1 = (a2 - a1) / n;
            h2 = (b2 - b1) / m;

            L = n * m;

            sides = new Side[L];

            q = -1;

            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < m; i++)
                {
                    q++;
                    sides[q].vectors = new Vector[4];

                    t1 = a1 + h1 * (j + 0);
                    t2 = b1 + h2 * (i + 0);
                    sides[q].vectors[0] = ToXYZ(t1, t2, r);
                    t1 = a1 + h1 * (j + 0);
                    t2 = b1 + h2 * (i + 1);
                    sides[q].vectors[1] = ToXYZ(t1, t2, r);
                    t1 = a1 + h1 * (j + 1);
                    t2 = b1 + h2 * (i + 1);
                    sides[q].vectors[2] = ToXYZ(t1, t2, r);
                    t1 = a1 + h1 * (j + 1);
                    t2 = b1 + h2 * (i + 0);
                    sides[q].vectors[3] = ToXYZ(t1, t2, r);

                }
            }

        }

        private Vector ToXYZ(double t1, double t2, double r)
        {
            Vector res = new Vector();
            res.x = r * Math.Sin(t1) * Math.Sin(t2);
            res.y = r * Math.Cos(t1);
            res.z = r * Math.Sin(t1) * Math.Cos(t2); 
            return res;

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.Clear(Color.White);
            Draw(r);
        }

        private void trackBarSize_Scroll(object sender, EventArgs e)
        {
            r = trackBarSize.Value * (0.1);
            g.Clear(Color.White);
            Draw(r);

        }

        private void trackBarTurn_Scroll(object sender, EventArgs e)
        {
            alf = trackBarTurn.Value + alf;
            beta = trackBarTurn.Value + beta;
            gam = trackBarTurn.Value + gam;
            g.Clear(Color.White);
            Draw(r);
        }



    }
}
