using System.Collections;

namespace ConsoleUI
{
    public class ListCommand : ICommand
    {
        public string Name { get { return "list"; } }
        public string Help { get { return "выводит список фигур на картинке"; } }
        public string Description { get { return "Выводит список Прям Всех Фигур. Прям прям."; } }
        public string[] Synonyms { get { return new string[2] {"printAll", "show"}; } }
        public void Execute(params string[] parameters)
        {
            IList<Shapes>
        }
    }
}