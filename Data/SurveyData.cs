using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using static UserSurvey_BlazorServer.Data.SurveyEnums;

namespace UserSurvey_BlazorServer.Data
{
    public class SurveyData
    {

        [Required]
        public string Sex { get; set; }

        [Required]
        public string AgeGroup { get; set; }

        [Required(ErrorMessage = "Pick your favourite Sci-Fi show.")]
        public SciFi SciFi { get; set; }


    }
}
