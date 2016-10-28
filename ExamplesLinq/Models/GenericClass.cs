using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamplesLinq.Models
{
    public class GenericClass<T, V>
    {
        public T Texto
        {
            get; set; }
        public V Valor
        {
            get;
            set;
        }
    }

    
}
