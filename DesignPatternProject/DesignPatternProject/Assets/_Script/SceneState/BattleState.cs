using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleState : ISceneState {
    public BattleState(SceneStateController controller) : base("03BattleScene", controller) {
    }
    public override void StateStart() {
        Debug.Log("进入了BattleScene");
    }
    public override void StateUpdate() {
    }

    public override void StateEnd() {
     
    }
}
