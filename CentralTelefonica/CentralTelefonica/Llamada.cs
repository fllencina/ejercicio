using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public class Llamada
    {
        //Enumerados
        public enum TipoLlamada
        {
             Local,
             Provincial,
            Todas
        }

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        //propiedades
        /// <summary>
        /// solo lectura, retorna la duracion de la llamada
        /// </summary>
        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }

        /// <summary>
        /// solo lectura, retorna numero de destino de llamada
        /// </summary>
        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }

        /// <summary>
        /// solo lectura, retorna el numero de destino de llamada
        /// </summary>
        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }
        //metodos
        public Llamada(float duracion, string nroDestino,string nroOrigen)
        {
            this.duracion = duracion;
            this.nroOrigen = nroOrigen;
            this.nroDestino = nroDestino;
        }
         public string Mostrar()
         {
            StringBuilder llamada = new StringBuilder(); 
            llamada.AppendFormat("Duracion: {0},Nro Destino:{1},Nro Origen: {2} ", Duracion,NroDestino,NroOrigen);
            return llamada.ToString() ;
         }
         
        public static  int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            if (llamada1.duracion > llamada2.duracion)
            {
                return 1;
            }
            if (llamada1.duracion < llamada2.duracion)
            {
                return -1;
            }

            return 0;
        }

    }
}
