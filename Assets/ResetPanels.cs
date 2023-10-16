using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPanels : MonoBehaviour
{
    UsePanels panelScript;

    // Start is called before the first frame update
    void Start()
    {
        panelScript = GameObject.Find("PanelManager").GetComponent<UsePanels>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (panelScript != null)
        {
            panelScript.ResetPanel();
            ModeManager.Instance.currentMode = GameMode.PANEL;
        }
        
    }

}
