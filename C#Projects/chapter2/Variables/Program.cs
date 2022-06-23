using static System.Console;


// Console.WriteLine($"default(int) = {default(int)}");
// Console.WriteLine($"default(bool) = {default(bool)}");

// int x = int.MaxValue - 1;
// WriteLine($"Initial value: {x}");
// x++;
// WriteLine($"After incrementing: {x}");
// x++;
// WriteLine($"After incrementing: {x}");
// x++;
// WriteLine($"After incrementing: {x}");


// int number = 0;

// WriteLine(nameof(number));

// static string CardinalToOrdinal(int number)
// {
//     switch (number)
//     {
//         case 11:
//         case 12:
//         case 13:
//             return $"{number}th";
//         default:
//             string numberAsText = number.ToString();
//             char lastDigit = numberAsText[numberAsText.Length - 1];
//             string suffix = string.Empty;
//             switch (lastDigit)
//             {
//                 case '1':
//                     suffix = "st";
//                     break;
//                 case '2':
//                     suffix = "nd";
//                     break;
//                 case '3':
//                     suffix = "rd";
//                     break;
//                 default:
//                     suffix = "th";
//                     break;
//             }
//             return $"{number}{suffix}";
//     }
// }
// static void RunCardinalToOrdinal()
// {
//     for (int number = 1; number <= 40; number++)
//     {
//         Write($"{CardinalToOrdinal(number)} ");
//     }
//     WriteLine();
// }

// RunCardinalToOrdinal();

// string format {index,alignment:formatstring}
// int num = 50000000;

// Write(string.Format("{0,18:C1}", num));
// Write(string.Format("{0,15}", num));



// /// <summary>
// /// REturns the factorial of a number recursively
// /// </summary>
// /// <param name="num">any integer</param>
// /// <returns>an integer</returns>
// int factorial(int num)
// {

//     if (num <= 1)
//     {
//         return 1;
//     }
//     else
//     {
//         return num * factorial(num - 1);
//     }

// }



// factorial(90);



// int n = 8;



// void makePattern(int n)
// {

//     for (int i = 1; i <= n; i++)
//     {

//         for (int j = i; j <= n; j++)
//         {
//             Write("* ");
//         }


//         for (int l = 1; l <= i - 1; l++)
//         {
//             Write("$ ");
//         }


//         for (int l = 1; l <= i; l++)
//         {
//             Write("$ ");
//         }
//         for (int j = i; j <= n; j++)
//         {
//             Write("* ");
//         }
//         for (int j = i; j <= n - 1; j++)
//         {
//             Write("* ");
//         }
//         for (int l = 1; l <= i - 1; l++)
//         {
//             Write("$ ");
//         }


//         for (int l = 1; l <= i; l++)
//         {
//             Write("$ ");
//         }
//         WriteLine();




//     }



// }

// makePattern(n);

double Add(double a, double b){
    return a * b;
}


Add(3, 4);

