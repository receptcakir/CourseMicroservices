﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroCourse.Services.Basket.Dtos
{
    public class BasketItemDto
    {
        public int Quantity { get; set; }

        public string CourseId { get; set; }
        public string CourseName { get; set; }

        public decimal Price { get; set; }
    }
}