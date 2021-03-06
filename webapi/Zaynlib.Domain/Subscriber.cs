﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Zaynlib.Domain
{
    [Table("Subscriber")]
    public class Subscriber
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(150)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(150)]
        public string Email { get; set; }
        public Subscription Subscription { get; set; }
    }
}
