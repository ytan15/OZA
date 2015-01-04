using UnityEngine;
using System.Collections;

public class UIScreenTest : MonoBehaviour {

	public Canvas uiCanvas;
	public Transform menuObject;
	public LayerMask menuOpener;
	public float openRadius = 10f;
	bool menuCanBeOpened = false;
	bool menuCurrentlyOpen = false;

	// Use this for initialization
	void Start () {
		uiCanvas.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		menuCanBeOpened = Physics2D.OverlapCircle (menuObject.position, openRadius, menuOpener);
		if (menuCanBeOpened && Input.GetKeyDown (KeyCode.E)) 	// Opening menu
		{
			uiCanvas.enabled = true;
			menuCurrentlyOpen = true;
		}
		if (menuCurrentlyOpen && Input.GetKeyDown (KeyCode.Escape)) 	//Closing menu
		{
			uiCanvas.enabled = false;
			menuCurrentlyOpen = false;
		}
	
	
	}


}
