using UnityEngine;
using System.Collections;

public class ClearArea : MonoBehaviour {

	public float EnemyCount;
	public GameObject MoveArrows;
	public GameObject Player;
	public Transform target;
	public GameObject LastMover;

	public float TravelTime =1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (EnemyCount <= 0) 
		{
			LastMover.SetActive (false);
			Player.transform.position = Vector3.MoveTowards (Player.transform.position, target.transform.position, .1f);
		}
	}

	void FixedUpdate ()
	{
		if (EnemyCount <= 0 && TravelTime >= 0)
		{
			TravelTime -= Time.deltaTime;
		}

		if (TravelTime <= 0)
		{
			MoveArrows.SetActive (true);
		}
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "Counter")
		{
			EnemyCount += 1;
			other.gameObject.tag = ("Counted");
		}
	}
		
}
