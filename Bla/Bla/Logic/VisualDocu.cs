using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bla.Logic
{
    public class VisualDocu
    {
        public string id { get; set; }
        public string therapy_week { get; set; }
        public string create_date { get; set; }
        public string batchnumber { get; set; }
        public string quantity { get; set; }
        public string speed { get; set; }
        public string amount { get; set; }
        public string place { get; set; }
        public string complications { get; set; }
        public string infections { get; set; }

        public VisualDocu(string id, string therapy_week, string create_date, string batchnumber, string quantity, string speed, string amount, string place, string complications, string infections)
        {
            this.id = id;
            this.therapy_week = therapy_week;
            this.create_date = create_date;
            this.batchnumber = batchnumber;
            this.quantity = quantity;
            this.speed = speed;
            this.amount = amount;
            this.place = place;
            this.complications = complications;
            this.infections = infections;
        }

        public VisualDocu(WeeklyDocumentation a)
        {
            this.id = a.id.ToString();
            this.therapy_week = a.therapy_week.ToString();
            this.amount = a.injection_site_count.ToString();
            this.create_date = a.createdate.ToString();
            this.batchnumber = a.batchnumber;
            this.quantity = a.injection_quantity_in_mikroliter.ToString();
            this.speed = a.injection_speed_in_mikroliter_per_hour.ToString();
            this.place = a.injection_site_region_other;
            if(a.therapeutic_complication.Equals(new TherapeuticComplication()))
            {
                this.complications = "Nein";
            }
            else
            {
                this.complications = "Ja";
            }
            if (a.infection.Equals(new Infection()))
            {
                this.infections = "Nein";
            }
            else
            {
                this.infections = "Ja";
            }
        }
    }
}