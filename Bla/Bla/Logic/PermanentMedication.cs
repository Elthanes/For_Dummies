using System;
namespace Bla.Logic
{
    public class PermMedication
    {

        public string medicament_name { get; set; }
        public DateTime start_of_medication_date { get; set; }

        //When not set manually set to maxDate
        public DateTime end_of_medication_date { get; set; /*can be null*/}
        public int dose_in_mikrogram { get; set; }
        public int morning_intake_count_divided_by_hundred { get; set; }
        public int noon_intake_count_divided_by_hundred { get; set; }
        public int evening_intake_count_divided_by_hundred { get; set; }
        public int night_intake_count_divided_by_hundred { get; set; }

        public PermMedication(int id,
                                    int user_id,
                                    String medicament_name,
                                    DateTime start_of_medication_date,
                                    DateTime end_of_medication_date,
                                    int dose_in_mikrogram,
                                    int morning_intake_count_divided_by_hundred,
                                    int noon_intake_count_divided_by_hundred,
                                    int evening_intake_count_divided_by_hundred,
                                    int night_intake_count_divided_by_hundred)
        {

            this.medicament_name = medicament_name;
            this.start_of_medication_date = start_of_medication_date;
            this.end_of_medication_date = end_of_medication_date;
            this.dose_in_mikrogram = dose_in_mikrogram;
            this.morning_intake_count_divided_by_hundred = morning_intake_count_divided_by_hundred;
            this.noon_intake_count_divided_by_hundred = noon_intake_count_divided_by_hundred;
            this.evening_intake_count_divided_by_hundred = evening_intake_count_divided_by_hundred;
            this.night_intake_count_divided_by_hundred = night_intake_count_divided_by_hundred;
        }

        public PermMedication(String name, int dose, DateTime start, DateTime end, int morning, int noon, int evening, int night){
            this.dose_in_mikrogram = dose;
            this.medicament_name = name;
            this.end_of_medication_date = end;
            this.start_of_medication_date = start;
            this.morning_intake_count_divided_by_hundred = morning;
            this.noon_intake_count_divided_by_hundred = noon;
            this.evening_intake_count_divided_by_hundred = evening;
            this.night_intake_count_divided_by_hundred = night;
        }

        public String writeMedication(PermMedication perm)
        {
            String result ="";

           result += perm.medicament_name;
           
            result += dose_in_mikrogram.ToString();

            return result;
        }
    }
}
