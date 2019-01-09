using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MasterpieceStore.Domain.Entities
{
   public class Author
    {
        [HiddenInput(DisplayValue = false)]
        public int AuthorID { get; set; }

        [Required(ErrorMessage = "Please enter Author's firstName")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter  Author's lastName")]
        public string LastName { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Please enter a description")]
        public string Description { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime DateOfDeath { get; set; }

        public byte[] ImageData { get; set; }
        public string ImageMimeType { get; set; }
    }
}
