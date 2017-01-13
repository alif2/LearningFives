using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ViewModels.SignUp
{
    public class RoleSignUpVM
    {
        [DisplayName("Preferred Role:")]
        [Required(ErrorMessage="You must select a preferred role")]
        public string PreferredRole { get; set; }

        [DisplayName("Top Lane")]
        public bool TopLane { get; set; }

        [DisplayName("Jungle")]
        public bool Jungle { get; set; }

        [DisplayName("Mid Lane")]
        public bool MidLane { get; set; }

        [DisplayName("ADC")]
        public bool Adc { get; set; }

        [DisplayName("Support")]
        public bool Support { get; set; }

        //Dropdown menu options for each value
        public static SelectList PreferredRoleOptions = new SelectList(new List<SelectListItem>
        {
            new SelectListItem {Text = "Top Lane", Value = "TopLane"},
            new SelectListItem {Text = "Jungle", Value = "Jungle"},
            new SelectListItem {Text = "Middle Lane", Value = "MidLane"},
            new SelectListItem {Text = "ADC", Value = "Adc"},
            new SelectListItem {Text = "Support", Value = "Support"}
        }, "Value", "Text");
    }
}