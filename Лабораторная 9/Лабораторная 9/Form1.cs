using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_9
{
    public partial class Form1 : Form
    {
        double[] pfreq = new double[5] { 0, 0, 0, 0, 0 };
        double prob5;
        const double SquareNormal = 9.488;

        public Form1()
        {
            InitializeComponent();
            
            ed1.ValueChanged += new System.EventHandler(this.ed1_ValueChanged);
            ed2.ValueChanged += new System.EventHandler(this.ed2_ValueChanged);
            ed3.ValueChanged += new System.EventHandler(this.ed3_ValueChanged);
            ed4.ValueChanged += new System.EventHandler(this.ed4_ValueChanged);
        }

        private void btStart1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            int number = (int)edAmount.Value;
            int[] events = new int[5] { 0, 0, 0, 0, 0 };
            double[] freq = new double[5] { 0, 0, 0, 0, 0 };

            Random rnd = new Random();

            for (int i = 0; i < number; i++)
            {

                double s = rnd.NextDouble();


                if ((0 <= s) && (s < pfreq[0]))
                {
                    events[0] = events[0] + 1;
                }

                if ((pfreq[0] <= s) && (s < (pfreq[0] + pfreq[1])))
                {
                    events[1] = events[1] + 1;
                }

                if (((pfreq[0] + pfreq[1]) <= s) && (s < (pfreq[0] + pfreq[1] + pfreq[2])))
                {
                    events[2] = events[2] + 1;
                }

                if (((pfreq[0] + pfreq[1] + pfreq[2]) <= s) && (s < (pfreq[0] + pfreq[1] + pfreq[2] + pfreq[3])))
                {
                    events[3] = events[3] + 1;
                }

                if (((pfreq[0] + pfreq[1] + pfreq[2] + pfreq[3]) <= s) && (s < (pfreq[0] + pfreq[1] + pfreq[2] + pfreq[3] + pfreq[4])))
                {
                    events[4] = events[4] + 1;
                }

            }


            for (int i = 0; i < 5; i++)
            {
                freq[i] = (double)events[i] / number;
                chart1.Series[0].Points.AddXY(i, freq[i]);
            }

            double TMath = 0;
            double TDisp = 0;
            double SMath = 0;
            double SDisp = 0;
            double PMath = 0;
            double PDisp = 0;
            double Square = 0;

            //теоретические значения:

            //матем. ожидание
            for (int i = 0; i < 5; i++)
            {
                TMath = TMath + (double)(pfreq[i] * (i + 1));
            }

            lbTMath.Text = Math.Round(TMath, 3).ToString();

            // дисперсия
            double tmxq = 0;
            for (int i = 0; i < 5; i++)
            {
                tmxq = tmxq + (double)(pfreq[i] * (i + 1) * (i + 1));
            }
            TDisp = tmxq - TMath * TMath;

            lbTDisp.Text = Math.Round(TDisp, 3).ToString();


            //статические значения:

            //матем. ожидание
            for (int i = 0; i < 5; i++)
            {
                SMath = SMath + (double)(freq[i] * (i + 1));
            }

            lbSMath.Text = Math.Round(SMath, 3).ToString();

            //дисперсия
            double smxq = 0;
            for (int i = 0; i < 5; i++)
            {
                smxq = smxq + (double)(freq[i] * (i + 1) * (i + 1));
            }
            SDisp = smxq - SDisp * SDisp;

            lbSDisp.Text = Math.Round(SDisp, 3).ToString();

            // относительная погрешность матем. ожидания
            double abPMath = Math.Abs(SMath - TMath);
            PMath = abPMath / Math.Abs(TMath);

            lbPMath.Text = Math.Round(PMath, 3).ToString();

            // относительная погрешность дисперсии
            double abPDisp = Math.Abs(SDisp - TDisp);
            PDisp = abPDisp / Math.Abs(TDisp);

            lbPDisp.Text = Math.Round(PDisp, 3).ToString();

            //Хи-квадрат
            for (int i = 0; i < 5; i++)
            {
                double c;
                c = Math.Abs(freq[i] - pfreq[i]);
                if (c == 0)
                {
                    c = 1;
                }
                Square = Square + (double)(c * c) / pfreq[i];

            }

            lbSquare.Text = Math.Round(Square, 3).ToString();

            if (Square > SquareNormal)
            {
                lbSign.Text = ">";
                lbIndicator.Text = "true";
                lbIndicator.ForeColor = Color.BlueViolet;
            }
            else
            {
                lbSign.Text = "<";
                lbIndicator.Text = "false";
                lbIndicator.ForeColor = Color.DarkViolet;
            }
        }

        private void ed1_ValueChanged(Object sender, EventArgs e)
        {
            pfreq[0] = (double)ed1.Value;
            prob5 = 1 - (pfreq[0] + pfreq[1] + pfreq[2] + pfreq[3]);
            ed5.Text = Math.Round(prob5, 3).ToString();
            if (prob5 < 0)
            {
                ed5.ForeColor = Color.Red;
                btStart1.Enabled = false;
            }
            else
            {
                ed5.ForeColor = Color.Black;
                btStart1.Enabled = true;
            }
            pfreq[4] = prob5;
        }

        private void ed2_ValueChanged(Object sender, EventArgs e)
        {
            pfreq[1] = (double)ed2.Value;
            prob5 = 1 - (pfreq[0] + pfreq[1] + pfreq[2] + pfreq[3]);
            ed5.Text = Math.Round(prob5, 3).ToString();
            if (prob5 < 0)
            {
                ed5.ForeColor = Color.Red;
                btStart1.Enabled = false;
            }
            else
            {
                ed5.ForeColor = Color.Black;
                btStart1.Enabled = true;
            }
            pfreq[4] = prob5;
        }

        private void ed3_ValueChanged(Object sender, EventArgs e)
        {
            pfreq[2] = (double)ed3.Value;
            prob5 = 1 - (pfreq[0] + pfreq[1] + pfreq[2] + pfreq[3]);
            ed5.Text = Math.Round(prob5, 3).ToString();
            if (prob5 < 0)
            {
                ed5.ForeColor = Color.Red;
                btStart1.Enabled = false;
            }
            else
            {
                ed5.ForeColor = Color.Black;
                btStart1.Enabled = true;
            }
            pfreq[4] = prob5;
        }

        private void ed4_ValueChanged(Object sender, EventArgs e)
        {
            pfreq[3] = (double)ed4.Value;
            prob5 = 1 - (pfreq[0] + pfreq[1] + pfreq[2] + pfreq[3]);
            ed5.Text = Math.Round(prob5, 3).ToString();
            if (prob5 < 0)
            {
                ed5.ForeColor = Color.Red;
                btStart1.Enabled = false;
            }
            else
            {
                ed5.ForeColor = Color.Black;
                btStart1.Enabled = true;
            }
            pfreq[4] = prob5;
        }
    }

}
