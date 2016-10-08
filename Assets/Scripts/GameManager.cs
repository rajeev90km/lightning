using UnityEngine;
using System.Collections;

public enum GameState { Main, Game};
public delegate void OnStateChangeHandler();

public class GameManager : MonoBehaviour {

    protected GameManager()
    {

    }

    private static GameManager gameManager = null;
    public event OnStateChangeHandler OnStateChange;
    public GameState gameState { get; private set; }


    public static GameManager GetInstance
    {
        get
        {
            if (GameManager.gameManager == null)
            {
                DontDestroyOnLoad(GameManager.gameManager);
                GameManager.gameManager = new GameManager();
            }
            return GameManager.gameManager;
        }

    }

    public void SetGameState(GameState state)
    {
        this.gameState = state;
        OnStateChange();
    }

    public void OnApplicationQuit()
    {
        GameManager.gameManager = null;
    }

    // Use this for initialization
    void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
