using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas22
{
   public class Areas
    {
        public decimal area;

        public decimal Area
        {
            get { return area; }
            set { area = value; }
        }

        public Areas()
        {
            area = 0;
        }
        public decimal Cuadrado(decimal lado)
        {
            area = lado * lado;
            return area;
        }
        public decimal Rectangulo(decimal b, decimal h)
        {
            area = b * h;
            return area;
        }
        public decimal Triangulo(decimal b, decimal h)
        {
            area = (b * h) / 2;
            return area;
        }
        public decimal Rombo(decimal D, decimal d)
        {
            area = D * d;
            return area;
        }
        public decimal Romboide(decimal B, decimal h)
        {
            area = B * h;
            return area;
        }
        public decimal Trapecio(decimal h, decimal B, decimal b)
        {
            area = h * (B * b) / 2;
            return area;
        }
        public decimal Poligono(decimal p, decimal a)
        {
            area = (p * a) / 2;
            return area;
        }
        public decimal Circulo(decimal radio)
        {
            area = (decimal)Math.PI * radio * radio;
            return area;
        }
    }
}
