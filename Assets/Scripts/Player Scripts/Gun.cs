using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {

	public bool GunLoaded = true;
	public float GunDamageAmount;
	public float ActiveAmmo = 12f;
	public float HandGunAmmoPool = 48f;
	public bool UsingHandGun = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (ActiveAmmo <= 0)
		{
			GunLoaded = false;
		}

		if (ActiveAmmo >= 1)
		{
			GunLoaded = true;
		}

		if (ActiveAmmo <= 0 && UsingHandGun == true && HandGunAmmoPool >=12)
		{
			ActiveAmmo = 12f;
			HandGunAmmoPool -= 12f;
		}

		if (ActiveAmmo <= 0 && UsingHandGun == true && HandGunAmmoPool <=11)
		{
			ActiveAmmo = HandGunAmmoPool;
			HandGunAmmoPool = 0f;
		}

		if (UsingHandGun == true)
		{
			GunDamageAmount = 5f;
		}
	
		if (Input.GetButtonDown ("Fire1"))
		{
			ActiveAmmo -=1;
		}

	}

//	void OnMouseDown()
//	{
//			Debug.Log ("Clicked2");
//
//		}
}
