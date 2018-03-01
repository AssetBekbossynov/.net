using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace midterm.Models
{
    public class LoadStore : IStore<Load>
    {
        private List<Load> _cachedCollection;
        
        public string Path { get; set; }
        public List<Load> GetCollection()
        {
            if(_cachedCollection == null)
            {
                var data = File.ReadAllLines(Path);
                _cachedCollection = data
                    .Skip(1)
                    .Select(x => ConvertItem(x))
                    .ToList();
            }
            
            return _cachedCollection;
        }

        public Load ConvertItem(string item)
        {
            var itemList = item.Split(';');

            return new Load()
            {
                Id = Convert.ToInt32(itemList[0]),
                CategoryId = Convert.ToInt32(itemList[1])
            };
        }
    }
}