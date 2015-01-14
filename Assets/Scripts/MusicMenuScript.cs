using UnityEngine;
using System.Collections;

public class MusicMenuScript : MonoBehaviour {

	public Canvas mainCanvas;				//All of the different menu sections are divided based on their canvas.
	public Canvas musicMenuCanvas;
	public Canvas instrumentsMenuCanvas;
	public Canvas scalesMenuCanvas;
	public Canvas songsMenuCanvas;
	public Transform menuObject;			//The item that opens the menu
	public LayerMask menuOpener;			//Player
	public float openRadius = 0.25f;		//How close the player must be
	bool menuCanBeOpened = false;
	bool menuCurrentlyOpen = false;

	public AudioClip clickSound;
	public AudioClip menuOpenSound;
	public AudioClip menuCloseSound;

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
			MenuOpenSound ();
			menuCurrentlyOpen = true;
		}
		if (menuCurrentlyOpen && Input.GetKeyDown (KeyCode.Escape)) 	//Closing menu
		{
			KillAllMenus ();
			MenuCloseSound ();
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
	public void ClickSound () {
		AudioSource.PlayClipAtPoint (clickSound, menuObject.position);
	}
	public void MenuOpenSound () {
		AudioSource.PlayClipAtPoint (menuOpenSound, menuObject.position);
	}
	public void MenuCloseSound () {
		AudioSource.PlayClipAtPoint (menuCloseSound, menuObject.position);
	}


}
