using System.ComponentModel;


namespace WeddingPage.Models
{
    public class OwnerFilterViewModel
    {
        [DisplayName("User name")]
        public string OwnerName{ get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("Phone")]
        public string Phone { get; set; }
    }
}