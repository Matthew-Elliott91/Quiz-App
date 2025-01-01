namespace Small_Quiz_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question[] questions = new Question[]
            {
                new Question(
                    "What is the capital of Germany?",
                    new string[] {"Paris", "Berlin", "London", "Madrid" },
                    1
                    ),
                new Question(
                    "Which European river flows through the most cities?",
                    new string[] {"The Danube", "The Rhine", "The Seine", "The Volga" },
                    0
                    ),
                new Question(
                    "What is the largest island in Europe?",
                    new string[] {"Great Britain", "Iceland", "Sicily", "Ireland" },
                    0
                    ),
                new Question(
                    "Which country borders both the Adriatic Sea and the Ionian Sea?",
                    new string[] {"Croatia", "Albania", "Montenegro", "Greece" },
                    1
                    ),
                new Question(
                    "What is the tallest mountain in Europe?",
                    new string[] {"Mont Blanc", "Matterhorn", "Mount Kazbek", "Mount Elbrus" },
                    3
                    ),
                new Question(
                    "Which European country has the most UNESCO World Heritage Sites?",
                    new string[] {"Spain", "UK", "Italy", "France" },
                    2
                    ),
                new Question(
                   "Which European country is known as the Land of a Thousand Lakes?",
                    new string[] {"Norway", "Finland", "Sweden", "Estonia" },
                    1
                    ),
                new Question(
                    "What is the smallest country in Europe by land area?",
                    new string[] {"Monaco", "Vatican City", "San Marino", "Liechtenstein" },
                    1
                    ),
                new Question(
                    "Which European capital city is built on 14 islands?",
                    new string[] {"Copenhagen", "Oslo", "Stockholm", "Helsinki" },
                    2
                    ),
                new Question(
                    "Which sea separates Europe from Africa?",
                    new string[] {"Black Sea", "Mediterranean Sea", "Adriatic Sea", "Aegean Sea" },
                    1
                    ),
                new Question(
                    "Which country shares the longest border with France?",
                    new string[] {"Spain", "Italy", "Germany", "Belgium" },
                    0
                    ),
                new Question(
                    "Which is the largest lake in Europe?",
                    new string[] {"Lake Geneva", "Lake Balaton", "Lake Vänern", "Lake Ladoga" },
                    3
                    ),
                new Question(
                    "What is the official currency of Denmark?",
                    new string[] {"Euro", "Danish Kroner", "Swedish Krona", "Norwegian Krone" },
                    1
                    ),
                new Question(
                    "Which country is nicknamed 'The Emerald Isle'?",
                    new string[] {"Ireland", "Scotland", "Wales", "Iceland" },
                    0
                    ),
                new Question(
                    "What is the longest river in Europe?",
                    new string[] {"Danube", "Volga", "Rhine", "Dnieper" },
                    1
                    ),
                new Question(
                    "What is the capital of Hungary?",
                    new string[] {"Bucharest", "Belgrade", "Budapest", "Bratislava" },
                    2
                    ),
                new Question(
                    "Which European country is famous for its tulips and windmills?",
                    new string[] {"Belgium", "Netherlands", "Denmark", "Austria" },
                    1
                    ),
                new Question(
                    "Which European mountain range forms a natural border between France and Spain?",
                    new string[] {"The Alps", "The Pyrenees", "The Carpathians", "The Apennines" },
                    1
                    ),
                new Question(
                    "Which European country has the highest population?",
                    new string[] {"Germany", "France", "Italy", "United Kingdom" },
                    0
                    ),
                new Question(
                    "Which Mediterranean island is shared between Greece and Turkey?",
                    new string[] {"Sicily", "Cyprus", "Crete", "Malta" },
                    1
                    ),



            };

          

            

            Quiz myQuiz = new Quiz(questions);
            myQuiz.StartQuiz();
        }
    }
}






