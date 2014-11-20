using UnityEngine;
using System.Collections;

public class CombatController : MonoBehaviour {

	public float songValue;
	bool canPlay = true;
	public int notesPlayed;
	float[] randomNumbers = {1f, 3f, 4f, 6f, 7f, 6f, 3f, 3f, 7f, 3f, 8f, 6f, 9f, 3f, 9f, 7f, 2f, 6f, 2f, 7f, 1f, 6f, 9f, 2f, 7f, 4f, 3f, 6f, 8f};	//A stupid 28 array

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (canPlay && Input.GetKeyDown (KeyCode.Keypad1))  //C
		{
			songValue += (1 * randomNumbers[notesPlayed]) + Mathf.Pow(notesPlayed,2);
			notesPlayed++;
		}
	if (canPlay && Input.GetKeyDown (KeyCode.Keypad2))	//D
		{
			songValue += (2 * randomNumbers[notesPlayed]) + Mathf.Pow(notesPlayed,2);
			notesPlayed++;
		}
	if (canPlay && Input.GetKeyDown (KeyCode.Keypad3))  //E
		{
			songValue += (3 * randomNumbers[notesPlayed]) + Mathf.Pow(notesPlayed,2);
			notesPlayed++;
		}
	if (canPlay && Input.GetKeyDown (KeyCode.Keypad4))	//F
		{
			songValue += (4 * randomNumbers[notesPlayed]) + Mathf.Pow(notesPlayed,2);
			notesPlayed++;
		}
	if (canPlay && Input.GetKeyDown (KeyCode.Keypad5))  //G
		{
			songValue += (5 * randomNumbers[notesPlayed]) + Mathf.Pow(notesPlayed,2);
			notesPlayed++;
		}
	if (canPlay && Input.GetKeyDown (KeyCode.Keypad6))	//A
		{
			songValue += (6 * randomNumbers[notesPlayed]) + Mathf.Pow(notesPlayed,2);
			notesPlayed++;
		}
	if (canPlay && Input.GetKeyDown (KeyCode.Keypad7))  //B
		{
			songValue += (7 * randomNumbers[notesPlayed]) + Mathf.Pow(notesPlayed,2);
			notesPlayed++;
		}
	if (canPlay && Input.GetKeyDown (KeyCode.Keypad8))	//High C
		{
			songValue += (8 * randomNumbers[notesPlayed]) + Mathf.Pow(notesPlayed,2);
			notesPlayed++;
		}	

	if (notesPlayed >= 29)
		notesPlayed = 0;


	}
}
