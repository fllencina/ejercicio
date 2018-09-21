using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public class Local:Llamada
    {
        protected float costo;
        //propiedades
        public float CostoLlamada
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
        public Local(Llamada llamada, float costo) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
        }
        public Local(string origen, float duracion,string destino,float costo):this(new Llamada(duracion,destino,origen),costo)
        { }
        public new string Mostrar()
        {
            string retorno = this.Mostrar();
            StringBuilder local = new StringBuilder();
            local.AppendFormat("{0},{1}", retorno, this.CostoLlamada);
            return local.ToString();
        }
    }
    
}
