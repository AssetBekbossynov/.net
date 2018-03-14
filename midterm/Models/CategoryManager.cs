using System;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace midterm.Models{
    public class CategoryManager{
        
        static readonly string categoryPath = "Data/Category.csv";

        public static List<Category> showCategory(){
            var categoryStore = new CategoryStore() { Path = categoryPath };
            var categoryList = categoryStore.GetCollection();

            return categoryList;
        }

    }
}