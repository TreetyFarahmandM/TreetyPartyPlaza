using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlaza
{
    internal class Order
    {
        private int orderNo, supplierNo;
        private DateTime orderDate;

        public Order()
        {
            this.orderNo = 0; this.supplierNo = 0; this.orderDate = orderDate;
        }
        public Order(int orderNo, int SupplierNo, DateTime orderDate)
        {
            this.orderNo = orderNo; this.supplierNo = supplierNo; this.orderDate = orderDate;
        }

        public int OrderNo
        {
            get { return orderNo; }
            set { orderNo = value; }
        }
        public int SupplierNo
        {
            get
            { return supplierNo;}
            set
            { supplierNo = value; }
        }
        public DateTime OrderDate
        {
            get
            {
                return orderDate;
            }
            set
            {
               orderDate = value;
            }
        }
    }
}
