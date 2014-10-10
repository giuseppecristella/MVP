using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mobilize.Alternative.Models
{
  public class BoardGame
  {

    public int Id { get; set; }

    public string Name { get; set; }

    [Display(Name="Manufacturer")]
    public string Manu { get; set; }

    public decimal Price { get; set; }

    [Display(Name="# in stock")]
    public int NumInStock { get; set; }

  }

}