﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SpyStore.Models.Entities.Base;


using System;
using System.Collections.Generic;
using System.Text;

namespace SpyStore.Models.Entities
{
    [Table("Categories", Schema = "Store")]
    public class Category : EntityBase
    {
        [DataType(DataType.Text), MaxLength(50)]
        public string CategoryName { get; set; }
    }
}
