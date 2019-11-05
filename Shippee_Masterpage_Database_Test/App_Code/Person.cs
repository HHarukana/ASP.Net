using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Person
{
    
      
        private string personID;
        private string personFirst;
        private string personMiddle;
        private string personLast;
        private string personStreet;
        private string personCity;
        private string personState;
        private string personZip;
        private string personNum;
        private string personMail;


        protected string feedback { get; set; }

        public string PersonID
        {

            set
            {
                if (!Validator.gotBadWords(value))
                {
                    personID = value;
                }
            }

            get { return personID; }

        }

        public string PersonFirst
        {
           
            set
            {
                if (!Validator.gotBadWords(value))
                {
                    personFirst = value;
                }
            }

            get { return personFirst; }

        }

        public string PersonMiddle
        {

            set
            {
                if (!Validator.gotBadWords(value))
                {
                    personMiddle = value;
                }
            }

            get { return personMiddle; }

        }

        public string PersonLast
        {

            set
            {
                if (!Validator.gotBadWords(value))
                {
                    personLast = value;
                }
            }

            get { return personLast; }

        }

        public string PersonStreet
        {

            set
            {
                if (!Validator.gotBadWords(value))
                {
                    personStreet = value;
                }
            }

            get { return personStreet; }

        }

        public string PersonCity
        {

            set
            {
                if (!Validator.gotBadWords(value))
                {
                    personCity = value;
                }
            }

            get { return personCity; }

        }

        public string PersonState
        {

            set
            {
                if (!Validator.gotBadWords(value))
                {
                    personState = value;
                }
            }

            get { return personState; }

        }

        public string PersonZip
        {

            set
            {
                if (!Validator.gotBadWords(value))
                {
                    personZip = value;
                }
            }

            get { return personZip; }

        }

        public string PersonNum
        {

            set
            {
                if (!Validator.gotBadWords(value))
                {
                    personNum = value;
                }
            }

            get { return personNum; }

        }

        public string PersonMail
        {

            set
            {
                if (!Validator.gotBadWords(value))
                {
                    personMail = value;
                }
            }

            get { return personMail; }

        }



        public Person(string id, string fname, string mname, string lname, string street, string city, string state, string zip, string num, string mail)
        {
            this.PersonID = id;
            this.PersonFirst = fname;
            this.PersonMiddle = mname;
            this.PersonLast = lname;
            this.PersonStreet = street;
            this.PersonCity = city;
            this.PersonState = state;
            this.PersonZip = zip;
            this.PersonNum = num;
            this.PersonMail = mail;

        }

        public string Feedback
        {
            get { return feedback; }
        }

        public Person()
        {
           
            PersonFirst = "";
            PersonMiddle = "";
            PersonLast = "";
            PersonStreet = "";
            PersonCity = "";
            PersonState = "";
            PersonZip = "";
            PersonNum = "";
            PersonMail = "";
            feedback = "";

        }
        public virtual string displayPersonOutput()
        {
            return  "Name: " + personFirst + " " + personLast + Environment.NewLine;
        }
}
