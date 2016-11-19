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

        public static SelectList RankTierOptions = new SelectList(new List<SelectListItem>
        {
            new SelectListItem {Text = "Bronze", Value = "Bronze"},
            new SelectListItem {Text = "Silver", Value = "Silver"},
            new SelectListItem {Text = "Gold", Value = "Gold"},
            new SelectListItem {Text = "Platinum", Value = "Platinum"},
            new SelectListItem {Text = "Diamond", Value = "Diamond"},
            new SelectListItem {Text = "Master", Value = "Master"},
            new SelectListItem {Text = "Challenger", Value = "Challenger"}
        }, "Value", "Text");

        //Dropdown menu options for each associated value
        public static SelectList ServerOptions = new SelectList(new List<SelectListItem>
        {
            new SelectListItem {Text = "BR", Value = "BR"},
            new SelectListItem {Text = "EUNE", Value = "EUNE"},
            new SelectListItem {Text = "EUW", Value = "EUW"},
            new SelectListItem {Text = "LAN", Value = "LAN"},
            new SelectListItem {Text = "LAS", Value = "LAS"},
            new SelectListItem {Text = "NA", Value = "NA"},
            new SelectListItem {Text = "OCE", Value = "OCE"},
            new SelectListItem {Text = "RU", Value = "RU"},
            new SelectListItem {Text = "TR", Value = "TR"},
            new SelectListItem {Text = "JP", Value = "JP"},
            new SelectListItem {Text = "KR", Value = "KR"}
        }, "Value", "Text");
    }
}