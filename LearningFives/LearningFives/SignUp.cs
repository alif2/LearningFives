using System.Collections.Generic;
using System.Web.Mvc;

namespace LearningFives
{
    public class SignUp
    {
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

        public static SelectList TeachingRankOptions = new SelectList(new List<SelectListItem>
        {
            new SelectListItem {Text = "Bronze", Value = "Bronze"},
            new SelectListItem {Text = "Silver", Value = "Silver"},
            new SelectListItem {Text = "Gold", Value = "Gold"},
            new SelectListItem {Text = "Platinum", Value = "Platinum"},
            new SelectListItem {Text = "Diamond+", Value = "Diamond"}
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