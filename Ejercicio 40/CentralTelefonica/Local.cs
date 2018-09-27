using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public class Local : Llamada
    {
        protected float costo;
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
            return costo * Duracion;
        }
        public override bool Equals(object obj)
        {
            if (obj is Local)
            {
                return true;
            }
            return false;
        }

        public Local(Llamada llamada, float costo) : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        { }
        public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)
        {
            this.costo = costo;
        }
        protected override string Mostrar()
        {
            string retorno = base.Mostrar();
            StringBuilder local = new StringBuilder();
            local.AppendFormat("Llamada: {0},\nCosto Llamada:{1}", retorno, this.CostoLlamada);
            return local.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
    }

}
