using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlaza
{
    internal class MyEntity
    {
        private int idNo;
        private String street, town, county, postcode, telNo;

        public MyEntity()
        {
            this.street = ""; this.town = ""; this.county = ""; this.postcode = ""; this.telNo = "";
        }

        public MyEntity(int idNo, String street, String town, String county, String postcode, String telNo)
        {
            this.street = street; this.town = town; this.county = county; this.postcode = postcode; this.telNo = telNo;
        }
        public int IDNO
        {
            get { return idNo; }
            set { idNo = value; }
        }
        public String Street
        {
            get { return street; }
            set
            {
                if (MyValidation.validLength(value, 5, 40) && MyValidation.validLetterNumberWhitespace(value))
                {
                    street = MyValidation.firstLetterEachWordToUppper(value);
                }
                else
                    throw new MyException("Street must be 5-40 letters");
            }
        }
        public String Town
        {
            get { return town; }
            set
            {
                if (MyValidation.validLength(value, 2, 20) && MyValidation.validLetterWhitespace(value))
                {
                    town = MyValidation.firstLetterEachWordToUppper(value);
                }
                else
                    throw new MyException("Town must be 2-20 letters");
            }
        }
        public String County
        {
            get
            {
                return county;
            }
            set
            {
                if (MyValidation.validLength(value, 2, 20) && MyValidation.validLetter(value))
                {
                    county = MyValidation.firstLetterEachWordToUppper(value);
                }
                else
                    throw new MyException("County must be 2-20 letters");
            }
        }
        public String Postcode
        {
            get
            {
                return postcode;
            }
            set
            {
                if (MyValidation.validLength(value, 7, 8) && MyValidation.validLetterNumberWhitespace(value))
                {
                    postcode = MyValidation.EachLetterToUpper(value);

                }
                else
                    throw new MyException("Postcode must be 7-8 letters and alphanumeric only");
            }
        }
        public String TelNo
        {
            get
            {
                return telNo;
            }
            set
            {
                if (MyValidation.validLength(value, 11, 15) && MyValidation.validNumber(value))
                {
                    telNo = value;
                }
                else
                    throw new MyException("Telephone number must be 11-15 digits");
            }
        }
    }
}
