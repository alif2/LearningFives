using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ViewModels.SignUp
{
    public class SummonerSignUpVM
    {
        [DisplayName("Summoner name:")]
        [StringLength(16), MinLength(3)]
        [Required]
        public string SummonerName { get; set; }

        [DisplayName("Server:")]
        [Required]
        public string Server { get; set; }

        [DisplayName("Age:")]
        [Required]
        [Range(1, 120)]
        public int Age { get; set; }

        [DisplayName("Email:")]
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        //Dropdown menu options for each associated value
        public static SelectList ServerOptions = new SelectList(new List<SelectListItem>
        {
            new SelectListItem {Text = "Brazil", Value = "BR"},
            new SelectListItem {Text = "EU Nordic & East", Value = "EUNE"},
            new SelectListItem {Text = "EU West", Value = "EUW"},
            new SelectListItem {Text = "Latin America North", Value = "LAN"},
            new SelectListItem {Text = "Latin America South", Value = "LAS"},
            new SelectListItem {Text = "North America", Value = "NA"},
            new SelectListItem {Text = "Oceania", Value = "OCE"},
            new SelectListItem {Text = "Russia", Value = "RU"},
            new SelectListItem {Text = "Turkey", Value = "TR"}
        }, "Value", "Text");
    }
}