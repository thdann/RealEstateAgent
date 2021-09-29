

namespace UtilitiesLib
{
    class ConverterClass
    {
        public int ConvertStringToInteger(string stringToBeConverted)
        {
            int myInt = 0;

            int.TryParse(stringToBeConverted, out myInt);

            return myInt;
        }

        public double ConvertStringToDouble(string stringToBeConverted)
        {
            double myDouble = 0.0;

            double.TryParse(stringToBeConverted, out myDouble);

            return myDouble;

        }

         public int ConvertStringToInteger( string strNum, int lowLimit, int highLimit)
        {
           int myInt = ConvertStringToInteger(strNum); 

           if (myInt < highLimit && myInt > lowLimit)
            {
                return myInt;
            } else
            {
                return -1;
            }
           
        }

        public double ConvertStringToDouble (string strNum, int lowLimit, int highLimit)
        {
            double myDouble = ConvertStringToDouble(strNum);

            if (myDouble < highLimit && myDouble > lowLimit)
            {
                return myDouble;
            }
            else
            {
                return -1;
            }

           
        }
    }
}
