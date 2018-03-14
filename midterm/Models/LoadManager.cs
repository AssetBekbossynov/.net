using System;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace midterm.Models{
    public class LoadManager{
        
        static readonly string loadPath = "Data/Load.csv";
        static readonly string categoryPath = "Data/Category.csv";

        public static List<LoadAndCategory> showLoad(){
            var loadStore = new LoadStore() { Path = loadPath };
            var loadList = loadStore.GetCollection();
            var categoryStore = new CategoryStore() { Path = categoryPath };
            var categoryList = categoryStore.GetCollection();

            var loadAndCategory = loadList
                .Join(categoryList, load=>load.CategoryId, category=>category.Id, (load, category) =>new
                {
                    load,
                    category 
                }).ToList();

            var returnVale = loadAndCategory.Select(
                x=>new LoadAndCategory(){
                    Id = x.load.Id,
                    Phone = x.load.Phone,
                    Description = x.category.Description
                }
            ).ToList();

            return returnVale;
        }

        public static List<LoadAndCategory> sortLoadByCategory(string Category){
            var loadStore = new LoadStore() { Path = loadPath };
            var loadList = loadStore.GetCollection();
            var categoryStore = new CategoryStore() { Path = categoryPath };
            var categoryList = categoryStore.GetCollection();

            var loadAndCategory = loadList
                .Join(categoryList, load=>load.CategoryId, category=>category.Id, (load, category) =>new
                {
                    load,
                    category 
                }).ToList();

            var returnVale = loadAndCategory
                .Select(
                    x=>new LoadAndCategory(){
                        Id = x.load.Id,
                        Phone = x.load.Phone,
                        Description = x.category.Description
                    }
                ).Where(y=>y.Description.Equals(Category))
                .ToList();
                
            return returnVale;
        }

        public static void AddLoad(string Phone, string Category){
            var categoryStore = new CategoryStore() { Path = categoryPath };
            var categoryList = categoryStore.GetCollection();
            var loadStore = new LoadStore() { Path = loadPath };
            var loadList = loadStore.GetCollection();

            int categoryId = Convert.ToInt32(categoryList
                .Where(x=>x.Description.Equals(Category))
                .Select(y=>y.Id));
            
            Load load = new Load(loadList.Count + 1, Phone, categoryId);

            File.AppendAllText(loadPath, load.DataToString() + Environment.NewLine);
        }
    }
}