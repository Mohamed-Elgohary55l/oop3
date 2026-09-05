using System;

namespace oop2.classes
{
    public class StandardShipment : Shipment
    {
        public StandardShipment(string trackingcode, string description, decimal weight, decimal deliveryfee, DeliveryAddress destination)
            :base(trackingcode, description, weight, deliveryfee, destination)
        {
        }
    }
}