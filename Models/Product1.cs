using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;//Validation attributes

namespace DFA_EFC_MVC_WebApp.Models;

public partial class Product1
{
    public int ProductId { get; set; }

    //[] are called as Data Annotations or Attributes
    [Required(ErrorMessage = "Product name is required")]
    [StringLength(100)]
    public string Name { get; set; }

    [Required]
    [Range(1, 100000, ErrorMessage = "Price must be greater than 0")]
    public decimal Price { get; set; }

    [Required]
    [Range(0, 10000)]
    public int Quantity { get; set; }

    public DateTime CreatedDate { get; set; }
}
