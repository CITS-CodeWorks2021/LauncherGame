using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class QuickLogic : MonoBehaviour
{
    static TimerState _state;
    bool isPaused = false;
    public static TimerState State
    {
        get
        {
            return _state;
        }
        private set
        {
            _state = value;
            // I can implement UI functionality here;
            
        }
    }

    public static UnityEvent<bool> OnPause = new UnityEvent<bool>();

    private void Start()
    {
        State = TimerState.StartMenu;
    }

    public void StartTimer()
    {
        State = TimerState.InGame;
    }

    public void PauseTimer()
    {
        isPaused = !isPaused;
        if (isPaused) State = TimerState.Paused;
        else State = TimerState.InGame;

        OnPause.Invoke(isPaused);
    }

}

public enum TimerState
{
    StartMenu,
    InGame,
    Paused,
    GameOver
}
