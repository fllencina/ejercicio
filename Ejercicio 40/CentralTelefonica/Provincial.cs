using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public class Provincial : Llamada
    {
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        protected Franja franjaHoraria;

        //propiedades
        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        //metodos
        private float CalcularCosto()
        {
            if (this.franjaHoraria == Franja.Franja_1)
            {
                return this.duracion * 0.99f;
            }
            if (this.franjaHoraria == Franja.Franja_2)
            {
                return this.duracion * 1.25f;
            }
            return this.duracion * 0.66f;
        }

        public override bool Equals(object obj)
        {
            if (obj is Provincial)
            {
                return true;
            }
            return false;
        }
        protected override string Mostrar()
        {
            string retorno = base.Mostrar();
            StringBuilder provincia = new StringBuilder();
            provincia.AppendFormat("Llamada: {0},\nCosto Llamada: {1},Franja Horaria: {2}", retorno, this.CostoLlamada, this.franjaHoraria);
            return provincia.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        public Provincial(Franja miFranja, Llamada llamada) : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        { }
        public Provincial(string origen, Franja miFranja, float duracion, string destino) : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

    }
}
