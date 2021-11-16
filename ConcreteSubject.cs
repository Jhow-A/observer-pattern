namespace ObserverPattern
{
    public class ConcreteSubject : ISubject
    {
        private readonly List<IObserver> observers = new List<IObserver>();

        private string Produto { get; }
        private int Preco { get; }
        private string Disponibilidade { get; set; }

        public ConcreteSubject(string produto, int preco, string status)
        {
            Produto = produto;
            Preco = preco;
            Disponibilidade = status;
        }

        public string GetDisponibilidade() => Disponibilidade;

        public void SetDisponibilidade(string status)
        {
            this.Disponibilidade = status;
            Console.WriteLine("A disponibilidade mudou de 'Sem Estoque' para 'Disponível'\n");
            NotificarObservers();
        }

        public void RegistrarObserver(IObserver observer)
        {
            Console.WriteLine("Observer Adicionado: " + ((ConcreteObserver)observer).Usuario);
            observers.Add(observer);
        }

        public void AdicionarObservers(IObserver observer) => observers.Add(observer);
        
        public void RemoverObserver(IObserver observer) => observers.Remove(observer);
        
        public void NotificarObservers()
        {
            Console.WriteLine($"Notificação sendo enviada: {Produto} no valor de R$ {Preco} agora esta disponível\n");

            foreach (IObserver observer in observers)
                observer.Atualizar(Disponibilidade);
        }
    }
}
