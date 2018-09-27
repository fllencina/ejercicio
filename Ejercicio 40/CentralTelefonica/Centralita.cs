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

            foreach ( Llamada unaLlamada in ListaDeLlamadas)
            {
                //ganancia = 0;
                switch(tipo)
                {
                    case Llamada.TipoLlamada.Local:
                        if (unaLlamada is Local)
                        {
                            ganancia = ganancia + ((Local)unaLlamada).CostoLlamada;
                        }
                        break;
                    case Llamada.TipoLlamada.Provincial:
                        if (unaLlamada is Provincial)
                        {
                            ganancia = ganancia + ((Provincial)unaLlamada).CostoLlamada;
                        }
                        break;
                    case Llamada.TipoLlamada.Todas:
                        if (unaLlamada is Local)
                        {
                            ganancia = ganancia + ((Local)unaLlamada).CostoLlamada;
                        }
                        if (unaLlamada is Provincial)
                        {
                            ganancia = ganancia + ((Provincial)unaLlamada).CostoLlamada;
                        }
                        break;                       
                }
            }
            return ganancia; 
        }
       
        public string Mostrar()
        {
            StringBuilder llamada = new StringBuilder();
            llamada.AppendFormat("Razon social:{0},\nGanancia Total: {1},Ganancia Local: {2}, Ganancia provincial: {3} ", this.razonSocial, this.CalcularGanancia(Llamada.TipoLlamada.Todas), this.CalcularGanancia(Llamada.TipoLlamada.Local),this.CalcularGanancia(Llamada.TipoLlamada.Provincial));
            llamada.AppendLine("\n");

            foreach(Llamada unaLlamada in ListaDeLlamadas)
            {
                llamada.AppendLine(unaLlamada.ToString()+"\n");

            }
            return llamada.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
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
            Console.WriteLine("--------------------------------------");
        }

        // sobrecargas

        public static bool operator==(Centralita c, Llamada llamada)
        {
            if(c.ListaDeLlamadas.Count>0)
            {
                foreach (Llamada m in c.ListaDeLlamadas)
                {
                    if (m == llamada)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }
        private void AgregarLlamada(Llamada llamada)
        {
            ListaDeLlamadas.Add(llamada);
        }
        public static Centralita operator +(Centralita c, Llamada llamada)
        {
            if(c!=llamada)
            {
                c.AgregarLlamada(llamada);
                return c;
            }
            else
            {
                return c;
            }

        }
    }
}
