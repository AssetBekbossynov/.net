using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace midterm.Models
{
    public class RouteStore : IStore<Route>
    {
        private List<Route> _cachedCollection;
        
        public string Path { get; set; }
        public List<Route> GetCollection()
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

        public Route ConvertItem(string item)
        {
            var itemList = item.Split(';');

            return new Route()
            {
                Id = Convert.ToInt32(itemList[0]),
                Path = itemList[1],
                Duration = Convert.ToInt32(itemList[2]),
                Cost = Convert.ToDouble(itemList[3])
            };
        }
    }
}