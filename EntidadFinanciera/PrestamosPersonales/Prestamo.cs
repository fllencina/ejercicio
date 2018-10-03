using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public abstract class Prestamo
    {
        protected float monto;
        protected DateTime vencimiento = new DateTime();
        private DateTime fechaActual = DateTime.Now;
        //propiedades
        public float Monto
        {
            get
            {
                return this.monto;
            }
        }
        public DateTime Vencimiento
        {

            get
            {
                return this.vencimiento;
            }
            set
            {
                if (value < fechaActual)
                {
                    this.vencimiento = fechaActual;
                }
                else
                {
                    this.vencimiento = value;
                }
            }
        }
        //constructor
        public Prestamo(float monto, DateTime vencimiento)
        {
            this.monto = monto;
            Vencimiento = vencimiento;
        }
        //metodos
        public abstract void ExtenderPlazo(DateTime nuevoVencimiento);

        public static int ordenarPorFecha(Prestamo p1,Prestamo p2)
        {
            if(p1.vencimiento>p2.vencimiento)
            {
                return 1;
            }
            if (p1.vencimiento < p2.vencimiento)
            {
                return -1;
            }
            return 0;
        }
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Monto: {0} Fecha de Vencimiento: {1}\n", Monto, Vencimiento);
            return sb.ToString();
        }

    }
}
