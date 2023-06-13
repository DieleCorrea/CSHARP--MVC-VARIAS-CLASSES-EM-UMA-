using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using VariasClasses.Models;

namespace VariasClasses.Controllers
{
    public class Todos : Controller
    {
        public IActionResult Index()
        {
            var model = new TodasClasses();

            model.Pets = ObterPets();
            model.Carros = ObterCarros();
            model.Cidades = ObterCidades();



            return View(model);
        }

        IEnumerable<Pet> ObterPets()
        {
            yield return new Pet
            {
                Nome = "Billy",
                Idade = 2,
                Raca = "Vira lata",
                Patologia = "nenhuma"

            };
        }

        IEnumerable<Carro> ObterCarros()
        {
            yield return new Carro
            {
                Modelo = "Fusca",
                Ano = 1998,
                Fabricante = "Fiat"

            };
        }

        IEnumerable<CidadeTuristicaEAtrativos> ObterCidades()
        {
            yield return new CidadeTuristicaEAtrativos
            {
                NomeCidade = "São Leopoldo",
                Uf = "Rs",
                Pais = "Brasil",
                Atrativo = "nenhum"

            };
        }










    }
}
