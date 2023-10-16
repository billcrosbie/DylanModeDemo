using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClueManager : MonoBehaviour
{
   

    // Update is called once per frame
    void Update()
    {
        //if we are not displaying a clue, do not read the space bar
        if (ModeManager.Instance.currentMode != GameMode.CLUE) return;

        if (Input.GetKeyUp(KeyCode.Space))
        {
            ModeManager.Instance.currentMode = GameMode.NORMAL;
        }

    }



}
