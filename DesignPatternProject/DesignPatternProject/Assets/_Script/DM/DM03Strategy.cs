using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//策略模式
public class DM03Strategy : MonoBehaviour {

    private void Start() {
        StrategyContext context = new StrategyContext();
        context.strategy = new ConcretateStrategyB();
        context.UseStrategyCal();
    }
}


public class StrategyContext {
    public IStrategy strategy;

    public void UseStrategyCal() {
        strategy.Cal();
    }
}

public abstract class IStrategy {
    public abstract void Cal();
}
public class ConcretateStrategyA : IStrategy {
    public override void Cal() {
        Debug.Log("使用策略A");
    }
}
public class ConcretateStrategyB : IStrategy {
    public override void Cal() {
        Debug.Log("使用策略B");
    }
}