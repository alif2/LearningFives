using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ViewModels.SignUp
{
    public class AvailabilitySignUpVM
    {
        [DisplayName("Start:")]
        [Required]
        [DataType(DataType.Time)]
        public DateTime MondayStart { get; set; }

        [DisplayName("End:")]
        [Required]
        [DataType(DataType.Time)]
        public DateTime MondayEnd { get; set; }

        [DisplayName("Start:")]
        [Required]
        [DataType(DataType.Time)]
        public DateTime TuesdayStart { get; set; }

        [DisplayName("End:")]
        [Required]
        [DataType(DataType.Time)]
        public DateTime TuesdayEnd { get; set; }

        [DisplayName("Start:")]
        [Required]
        [DataType(DataType.Time)]
        public DateTime WednesdayStart { get; set; }

        [DisplayName("End:")]
        [Required]
        [DataType(DataType.Time)]
        public DateTime WednesdayEnd { get; set; }

        [DisplayName("Start:")]
        [Required]
        [DataType(DataType.Time)]
        public DateTime ThursdayStart { get; set; }

        [DisplayName("End:")]
        [Required]
        [DataType(DataType.Time)]
        public DateTime ThursdayEnd { get; set; }

        [DisplayName("Start:")]
        [Required]
        [DataType(DataType.Time)]
        public DateTime FridayStart { get; set; }

        [DisplayName("End:")]
        [Required]
        [DataType(DataType.Time)]
        public DateTime FridayEnd { get; set; }

        [DisplayName("Start:")]
        [Required]
        [DataType(DataType.Time)]
        public DateTime SaturdayStart { get; set; }

        [DisplayName("End:")]
        [Required]
        [DataType(DataType.Time)]
        public DateTime SaturdayEnd { get; set; }

        [DisplayName("Start:")]
        [Required]
        [DataType(DataType.Time)]
        public DateTime SundayStart { get; set; }

        [DisplayName("End:")]
        [Required]
        [DataType(DataType.Time)]
        public DateTime SundayEnd { get; set; }
    }
}