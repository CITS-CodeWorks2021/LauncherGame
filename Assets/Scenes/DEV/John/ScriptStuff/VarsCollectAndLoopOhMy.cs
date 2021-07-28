using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class VarsCollectAndLoopOhMy : MonoBehaviour
{
    public float aFloat;
    public int anInt;
    public string aString;
    public GameObject anObject;
    
    public GameState watState;

    public YourScriptNameHere yourCustomScript;

    public int[] anIntArray;
    public List<YourScriptNameHere> anIntList;

    Dictionary<Items, GameObject> myDictionary = new Dictionary<Items, GameObject>();

    Queue<GameObject> aQueue; //a line. . . FIFO
    Stack<GameObject> aSTack; // FI LO

    // Start is called before the first frame update
    void Start()
    {
        myDictionary.Add(Items.Explosion, gameObject);
        anInt = (int)Items.Explosion;

        GameObject objGrabbed;
        myDictionary.TryGetValue(Items.Explosion, out objGrabbed);

        int newNum = anIntArray[0];

        for(int i = anIntArray.Length - 1; i >= 0; i--)
        {
            anIntArray[i] = i;
        }

        for(int i = 0; i < anIntList.Count; i++)
        {
            anInt++;
        }

        foreach(YourScriptNameHere y in anIntList)
        {
            y.wat = 2;
        }

        PauseManager.PauseGame(true);
    }

    // Update is called once per frame
    void Update()
    {
        anObject.GetComponent<IPauseable>().PauseMe(true);
    }
}

public enum Items
{
    Explosion = 21,
    Pickup = 1,
    Damage = 33
}

public enum GameState
{
    RootMenu,
    InGame,
    GameOver,
    Settings
}