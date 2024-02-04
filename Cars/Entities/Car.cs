using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Entities;

public class Car
{
    public int Id { get; set; }
    public string Name { get; set; }
    //public string Model { get; set; }
    public string ModelYear { get; set; }
    public string FuelType { get; set; }
}
