using System;

namespace StringTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            String Text = "Цихлиды, населяющие озеро Малави(Ньяса), появились в нём сравнительно недавно, всего миллион лет назад, куда прибыли из другого крупного озера - Танганьики.Некоторое время эти озёра были соединены речным каналом, образовавшемся в результате тектонических сдвигов. По мнению учёных, с момента появления канала в него устремилось множество видов рыб, однако, добраться до Малави смог всего один вид цихлид.Далее произошло эволюционное событие, не имевшее аналогов в животном мире." +
                "За несколько сотен тысяч лет из одного единственного вида образовалось более 500 новых видов! Причём процесс видообразования продолжается и сейчас."
                + "Практически все из них являются эндемиками и не встречаются более нигде.Успех этих цихлид объясняется необычным способом защиты мальков, появившимся впервые ещё в озере Танганьика. В период нереста рыбки откладывают от нескольких десятков до сотен икринок. После оплодотворения самка сразу забирает их себе в рот, где и происходит дальнейшее развитие.Появившиеся мальки всегда держаться рядом с родителями и в случае опасности тут же прячутся обратно в безопасное место - во рту." +
                "Озеро Малави находится в рифтовой долине на Востоке Африки и представляет собой водоём, заполнивший глубокую трещину на поверхности земли. К примеру, такое же происхождение имеет Байкал. Дно озера завалено осадочными породами(песок, камни), а береговая линия сочетает в себе пологие склоны и скальные нагромождения.Основой экосистемы является фито и зоопланктон, тем не менее, источники пищи очень ограничены, что предопределило высокую конкуренцию за пищевые ресурсы. В ходе эволюции цихлиды разделились на три специализированные группы: первая стала просеивать песок на дне и добывая из него полезных микроорганизмов, вторая группа рыб, известная как Утака, питается мелким планктоном в толще воды, третья — самая многочисленная группа, известная под названием Мбуна, питается водорослями, растущими на поверхности камней и скал. Именно последняя группа является наиболее популярной в аквариумистике. Эти рыбки отличаются яркой окраской и интересным социальным поведением";

            String text1 = Text;

            //Печать текста удобным для чтения
            String[] Array1 = Text.Split(new char[] { '.', '!' });
            for (int i = 0; i < Array1.Length; i++)
            {
                Console.WriteLine(Array1[i]);
            }

            Console.WriteLine();

            ProcessingText(Text);

            String[] Array = Text.Split(new char[] { ' ' });

            LookingForVerbs(Array, 0);

            Sorting(Array, 0);

            Console.WriteLine();

            DuplicationsCheck(Array, 0);

            Console.WriteLine();

            ReplacingWithMyWords(Array1, ref text1, Array, 0);

            Console.WriteLine(text1);

            Console.ReadLine();
        }

        static void Sorting(String[] Array, int j)
        {

            string Temp;
            for (int i = 0; i < Array.Length - 1; i++)
            {
                if (Array[i] == null && i < Array.Length - 1)
                {
                    for (j = i + 1; Array[j] == null && j < Array.Length - 1; j++)
                    {
                    }
                    if (Array[j] != null)
                    {
                        Temp = Array[i];
                        Array[i] = Array[j];
                        Array[j] = Temp;
                    }
                }
            }
        }

        static void ReplacingWithMyWords(String[] Array1, ref String text1, String[] Array, int j)
        {
            Array1 = text1.Split(new char[] { ' ' });
            for (int i = 0; Array[i] != null; i++)
            {
                for (j = 0; j < Array1.Length; j++)
                {
                    if (Array1[j].Contains(Array[i]))
                    { Array1[j] = "Уточка"; }
                }
            }
            for (int i = 0; i < Array1.Length; i++)
            {
                if (Array1[i].Length < 5)
                { Array1[i] = "ЗЛО"; }
            }
            text1 = String.Join(" ", Array1);
        }

        static void DuplicationsCheck(String[] Array, int j)
        {
            int Counter = 0;
            for (int i = 0; Array[i] != null; i++)
            {
                for (j = i + 1; Array[j] != null; j++)
                {
                    if (Array[i].Equals(Array[j]))
                    {
                        Counter++;
                    }
                }
                Console.WriteLine("*" + Array[i] + "*" + " duplications quantity:" + Counter);
                Counter = 0;
            }
        }

        static void ProcessingText(String Text)
        {
            Text = Text.Replace(".", " ");
            Text = Text.Replace("!", " ");
            Text = Text.Replace("?", " ");
            Text = Text.Replace(",", " ");
            Text = Text.Replace("-", " ");
            Text = Text.Replace(":", " ");
            Text = Text.Replace("(", " ");
            Text = Text.Replace(")", " ");
            Text = Text.Replace("  ", " ");
            Text = Text.Replace("   ", " ");
            Text = Text.ToLower();
        }

        static void LookingForVerbs(String[] Array, int j)
        {
            bool Flag = false;
            String[] End = { "сь", "ыли", "ось", "ло", "тся", "ться", "ают", "ает", "ит", "яет", "яют", "еет", "еют", "ивать" };
            for (int i = 0; i < Array.Length; i++)
            {
                for (j = 0; j < End.Length; j++)
                {
                    if (Array[i].EndsWith(End[j]))
                    {
                        Console.WriteLine(Array[i]);
                        Flag = true;
                        break;

                    }
                }
                if (Flag == false)
                {
                    Array[i] = null;
                }
                Flag = false;
            }
        }
    }
}
