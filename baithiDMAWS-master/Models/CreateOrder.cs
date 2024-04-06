using System.ComponentModel.DataAnnotations;

namespace baithiDMAWS.Models
{
    public class CreateOrder
    {
        [Required(ErrorMessage = "Please enter Code")]
        public string ItemCode { get; set; }

        [Required(ErrorMessage = "Please enter Name")]
        public string ItemName { get; set; }

        [Required(ErrorMessage = "Please enter Quantity")]
        public int ItemQty { get; set; }

        [Required(ErrorMessage = "Please enter Delivery Time")]
        public DateTime OrderDelivery { get; set; }

        [Required(ErrorMessage = "Please enter Address")]
        public string OrderAddress { get; set; }

        [Required(ErrorMessage = "Please enter Phone Number")]
        public string PhoneNumber { get; set; }
    }
}
