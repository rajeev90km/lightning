using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour {

    GameManager gm;

	// Use this for initialization
	void Awake()
    {
        gm = GameManager.GetInstance;
        gm.OnStateChange += HandleStateChange;
        Debug.Log(gm.gameState);

    }

    public void startGame()
    {
        gm.SetGameState(GameState.Game);
        Debug.Log(gm.gameState);
    }
	
    public void HandleStateChange()
    {
        SceneManager.LoadScene("Game");
    }

    // Update is called once per frame
    void Update() {
	    
	}
}
                                                                                                          