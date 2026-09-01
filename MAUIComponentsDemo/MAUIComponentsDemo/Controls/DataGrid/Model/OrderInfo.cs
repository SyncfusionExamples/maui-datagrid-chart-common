using System.ComponentModel;

namespace MAUIComponentsDemo
{
    public class OrderInfo : INotifyPropertyChanged
    {
        #region private variables

        private int orderID;
        private int customerID;
        private string? name;
        private string? shipCity;
        private string? shipCountry;
        private DateTime shippingDate;
        #endregion

        /// <summary>
        /// Initializes a new instance of the OrderInfo class.
        /// </summary>
        public OrderInfo()
        {
        }

        /// <summary>
        /// Represents the method that will handle the <see cref="E:System.ComponentModel.INotifyPropertyChanged.PropertyChanged"></see> event raised when a property is changed on a component
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        #region Public Properties

        /// <summary>
        /// Gets or sets the value of OrderID and notifies user when value gets changed
        /// </summary>
        public int OrderID
        {
            get
            {
                return this.orderID;
            }

            set
            {
                this.orderID = value;
                this.RaisePropertyChanged("OrderID");
            }
        }

      
        /// <summary>
        /// Gets or sets the value of EmployeeID and notifies user when value gets changed
        /// </summary>
        public int CustomerID
        {
            get
            {
                return this.customerID;
            }

            set
            {
                this.customerID = value;
                this.RaisePropertyChanged("CustomerID");
            }
        }

        

        /// <summary>
        /// Gets or sets the value of FirstName and notifies user when value gets changed
        /// </summary>
        public string? Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
                this.RaisePropertyChanged("Name");
            }
        }


        /// <summary>
        /// Gets or sets the value of ShipCity and notifies user when value gets changed
        /// </summary>
        public string? ShipCity
        {
            get
            {
                return this.shipCity;
            }

            set
            {
                this.shipCity = value;
                this.RaisePropertyChanged("ShipCity");
            }
        }

        /// <summary>
        /// Gets or sets the value of ShipCountry and notifies user when value gets changed
        /// </summary>
        public string? ShipCountry
        {
            get
            {
                return this.shipCountry;
            }

            set
            {
                this.shipCountry = value;
                this.RaisePropertyChanged("ShipCountry");
            }
        }

        /// <summary>
        /// Gets or sets the value of ShippingDate and notifies user when value gets changed
        /// </summary>
        public DateTime ShippingDate
        {
            get
            {
                return this.shippingDate;
            }

            set
            {
                this.shippingDate = value;
                this.RaisePropertyChanged("ShippingDate");
            }
        }

        #endregion

        #region INotifyPropertyChanged implementation

        /// <summary>
        /// Triggers when Items Collections Changed.
        /// </summary>
        /// <param name="name">string type parameter name</param>
        private void RaisePropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        #endregion
    }
}
