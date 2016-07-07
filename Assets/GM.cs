using UnityEngine;
using System.Collections;

public class GM : MonoBehaviour {

	public Texture2D cursorTexture;
	//public Color cursorColor;
	public CursorMode cursorMode = CursorMode.Auto;
	public Vector2 hotSpot = Vector2.zero;


	// Use this for initialization
	void Start () 
	{
		Cursor.SetCursor (cursorTexture, hotSpot, cursorMode);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
