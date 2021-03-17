using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Taller1U3
{
    class Linea{
        private int x1, x2, y1, y2;
            }
class CEcuacion
    {
       
        //datos miembro 
        private int msix, msiy, midx, midy;
        //graficos
        private Graphics mGraphics;
        private int SF = 10;
        private int mWhidth, mHeight;
        private Pen mPen, mPen1,mPen2;
        private int xc, yc;

        public int Msix { get => msix; set => msix = value; }
        public int Msiy { get => msiy; set => msiy = value; }
        public int Midx { get => midx; set => midx = value; }
        public int Midy { get => midy; set => midy = value; }
        public CEcuacion() { }
        public CEcuacion(int x0, int x1, int y0, int y1)
        {
            msix = x0 * SF;
            midx = x1 * SF;
            msiy = y0 * SF;
            midy = y1 * SF;
        }
        public bool readData(NumericUpDown numXP1, NumericUpDown numYP1, NumericUpDown numXPF, NumericUpDown numYPF, PictureBox picCanvas)
        {
            try
            {
                mHeight = picCanvas.Height;
                mWhidth = picCanvas.Width;
                msix = (int)numXP1.Value * SF;
                midx = (int)numXPF.Value * SF;
                msiy = (int)numYP1.Value * SF;
                midy = (int)numYPF.Value * SF;
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        public void GraphAxis(PictureBox picCanvas)
        {
            mGraphics = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Red, 2);
            xc = mWhidth / 2;
            yc = mHeight / 2;
            //vertical
            //mGraphics.ScaleTransform(3F, 3F);
            mGraphics.DrawLine(mPen, xc, 0, xc, mHeight);
            mGraphics.DrawLine(mPen, 0, yc, mWhidth, yc);
        }
        public void GraphLines(PictureBox picCanvas)
        {
            float[] dashValues = { 1, 1, 1, 1 };
            mGraphics = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Black, 1);
            mPen2 = new Pen(Color.Blue, 2);
            mPen.DashPattern = dashValues;
            xc = mWhidth / 2;
            yc = mHeight / 2;
            int x1 = msix + xc, x2 = midx + xc, y1 = yc - msiy, y2 = yc - midy;
            //vertical
            //mGraphics.ScaleTransform(3F,3F);
            // mGraphics.DrawLine(mPen, xc, 0, xc, mHeight);
            //Linea V superior
            mGraphics.DrawLine(mPen, x1, 0, x1, mHeight);
            //Linea H superior
            mGraphics.DrawLine(mPen, 0, y1, mWhidth, y1);
            //Linea V inferior
            mGraphics.DrawLine(mPen, x2, 0, x2, mHeight);
            //Linea H inferior
            mGraphics.DrawLine(mPen, 0, y2, mWhidth, y2);
            //puntos
            mGraphics.DrawRectangle(mPen2, x1,y1, 1, 1);
            mGraphics.DrawRectangle(mPen2, x2, y2, 1, 1);
            //No entrecortadas //Area
            mPen1 = new Pen(Color.Green, 1);
            //Horizontal Izquierda
            mGraphics.DrawLine(mPen1, x1, y1, x1, y2);
            //Horizontal Derecha
            mGraphics.DrawLine(mPen1, x2, y1, x2, y2);
            //vertical arriba 
            mGraphics.DrawLine(mPen1, x1, y1, x2, y1);
            //vertical abajo
            mGraphics.DrawLine(mPen1, x1, y2, x2, y2);
        }
        public void pounts(PictureBox picCanvas,  MouseEventArgs e)
        {
            mGraphics = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Black, 1);
            xc = mWhidth / 2;
            yc = mHeight / 2;
            int x1 = msix + xc, x2 = midx + xc, y1 = yc - msiy, y2 = yc - midy;
            List<Linea> lineas = new List<Linea>();
            mGraphics.DrawRectangle(mPen, e.X, e.Y, 1, 1);

            //mGraphics.DrawLines();
        }
    }

}

