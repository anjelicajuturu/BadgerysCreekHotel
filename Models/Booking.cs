using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace BadgerysCreekHotel.Models
{
    public class Booking
    {
      public int ID {get; set;}
      
      public int RoomID {get; set;}
      
      public string CustomerEmail { get; set; }
      
      [DataType(DataType.Date)]
      public DateTime CheckIn {get; set;}
      
      [DataType(DataType.Date)]
      public DateTime CheckOut {get; set;}
      
      public decimal Cost {get; set;}
      
      //navigation property of Room model
      public Room TheRoom { get; set; }
      //navigation property of Customer model
      public Customer TheCustomer { get; set; }
      }
}
