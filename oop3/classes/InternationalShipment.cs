using System;
using System.Collections.Generic;
using System.Text;

namespace oop2.classes
{
    internal class InternationalShipment: Shipment
    {

        #region properites
        private string destinationcountry;
        public string DestinationCountry
        {
            get { return destinationcountry; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Destination country cannot be null or empty.");
                }
                else
                {
                    destinationcountry = value;
                }
            }
        }
        private decimal CustomsFee;
        #endregion

        #region constructors
        public InternationalShipment(string trackingcode, string description, decimal weight, decimal deliveryfee, decimal customsFee, DeliveryAddress destination) : base(trackingcode, description, weight, deliveryfee, destination)
        {
            CustomsFee = customsFee;

        }
        #endregion
        #region methods

        override public decimal EstimatedCost
        {
            get { return base.DeliveryFee + Weight * 5 + CustomsFee; }
        }
        public override void PrintShipmentDetails()
        {
      Console.WriteLine($"Tracking Code: {TrackingCode}, Description: {Description}, Weight: {Weight} kg, Delivery Fee: ${DeliveryFee}, Destination: {DestinationCountry}, Estimated Cost: ${EstimatedCost}, destination country: {DestinationCountry},customs fee: ${CustomsFee}");
        }
       

        #endregion
    }
}
