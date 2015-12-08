using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CommoProject.Models.Finance
{
    public class Account
    {
        [Key]
        public int AccountId { get; set; }

        public string Description { get; set; }

        public DateTime Created { get; set; }

        public decimal Total { get; set; }

        public int AccountTypeId { get; set; }

        [ForeignKey("AccountTypeId")]
        public virtual AccountType AccountType { get; set; }

        public string RefNum { get; set; }

        public int OwnerId { get; set; }

        [ForeignKey("OwnerId")]
        public virtual Owner Owner { get; set; }

        public int StatusId { get; set; }

        [ForeignKey("StatusId")]
        public virtual Status Status { get; set; }
    }
}
