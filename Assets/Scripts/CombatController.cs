using UnityEngine;
using System.Collections;

public class CombatController : MonoBehaviour {

	//                      C   C#  D   D#  E   F   F#  G   G#  A    A#   B    C    C#   D    D#   E    F    F#   G    G#   A    A#   B    C
	//float[] noteValues = {1f, 2f, 3f, 4f, 5f, 6f, 7f, 8f, 9f, 10f, 11f, 12f, 13f, 14f, 15f, 16f, 17f, 18f, 19f, 20f, 21f, 22f, 23f, 24f. 25f};
	// This was supposed to be useful until I decided it was stupid. Now it's just a good reference.

	// Basic C scale comes preloaded here
	public float noteFirst = 1f;
	public float noteSecond = 3f;
	public float noteThird = 5f;
	public float noteFourth = 6f;
	public float noteFifth = 8f;
	public float noteSixth = 10f;
	public float noteSeventh = 12f;
	public float noteEighth = 13f;
	public float noteNinth = 15f;

	public bool ninthUnlocked = false; //Has the player unlocked the use of nine notes?


	public float songValue; //The variable that tracks the current value of your song.
	bool canPlay = true; //Checks if you are currently allowed to play.
	public int notesPlayed; //For use in the randomizer array
	float[] randomNumbers = {1f, 3f, 4f, 6f, 7f, 6f, 3f, 3f, 7f, 3f, 8f, 6f, 9f, 3f, 9f, 7f, 2f, 6f, 2f, 7f, 1f, 6f, 9f, 2f, 7f, 4f, 3f, 6f, 8f};	//A stupid 28 array

	public Rigidbody2D musicNoteSm; //All variables used to fire physical notes.
	Rigidbody2D noteSmInstance;
	public Transform noteOrigin;
	public Transform heWhoShoots;




	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// All of the keys that can be played are below, referencing the currently active scale
		if (canPlay && Input.GetKeyDown (KeyCode.Keypad1))
		{
			songValue += (noteFirst * randomNumbers[notesPlayed]) + Mathf.Pow(notesPlayed,2);
			notesPlayed++;
			FireSm ();
		}
		if (canPlay && Input.GetKeyDown (KeyCode.Keypad2))
		{
			songValue += (noteSecond * randomNumbers[notesPlayed]) + Mathf.Pow(notesPlayed,2);
			notesPlayed++;
			FireSm ();
		}
		if (canPlay && Input.GetKeyDown (KeyCode.Keypad3))
		{
			songValue += (noteThird * randomNumbers[notesPlayed]) + Mathf.Pow(notesPlayed,2);
			notesPlayed++;
			FireSm ();
		}
		if (canPlay && Input.GetKeyDown (KeyCode.Keypad4))
		{
			songValue += (noteFourth * randomNumbers[notesPlayed]) + Mathf.Pow(notesPlayed,2);
			notesPlayed++;
			FireSm ();
		}
		if (canPlay && Input.GetKeyDown (KeyCode.Keypad5)) 
		{
			songValue += (noteFifth * randomNumbers[notesPlayed]) + Mathf.Pow(notesPlayed,2);
			notesPlayed++;
			FireSm ();
		}
		if (canPlay && Input.GetKeyDown (KeyCode.Keypad6))
		{
			songValue += (noteSixth * randomNumbers[notesPlayed]) + Mathf.Pow(notesPlayed,2);
			notesPlayed++;
			FireSm ();
		}
		if (canPlay && Input.GetKeyDown (KeyCode.Keypad7))
		{
			songValue += (noteSeventh * randomNumbers[notesPlayed]) + Mathf.Pow(notesPlayed,2);
			notesPlayed++;
			FireSm ();
		}
		if (canPlay && Input.GetKeyDown (KeyCode.Keypad8))
		{
			songValue += (noteEighth * randomNumbers[notesPlayed]) + Mathf.Pow(notesPlayed,2);
			notesPlayed++;
			FireSm ();
		}	
		if (ninthUnlocked && canPlay && Input.GetKeyDown (KeyCode.Keypad9))	//Extra note
		{
			songValue += (noteNinth * randomNumbers[notesPlayed]) + Mathf.Pow(notesPlayed,2);
			notesPlayed++;
			FireSm ();
		}	

		if (Input.GetKeyDown (KeyCode.Keypad0)) //Reset button
		{
			notesPlayed = 0;
			songValue = 0;
		}

		if (notesPlayed >= 29) //Resets the randomness array.
			notesPlayed = 0;





	
	}

	void FireSm () {
		noteSmInstance = Instantiate(musicNoteSm, noteOrigin.position, noteOrigin.rotation) as Rigidbody2D;
		noteSmInstance.velocity = new Vector2 ((heWhoShoots.localScale.x * 4), 0);

	}


}
