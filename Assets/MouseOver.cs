using UnityEngine;
using System.Collections;

public class MouseOver : MonoBehaviour {

	public CursorMode cursorMode = CursorMode.Auto;
	public Vector2 hotSpot = Vector2.zero;
	public Texture2D cursorTexture;

	public GameObject Area;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseEnter ()
	{
		if (Area.activeSelf == false)
		{
			Cursor.SetCursor (cursorTexture, hotSpot, cursorMode);
		}
	}

	void OnMouseExit ()
	{
		if (Area.activeSelf == false) 
		{
			Cursor.SetCursor (null, hotSpot, cursorMode);
		}
	}
}
