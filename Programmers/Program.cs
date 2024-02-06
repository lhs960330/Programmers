using System.Globalization;

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
            // 삼각형의 완성조건(1)
            public int solution21(int[] sides)
            {
                int answer = 0;
                int b = 0;
                foreach (int a in sides)
                {
                    b += a;
                }
                int max = sides.Max();
                b = b - max;
                if (b > max)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }

                return answer;
            }
            // 피자 나눠 먹기(1)
            public int solution22(int n)
            {
                int answer = 0;
                if (n % 7 == 0)
                {
                    answer = n / 7;
                }
                else
                {
                    answer = (n / 7) + 1;
                }

                return answer;
            }
            // 머쓱이보다 키 큰 사람
            public int solution23(int[] array, int height)
            {
                int answer = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > height)
                    {
                        answer++;
                    }
                }
                return answer;
            }
            // 배열 자르기
            public int[] solution24(int[] numbers, int num1, int num2)
            {
                int aaa = 0;
                int[] answer = new int[num2 - num1 + 1];



                for (int i = 0; i < numbers.Length; i++)
                {

                    if (num1 <= i && num2 >= i)
                    {


                        answer[aaa++] = numbers[i];

                    }
                }

                return answer;
            }
            // 중복된 숫자 개수
            public int solution25(int[] array, int n)
            {
                int answer = 0;
                foreach (int i in array)
                {
                    if (i == n)
                    {
                        answer++;
                    }
                    else
                    {

                    }
                }

                return answer;
            }
            // 피자 나눠 먹기 (3)
            public int solution26(int slice, int n)
            {
                return (n + (slice - 1)) / slice;
            }
            // 옷가게 할인 받기
            public int solution27(int price)
            {
                if (price < 300000 && price >= 100000)
                {
                    price = (int)(price * 0.95f);
                }
                else if (price < 500000 && price >= 300000)
                {
                    price = (int)(price * 0.9f);
                }
                else if (price >= 500000)
                {
                    price = (int)(price * 0.8f);
                }

                int answer = price;
                return answer;



            }
            // 중앙값 구하기
            public int solution28(int[] array)
            {
                int answer = 0;
                Array.Sort(array);

                answer = array[array.Length / 2];

                return answer;
            }
            // 점의 위치 구하기
            public int solution29(int[] dot)
            {
                int xPos = dot[0];
                int yPos = dot[1];
                int answer = 0;
                if (xPos > 0 && yPos > 0)
                {
                    answer = 1;
                }
                else if (xPos < 0 && yPos > 0)
                {
                    answer = 2;
                }
                else if (xPos < 0 && yPos < 0)
                {
                    answer = 3;
                }
                else if (xPos > 0 && yPos < 0)
                {
                    answer = 4;
                }


                return answer;
            }
            // 최댓값 만들기(1)
            public int solution30(int[] numbers)
            {
                int answer = 0;
                Array.Sort(numbers);
                int a = numbers[numbers.Length - 1];
                int b = numbers[numbers.Length - 2];

                return answer = a * b;
            }
            // 세균 증식
            public int solution31(int n, int t)
            {
                int answer = 0;
                int a = 2;
                for (int i = 0; i < t; i++)
                {
                    n *= a;
                }
                return answer = n;
            }
            // 짝수는 싫어요
            public int[] solution32(int n)
            {
                int b = 0;
                if (n % 2 == 0)
                {
                    b = n / 2;
                }
                else
                {
                    b = (n / 2) + 1;
                }
                int[] answer = new int[b];
                int a = 0;
                for (int i = 1; i <= n; i++)
                {
                    if (i % 2 != 0)
                    {
                        answer[a++] = i;
                    }
                }
                return answer;
            }
            // 문자 반복 출력하기
            public string solution33(string my_string, int n)
            {
                string answer = "";
                foreach (char a in my_string)
                {
                    for (int i = 0; i < n; i++)
                    {
                        answer += a;
                    }

                }

                return answer;
            }
            // 제곱수 판별하기
            public int solution34(int n)
            {
                int answer = 0;
                int a = 0;

                for (int i = 0; i < n; i++)
                {
                    a = i * i;
                    if (n == a)
                    {
                        return 1;
                    }
                }
                return 2;
            }
            // 개미 군단
            public int solution35(int hp)
            {
                int answer = 0;
                int atk = 0;
                for (int i = 0; i < hp; i++)
                {
                    if (hp >= atk + 5)
                    {
                        atk += 5;
                        answer++;
                    }
                    else if (hp >= atk + 3)
                    {
                        atk += 3;
                        answer++;
                    }
                    else if (hp >= atk + 1)
                    {
                        atk += 1;
                        answer++;
                    }
                    else
                    {
                        return answer;
                    }
                }
                return answer;
            }
            // 가위 바위 보
            public string solution36(string rsp)
            {
                string answer = "";
                char c;
                foreach (char a in rsp)
                {
                    if (a == '2')
                    {
                        c = '0';
                        answer += c;
                    }
                    else if (a == '0')
                    {
                        c = '5';
                        answer += c;
                    }
                    else
                    {
                        c = '2';
                        answer += c;
                    }
                }
                return answer;
            }
            // 대문자와 소문자
            public string solution37(string my_string)
            {
                string answer = "";
                char c;
                foreach (char a in my_string)
                {
                    c = a;
                    c = char.ToUpper(a);
                    if (c != a)
                    {
                        answer += c;
                    }
                    else
                    {
                        c = char.ToLower(a);
                        answer += c;
                    }
                }
                return answer;
            }
            // n의 배수 고르기
            public int[] solution38(int n, int[] numlist)
            {

                int[] answer = numlist.Where(num => num % n == 0).ToArray();
                return answer;

            }
            // 모음 제거
            public string solution39(string my_string)
            {
                string answer = "";
                int index = 0;
                foreach (char a in my_string)
                {
                    if (a == 'a' || a == 'e' || a == 'i' || a == 'o' || a == 'u')
                    {

                    }
                    else
                    {
                        answer += a;
                    }
                }
                return answer;
            }
            // 최댓값 만들기 (2)
            public int solution40(int[] numbers)
            {
                int max1 = int.MinValue;
                int max2 = int.MinValue;
                int min1 = int.MaxValue;
                int min2 = int.MaxValue;

                foreach (int num in numbers)
                {
                    if (num > max1)
                    {
                        max2 = max1;
                        max1 = num;
                    }
                    else if (num > max2)
                    {
                        max2 = num;
                    }

                    if (num < min1)
                    {
                        min2 = min1;
                        min1 = num;
                    }
                    else if (num < min2)
                    {
                        min2 = num;
                    }
                }


                return Math.Max(max1 * max2, min1 * min2);

            }
            // 문자열을 정수로 바꾸기     
                public int solution41(string s)
                {
                    int answer = 0;
                    answer = int.Parse(s);
                    return answer;
                }
            // 나머지가 1이되는 수 찾기
            public int solution42(int n)
            {
                int answer = 0;
                for (int i = 1; i < n; i++)
                {
                    if (n % i == 1)
                    {
                        answer = i;
                        return answer;
                    }
                }
                return answer;
            }

        }
        // 평균 구하기
        public double solution43(int[] arr)
        {
            double answer = 0;
            double b = 0;
            foreach (double a in arr)
            {
                b += a;
            }
            answer = b / arr.Length;
            return answer;
        }




        static void Main(string[] args)
        {
            int[] answer = new int[] { };
            answer.
        }
    }
}
