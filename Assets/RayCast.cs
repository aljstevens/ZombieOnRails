using UnityEngine;
using System.Collections;

public class RayCast : MonoBehaviour {

	Ray ray;
	RaycastHit hit;

	// Use this for initialization
	void Start () {
	
	}
	
	void Update() {
		ray=Camera.main.ScreenPointToRay(Input.mousePosition);

		if(Physics.Raycast(ray,out hit))
		{

			//if(Input.GetKey(KeyCode.Mouse0) && Reloading == true)
			if (Input.GetButtonDown ("Fire1"))
			{
				if (hit.transform.tag == ("Soldier"))
				{
					Debug.Log ("HitFriendly");
				}

				if (hit.transform.tag == ("Enemy"))
					{
						Debug.Log ("LOL");
					}

			}
	}
}
}