using UnityEngine;
using System.Collections;

public class CombatController : MonoBehaviour {

	public double songValue;
	bool canPlay = true;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (canPlay && Input.GetKeyDown (KeyCode.Keypad1))  //C
		{
			songValue += 1;
		}
	if (canPlay && Input.GetKeyDown (KeyCode.Keypad2))	//D
		{
			songValue += 2;
		}
	if (canPlay && Input.GetKeyDown (KeyCode.Keypad3))  //E
		{
			songValue += 3;
		}
	if (canPlay && Input.GetKeyDown (KeyCode.Keypad4))	//F
		{
			songValue += 4;
		}
	if (canPlay && Input.GetKeyDown (KeyCode.Keypad5))  //G
		{
			songValue += 5;
		}
	if (canPlay && Input.GetKeyDown (KeyCode.Keypad6))	//A
		{
			songValue += 6;
		}
	if (canPlay && Input.GetKeyDown (KeyCode.Keypad7))  //B
		{
			songValue += 7;
		}
	if (canPlay && Input.GetKeyDown (KeyCode.Keypad8))	//High C
		{
			songValue += 8;
		}	
	
	
	
	
	
	}
}
