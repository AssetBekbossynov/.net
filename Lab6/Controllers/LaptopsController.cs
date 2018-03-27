using System;
using System.Collections.Generic;
using System.Linq;
using Lab6.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab6.Controllers
{
    [Route("api/[controller]")]
    public class LaptopsController: Controller 
    {
        private static List<Laptop> _laptops;

        public LaptopsController()
        {
            if(_laptops == null)
            {
                Generate();
            }
        }

        [HttpGet]
        public IEnumerable<Laptop> Get()
        {
            return _laptops;
        }

        [HttpGet("{id}")]
        public Laptop Get(int id)
        {
            return _laptops.FirstOrDefault(x => x.Id == id);
        }

        [HttpPost]
        public void Post([FromBody] Laptop laptop)
        {
            laptop.Id = _laptops.Max(x => x.Id) + 1;
            _laptops.Add(laptop);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item = _laptops.First(x => x.Id == id);
            _laptops.Remove(item);
        }

        [HttpPut]
        public void Put([FromBody] Laptop laptop)
        {
            var _laptop = _laptops.First(x => x.Id == laptop.Id);
            _laptop.Company = laptop.Company;
            _laptop.Model = laptop.Model;
            _laptop.Price = laptop.Price;
        }

        private void Generate()
        {
            _laptops = new List<Laptop>();
            _laptops.Add(new Laptop(){ Id = 1, Model = "aaa", Company = "Lenovo", Price = 100000 });
            _laptops.Add(new Laptop(){ Id = 2, Model = "bbb", Company = "HP", Price = 190000 });
            _laptops.Add(new Laptop(){ Id = 3, Model = "ccc", Company = "Asus", Price = 220000 });
        }
    }
}