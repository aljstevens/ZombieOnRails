using UnityEngine;
using System.Collections;

public class RayCast : MonoBehaviour {

	Ray ray;
	RaycastHit hit;
	public float Health=10f;
	public bool PlayerIsAttacked;

	private Gun gun;
	public GameObject Player;
	private Shot shot;
	private GameObject Enemy;

	// Use this for initialization
	void Awake () 
	{
		if (Player == null)
		{
			Player = GameObject.FindWithTag ("Player");
		}

		if (gun == null)
		{
			gun = Player.GetComponent <Gun> ();
		}
	}
		

	// Use this for initialization
	void Start () {
	
	}
	
	void Update() {
		ray=Camera.main.ScreenPointToRay(Input.mousePosition);

		if(Physics.Raycast(ray,out hit))
		{
			
			if (Input.GetButtonDown ("Fire1") && gun.GunLoaded == true)
			{

				if (hit.transform.tag == ("Soldier"))
				{
					Debug.Log ("HitFriendly");
				}

				if (hit.transform.tag == ("Barrel"))
				{
					Debug.Log ("Boom");
				}

				if (hit.transform.tag == ("Enemy"))
					{
						Debug.Log ("LOL");
						Enemy =	hit.collider.gameObject;
						shot = Enemy.GetComponent <Shot> ();
						shot.Health -= gun.GunDamageAmount;
					}

			}
	}
}
}