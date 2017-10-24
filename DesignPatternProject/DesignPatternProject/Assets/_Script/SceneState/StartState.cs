using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartState : ISceneState {
    public StartState( SceneStateController controller) : base("01StartScene", controller) {
    }

    private Image mlogo;
    private float mSmoothingSpeed = 1;
    private float mWaitTime = 2;

    public override void StateStart() {
        mlogo = GameObject.Find("Logo").GetComponent<Image>();
        mlogo.color = Color.black;
    }

    public override void StateUpdate() {
        mlogo.color = Color.Lerp(mlogo.color, Color.white, mSmoothingSpeed * Time.deltaTime);
        mWaitTime -= Time.deltaTime;
        if (mWaitTime < 0) {
            mController.SetState(new MainSceneState(mController));
        }
    }

}
