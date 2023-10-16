using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayGameMode : MonoBehaviour
{
    // this is just for debugging to print to screen
    TMP_Text txtGameMode;
    string labelText = "Debug - current mode is:";

    // Start is called before the first frame update
    void Start()
    {
        txtGameMode = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {

        switch (ModeManager.Instance.currentMode)
        {
            case GameMode.CLUE:
                txtGameMode.text = labelText + "CLUE";
            break;
            case GameMode.NORMAL:
                txtGameMode.text = labelText + "NORMAL";
            break;
            case GameMode.PANEL:
                txtGameMode.text = labelText + "PANEL";
            break;

        }
        
    }
}
