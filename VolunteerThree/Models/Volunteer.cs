using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VolunteerThree.Models
{
    public class Volunteer
    {
        [Key]
        public int VId { get; set; }
        [Required(ErrorMessage = "Фамилия обязательно")]
        [Display(Name = "Фамилия")]
        public string VSurname { get; set; }
        [Required(ErrorMessage = "Имя обязательно")]
        [Display(Name = "Имя")]
        public string VName { get; set; }
        
        [Required(ErrorMessage = "День рождения обязательно")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "День рождения")]
        public DateTime VBirthday { get; set; }
       
        [Required(ErrorMessage = "ПИН обязательно")]
        [Display(Name = "ПИН", Prompt = "Персональный номер")]
        [StringLength(14, MinimumLength =14, ErrorMessage ="Недопустимая длина")]
        public string VPersonNumber { get; set; }
        

        [Display(Name = "Район/Город", Prompt = "Место")]
        public int ZonId { get; set; }
        public Zon Zon { get; set; }

        [Required(ErrorMessage ="Номер телефона обязательно")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Номер телефона", Prompt ="xxxx-xx-xx-xx")]
        //[Required(ErrorMessage = "Phone Number Required!")]
        //[RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
        //           ErrorMessage = "Entered phone format is not valid.")]
        [DisplayFormat(DataFormatString = "{0:####-##-##-##}")]
        public string VPhoneNumber { get; set; }
        [Display(Name ="Примечание")]
        public string Note { get; set; }

        public string UserId { get; set; }
    }

    public class Reg
    {
        public int Id { get; set; }
        public string RName { get; set; }
        public List<Zon> zons { get; set; } = new List<Zon>();
    }

    public class Zon
    {
        public int Id { get; set; }
        public string ZName { get; set; }
        [Display(Name = "Область")]
        public int RegId { get; set; }
        public Reg Reg { get; set; }
    }
}
