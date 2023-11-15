﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using HogWildSystem.Entities.dboSchema;


namespace HogWildSystem.Entities.dboSchema;

[Table("InvoiceLine")]
internal partial class InvoiceLine
{
    [Key]
    public int InvoiceLineID { get; set; }

    public int InvoiceID { get; set; }

    public int PartID { get; set; }

    public int Quantity { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal Price { get; set; }

    public bool RemoveFromViewFlag { get; set; }

    [ForeignKey("InvoiceID")]
    [InverseProperty("InvoiceLines")]
    public virtual Invoice Invoice { get; set; }

    [ForeignKey("PartID")]
    [InverseProperty("InvoiceLines")]
    public virtual Part Part { get; set; }
}