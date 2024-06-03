using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
namespace BookStore.API.Models;
{
public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
}
}