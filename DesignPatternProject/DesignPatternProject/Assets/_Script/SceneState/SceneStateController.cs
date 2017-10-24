using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneStateController {

    private ISceneState mState;
    private AsyncOperation mAO;
    private bool mIsRunedStart = false;

    public void SetState(ISceneState state,bool isLoadScene=true) {
        if (mState != null)
            mState.StateEnd();//上一个状态的清理工作
        mState = state;
        if (isLoadScene) {
            mAO = SceneManager.LoadSceneAsync(state.SceneName);
            mIsRunedStart = false;
        } else {
            mState.StateStart();
            mIsRunedStart = true;
        }
    }


    public void StateUpdate() {
        if (mAO != null && mAO.isDone != true) return;
        if (mIsRunedStart == false && mAO != null && mAO.isDone) {
            mState.StateStart();
            mIsRunedStart = true;
        }
        if (mState != null) {
            mState.StateUpdate();
        }

    }

}
