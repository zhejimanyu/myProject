using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.AI;

public abstract class ICharacter {

    protected ICharacterAttr mAttr;
    protected GameObject mGameObject;
    protected NavMeshAgent mNavAgent;
    protected AudioSource mAudio;

    private IWeapon weapon;
    public IWeapon Weapon { set { weapon = value; } }

    public virtual void Attack(Vector3 targetPos) {
        weapon.Fire(targetPos);
    }

}
