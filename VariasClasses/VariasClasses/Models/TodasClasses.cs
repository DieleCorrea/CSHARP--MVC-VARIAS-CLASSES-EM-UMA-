using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VariasClasses.Models
{
    public class TodasClasses
    {
        public IEnumerable<Pet> Pets { get; set; }
        public IEnumerable<Carro> Carros { get; set; }
        public IEnumerable<CidadeTuristicaEAtrativos> Cidades { get; set; }
    }
}
