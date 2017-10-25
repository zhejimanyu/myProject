using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public abstract class IWeapon {

    protected int mAtk;
    protected float mtkRange;
    protected int mAtkPlusValue;

    protected GameObject mGameObject;
    protected ICharacter mOwner;
    protected ParticleSystem mPariticle;
    protected LineRenderer mLine;
    protected Light mLight;
    protected AudioSource mAudio;


    public abstract void Fire(Vector3 targetPos);
}
