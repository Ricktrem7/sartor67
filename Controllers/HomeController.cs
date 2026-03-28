using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Sartor67.Models;

namespace Sartor67.Controllers;

public class HomeController : Controller
{
    private static readonly List<Product> Products = new()
    {
        new Product
        {
            Id = 1,
            Category = "SUITS",
            Name = "Vanquish II Suit",
            Price = "€ 6.500",
            Image = "product1.jpg",
            Description = "The Vanquish II is the epitome of Italian tailoring mastery. Crafted from the finest Super 180s wool, this suit combines a razor-sharp silhouette with unparalleled comfort. Each piece is hand-finished by our master tailors in Rome, requiring over 220 hours of meticulous craftsmanship.",
            Sizes = new List<string> { "44", "46", "48", "50", "52", "54", "56" },
            Details = new List<string>
            {
                "Super 180s Wool",
                "Hand-stitched lapels",
                "Full canvas construction",
                "Mother of pearl buttons",
                "Made in Italy"
            }
        },
        new Product
        {
            Id = 2,
            Category = "OUTERWEAR",
            Name = "Cashmere Overcoat",
            Price = "€ 8.200",
            Image = "product2.jpg",
            Description = "Woven from the rarest Mongolian cashmere, this overcoat represents the pinnacle of outerwear luxury. Its structured shoulders and fluid drape create a commanding silhouette, while the hand-sewn lining in pure silk ensures exceptional comfort throughout the seasons.",
            Sizes = new List<string> { "44", "46", "48", "50", "52", "54", "56" },
            Details = new List<string>
            {
                "100% Mongolian Cashmere",
                "Pure silk lining",
                "Horn buttons",
                "Hand-finished edges",
                "Made in Italy"
            }
        },
        new Product
        {
            Id = 3,
            Category = "SHIRTS",
            Name = "Formal Dress Shirt",
            Price = "€ 950",
            Image = "product3.jpg",
            Description = "Impeccably crafted from two-ply Egyptian cotton, this formal dress shirt offers an extraordinary softness that only improves with wear. The hand-rolled collar and double-cuff details speak to the Sartor 67 commitment to perfection in every stitch.",
            Sizes = new List<string> { "38", "39", "40", "41", "42", "43", "44", "45" },
            Details = new List<string>
            {
                "Two-ply Egyptian Cotton",
                "Hand-rolled collar",
                "Double cuff",
                "Mother of pearl buttons",
                "Made in Italy"
            }
        },
        new Product
        {
            Id = 4,
            Category = "ACCESSORIES",
            Name = "Silk Tie Collection",
            Price = "€ 420",
            Image = "product4.jpg",
            Description = "Hand-printed on the finest seven-fold silk from Como, Italy, this tie is a testament to the art of accessory making. The rich, lustrous fabric and precisely executed patterns make it the perfect finishing touch for the discerning gentleman.",
            Sizes = new List<string> { "One Size" },
            Details = new List<string>
            {
                "Seven-fold silk construction",
                "Hand-printed in Como",
                "Hand-rolled edges",
                "Wool interlining",
                "Made in Italy"
            }
        }
    };

    public IActionResult Index()
    {
        return View(Products);
    }

    public IActionResult Product(int id)
    {
        var product = Products.FirstOrDefault(p => p.Id == id);
        if (product == null) return NotFound();
        return View(product);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}