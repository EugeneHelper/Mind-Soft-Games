//using UnityEngine;
//// Интерфейс Стратегии объявляет операции, общие для всех поддерживаемых
//// версий некоторого алгоритма.
////
//// Контекст использует этот интерфейс для вызова алгоритма, определённого
//// Конкретными Стратегиями.


//// Конкретные Стратегии реализуют алгоритм, следуя базовому интерфейсу
//// Стратегии. Этот интерфейс делает их взаимозаменяемыми в Контексте.
////class ConcreteStrategyA : IStrategy
////{
////    public object DoAlgorithm(object data)
////    {
////        var list = data as List<string>;
////        list.Sort();

////        return list;
////    }
////}

////class ConcreteStrategyB : IStrategy
////{
////    public object DoAlgorithm(object data)
////    {
////        var list = data as List<string>;
////        list.Sort();
////        list.Reverse();

////        return list;
////    }
////}

//public class PlayerController : MonoBehaviour
//{
//    static void Main(string[] args)
//    {
//        // Клиентский код выбирает конкретную стратегию и передаёт её в
//        // контекст. Клиент должен знать о различиях между стратегиями,
//        // чтобы сделать правильный выбор.
//        var context = new Context();

//        Console.WriteLine("Client: Strategy is set to normal sorting.");
//        context.SetStrategy(new ConcreteStrategyA());
//        context.DoSomeBusinessLogic();


//        Console.WriteLine();

//        Console.WriteLine("Client: Strategy is set to reverse sorting.");
//        context.SetStrategy(new ConcreteStrategyB());
//        context.DoSomeBusinessLogic();
//    }
//}
//}