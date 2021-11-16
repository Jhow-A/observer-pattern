namespace ObserverPattern
{
    public class ConcreteObserver : IObserver
    {
        public string Usuario { get; set; }

        public ConcreteObserver(string nome, ISubject subject)
        {
            Usuario = nome;
            subject.RegistrarObserver(this);
        }

        public void Atualizar(string disponibilidade) => 
            Console.WriteLine($"Olá {Usuario}: o produto que você deseja agora está {disponibilidade}");
    }
}
