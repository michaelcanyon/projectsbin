using System;
using System.Text;

namespace StringTasks
{
    class Program
    {
        static void Main(string[] args)
        {

            string endings = ".!?-:(), ";
            int wordLength = 0;
            int wordBeginingIndex = 0;
            string myWord1 = "ЗЛО";
            string myWord2 = "Уточка";
            string letter = "";
            StringBuilder text0 = new StringBuilder("Цихлиды, населяющие озеро Малави(Ньяса), появились в нём сравнительно недавно, всего миллион лет назад, куда прибыли из другого крупного озера - Танганьики.Некоторое время эти озёра были соединены речным каналом, образовавшемся в результате тектонических сдвигов. По мнению учёных, с момента появления канала в него устремилось множество видов рыб, однако, добраться до Малави смог всего один вид цихлид.Далее произошло эволюционное событие, не имевшее аналогов в животном мире." +
                "За несколько сотен тысяч лет из одного единственного вида образовалось более 500 новых видов! Причём процесс видообразования продолжается и сейчас."
                + "Практически все из них являются эндемиками и не встречаются более нигде. Успех этих цихлид объясняется необычным способом защиты мальков, появившимся впервые ещё в озере Танганьика. В период нереста рыбки откладывают от нескольких десятков до сотен икринок. После оплодотворения самка сразу забирает их себе в рот, где и происходит дальнейшее развитие.Появившиеся мальки всегда держаться рядом с родителями и в случае опасности тут же прячутся обратно в безопасное место - во рту." +
                "Озеро Малави находится в рифтовой долине на Востоке Африки и представляет собой водоём, заполнивший глубокую трещину на поверхности земли. К примеру, такое же происхождение имеет Байкал. Дно озера завалено осадочными породами(песок, камни), а береговая линия сочетает в себе пологие склоны и скальные нагромождения.Основой экосистемы является фито и зоопланктон, тем не менее, источники пищи очень ограничены, что предопределило высокую конкуренцию за пищевые ресурсы. В ходе эволюции цихлиды разделились на три специализированные группы: первая стала просеивать песок на дне и добывая из него полезных микроорганизмов, вторая группа рыб, известная как Утака, питается мелким планктоном в толще воды, третья — самая многочисленная группа, известная под названием Мбуна, питается водорослями, растущими на поверхности камней и скал. Именно последняя группа является наиболее популярной в аквариумистике. Эти рыбки отличаются яркой окраской и интересным социальным поведением");

            string text = text0.ToString();

            string[] words = text.Split(new char[] { '.', '!', '?', '-', ':', '(', ')', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine();

            var verbs = FindVerbs(words);

            Console.WriteLine();

            FindDuplicationsCount(verbs);

            Console.WriteLine();

            text0 = ReplaceWordsShorterThan5Symbols(text0, endings, wordLength, wordBeginingIndex, myWord1, letter);
            text0 = ReplaceVerbsInText(verbs, text0, endings, wordLength, wordBeginingIndex, myWord2, letter);
            text0.ToString();

            Console.WriteLine(text0);

            Console.ReadLine();
        }

        /// <summary>
        /// Метод заменяет слова короче 5 символом другим словом
        /// </summary>
        /// <param name="words">Массив слов-строк</param>
        static void ReplaceWithMyWords(string[] words, string myWord)
        {
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length < 5)
                    words[i] = myWord;
            }
        }

