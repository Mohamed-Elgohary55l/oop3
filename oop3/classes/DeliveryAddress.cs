using System;
using System.Collections.Generic;
using System.Text;

namespace oop2.classes
{
    public struct DeliveryAddress
    {
        #region fields
        private string city;
        private string street;
        private int buildingNumber;
        #endregion


        #region constructor
        public DeliveryAddress(string city , string street, int buildingNumber)
        {
            City = city;
            Street = street;
            BuildingNumber = buildingNumber;
        }
        #endregion

        #region properties
        public string City
        {
            get { return city; }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("City cannot be null or empty.");
                }

                city = value;
            }
        }
        public string Street
        {
            get { return street; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) { throw new ArgumentException("Street cannot be null or empty."); }
                street = value;
            }
        }
        public int BuildingNumber
        {
            get { return buildingNumber; }
            set
            {
                if (value <= 0)
                { throw new ArgumentException("Building number must be a positive integer."); }
                buildingNumber = value;
            }
        }

        #endregion

        #region methods
        public string GetFullAddress()
        {
            return $"{city}, {street}, {buildingNumber}";
        }


        #endregion
    }
}
