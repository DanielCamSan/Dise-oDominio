using System;
using System.Collections.Generic;
using System.Text;

namespace Diseño_Guiado_por_el_Dominio_y_SOLID
{
    public interface IDue
    {
        public decimal TotalToPay();
        void AddWeightTax();
        void AddLuggageTax();
        string ServeFood();

    }
}
