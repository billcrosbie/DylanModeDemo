using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameMode
{
    PANEL, NORMAL, CLUE
}

public class ModeManager : MonoBehaviour
{

    public static ModeManager Instance { get; private set; }
    public GameMode currentMode;

    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        currentMode = GameMode.PANEL;
    }

}
