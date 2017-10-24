using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoop : MonoBehaviour {

    private SceneStateController mController;

    private void Awake() {
        DontDestroyOnLoad(this.gameObject);
    }
    private void Start() {
        mController = new SceneStateController();
        mController.SetState(new StartState(mController), false);
    }
    private void Update() {
        if (mController != null)
            mController.StateUpdate();
    }


}
