using System;
using System.Text;

namespace Optiver
{
    public class MultiplyBigInteger
    {
        static string multiply(string num1, string num2)
        {
            if (num1 == "0" || num2 == "0")
                return "0";

            var length1 = num1.Length;
            var length2 = num2.Length;
            var maxLength = length1 + length2;
            var resultArr = new int[maxLength];

            var indexNum1 = 0;
            for (int i = length1 - 1; i >= 0; i--)
            {
                int carry = 0;
                int number1 = num1[i] - '0';
                var indexNum2 = 0;

                for (int j = length2 - 1; j >= 0; j--)
                {
                    int number2 = num2[j] - '0';
                    int sum = number1 * number2 + resultArr[indexNum1 + indexNum2] + carry;

                    resultArr[indexNum1 + indexNum2] = sum % 10;
                    carry = sum / 10;
                    indexNum2++;
                }

                if (carry > 0)
                    resultArr[indexNum1 + indexNum2] = carry;

                indexNum1++;
            }

            var actualLength = maxLength - 1;

            for (; actualLength >= 0 ; actualLength--)
            {
                if (resultArr[actualLength] != 0)
                {
                    break;
                }
            }

            var result = new StringBuilder();
            for (int index = actualLength; index >= 0; index--)
            {
                result.Append(resultArr[actualLength--]);
            }

            return result.ToString();

        }

        public static void Main2(string[] args)
        {
            string num1 = "123"; //"1235421415454545454545454544"; //Console.ReadLine();

            string num2 = "0"; //"1714546546546545454544548544544545"; //Console.ReadLine();

            string res = multiply(num1, num2);

            Console.WriteLine(res);
        }
    }
}
