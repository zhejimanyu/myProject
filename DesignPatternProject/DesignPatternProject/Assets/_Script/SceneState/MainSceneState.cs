using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainSceneState : ISceneState {
    public MainSceneState(SceneStateController controller) : base("02MainMenuScene", controller) {
    }

    public override void StateStart() {
        base.StateStart();
        GameObject.Find("StartGameButton").GetComponent<Button>().onClick.AddListener(OnStartButtonClick);
    }

    private void OnStartButtonClick() {
        mController.SetState(new BattleState(mController));
    }
}

