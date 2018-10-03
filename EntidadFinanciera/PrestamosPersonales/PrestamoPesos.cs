using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class PrestamoPesos:Prestamo
    {
        private float porcentajeInteres;
        public float interes
        {
            get
            {
                return this.CalcularInteres();
            }
        }
        private float CalcularInteres()
        {
            return Monto * porcentajeInteres / 100;
        }
        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            if (this.vencimiento < nuevoVencimiento)
            {
                Vencimiento = nuevoVencimiento;
                TimeSpan difTime = new TimeSpan();
                int dias = difTime.Days;
                this.monto = (Monto * 0.25f) / 100;
            }
        }
        public PrestamoPesos(float monto, DateTime vencimiento, float porcentajeInteres) : base(monto, vencimiento)
        {
            this.porcentajeInteres = porcentajeInteres;
        }
        public PrestamoPesos(Prestamo prestamo, float porcentajeInteres) : this(prestamo.Monto, prestamo.Vencimiento, porcentajeInteres)
        {
        }
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} \nPorcentaje de Interes: {1} - Intereses: {2}", Mostrar(), this.porcentajeInteres, CalcularInteres());
            return sb.ToString();
        }
    }
}
