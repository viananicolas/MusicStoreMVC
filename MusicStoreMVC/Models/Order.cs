using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using MusicStoreMVC.Models.Validation;

namespace MusicStoreMVC.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        //[Remote("CheckUserName", "Account", ErrorMessage ="Username already in use")]
        [ScaffoldColumn(false)]
        public string Username { get; set; }
        [Required, StringLength(160, MinimumLength = 2), MaxWords(3), Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required, StringLength(160, MinimumLength = 2), MaxWords(15), Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        [DataType(DataType.PostalCode)]
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Invalid email address")]
        public string Email { get; set; }
        [DataType(DataType.Currency)]
        public decimal Total { get; set; }
        //public List<OrderDetail> OrderDetails { get; set; }
    }
}
