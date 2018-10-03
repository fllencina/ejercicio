using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
   
    public class PrestamoDolar:Prestamo
    {
        PeriodicidadDePagos periodicidad;

        //constructores
        public PrestamoDolar(float monto, DateTime vencimiento, PeriodicidadDePagos periodicidad) :base(monto,vencimiento)
        {
            this.periodicidad = periodicidad;
        }
        public PrestamoDolar(Prestamo prestamo,PeriodicidadDePagos periodicidad):this(prestamo.Monto,prestamo.Vencimiento,periodicidad)
        {
        }

        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            if(this.vencimiento<nuevoVencimiento)
            {
                Vencimiento = nuevoVencimiento;
                TimeSpan difTime = new TimeSpan();
                int dias = difTime.Days;
                this.monto = (Monto * 2.5f )/100;
            }
        }
        public  float interes
        {
            get
            {
                return this.CalcularInteres();
            }
        }
        public PeriodicidadDePagos PeriodicidadDePagos
        {
            get
            {
                return this.periodicidad;
            }
        }
        private float CalcularInteres()
        {
            float interes;
            switch(this.periodicidad)
            {
                case PeriodicidadDePagos.Mensual:
                    interes= (this.Monto * 25 / 100);
                    break;
                case PeriodicidadDePagos.Bimestral:
                    interes=(this.Monto * 35 / 100);
                    break;
                case PeriodicidadDePagos.Trimestral:
                    interes= (this.Monto*40/100);
                    break;
                default:
                    interes = -1;
                    break;
            }
            return interes;
        }
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} \nPeriodicidad: {1} - Intereses: {2}", Mostrar(), this.periodicidad, CalcularInteres());
            return sb.ToString();
        }
    }
}
