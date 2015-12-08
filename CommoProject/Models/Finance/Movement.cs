using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CommoProject.Models.Finance
{
    public class Movement
    {
        public int MovementId { get; set; }

        public int AccountId { get; set; }

        [ForeignKey("AccountId")]
        public virtual Account Account { get; set; }

        public decimal Amount { get; set; }

        public DateTime Date { get; set; }

        public bool Type { get; set; }

        public string Description { get; set; }
    }
}
