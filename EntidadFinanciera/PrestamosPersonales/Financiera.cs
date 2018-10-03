using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class Financiera
    {
        private string razonSocial;
        public List<Prestamo> listaDePrestamos;

        private Financiera()
        {
            listaDePrestamos = new List<Prestamo>();
        }
        public Financiera(string razonSocial) : this()
        {
            this.razonSocial = razonSocial;
        }
        public string RazonSocial
        {
            get
            {
                return this.razonSocial;
            }
        }
        public List<Prestamo> ListaDePrestamos
        {
            get
            {
                return this.listaDePrestamos;
            }
        }
        public float IntersesEnDolares
        {
            get
            {
                return this.CalcularInteresesGanados(TipoDePrestamo.Dolares);

            }
        }
        public float IntersesEnPesos
        {
            get
            {
                return this.CalcularInteresesGanados(TipoDePrestamo.Pesos);
            }
        }
        public float InteresesTodos
        {
            get
            {
                return IntersesEnDolares + IntersesEnPesos;
            }
        }
        private float CalcularInteresesGanados(TipoDePrestamo tipoPrestamo)
        {
            float resultado = 0;
            foreach (Prestamo a in listaDePrestamos)
            {
                switch (tipoPrestamo)
                {
                    case TipoDePrestamo.Dolares:
                        if (a is PrestamoDolar)
                        {
                            resultado = +((PrestamoDolar)a).Interes;
                        }
                        break;
                    case TipoDePrestamo.Pesos:
                        if (a is PrestamoPesos)
                        {
                            resultado = +((PrestamoPesos)a).Interes;
                        }
                        break;
                    default:
                        if (a is PrestamoDolar)
                        {
                            resultado = +((PrestamoDolar)a).Interes;
                        }
                        if (a is PrestamoPesos)
                        {
                            resultado = +((PrestamoPesos)a).Interes;
                        }
                        break;
                }
            }

            return resultado;
        }
        public static explicit operator string(Financiera financiera)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Razon social: {0}\nIntereses totales: {1}\nintereses Prestamos en Pesos: {2}\nIntereses Presatmos en Dolares: {3}", financiera.RazonSocial, financiera.InteresesTodos, financiera.IntersesEnPesos, financiera.IntersesEnDolares);
            foreach (Prestamo a in financiera.listaDePrestamos)
            {
                sb.AppendFormat("\n{0}", a.Mostrar());
            }
            return sb.ToString();
        }
        public string Mostrar(Financiera financiera)
        {
            return (string)financiera;
        }
        public void OrdenarPrestamos()
        {
            listaDePrestamos.Sort(Prestamo.ordenarPorFecha);
        }
        //sobrecargas
        public static bool operator ==(Financiera f1, Prestamo p1)
        {
            foreach (Prestamo a in f1.listaDePrestamos)
            {
                if (a.Monto == p1.Monto && a.Vencimiento == p1.Vencimiento)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Financiera f1, Prestamo p1)
        {
            return !(f1 == p1);
        }
        public static Financiera operator +(Financiera f1, Prestamo p1)
        {
            if (f1 != p1)
            {
                f1.listaDePrestamos.Add(p1);
            }
            return f1;
        }
    }
}
