using UnityEngine;
using System.Collections;

public class Life1 : MonoBehaviour {

	public float GunShot =2;

	private float ObjectX;
	private float ObjectZ;
	private float ObjectY;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		GunShot -= Time.deltaTime; 
		ObjectX = transform.position.x;
		ObjectZ = transform.position.z;
		ObjectY = transform.position.y;
		transform.localPosition = new Vector3(ObjectX, ObjectY +.3f, ObjectZ);

		if (GunShot <= 0) 
		{
			Destroy (gameObject);
		}
	}
}
