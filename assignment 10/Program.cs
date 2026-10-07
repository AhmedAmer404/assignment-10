public partial class Shipment
{
    public string TrackingCode { get; set; }
    public string ShipmentType { get; set; }
    public double Weight { get; set; }
    public DeliveryAddress DeliveryAddress { get; set; }

    public Shipment(string trackingCode, string shipmentType,
                    double weight, DeliveryAddress deliveryAddress)
    {
        TrackingCode = trackingCode;
        ShipmentType = shipmentType;
        Weight = weight;
        DeliveryAddress = deliveryAddress;
    }

    public Shipment CopyShipment()
    {
        return new Shipment(
            TrackingCode,
            ShipmentType,
            Weight,
            DeliveryAddress
        );
    }
}
