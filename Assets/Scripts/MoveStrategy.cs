using UnityEngine;

class Context
{
    private IStrategyMove _strategy;

    public Context()
    { }

    public Context(IStrategyMove strategy)
    {
        this._strategy = strategy;
    }

    public void SetStrategy(IStrategyMove strategy)
    {
        this._strategy = strategy;
    }

    public void DoSomeBusinessLogic()
    {

        this._strategy.StartMove();

    }
}


//class ConcreteStrategyA : IStrategy
//{
//    public object DoAlgorithm(object data)
//    {
//        var list = data as List<string>;
//        list.Sort();

//        return list;
//    }
//}

//class ConcreteStrategyB : IStrategy
//{
//    public object DoAlgorithm(object data)
//    {
//        var list = data as List<string>;
//        list.Sort();
//        list.Reverse();

//        return list;
//    }
//}

public class PlayerController : MonoBehaviour
{
    //static void Main(string[] args)
    //{

    //    var context = new Context();

    //    Console.WriteLine("Client: Strategy is set to normal sorting.");
    //    context.SetStrategy(new ConcreteStrategyA());
    //    context.DoSomeBusinessLogic();


    //    Console.WriteLine();

    //    Console.WriteLine("Client: Strategy is set to reverse sorting.");
    //    context.SetStrategy(new ConcreteStrategyB());
    //    context.DoSomeBusinessLogic();
    //}

    private void Start()
    {
        var context = new Context();
        //context.SetStrategy(new ConcreteStrategyA());
    }
}
