using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class WeaponLaser : IWeapon {
    public override void Fire(Vector3 targetPos) {
        Debug.Log("播放特效 Laser");
        Debug.Log("播放声音 Laser");
    }
}
