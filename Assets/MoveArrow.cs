using UnityEngine;
using System.Collections;

public class MoveArrow : MonoBehaviour {

	public GameObject Player;
	public Transform target;
	public GameObject LastAreaClear;

	public bool Used;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Used == true) 
		{
			Player.transform.position = Vector3.MoveTowards (Player.transform.position, target.transform.position, .1f);
		}
	}

	void OnMouseDown()
	{
		Used = true;
		LastAreaClear.SetActive (false);
		Debug.Log ("Arrowed");
	}
}
