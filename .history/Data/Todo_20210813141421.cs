using System;
using System.ComponentModel.DataAnnotations;

namespace DotNetAzure.Data
{
   public class Todo
    {
        public int ID { get; set; }
        public string Description { get; set; }

        [Display(Name = "Created Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public teTime CreatedDate { get; set; }
    }
}