﻿using Mycouse.Models.ValueTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCouse.Models.ViewModels
{
    public class CourseViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public string Author { get; set; }
        public double Rating { get; set; }
        
        //viene usata la classe Money perchè l'importo può essere in 3 valute
        public Money FullPrice { get; set; }
        public Money CurrentPrice { get; set; }

    }
}