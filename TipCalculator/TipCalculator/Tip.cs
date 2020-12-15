using System;


namespace TipCalculator
{
    class Tip
    {
        private int no_of_persons;
        private double bill;
        private double tip_percentage;
        private double tip_per_person;
        private double total_per_person;

        // Default constructor of TipCalculator class
        public Tip()
        {
            this.no_of_persons = 0;
            this.bill = 0;
            this.tip_percentage = 0;
        }

        // Parametrized constructor of TipCalculator class
        public Tip(int no_of_persons, double bill, double tip_percentage)
        {
            this.no_of_persons = no_of_persons;
            this.bill = bill;
            this.tip_percentage = tip_percentage;
        }

        // Getter of number of person
        public int get_no_of_person()
        {
            return this.no_of_persons;
        }

        // Setter of number of person
        public void set_no_of_person(int value)
        {
            this.no_of_persons=value;
        }

        // Getter of bill
        public double get_bill()
        {
            return this.bill;
        }

        // Setter of bill
        public void set_bill(double value)
        {
            this.bill = value;
        }

        // Getter of tip percentage
        public double get_tip_percentage()
        {
            return this.tip_percentage;
        }

        // Setter of tip percentage
        public void set_tip_percentage(double value)
        {
            this.tip_percentage = value;
        }

        // Getter of tip per person
        public double get_tip_per_person()
        {
            return this.tip_per_person;
        }

        // Setter of tip per person
        public void set_tip_per_person(double value)
        {
            this.tip_per_person = value;
        }

        // Getter of total per person
        public double get_total_per_person()
        {
            return this.total_per_person;
        }

        // Setter of total per person
        public void set_total_per_person(double value)
        {
            this.total_per_person = value;
        }

        // Function calculate_tip() is used to calculate the tip per person
        public double calculate_tip()
        {
            this.tip_per_person = (this.bill * this.tip_percentage) / (this.no_of_persons * 100);
            return Math.Round(this.tip_per_person,2);
        }

        // Function calculate_total() is used to calculate the total per person
        public double calculate_total()
        {
            this.total_per_person = (this.bill / this.no_of_persons) + this.tip_per_person;
            return Math.Round(this.total_per_person,2);
        }

    }
}
