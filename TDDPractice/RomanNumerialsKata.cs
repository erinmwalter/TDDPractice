namespace TDDPractice
{
    class RomanNumerialsKata
    {
        public string RomanNumeral(int num)
        {
            string output = "";

            //thousands
            output += GetThousands((num / 1000) % 10);
            num = num % 1000;

            //hundreds
            output += GetNumerals((num / 100) % 10, "C", "D", "M" );
            num = num % 100;

            //tens
            output += GetNumerals((num / 10) % 10, "X", "L", "C");
            num = num % 10;

            //ones
            output += GetNumerals(num % 10, "I", "V", "X" );

            return output;
        }
 

        public string GetThousands(int num)
        {
            string output = "";

            for (int i = 1; i <= num; i++)
            {
                output += "M";
            }

            return output;
        }

        public string GetNumerals(int num, string small, string medium, string large)
        {
            string output = "";
            switch (num)
            {
                case 9:
                    return small + large;
                case 4:
                    return small + medium;
                default:
                    if (num >= 5)
                    {
                        output += medium;
                        num = num - 5;
                    }
                    for (int i = 1; i <= num; i++)
                    {
                        output += small;
                    }
                    break;
            }

            return output;
        }
    }
}





//unnecessary code since made into one method "GetNumerals" to replace these 3

//public string GetOnes(int num)
//{
//    string output = "";
//    switch (num)
//    {
//        case 9:
//            return "IX";
//        case 4:
//            return "IV";
//        default:
//            if (num >= 5)
//            {
//                output += "V";
//                num = num - 5;
//            }
//            for (int i = 1; i <= num; i++)
//            {
//                output += "I";
//            }
//            break;
//    }

//    return output;
//}

//public string GetTens(int num)
//{
//    string output = "";
//    switch (num)
//    {
//        case 9:
//            return "XC";
//        case 4:
//            return "XL";
//        default:
//            if (num >= 5)
//            {
//                output += "L";
//                num = num - 5;
//            }
//            for (int i = 1; i <= num; i++)
//            {
//                output += "X";
//            }
//            break;
//    }

//    return output;
//}

//public string GetHundreds(int num)
//{
//    string output = "";
//    switch (num)
//    {
//        case 9:
//            return "CM";
//        case 4:
//            return "DC";
//        default:
//            if (num >= 5)
//            {
//                output += "D";
//                num = num - 5;
//            }
//            for (int i = 1; i <= num; i++)
//            {
//                output += "C";
//            }
//            break;
//    }

//    return output;
//}