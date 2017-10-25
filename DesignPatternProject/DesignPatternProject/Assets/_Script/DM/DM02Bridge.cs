using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//桥接模式
public class DM02Bridge : MonoBehaviour {

	void Start () {
        ICharacter character = new SoldierCaptain();
        character.Weapon = new WeaponLaser();
        character.Attack(Vector3.zero);

        
        	
	}
	
	void Update () {
		
	}
}
