using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DM01State : MonoBehaviour {

    Context context = new Context();
    private void Start() {
        context.ChangeState(new StateA(context));
        context.Handler(8);
        context.Handler(10);
        context.Handler(11);
        context.Handler(12);
        context.Handler(3);
    }
}


public class Context {
    private IState state;

    public void SetState(IState newState,int value) {
        if (state != null)
            state.StateEnd();
        state = newState;
        state.StateStart(value);
    }

    public void Handler(int value) {
        state.Handler(value);
    }
    public void ChangeState(IState state) {
        this.state = state;
    }

}



public class IState {
    protected Context context;
    public virtual void StateStart(int value) { }
    public virtual void StateEnd() { }
    public virtual void StateUpdate() { }

    public  IState(Context context) { this.context = context; }
    public virtual void Handler(int value) { }
}

public class StateA : IState {
    public  StateA(Context context) : base(context) {
        this.context = context;
    }

    public override void Handler(int value) {
        Debug.Log("StateA " + value);
        if (value > 10) {
            context.ChangeState(new StateB(this.context));
        }
    }
}
public class StateB : IState {
    public StateB(Context context) : base(context) {
        this.context = context;
    }

    public override void Handler(int value) {
        Debug.Log("StateB " + value);
        if (value <= 10) {
            context.ChangeState(new StateA(this.context));
        }
    }
}