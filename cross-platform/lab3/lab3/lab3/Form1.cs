using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double f(double x, ref int k1) 
        {
            switch (k1)
            {
                case 0: return x * x - 4;
                case 1: return Math.Pow(Math.E, -x) - Math.Log10(1 - Math.Pow(x, 2)) - 2.0;
            }
            return 0;
        }
        double fp(double x, double d, ref int k1)   // Перша похідна
        {
            return (f(x + d, ref k1) - f(x, ref k1)) / d;
        }
        double f2p(double x, double d, ref int k1)  // Друга похідна
        {
            return (f(x + d, ref k1) + f(x - d, ref k1) - 2 * f(x, ref k1)) / (d * d);
        }
        double MDP(double a, double b, double Eps, ref int k1, ref int L)
        {
            double c = 0, Fc;
            while (b - a > Eps)
            {
                c = (a+b)/2.0;
                L++;    
                Fc = f(c, ref k1);
                if (Math.Abs(Fc) < Eps) 
                    return c;   
                if (f(a, ref k1) * Fc > 0)
                    a = c;
                else
                    b = c;
            }
            return c;   
        }

        double MN(double a, double b, double Eps, ref int k1, int Kmax, ref int cnt)
        {
            double x = b, Dx = 0.0, D = Eps/100.0;
            if (f(x, ref k1) * f2p(x, D, ref k1) < 0)
                x = a;

            if (f(x, ref k1) * f2p(x, D, ref k1) < 0)
                MessageBox.Show("Для цього рівняння збіжність ітерацій не гарантована");

            for (int i = 1; i <= Kmax; i++)
            {
                Dx = f(x, ref k1) / fp(x, D, ref k1);
                x = x - Dx;
                if (Math.Abs(Dx) <= Eps)
                {
                    cnt = i;
                    return x;   
                }
            }
            MessageBox.Show("За задану кількість ітерацій кореня не знайдено");
            return -1000.0;
        }
        
        private void mMethodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (mMethodComboBox.SelectedIndex)
            {
                case 0:
                    {
                        mKMax.Visible = false;   // Робимо невидимим вікно для введення Kmax 
                        mKmaxTextBox.Visible = false;
                    }
                    break;
                case 1:
                    {
                        mKMax.Visible = true;    // Робимо видимим вікно для введення Kmax 
                        mKmaxTextBox.Visible = true;
                    }
                    break;
            }
        }

        private void mSolveButton_Click(object sender, EventArgs e)
        {
            int L, k = -1, Kmax, m = -1; double D, Eps = 0, a, b;
            L = 0;
            switch (mMethodComboBox.SelectedIndex)    // Вибір чисельного методу :
            {
                case 0: m = 0;
                    mKMax.Visible = false;  // Робимо видимим вікно для введення Kmax
                    mKmaxTextBox.Visible = false;
                    mKmaxTextBox.Enabled = true;
                    break;   // метод ділення навпіл
                case 1: // метод Ньютона
                    {
                        m = 1;
                        D = Eps / 100.0;
                        mKMax.Visible = true;  // Робимо видимим вікно для введення Kmax
                        mKmaxTextBox.Visible = true;
                        mKmaxTextBox.Enabled = true;
                    }
                    break;
            }
            if (m == -1)
            {
                MessageBox.Show("Оберіть метод !"); mMethodComboBox.Focus();
                return;
            }
            mATextBox.Enabled = true;

            mBTextBox.Enabled = true;
            switch (mEquationComboBox.SelectedIndex)    // Вибір нелінійного рівняння
            {
                case 0: k = 0; break;
                case 1: k = 1; break;
            }
            if (k == -1)
            {
                MessageBox.Show("Оберіть рівняння !");
                mEquationComboBox.Focus();
                return;
            }
            // Перевіряємо правильність введення вхідних даних
            if (mATextBox.Text == "")
            {
                MessageBox.Show("Введіть a");
                mATextBox.Focus();
                return;
            }
            a = Convert.ToDouble(mATextBox.Text);
            mBTextBox.Enabled = true;
            if (mBTextBox.Text == "")
            {
                MessageBox.Show("Введіть b");
                mBTextBox.Focus();
                return;
            }
            b = Convert.ToDouble(mBTextBox.Text);
            if (a > b)
            {
                D = a;
                a = b;
                b = D; 
                mATextBox.Text = Convert.ToString(a);
                mBTextBox.Text = Convert.ToString(b);
            }
            if (mEpsTextBox.Text == "")
            {
                MessageBox.Show("Введіть eps");
                mEpsTextBox.Focus();
                return;
            }
            Eps = Convert.ToDouble(mEpsTextBox.Text);
            if ((Eps > 1e-1) || (Eps <= 0))
            { 
                Eps = 0.0001;
                mEpsTextBox.Text = Convert.ToString(Eps);
            }
            if (m == 0)
                if ((f(a, ref k)) * (f(b, ref k)) > 0.0)  
                {
                    MessageBox.Show("На інтервалі корінь відсутній");
                    mATextBox.Text = "";
                    mBTextBox.Text = "";
                    mATextBox.Focus();
                    return;
                }
            if (Math.Abs(f(a, ref k)) < Eps)
            {
                mXTextBox.Text = Convert.ToString(a);
                mCounterTextBox.Text = Convert.ToString(L);
                return;
            }
            if (Math.Abs(f(b, ref k)) < Eps)
            {
                mXTextBox.Text = Convert.ToString(b);
                mCounterTextBox.Text = Convert.ToString(L);
                return;
            }
            switch (m)
            {
                case 0: 
                    {
                        mXTextBox.Text = Convert.ToString(MDP(a, b, Eps, ref k, ref L));
                        mCounterTextBox.Text = Convert.ToString(L);
                        mFXTextBox.Text = Convert.ToString(f(MDP(a, b, Eps, ref k, ref L),ref k));
                        mCounterLabel.Text = "К-ть поділів =";
                    }
                    break;

                case 1: 
                    {
                        if (mKmaxTextBox.Text == "")
                        {
                            MessageBox.Show("Введіть kmax");
                            mKmaxTextBox.Focus();
                            return;
                        }
                        Kmax = Convert.ToInt32(mKmaxTextBox.Text);
                        mXTextBox.Text = Convert.ToString(MN(a, b, Eps, ref k, Kmax, ref L));
                        mCounterTextBox.Text = Convert.ToString(L);
                        mFXTextBox.Text = Convert.ToString(f(MN(a, b, Eps, ref k, Kmax, ref L), ref k));
                        mCounterLabel.Text = "К-ть ітерац.=";
                    }
                    break;
            }

        }

        private void mClearButton_Click(object sender, EventArgs e)
        {
            mATextBox.Clear();
            mBTextBox.Clear();
            mEpsTextBox.Clear();
            mKmaxTextBox.Clear();
            mXTextBox.Clear();
            mCounterTextBox.Clear();
            mFXTextBox.Clear();
            switch (mMethodComboBox.SelectedIndex)
            {
                case 0:
                    {
                        mKMax.Visible = false; // Робимо невидимим вікно для введення Kmax
                        mKmaxTextBox.Visible = false;
                    }
                    break;
                case 1:
                    {
                        mKMax.Visible = true;  // Робимо видимим вікно для введення Kmax 
                        mKmaxTextBox.Visible = true;
                    }
                    break;
            }
        }
    }
}