using System;

namespace oop2.classes
{
    public class Driver
    {
        #region fields
        private string driverId;
        private string fullName;
        private string phoneNumber;
        #endregion

        #region constructor
        public Driver(string driverId, string fullName, string phoneNumber)
        {
            DriverId = driverId;
            FullName = fullName;
            PhoneNumber = phoneNumber;
        }
        #endregion

        #region properties
        public string DriverId
        {
            get { return driverId; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Driver ID cannot be null or empty.");
                }
                driverId = value;
            }
        }

        public string FullName
        {
            get { return fullName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Full name cannot be null or empty.");
                }
                fullName = value;
            }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Phone number cannot be null or empty.");
                }
                phoneNumber = value;
            }
        }
        #endregion
    }
}