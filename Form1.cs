using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller1U3
{
    public partial class Form1 : Form
    {
        private CEcuacion objC = new CEcuacion();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            if (objC.readData(nudSX, nudSY, nudIX, nudIY, picCanvas))
            {
                picCanvas.Refresh();
                objC.GraphAxis(picCanvas);
                objC.GraphLines(picCanvas);
            }
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            objC.pounts(picCanvas,e);

        }
    }
}
