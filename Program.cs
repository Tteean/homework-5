namespace c__homework_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //string words = "bu yazida boshluqlari sil";
            //string final = "";

            //foreach (char word in words)
            //{
            //    if (word == ' ')
            //    {
            //        continue;

            //    }
            //    final += word;
            //}
            //Console.WriteLine(final);
            #endregion

            #region Task2

            //string[] words = { "We","Love","Coding"};
            //int count = 0;

            //foreach (string word in words) 
            //{
            //    foreach (char find in word) 
            //    {
            //        if (find == 'o')
            //        {
            //            count++;
            //        }
            //    }
            //}
            //Console.WriteLine(count);
            #endregion

            #region Task3
            string words = " hit the road jack ";
            string final = "";

            foreach (char word in words)
            {
                for (int i = 0; i < words.Length; i++)
                {

                    if (words[0] == ' ' || words[words.Length-1] == ' ')
                    {
                        continue;
                    }

                }
                final += word;
            }
            Console.WriteLine(final);
            #endregion


            #region Task4
            int n = 10;
            int m = 5;





            #endregion

            #region Task5
            //string word = "Teacher";
            //int count = 0;
            //foreach (char c in word)
            //{
            //    if (c == 'a')
            //    {
            //        count++;
            //    }
            //    else
            //        count += 0;

            //}
            //if (count > 0)
            //{
            //    Console.WriteLine("letter a exists");
            //}
            //else
            //{
            //    Console.WriteLine("letter a doesn't exists");
            //}
            #endregion

            #region Task6

            //string word = "Teacher";
            //int count = 0;
            //foreach (char c in word)
            //{
            //    if (c == 'e')
            //    {
            //        count++;
            //    }
            //    else
            //        count += 0;

            //}
            //Console.WriteLine(count);

            #endregion

            #region Task7
            //int n = 8;
            //int res = 0;

            //if (n > 0 && n % 2 == 0)
            //{
            //    res = n * n;
            //    Console.WriteLine(res);
            //}
            //else
            //{ 
            //    Console.WriteLine("duzgun eded daxil edin"); 
            //}


            #endregion

            #region Task8

            //string edu = "programming";

            //switch (edu)
            //{
            //    case "programming":
            //        Console.WriteLine("400 saat");
            //        break;
            //    case "design":
            //        Console.WriteLine("250 saat");
            //        break;
            //    case "system":
            //        Console.WriteLine("200 saat");
            //        break;
            //    default:
            //        Console.WriteLine("təhsil novu yanlisdir");
            //        break;

            //}
            #endregion
        }
    }

}
