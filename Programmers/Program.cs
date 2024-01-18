namespace Programmers
{
    internal class Program
    {
        // Level_0


        
        public class Solution
        {            
            // 나이 출력
            public int solution1(int age)
            {
                int answer = 2023 - age;
                return answer;
            }
            // 두 수의 차
            public int solution2(int num1, int num2)
            {
                int answer = num1 + (-num2);
                return answer;
            }
            // 두 수의 곱
            public int solution3(int num1, int num2)
            {
                int answer = num1 * num2;
                return answer;
            }
            // 숫자 비교하기
            public int solution4(int num1, int num2)
            {
                int answer = 0;
                if (num1 == num2)
                {
                    answer = 1;
                    return answer;
                }
                else if (num1 != num2)
                {
                    answer = -1;
                    return answer;
                }
                else
                {
                    return answer;
                }
            }
            // 나머지 구하기
            public int solution5(int num1, int num2)
            {
                int answer = num1 % num2;
                return answer;
            }
            // 두 수의 합
            int solution6(int num1, int num2)
            {
                int answer = num1 + num2;
                return answer;
            }
            // 두 수의 나눗셈
            public int solution7(int num1, int num2)
            {
                int answer = (num1 * 1000 / num2);
                return answer;
            }
            // 각도기 
            public int solution8(int angle)
            {
                int answer = 0;
                if (0 < angle && angle < 90)
                {
                    answer = 1;
                }
                else if (90 == angle)
                {
                    answer = 2;
                }
                else if (90 < angle && angle < 180)
                {
                    answer = 3;
                }
                else if (angle == 180)
                {
                    answer = 4;
                }

                return answer;
            }
            // 짝수의 합
            public int solution9(int n)
            {
                int answer = 0;

                for (int i = 0; i <= n; i++)
                {
                    if (i % 2 == 0)
                    {
                        answer += i;
                    }
                }

                return answer;
            }
            // 배열의 평균값
            public double solution10(int[] numbers)
            {
                int allNum = numbers.Length;
                double total = 0;
                for (int i = 0; i < allNum; i++)
                {
                    total += numbers[i];
                }
                total /= allNum;
                return total;
            }
            // 특정 문자 제거하기
            public string solution11(string my_string, string letter)
            {
                string answer = "";
                return answer = my_string.Replace(letter.ToString(), ""); ;
            }
            // 문자열안에 문자열
            public int solution12(string str1, string str2)
            {


                if (str1.Contains(str2))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
                return 1;
            }
            // 편지
            public int solution13(string message)
            {

                int answer = message.Length * 2;

                return answer;
            }
            // 배열 원소의 길이
            public int[] solution14(string[] strlist)
            {
                int[] answer = new int[strlist.Length];
                for (int i = 0; i < strlist.Length; i++)
                {
                    answer[i] = strlist[i].Length;
                }

                return answer;
            }
            // 아이스 아메리카노
            public int[] solution15(int money)
            {
                int aa = 0;


                while (money >= 5500)
                {
                    money -= 5500;
                    aa++;
                }
                int[] answer = new int[] { aa, money };
                return answer;
            }
            // 최댓값 만들기(1)
            public int solution16(int[] numbers)
            {
                int answer = 0;
                Array.Sort(numbers);
                int a = numbers[numbers.Length - 1];
                int b = numbers[numbers.Length - 2];

                return answer = a * b;
            }
            // 양꼬치
            public int solution17(int n, int k)
            {
                k = k - n / 10;

                n = n * 12000;
                k = k * 2000;

                int answer = n + k;
                return answer;
            }
            // 배열의 유사도
            public int solution18(string[] s1, string[] s2)
            {
                int answer = 0;
                foreach (string value1 in s1)
                {
                    for (int i = 0; i < s2.Length; i++)
                    {
                        if (value1 == s2[i])
                        {
                            answer++;
                        }
                    }
                }
                return answer;
            }
            // 몫 구하기
            int solution19(int num1, int num2)
            {
                int answer = num1 / num2;
                return answer;
            }
            // 배열 두배 만들기
            public int[] solution20(int[] numbers)
            {

                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] += numbers[i];
                }

                return numbers;
            }








        }



        public class Solution2
        {
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
