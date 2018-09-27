using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public abstract class Llamada
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

        //constructor
        public Llamada(float duracion, string destino, string origen)
        {
            this.duracion = duracion;
            this.nroDestino = destino;
            this.nroOrigen = origen;
        }
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

        /// <summary>
        /// propiedad costo abstracta, debe ser de solo lectura
        /// </summary>
        /// <returns></returns>
        public abstract float CostoLlamada
        {
            get;
        }
        
        //metodos
       /* /// <summary>
        /// constructor de instancia
        /// </summary>
        /// <param name="duracion"></param>
        /// <param name="nroDestino"></param>
        /// <param name="nroOrigen"></param>
        public Llamada(float duracion, string nroDestino,string nroOrigen)
        {
            this.duracion = duracion;
            this.nroOrigen = nroOrigen;
            this.nroDestino = nroDestino;
        }*///No se puede instanciar una clase abstract

        /// <summary>
        /// retorna string con datos atributos
        /// </summary>
        /// <returns></returns>
         protected virtual string Mostrar()
         {
            StringBuilder llamada = new StringBuilder(); 
            llamada.AppendFormat("Duracion: {0},Nro Destino:{1},Nro Origen: {2} ", Duracion,NroDestino,NroOrigen);
            return llamada.ToString() ;
         }

         /// <summary>
         /// ordena por duracion de llamada ascendente
         /// </summary>
         /// <param name="llamada1"></param>
         /// <param name="llamada2"></param>
         /// <returns></returns>
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

        public static bool operator==(Llamada Llamada1, Llamada Llamada2)
        {
            if(Llamada1.Equals(Llamada2))
            {
                if (Llamada1.NroDestino == Llamada2.NroDestino && Llamada2.NroOrigen == Llamada2.NroOrigen)
                {
                    return true;
                }
            }         
            return false;
        }
        public static bool operator !=(Llamada Llamada1, Llamada Llamada2)
        {
            return !(Llamada1 == Llamada2);
        }

    }
}
