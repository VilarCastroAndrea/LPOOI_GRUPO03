using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesBase
{
    class FormaDePago

    {
       private int fp_ID;
        private String fp_Descripcion;

        public FormaDePago(int fp_ID, string fp_Descripcion)
        {
            this.fp_ID = fp_ID;
            this.fp_Descripcion = fp_Descripcion;
        }

        public FormaDePago()
        {
        }

        public int Fp_ID { get => fp_ID; set => fp_ID = value; }
        public string Fp_Descripcion { get => fp_Descripcion; set => fp_Descripcion = value; }

    }
}
