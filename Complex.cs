using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    class Complex
    {
        private double re;
        private double im;

        public Complex(double real, double img)
        {
            this.re = real;
            this.im = img;
        }

        public Complex(double input)
        {
            this.re = input;
            this.im = 0;
        }

        public Complex(string input)
        {
            string[] split = input.Split('+');
            if (split.Length == 2)
            {
                this.re = double.Parse(split[0]);

                string[] img = split[1].Split('i');
                this.im = double.Parse(img[0]);
            }
            else
            {
                split = input.Split('-');
                if (split.Length == 2)
                {
                    this.re = double.Parse(split[0]);

                    string[] img = split[1].Split('i');
                    this.im = double.Parse(img[0]) * -1;
                }
                else
                {
                    this.re = double.Parse(split[1]) * -1;

                    string[] img = split[2].Split('i');
                    this.im = double.Parse(img[0]) * -1;
                }
            }

        }

        public double GetRe()
        {
            return this.re;
        }

        public double GetIm()
        {
            return this.im;
        }

        public double Abs()
        {
            return Math.Sqrt(this.re * this.re + this.im * this.im);
        }

        public static double StaticAbs(Complex c)
        {
            return Math.Sqrt(c.re * c.re + c.im * c.im);
        }

        public static Complex operator+(Complex a, Complex b)
        {
            return new Complex(a.re + b.re, a.im + b.im);
        }

        public override string ToString()
        {
            return $"{this.re} + {this.im}i";
        }
    }
}
