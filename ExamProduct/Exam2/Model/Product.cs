﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace Exam2.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }

        [JsonPropertyName("img")]
        public string Image { get; set; }
        public double Price { get; set; }
        public override string ToString() => JsonSerializer.Serialize<Product>(this);
    }
}