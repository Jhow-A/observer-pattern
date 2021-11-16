// See https://aka.ms/new-console-template for more information

using ObserverPattern;

var iPhone = new ConcreteSubject("Phone 11 ", 4900, "Sem Estoque");

Console.WriteLine("Phone 11: " + iPhone.GetDisponibilidade());

var jhow = new ConcreteObserver("Jhonathan", iPhone);
var matheus = new ConcreteObserver("Matheus", iPhone);
var lucas = new ConcreteObserver("Lucas", iPhone);

Console.Write(Environment.NewLine);

iPhone.SetDisponibilidade("Disponível");
