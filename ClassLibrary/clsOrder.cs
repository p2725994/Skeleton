using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public int OrderTotal { get; set; }
        public DateTime DateTimePlaced { get; set; }
        public bool Purchased { get; set; }
        public string DeliveryAddress { get; set; }
        public int NoOfItems { get; set; }
        public bool IsGift { get; set; }
    }
}