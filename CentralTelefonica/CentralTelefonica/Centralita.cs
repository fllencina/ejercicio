using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public class Centralita
    {
        private List<Llamada> ListaDeLlamadas=new List<Llamada>();
        public string razonSocial;

        //metodos
        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float ganancia = 0;

            for (int i = 0; i < ListaDeLlamadas.Capacity; i++)
            {
                Llamada unaLlamada = ListaDeLlamadas.ElementAt<Llamada>(i);
                if (tipo == Llamada.TipoLlamada.Local)
                {
                    if (unaLlamada is Local)
                    {
                        ganancia = ganancia + ((Local)unaLlamada).CostoLlamada;
                    }
                }
                if (tipo == Llamada.TipoLlamada.Provincial)
                {
                    if (unaLlamada is Provincial)
                    {
                        ganancia = ganancia + ((Provincial)unaLlamada).CostoLlamada;
                    }
                }
                if (tipo == Llamada.TipoLlamada.Todas)
                {
                    if (unaLlamada is Local)
                    {
                        ganancia = ganancia + ((Local)unaLlamada).CostoLlamada;
                    }
                    if (unaLlamada is Provincial)
                    {
                        ganancia = ganancia + ((Provincial)unaLlamada).CostoLlamada;
                    }
                } 
            }
            return ganancia; 
        }
       
        public string Mostrar()
        {
            StringBuilder llamada = new StringBuilder();
            llamada.AppendFormat("{0},{1},{2},{3} ", this.razonSocial, this.CalcularGanancia(Llamada.TipoLlamada.Todas), this.CalcularGanancia(Llamada.TipoLlamada.Local),this.CalcularGanancia(Llamada.TipoLlamada.Provincial));

            for (int i = 0; i < this.ListaDeLlamadas.Capacity; i++)
            {
                ListaDeLlamadas.ElementAt<Llamada>(i).Mostrar();
            }
            return llamada.ToString();
        }
        //constructores

        public Centralita()
        {
            
        }
        public Centralita(string NombreEmpresa)
        {
            this.razonSocial = NombreEmpresa;
        }
        // propiedades
        public float GananciaPorLocal
        {
            get
            {
               return  this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }
        public float GananciaPorProvincial
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }
        public float GananciaTotal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }
        public List<Llamada> llamadas
        {
            get
            {
                return this.ListaDeLlamadas;
            }
        }
        public void OrdenarLlamadas()
        {
            this.ListaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
    }
}
