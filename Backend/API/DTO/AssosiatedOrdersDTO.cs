using System;
using System.Collections.Generic;

namespace API.DTO
{
    public class AssosiatedOrdersDTO
    {
        public bool IsMain{get;set;}
        public string OrderNumber { get; set; }
        public string Customer {get;set;}
        public double? Quantity {get;set;}
        public string DeliveryDate {get;set;}
        public int? OrderId{get;set;}
    }
}