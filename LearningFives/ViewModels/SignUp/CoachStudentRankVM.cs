using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ViewModels.SignUp
{
    public class CoachStudentRankVM
    {
        [DisplayName("Rank of players you want to coach:")]
        [Required(ErrorMessage="You must select a rank")]
        public string PreferredStudentRank { get; set; }

        public static SelectList RankOptions = new SelectList(new List<SelectListItem>
        {
            new SelectListItem {Text = "Bronze", Value = "Bronze"},
            new SelectListItem {Text = "Silver", Value = "Silver"},
            new SelectListItem {Text = "Gold", Value = "Gold"},
            new SelectListItem {Text = "Platinum", Value = "Platinum"},
            new SelectListItem {Text = "Diamond+", Value = "Diamond"}
        }, "Value", "Text");
    }
}