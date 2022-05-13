using System;
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
        this._strategy.Moving();
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

public class StrategyMovementController : MonoBehaviour
{
    [SerializeField] private HandController handController;
    [SerializeField] public AutoPilotController autoPilotTractor;
    [SerializeField] private InputController inputController;
    Context context = new Context();


    private void Start()
    {
        Initialize();
    }

    private void Initialize()
    {
        context.SetStrategy(handController);
        inputController.OnAotoPilotSwitchGetKey += SetAutoPilotStrategy;
        inputController.OnWASDGetKey += SetHandPilotStrategy;
    }

    private void SetHandPilotStrategy()
    {
        context.SetStrategy(handController);
    }

    private void SetAutoPilotStrategy()
    {
        context.SetStrategy(autoPilotTractor);        
    }

    private void OnDestroy()
    {
        inputController.OnAotoPilotSwitchGetKey -= SetAutoPilotStrategy;
        inputController.OnWASDGetKey -= SetHandPilotStrategy;
    }

    private void Update()
    {
        context.DoSomeBusinessLogic();
    }
}
