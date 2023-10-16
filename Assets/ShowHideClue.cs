using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHideClue : MonoBehaviour
{
    public GameObject clue; // the clue this trigger shows/hides

    // Start is called before the first frame update
    void Start()
    {
        clue.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ModeManager.Instance.currentMode != GameMode.CLUE)
            clue.SetActive(false);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        ModeManager.Instance.currentMode = GameMode.CLUE;
        clue.SetActive(true);
    }


}
