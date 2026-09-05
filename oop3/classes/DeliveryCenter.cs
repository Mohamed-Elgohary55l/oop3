using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace oop2.classes
{
    public class DeliveryCenter
    {
        #region fields
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or empty.");
                }
                name = value;
            }
        }
        private Shipment[] shipments = new Shipment[20];
        public Shipment[] Shipments
        {
            get { return shipments; }
            set
            {
                if (value == null || value.Length != 20)
                {
                    throw new ArgumentException("Shipments array must have exactly 20 elements.");
                }
                shipments = value;
            }
        }
        /* new */
        public Driver Driver { get; set; }
        #endregion


        #region constructors
        public DeliveryCenter()
        {

        }
        #endregion
        #region indexers
        public Shipment this[int postion]
        {

            get
            {

                if (postion < 0 || postion >= shipments.Length)
                    return default;

                return shipments[postion];
            }
            set
            {
                if (postion < 0 || postion >= shipments.Length)
                    return;

                shipments[postion] = value;
            }

        }

        public Shipment this[string trackingcode]
        {

            get
            {
                if (string.IsNullOrWhiteSpace(trackingcode))
                    return default;

                foreach (var shipment in shipments)
                {
                    if (shipment != null && shipment.TrackingCode == trackingcode)
                        return shipment;
                }

                return default;





            }


        }



        #endregion


        #region methods

        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] == null || string.IsNullOrEmpty(shipments[i].TrackingCode))
                {
                    shipments[i] = shipment;
                    return true;
                }
            }
            return false;
        }
        public bool RemoveShipment(string trackingcode)
        {

            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i].TrackingCode == trackingcode)
                {
                    shipments[i] = null;
                    return true;
                }
            }
            return false;
        }

        public void PrintAllShipments()
        {
            foreach (Shipment shipment in shipments)
            {
                if (shipment != null)
                {
                    Console.WriteLine($"Tracking Code: {shipment.TrackingCode}, Type: {shipment.GetType().Name}");
                }
            }

        }




        #endregion



    }

}

