using System;
using System.Collections.Generic;
using System.Text;

public class GameFacade {
    private static GameFacade _instance = new GameFacade();
    public static GameFacade Instance { get { return _instance; } }
    private GameFacade() { }
    private bool mIsGameOver = false;
    public bool IsGameOver { get { return mIsGameOver; } }
    //成就 兵营 角色 能量 关卡 游戏事件 UI系统

    public void Init() {
    }
    public void Update() {
    }
    public void Release() {
    }

}
