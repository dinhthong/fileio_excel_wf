using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product_filter1
{
    class Product
    {
        private int no;
        private string name;
        private string price;
        private string product_url;
        private string image_url;
        public int No
        {
            get { return no; }
            set { no = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Product_url
        {
            get { return product_url; }
            set { product_url = value; }
        }
        public string Image_url
        {
            get { return image_url; }
            set { image_url = value; }
        }
    }
}
