using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour {


	public Button startGame;
	public Button exitGame;

	// Use this for initialization
	void Start () {

		startGame = startGame.GetComponent<Button>();
		exitGame = exitGame.GetComponent<Button>();

	
	}


	public void exitpress()
	{
		Application.Quit();
	}

	public void startpress()
	{
		Application.LoadLevel(1);
	}

	
}
