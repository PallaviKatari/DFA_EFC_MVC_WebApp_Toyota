using System;
using System.Collections.Generic;

namespace DFA_EFC_MVC_WebApp.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public decimal Price { get; set; }
}
