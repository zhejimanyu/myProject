using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class WeaponGan : IWeapon {

    public override void Fire(Vector3 targetPos) {
        Debug.Log("播放特效 Gun");
        Debug.Log("播放声音 Gun");
    }

}
