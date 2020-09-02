namespace Group2.Znalytics_GreatOutDoors.PresentationLayer
{
    internal class OrderProduct
    {
        internal string ProductId;

        public string ProductID { get; internal set; }
        public string UserName { get; internal set; }
        public double TotalPrice { get; internal set; }
        public int CustomerAddressId { get; internal set; }
    }
}