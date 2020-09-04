using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TSSMARTIFYOnlineMart.Models
{
    public class Customer
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerID { get; set; }

        [Required(ErrorMessage = "Please Enter Name e.g. ABCD ABCDEFGH")]
        [DisplayName("Name")]
        [StringLength(30, MinimumLength = 10)]
        [RegularExpression("^[A-Z]{4,8} [A-Z]{4,8}$")]
        public string CustomerName { get; set; }
        
        [ForeignKey("LoginType")]
        [DisplayName("Select type")]
        public int LoginTypeID { get; set; }
        
        [DisplayName("Email")]
        [Required(ErrorMessage = "Enter Email Address")]
        [EmailAddress]
        public string Email { get; set; }
        [DisplayName("Password")]
        [Required(ErrorMessage = "Password should not be blank")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DisplayName("Phone Number")]
        //(372) 587-2335
        [RegularExpression(@"^\([0-9]{3}\) [1-9]{3}-[1-9]{4}$")]
        [Required(ErrorMessage = "Phone number should not be blank eg. (372) 587-2335")]
        public string Contact { get; set; }
        [DisplayName("Address")]
        [Required(ErrorMessage = "Address should not be blank")]
        public string Address { get; set; }
        [DisplayName("City")]
        [Required(ErrorMessage = "City should not be blank")]
        public string City { get; set; }
        [DisplayName("Pin Code")]
        [Required(ErrorMessage = "Pin Code should not be blank")]
        public string PinCode { get; set; }

        public virtual LoginType LoginType { get; set; }
        public virtual ICollection<Bill> Bills { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<Product> Products { get; set; }


        


    }
}