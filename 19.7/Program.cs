namespace _19._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nomi = new List<string> { "filippo", "anna", "claudio", "alessia", "mirko", "giacomo" };
            Console.WriteLine("inserisci il nome di un partecipante");
            string nome = Console.ReadLine();
            nome = nome.ToLower();
            int posizione = -1;
            for (int i = 0; i < nomi.Count; i++)
            {
                if (nomi[i] == nome)
                    posizione = i;
            }
            if(posizione==-1)
                Console.WriteLine("il nome inserito non è presente nella lista, ed è in posizione {0}");
            else
                Console.WriteLine("il nome inserito è presente nella lista, ed è in posizione {0}", posizione + 1);


        }
    }
}
