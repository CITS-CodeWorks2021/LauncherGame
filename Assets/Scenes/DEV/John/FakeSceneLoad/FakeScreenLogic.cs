using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FakeScreenLogic : MonoBehaviour
{
    static GameScene _currentScene;

    public static GameScene TheScene
    {
        get
        {
            return _currentScene;
        }
        private set
        {
            _currentScene = value;
            // Events for something. . . Anything really :)
            OnChangedScene.Invoke();
            Debug.Log("I've Changed!");
        }
    }

    // Might be needed if there is a pause
    GameScene pastScene;

    public static UnityEvent OnChangedScene = new UnityEvent();

    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(0.2f);
        TheScene = GameScene.WorldMap;
    }

    public void StartGame()
    {
        TheScene = GameScene.WorldMap;
    }

    public static void ChangeScene(GameScene toWhich)
    {
        TheScene = toWhich;
    }
}


public enum GameScene
{
    MainMenu,
    WorldMap,
    Battle01,
    Battle02
}