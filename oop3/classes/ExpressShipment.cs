using System;
using System.Collections.Generic;
using System.Text;

namespace oop2.classes
{
    internal class ExpressShipment : Shipment
    {
        #region properties


        decimal extraFee ;
        public decimal ExtraFee
        {
            get { return extraFee; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Express fee cannot be negative.");
                }
                extraFee = value;
            }
        }

       override public decimal EstimatedCost 
        {
            get { return base.DeliveryFee + Weight*5+ ExtraFee; }
        }

        #endregion

        #region constructors
        public ExpressShipment(string trackingcode, string description, decimal weight, decimal deliveryfee  , decimal expressFee, DeliveryAddress destination):base(trackingcode, description, weight, deliveryfee, destination)
        {
            ExtraFee=expressFee;
        }
        #endregion

        #region methods
        public override void PrintShipmentDetails()
        {
            Console.WriteLine($"Tracking Code: {TrackingCode}, Description: {Description}, Weight: {Weight} kg, Delivery Fee: ${DeliveryFee} ,Estimated Cost: ${EstimatedCost}, Extra Fee: ${ExtraFee}");
        }
        #endregion

    }
}
