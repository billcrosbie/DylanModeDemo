using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsePanels : MonoBehaviour
{
    public GameObject[] panels; 

    private int currentPanel = 0;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ModeManager.Instance.currentMode == GameMode.PANEL)
        {
            for (int i=0; i < panels.Length; i++)
            {
                panels[i].gameObject.SetActive(false);
            }

            panels[currentPanel].gameObject.SetActive(true);

            if (Input.GetKeyUp(KeyCode.Space))
            {
                currentPanel++;
            }

            if (currentPanel == panels.Length)
            {
                //we are at the end of the panels
                //go to NORMAL mode
                panels[currentPanel-1].gameObject.SetActive(false);
                ModeManager.Instance.currentMode = GameMode.NORMAL;
            }
        }       
    }

    public void ResetPanel()
    {
        currentPanel = 0;
    }

}
