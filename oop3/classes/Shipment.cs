using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Text;

namespace oop2.classes
{
    public class Shipment
    {
        #region fields
        private string trackingcode;
        private string description;
        private decimal weight;
        private decimal deliveryfee;
        #endregion

        #region constructor
        public Shipment(string trackingcode)
        {
            this.trackingcode = trackingcode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = default;
        }

        public Shipment(string trackingcode, string description, decimal weight, decimal deliveryfee, DeliveryAddress destination)
        {


            this.trackingcode = trackingcode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryfee;
            Destination = destination;
        }

        
        public override string ToString()
        {
            return $"Tracking Code: {trackingcode},\nDescription: {description}\nWeight: {weight} ,\nweight fee{deliveryfee} ,destnation {Destination},\n ";

        }
        #endregion

        #region properties
        public string TrackingCode
        {
            get { return trackingcode; }
            set { if(value == null) { throw new ArgumentException("Tracking code cannot be null."); }
                trackingcode = value; }
        }


        public string Description
        {
            get { return description; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) { throw new ArgumentException("Description cannot be null or empty."); }
                description = value;
            }
        }
        public decimal Weight
        {
            get { return weight; }
            set
            {
                if (value <= 0) { throw new ArgumentException("Weight must be a positive integer."); }

                weight = value;
            }
        }
        public decimal DeliveryFee
        {
            get { return deliveryfee; }
             set
            {
                if (value <= 0) { throw new ArgumentException("Delivery fee must be a positive integer."); }

                deliveryfee = value;
            }
          
        }
        public DeliveryAddress Destination
        {
            get; set;
        }
        public virtual decimal  EstimatedCost
        {
            get { return deliveryfee + (decimal)weight * 5; }
        }


        
        #endregion


        #region methods
        public decimal UpdateDeliveryFee(decimal newDeliveryFee)
        {
            if (newDeliveryFee > 0)
            {
                DeliveryFee = newDeliveryFee;
            }
            return DeliveryFee;
        }
        public virtual void PrintShipmentDetails()
        {
            Console.WriteLine($"Tracking Code: {trackingcode}, Description: {description}, Weight: {weight} kg, Delivery Fee: ${deliveryfee}, Destination: {Destination}, Estimated Cost: ${EstimatedCost}");
        }
        /*          new assignment oop3       */

        public void UpdateShipmentWeight(decimal newWeight)
        {
            if (newWeight <= 0) { throw new ArgumentException("Weight must be a positive integer."); }
            Weight = newWeight;
        }

        public void UpdateShipmentWeight(decimal newWeight, decimal extraPackingWeight)
        {
            if (newWeight <= 0|| extraPackingWeight<=0) { throw new ArgumentException("Weight and extra packing weight must be positive integers."); }
            Weight = newWeight + extraPackingWeight;
            
        }



        
        #endregion

        
    }
}
