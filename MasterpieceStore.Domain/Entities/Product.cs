using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MasterpieceStore.Domain.Entities
{
    public class Product
    {
        [HiddenInput(DisplayValue = false)]
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Please enter a product name")]
        public string Name { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Please enter a description")]
        public string Description { get; set; }

        [Required]
        // [Range(typeof(Decimal), "0.0", "1000000000000000000", ErrorMessage = "Please enter a positive price")]

        public decimal? MinPrice { get; set; }
        public short? Created { get; set; }

        public byte[] ImageData { get; set; }
        public string ImageMimeType { get; set; }

        //public string Genre { get; set; }
    }
}
