using System;
using System.Collections.Generic;
namespace Bla.Logic
{
    public class WeeklyDocumentation
    {
        public int id { get; set; }
        public DateTime createdate { get; set; }
        public int therapy_week { get; set; }
        public DateTime first_day_of_the_week { get; set; }
        public String batchnumber { get; set; }
        public int injection_quantity_in_mikroliter { get; set; }
        public int injection_site_count { get; set; }
        public Boolean injection_site_region_abdomen { get; set; }
        public Boolean injection_site_region_thigh { get; set; }
        public Boolean injection_site_region_upper_arm { get; set; }
        public Boolean injection_site_region_gluteus_or_latus { get; set; }
        public String injection_site_region_other { get; set; }
        public int injection_speed_in_mikroliter_per_hour { get; set; }
        public TherapeuticComplication therapeutic_complication { get; set; }
        public Infection infection { get; set; }

    }

    public class TherapeuticComplication
    {
        //TherapeuticComplicationObjekt, like its defined in the documentation
        public int id { get; set; }
        public bool pain { get; set; }
        public bool fever { get; set; }
        public bool chills { get; set; }
        public bool reddening { get; set; }
        public bool itching { get; set; }
        public bool headache { get; set; }
        public bool swelling { get; set; }
        public bool tiredness { get; set; }
        public bool vomiting { get; set; }
        public String other { get; set; }
    }
    public class Infection
    {
        public int id { get; set; }
        public Boolean skin { get; set; }
        public Boolean neck_or_throat { get; set; }
        public Boolean nose_or_nasal_sinuses { get; set; }
        public Boolean ears { get; set; }
        public Boolean acute_bronchitis { get; set; }
        public Boolean aggravation_of_chronic_bronchitis { get; set; }
        public Boolean bladder { get; set; }
        public Boolean pneumonia { get; set; }
        public Boolean gallbladder_or_bile_duct { get; set; }
        public Boolean kidney { get; set; }
        public Boolean uterus { get; set; }
        public Boolean gastro { get; set; }
        public Boolean peritoneum { get; set; }
        public Boolean sepsis { get; set; }
        public String other { get; set; }
        public List<InfectionTreatmentMedicament> infection_treatment_medicament_list { get; set; }
    }

    public class InfectionTreatmentMedicament
    {
        public int id { get; set; }
        public String medicament_name { get; set; }
        public int dose_in_mikrogram_per_day { get; set; }
        public DateTime startdate { get; set; }
        public int intake_duration_in_days { get; set; }
    }


}
