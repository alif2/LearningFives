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

        [DisplayName("Rate your comfort with top lane:")]
        [Required(ErrorMessage = "You must select a comfort level")]
        [Range(0, 3)]
        public int TopLaneComfort { get; set; }

        [DisplayName("Rate your comfort with jungle:")]
        [Required(ErrorMessage = "You must select a comfort level")]
        [Range(0, 3)]
        public int JungleComfort { get; set; }

        [DisplayName("Rate your comfort with mid lane:")]
        [Required(ErrorMessage = "You must select a comfort level")]
        [Range(0, 3)]
        public int MidComfort { get; set; }

        [DisplayName("Rate your comfort with marksman:")]
        [Required(ErrorMessage = "You must select a comfort level")]
        [Range(0, 3)]
        public int MarksmanComfort { get; set; }

        [DisplayName("Rate your comfort with support:")]
        [Required(ErrorMessage = "You must select a comfort level")]
        [Range(0, 3)]
        public int SupportComfort { get; set; }


        //Dropdown menu options for each value
        public static SelectList PreferredRoleOptions = new SelectList(new List<SelectListItem>
        {
            new SelectListItem {Text = "Top Lane", Value = "Top Lane"},
            new SelectListItem {Text = "Jungle", Value = "Jungle"},
            new SelectListItem {Text = "Middle Lane", Value = "Middle Lane"},
            new SelectListItem {Text = "Marksman", Value = "Marksman"},
            new SelectListItem {Text = "Support", Value = "Support"}
        }, "Value", "Text");

        public static SelectList TopLaneComfortOptions = new SelectList(new List<SelectListItem>
        {
            new SelectListItem {Text = "3 - I would really like to play top lane", Value = "3"},
            new SelectListItem {Text = "2 - I would be okay with playing top lane", Value = "2"},
            new SelectListItem {Text = "1 - I do not like playing top lane, but will play it if necessary", Value = "1"},
            new SelectListItem {Text = "0 - I do not want to play top lane in any case", Value = "0"}
        }, "Value", "Text");

        public static SelectList JungleComfortOptions = new SelectList(new List<SelectListItem>
        {
            new SelectListItem {Text = "3 - I would really like to play jungle", Value = "3"},
            new SelectListItem {Text = "2 - I would be okay with playing jungle", Value = "2"},
            new SelectListItem {Text = "1 - I do not like playing jungle, but will play it if necessary", Value = "1"},
            new SelectListItem {Text = "0 - I do not want to play jungle in any case", Value = "0"}
        }, "Value", "Text");

        public static SelectList MidComfortOptions = new SelectList(new List<SelectListItem>
        {
            new SelectListItem {Text = "3 - I would really like to play mid lane", Value = "3"},
            new SelectListItem {Text = "2 - I would be okay with playing mid lane", Value = "2"},
            new SelectListItem {Text = "1 - I do not like playing mid lane, but will play it if necessary", Value = "1"},
            new SelectListItem {Text = "0 - I do not want to play mid lane in any case", Value = "0"}
        }, "Value", "Text");

        public static SelectList MarksmanComfortOptions = new SelectList(new List<SelectListItem>
        {
            new SelectListItem {Text = "3 - I would really like to play marksman", Value = "3"},
            new SelectListItem {Text = "2 - I would be okay with playing marksman", Value = "2"},
            new SelectListItem {Text = "1 - I do not like playing marksman, but will play it if necessary", Value = "1"},
            new SelectListItem {Text = "0 - I do not want to play marksman in any case", Value = "0"}
        }, "Value", "Text");

        public static SelectList SupportComfortOptions = new SelectList(new List<SelectListItem>
        {
            new SelectListItem {Text = "3 - I would really like to play support", Value = "3"},
            new SelectListItem {Text = "2 - I would be okay with playing support", Value = "2"},
            new SelectListItem {Text = "1 - I do not like playing support, but will play it if necessary", Value = "1"},
            new SelectListItem {Text = "0 - I do not want to play support in any case", Value = "0"}
        }, "Value", "Text");
    }
}