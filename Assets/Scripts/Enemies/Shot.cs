using UnityEngine;
using System.Collections;

public class Shot : MonoBehaviour {
	
	public float Health=10f;
	public float CurrentHealth;
	public bool PlayerIsAttacked;

	public GameObject Blood;

//	private Gun gun;
//	public GameObject Player;
//
	// Use this for initialization
	void Awake () 
	{
		CurrentHealth = Health;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (CurrentHealth != Health) 
		{
			Instantiate(Blood, gameObject.transform.position, gameObject.transform.rotation);
			CurrentHealth = Health;

		}
	}
//
//	void OnMouseDown()
//	{
//		if (gun.GunLoaded == true) 
//		{
//			Debug.Log ("Clicked");
//			Health -= gun.GunDamageAmount;
//		}
//	}

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == ("Boom")) 
		{
			Health = 0f;
		}
	}
}
