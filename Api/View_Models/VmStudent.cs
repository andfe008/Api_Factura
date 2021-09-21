using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.View_Models.Models
{
    public class StudentVm
    {
        public int Id { get; set; }

        [MaxLength(20, ErrorMessage = "FirtsName maximum 20 letters")]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "FirstName Only letters")]
        public string FirstName { get; set; }

        [MaxLength(20, ErrorMessage = "FirtsName maximum 20 letters")]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "FirstName Only letters")]
        public string LastName { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Identification, Please enter valid integer Number")]
        public Int64 Identification { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Identification, Please enter valid integer Number")]
        public int Age { get; set; }
        public HouseVm Fk_Houses { get; set; }
        public int Fk_House { get; set; }
    }
}
    