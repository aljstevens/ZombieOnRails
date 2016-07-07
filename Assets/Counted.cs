using UnityEngine;
using System.Collections;

public class Counted : MonoBehaviour {

	private Shot shot;
	public GameObject Clearer;
	private ClearArea cleararea;
	private bool Used;

	// Use this for initialization
	void Awake () 
	{
		shot = GetComponentInParent <Shot> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (gameObject.tag == ("Counted") && shot.Health <= 0 && Used == false)
			{
				cleararea.EnemyCount -= 1;
				Used = true;
			}
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == ("Clearer") && Clearer == null)
		{
			Clearer = other.gameObject;
			cleararea = Clearer.GetComponent <ClearArea> ();

		}
	}
}
