﻿using System.ComponentModel.DataAnnotations;

namespace DominosStockOrder.Server.Models
{
    public class InventoryItem
    {
        [Key]
        public required string Code { get; set; }
        public string? PortalItemId { get; set; }

        public float PackSize { get; set; }
        public float Multiplier { get; set; }
        public bool ManualCount { get; set; }
    }
}