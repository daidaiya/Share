using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop_System.Models
{
    [MetadataType(typeof(ItemMetadata))]
    public partial class ITEMS
    {
        public string RePwd { get; set; }
    }
 
    public class ItemMetadata
    {
        [DisplayName("Item ID")]
        public int ITEM_ID { get; set; }

        [DataType(DataType.MultilineText)]
        [DisplayName("DESCRIPTION")]
        public string DESCRIPTION { get; set; }

        [DataType(DataType.MultilineText)]
        [DisplayName("QUANTITY")]
        public string QUANTITY { get; set; }

        [DisplayName("PRICE")]
        public decimal PRICE { get; set; }

    }
}