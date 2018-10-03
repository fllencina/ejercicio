using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class Financiera
    {
        private string razonSocial;
        public List<Prestamo> listaDePrestamos;

        private Financiera()
        {
            listaDePrestamos = new List<Prestamo>();
        }
        public Financiera(string razonSocial) : this()
        {
            this.razonSocial = razonSocial;
        }
        public string RazonSocial
        {
            get
            {
                return this.razonSocial;
            }
        }
       public List<Prestamo> ListaDePrestamos
        {
            get
            {
                return this.listaDePrestamos;
            }
        }
        public float IntersesEnDolares
        {
            get
            {
                foreach(PrestamoDolar a in ListaDePrestamos)
                {
                    return a.interes;
                }
                return -1;
            }
        }
        public float IntersesEnPesos
        {
            get
            {
                foreach (PrestamoPesos a in ListaDePrestamos)
                {
                    return a.interes;
                }
                return -1;
            }
        }
        public float IntersesTodos
        {
            get
            {
                return IntersesEnDolares + IntersesEnPesos;
            }
        }


    }
}
