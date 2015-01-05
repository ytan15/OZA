using UnityEngine;
using System.Collections;

public class MusicMenuScript : MonoBehaviour {

	public Canvas mainCanvas;
	public Canvas musicMenuCanvas;
	public Canvas instrumentsMenuCanvas;
	public Canvas scalesMenuCanvas;
	public Canvas songsMenuCanvas;
	public Transform menuObject;
	public LayerMask menuOpener;
	public float openRadius = 0.25f;
	bool menuCanBeOpened = false;
	bool menuCurrentlyOpen = false;

	// Use this for initialization
	void Start () {
		KillAllMenus ();
	}
	
	// Update is called once per frame
	void Update () {
		menuCanBeOpened = Physics2D.OverlapCircle (menuObject.position, openRadius, menuOpener);
		if (menuCanBeOpened && Input.GetKeyDown (KeyCode.E)) 	// Opening menu
		{
			KillAllMenus ();	//Ensures a fresh menu state
			mainCanvas.enabled = true;
			musicMenuCanvas.enabled = true;
			menuCurrentlyOpen = true;
		}
		if (menuCurrentlyOpen && Input.GetKeyDown (KeyCode.Escape)) 	//Closing menu
		{
			KillAllMenus ();
		}
	
	
	}
	public void KillAllMenus () {
		mainCanvas.enabled = false;
		musicMenuCanvas.enabled = false;
		instrumentsMenuCanvas.enabled = false;
		scalesMenuCanvas.enabled = false;
		songsMenuCanvas.enabled = false;
		menuCurrentlyOpen = false;
	}

}
