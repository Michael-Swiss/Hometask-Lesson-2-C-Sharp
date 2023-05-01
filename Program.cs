//* HOMEWORK 2. TASK 1.

int Prompt (string message) {
     System.Console.Write(message);
     string value = Console.ReadLine();
     int result = Convert.ToInt32(value);
     return result;
     }
 int number = Prompt("Введите трехзначное число > ");
 if (number < 100 || number >= 1000) {
     System.Console.WriteLine("Вы ввели не трехзначное число, повторите ввод именно трехзначного числа: ");
 return;
 }
 System.Console.WriteLine($"Введеное число '{number}'");
 int secondRank = number / 10 % 10;
 System.Console.WriteLine($"Вторая цифра '{secondRank}'");

//* HOMEWORK 2. TASK 2.

// int Prompt(string message) {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
//     }
//     int GetThirdRank(int number) {
//         while (number > 999) {
//             number /= 10;
//         }
//         return number % 10;
//     }
//     bool ValidateNumber(int number) {
//         if (number < 100) {
//             Console.WriteLine("Третьей цифры нет");
//             return false;
//         }
//         return true;
//     }
//     int number = Prompt("Введите число > ");
//     if (ValidateNumber(number)) {
//         System.Console.WriteLine(GetThirdRank(number));
//     }

    //* HOMEWORK 2. TASK 3.

    // int Prompt(string message) {
    // System.Console.Write(message);
    // string value = Console.ReadLine();
    // int result = Convert.ToInt32(value);
    // return result;
    // }
    // bool IsWeekend(int weekDay) {
    //     if (weekDay > 5) {
    //         return true;
    //     }
    //     return false;
    // }
    // bool ValidateWeekday(int number) {
    //     if (number > 0 && number <= 7) {
    //         return true;
    //     }
    //     System.Console.WriteLine("Это не день недели!");
    //     return false;
    // }
    // int weekDay = Prompt("Введите день недели > ");
    // if (ValidateWeekday(weekDay)) {
    //     if(IsWeekend(weekDay)) {
    //         System.Console.WriteLine("Наконец-то выходной");
    //     } else {
    //         System.Console.WriteLine("Придется поработать");
    //     }
    // }
