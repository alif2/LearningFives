using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ViewModels.SignUp
{
    public class SummonerSignUpVM
    {
        [DisplayName("Summoner name:")]
        [StringLength(24), MinLength(4)]
        [Required]
        public string SummonerName { get; set; }

        [DisplayName("Server:")]
        [Required]
        public string Server { get; set; }

        [DisplayName("Ranking:")]
        [Required]
        public string RankTier { get; set; }

        [DisplayName("Server:")]
        [Required]
        [Range(1, 5)]
        public int RankDivision { get; set; }

        [DisplayName("Age:")]
        [Required]
        [Range(1, 120)]
        public int Age { get; set; }

        [DisplayName("Email:")]
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DisplayName("Are you already registered on the L5 Slack?")]
        [Required]
        public bool HasSlackAccount { get; set; }

        //Dropdown menu options for each associated value
        public static SelectList ServerOptions = new SelectList(new List<SelectListItem>
        {
            new SelectListItem {Text = "Brazil", Value = "Brazil"},
            new SelectListItem {Text = "EU Nordic & East", Value = "EU Nordic & East"},
            new SelectListItem {Text = "EU West", Value = "EU West"},
            new SelectListItem {Text = "Latin America North", Value = "Latin America North"},
            new SelectListItem {Text = "Latin America South", Value = "Latin America South"},
            new SelectListItem {Text = "North America", Value = "North America"},
            new SelectListItem {Text = "Oceania", Value = "Oceania"},
            new SelectListItem {Text = "Russia", Value = "Russia"},
            new SelectListItem {Text = "Turkey", Value = "Turkey"}
        }, "Value", "Text");

        public static SelectList RankTierOptions = new SelectList(new List<SelectListItem>
        {
            new SelectListItem {Text = "Bronze", Value = "Bronze"},
            new SelectListItem {Text = "Silver", Value = "Silver"},
            new SelectListItem {Text = "Gold", Value = "Gold"},
            new SelectListItem {Text = "Platinum", Value = "Platinum"},
            new SelectListItem {Text = "Diamond", Value = "Diamond"},
            new SelectListItem {Text = "Master/Challenger", Value = "Master/Challenger"},
        }, "Value", "Text");

        public static SelectList RankDivionOptions = new SelectList(new List<SelectListItem>
        {
            new SelectListItem {Text = "I", Value = "1"},
            new SelectListItem {Text = "II", Value = "2"},
            new SelectListItem {Text = "III", Value = "3"},
            new SelectListItem {Text = "IV", Value = "4"},
            new SelectListItem {Text = "V", Value = "5"}
        }, "Value", "Text");
    }
}