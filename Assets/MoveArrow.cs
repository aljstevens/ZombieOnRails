using UnityEngine;
using System.Collections;

public class MoveArrow : MonoBehaviour {

	public GameObject Player;
	public Transform target;
	public Transform target2;
	public GameObject LastAreaClear;

	public bool Used;
	public float MoveTime=4f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Used == true && MoveTime >= 0) 
		{
			Player.transform.LookAt (target.transform);
			Player.transform.position = Vector3.MoveTowards (Player.transform.position, target.transform.position, .1f);
		}

		if (MoveTime <= 0 && target2 != null)
		{
			Player.transform.LookAt (target2.transform);
			Player.transform.position = Vector3.MoveTowards (Player.transform.position, target2.transform.position, .1f);
		}
	}

	void OnMouseDown()
	{
		Used = true;
		LastAreaClear.SetActive (false);
		Debug.Log ("Arrowed");
	}

	void FixedUpdate ()
	{
		if (Used == true) 
		{
			MoveTime -= Time.deltaTime; 
		}
	}
}