        /// <summary>
        /// Метод заменяет глаголы другим словом
        /// </summary>
        /// <param name="words">Массив слов-строк</param>
        /// <param name="verbs">Массив найденных глаголов</param>
        static void ReplaceVerbs(string[] words, string[] verbs, string myWord)
        {
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < verbs.Length; j++)
                    if (words[i] == verbs[j])
                        words[i] = myWord;
            }
        }

        /// <summary>
        /// Метод считает и выводит количество повторений глаголов
        /// </summary>
        /// <param name="verbs">Массив найденных глаголов</param>
        static void FindDuplicationsCount(string[] verbs)
        {
            int counter = 0;
            for (int i = 0; i < verbs.Length; i++)
            {
                for (int j = i + 1; j < verbs.Length; j++)
                {
                    if (verbs[i] == verbs[j])
                        counter++;
                }
                Console.WriteLine("*" + verbs[i] + "*" + " duplications quantity:" + counter);
                counter = 0;
            }
        }

        /// <summary>
        /// Поиск глаголов
        /// </summary>
        /// <param name="words">Массив слов-строк</param>
        /// <returns>Массив глаголов</returns>
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
        /// Замена глаголов в тексте другим словом
        /// </summary>
        /// <param name="verbs">Массив глаголов</param>
        /// <param name="text0">Передаваемый методу текст</param>
        /// <param name="endings">Строка, содержащая знаки препинания или другие символы, сигнализирующие о конце слова</param>
        /// <param name="wordLength">Длина слова</param>
        /// <param name="wordBeginingIndex">Индекс начала слова</param>
        /// <param name="myWord">Слово, заменяющее глагол</param>
        /// <param name="letter">Переменная, хранящая анализируемый символ. Необходима для её сравнения со знаками препинания </param>
        /// <returns>Текст с замененными словами</returns>
        static StringBuilder ReplaceVerbsInText(string[] verbs, StringBuilder text0, string endings, int wordLength, int wordBeginingIndex, string myWord, string letter)
        {
            string word = "";
            for (int i = 0; i < text0.Length;)
            {
                letter = text0[i].ToString();
                while (!endings.Contains(letter))
                {
                    wordLength++;
                    i++;
                    if (i == text0.Length)
                        goto EndOfCycle;
                    letter = text0[i].ToString();
                }
                wordBeginingIndex = i - wordLength;
                for (int k = wordBeginingIndex; k < i; k++)
                    word = string.Concat(word, text0[k]);
                for (int k = 0; k < verbs.Length; k++)
                {
                    if (word.Equals(verbs[k]))
                    {
                        text0.Remove(wordBeginingIndex, wordLength);
                        text0.Insert(wordBeginingIndex, myWord);
                        i = wordBeginingIndex + wordLength;
                    }
                }
                word = "";
                letter = text0[i].ToString();
                while (endings.Contains(letter))
                {
                    i++;
                    letter = text0[i].ToString();
                }
                wordLength = 0;
                EndOfCycle:;
            }
            return text0;
        }

        /// <summary>
        /// Замена коротких слов другим словом
        /// </summary>
        /// <param name="text0">Передаваемый методу текст</param>
        /// <param name="endings">Строка, содержащая знаки препинания или другие символы, сигнализирующие о конце слова</param>
        /// <param name="wordLength">Длина слова</param>
        /// <param name="wordBeginingIndex">Индекс начала слова</param>
        /// <param name="myWord">Слово, заменяющее короткое слово</param>
        /// <param name="letter">Переменная, хранящая анализируемый символ. Необходима для её сравнения со знаками препинания </param>
        /// <returns>Текст с замененными словами</returns>
        static StringBuilder ReplaceWordsShorterThan5Symbols(StringBuilder text0, string endings, int wordLength, int wordBeginingIndex, string myWord, string letter)
        {
            for (int i = 0; i < text0.Length;)
            {
                letter = text0[i].ToString();
                while (!endings.Contains(letter))
                {
                    wordLength++;
                    i++;
                    if (i == text0.Length)
                        goto EndOfCycle;
                    letter = text0[i].ToString();
                }
                wordBeginingIndex = i - wordLength;
                if (wordLength < 5)
                {
                    text0.Remove(wordBeginingIndex, wordLength);
                    text0.Insert(wordBeginingIndex, myWord);
                    i = wordBeginingIndex + myWord.Length;
                }
                letter = text0[i].ToString();
                while (endings.Contains(letter))
                {
                    i++;
                    letter = text0[i].ToString();
                }
                wordLength = 0;
                EndOfCycle:;
            }
            return text0;
        }
    }
}