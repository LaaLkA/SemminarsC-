Console.Clear();
string[,] array = //Последние значение каждой строки есть правильный ответ
{
{"Какие из перечисленных ниже программ являются антивирусными?", "MS Word", "Dr.Web", "Chrome", "PDFreader", "Dr.Web"},
{"Какого типа графики не существует?", "Растровая", "Векторная", "Облачная", "Трехмерная", "Облачная"},
{"Когда появился термин «информационные технологии» в современном значении?", "В 1893 году", "В 1990 году", "В 1958 году", "В 1902 году", "В 1958 году"},
{"В каком году компанией IBM был выпущен первый в истории жесткий диск?", "В 1956 году", "В 1958 году", "В 1955 году", "В 1957 году", "В 1956 году"},
{"Какая поисковая система была самой популярной в 2011 году?", "Yahoo!", "Google", "Bing", "Yandex", "Google"},
{"Страна лидер по количеству суперкомпьютеров?", "Китай", "США", "Япония", "Россия", "Китай"},
{"Какого Интернет-браузера не существует?", "MS PowerPoint", "Opera", "Google Chrome", "Internet Explorer", "MS PowerPoint"},
{"Какие из клавиш клавиатуры относятся к группе функциональных?", "F1-F12", "CTRL, ALT, Shift", "Windows","Tab", "F1-F12"},
{"Какую скорость передачи данных может обеспечить широкополосная связь по ЛЭП?", "200 МБит/с", "1 МБит/с", "100 МБит/с", "10 МБит/с", "100 МБит/с"},
};


int TakeNumber(string message)
{
    System.Console.WriteLine($"Введите {message}");
    string StrNum = Console.ReadLine();
    if (int.TryParse(StrNum, out int num))
    {
        if (num < 5 || num == 50) return num;
        return TakeNumber(message);
    }
    return TakeNumber(message);
}

void Game()
{
    int countUse50 = 0;
    int Score = 0;
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        System.Console.WriteLine($"Вопрос: {array[i, 0]}");
        System.Console.WriteLine();
        System.Console.WriteLine($"Варианты ответа:");

        for (int j = 1; j < array.GetLength(1) - 1; j++)
        {
            System.Console.WriteLine($"{j}) {array[i, j]}");
        }
        System.Console.WriteLine();
        System.Console.WriteLine("Чтобы воспользоваться шансом 50 на 50  - введите число 50");

    a: int Answer = TakeNumber("номер верного ответа");

        if (Answer == 50)
        {
            int count50 = 0;
            if (countUse50 > 1)
            {
                System.Console.WriteLine("У Вас боьше нед подсказки 50 на 50");
                goto a;
            }
            else
            {
                System.Console.WriteLine("Варианты ответа:");

                for (int k = 1; k < array.GetLength(1) - 1; k++)
                {
                    if (array[i, k] == array[i, 5]) System.Console.WriteLine($"{k}) {array[i, k]}");
                    else
                    {
                        count50++;
                        if (count50 < 2) System.Console.WriteLine($"{k}) {array[i, k]}");
                        else goto a;
                    }

                }
            }
        }
        else if (array[i, Answer] == array[i, 5])
            {
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine("Ответ правильный!");
                Console.ResetColor();
                // Console.Clear();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("Вы ввели неправильный ответ");
                Console.ResetColor();
                count++;

                if (count > 2)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("Вы прогирали. Конец игры");
                    Console.ResetColor();
                    break;
                }
                else
                {
                    System.Console.WriteLine("Попробуйте ещё раз");
                    goto a;
                }
            }
            Score++;
        }
        if (Score > 8)
        {
            System.Console.WriteLine(Score);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("Поздравляю Вы прошли игру!!!");
            Console.ResetColor();
        }
    }
    Game();
