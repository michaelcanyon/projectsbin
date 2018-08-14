using System;
using System.Text;

namespace StringTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Цихлиды, населяющие озеро Малави(Ньяса), появились в нём сравнительно недавно, всего миллион лет назад, куда прибыли из другого крупного озера - Танганьики.Некоторое время эти озёра были соединены речным каналом, образовавшемся в результате тектонических сдвигов. По мнению учёных, с момента появления канала в него устремилось множество видов рыб, однако, добраться до Малави смог всего один вид цихлид.Далее произошло эволюционное событие, не имевшее аналогов в животном мире." +
                "За несколько сотен тысяч лет из одного единственного вида образовалось более 500 новых видов! Причём процесс видообразования продолжается и сейчас."
                + "Практически все из них являются эндемиками и не встречаются более нигде. Успех этих цихлид объясняется необычным способом защиты мальков, появившимся впервые ещё в озере Танганьика. В период нереста рыбки откладывают от нескольких десятков до сотен икринок. После оплодотворения самка сразу забирает их себе в рот, где и происходит дальнейшее развитие.Появившиеся мальки всегда держаться рядом с родителями и в случае опасности тут же прячутся обратно в безопасное место - во рту." +
                "Озеро Малави находится в рифтовой долине на Востоке Африки и представляет собой водоём, заполнивший глубокую трещину на поверхности земли. К примеру, такое же происхождение имеет Байкал. Дно озера завалено осадочными породами(песок, камни), а береговая линия сочетает в себе пологие склоны и скальные нагромождения.Основой экосистемы является фито и зоопланктон, тем не менее, источники пищи очень ограничены, что предопределило высокую конкуренцию за пищевые ресурсы. В ходе эволюции цихлиды разделились на три специализированные группы: первая стала просеивать песок на дне и добывая из него полезных микроорганизмов, вторая группа рыб, известная как Утака, питается мелким планктоном в толще воды, третья — самая многочисленная группа, известная под названием Мбуна, питается водорослями, растущими на поверхности камней и скал. Именно последняя группа является наиболее популярной в аквариумистике. Эти рыбки отличаются яркой окраской и интересным социальным поведением";

            string[] words = text.Split(new char[] { '.', '!', '?', '-', ':', '(', ')', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine();

            var verbs = FindVerbs(words);

            Console.WriteLine();

            FindDuplicationsCount(verbs, 0);

            Console.WriteLine();

            ReplaceWithMyWords(words);

            ReplaceVerbs(words, verbs);

            text = ReplaceWordsShorterThan5Symbols(text);

            text = ReplaceVerbsInText(verbs, text);

            Console.WriteLine(text);

            Console.ReadLine();
        }

        /// <summary>
        /// Метод заменяет слова короче 5 символом другим словом
        /// </summary>
        /// <param name="words"></param>
        static void ReplaceWithMyWords(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length < 5)
                    words[i] = "ЗЛО";
            }
        }

        /// <summary>
        /// Метод заменяет глаголы другим словом
        /// </summary>
        /// <param name="words"></param>
        /// <param name="verbs"></param>
        static void ReplaceVerbs(string[] words, string[] verbs)
        {
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < verbs.Length; j++)
                    if (words[i] == verbs[j])
                        words[i] = "Уточка";
            }
        }

        /// <summary>
        /// Метод считает и выводит количество повторений глаголов
        /// </summary>
        /// <param name="verbs"></param>
        /// <param name="j"></param>
        static void FindDuplicationsCount(string[] verbs, int j)
        {
            int counter = 0;
            for (int i = 0; i < verbs.Length; i++)
            {
                for (j = i + 1; j < verbs.Length; j++)
                {
                    if (verbs[i] == verbs[j])
                        counter++;
                }
                Console.WriteLine("*" + verbs[i] + "*" + " duplications quantity:" + counter);
                counter = 0;
            }
        }

        /// <summary>
        /// Поиск глаголов. Метод возвращает массив с ними
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        static string[] FindVerbs(string[] words)
        {
            string[] verbs = new string[words.Length];
            int verbCounter = 0;
            string[] verbsEnds = { "сь", "ыли", "ось", "ло", "тся", "ться", "ают", "ает", "ит", "яет", "яют", "еет", "еют", "ивать" };
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < verbsEnds.Length; j++)
                {
                    if (words[i].EndsWith(verbsEnds[j]))
                    {
                        verbs[verbCounter++] = words[i];
                        break;
                    }
                }
            }
            string[] verbs2 = new string[verbCounter];
            for (int i = 0; i < verbs2.Length; i++)
                verbs2[i] = verbs[i];
            return verbs2;
        }

        /// <summary>
        /// Замена глаголов своим словом
        /// </summary>
        /// <param name="verbs"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        static string ReplaceVerbsInText(string[] verbs, string text)
        {
            string[] pureTextWithVerbsToChange = text.Split(new char[] { ' ' });
            for (int i = 0; i < pureTextWithVerbsToChange.Length; i++)
            {
                for (int j = 0; j < verbs.Length; j++)
                {
                    if (pureTextWithVerbsToChange[i].StartsWith(verbs[j]))
                        pureTextWithVerbsToChange[i] = pureTextWithVerbsToChange[i].Replace(verbs[j], "Уточка");
                }
            }
            return string.Join(" ", pureTextWithVerbsToChange);
        }

        /// <summary>
        /// замена слов длиной меньше 5 символов своим
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static string ReplaceWordsShorterThan5Symbols(string text)
        {
            string[] endings = new string[] { ".", "!", "?", "-", ":", "(", ")" };//Массив из знаков препинаний, чтобы проверять на наличие в конце слова. Далее удаляю и после проверки на длину возвращаю в слово
            string[] findShortWords = text.Split(new char[] { '.', '!', '?', '-', ':', '(', ')', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int wordsCounter = 0;
            //Считаю короткие слова
            for (int i = 0; i < findShortWords.Length; i++)
            {
                if (findShortWords[i].Length < 5)
                    wordsCounter++;
            }
            string[] shortWords = new string[wordsCounter];//массив на N коротких слов
            wordsCounter = 0;//обнуляю счетчик, чтобы использовать его как индекс элемента массива
            //Заполняю массив короткими словами
            for (int i = 0; i < findShortWords.Length; i++)
            {
                if (findShortWords[i].Length < 5)
                    shortWords[wordsCounter++] = findShortWords[i];
            }

            findShortWords = text.Split(new char[] { ' ' });//Делю текст на слова со знаками препинания для проверки их длины
            string putSymbolBack = "";//Сюда заносится знак препинания, которым оканчивается слово
            for (int i = 0; i < findShortWords.Length; i++)//Весь текст
            {
                for (int j = 0; j < shortWords.Length; j++)//Массив коротких слов
                {
                    for (int k = 0; k < endings.Length; k++)//Знаки препинания
                    {
                        if (findShortWords[i].EndsWith(endings[k]))
                        {
                            putSymbolBack = endings[k];
                            findShortWords[i] = findShortWords[i].Replace(endings[k], "");//удаляется знак препинания
                            break;
                        }
                    }
                    if (findShortWords[i].Length < 5 && findShortWords[i].Contains(shortWords[j]))//
                        findShortWords[i] = "ЗЛО";
                    string.Concat(findShortWords[i], putSymbolBack);//возвращаю знак препинания
                }
            }
            return string.Join(" ", findShortWords);
        }
    }
}
