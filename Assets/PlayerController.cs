using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class PlayerController : MonoBehaviour
{
    [SerializeField] private float horiz;
    [SerializeField] private float vert;
    [SerializeField] private float speed = 10f;

    Vector3 pos = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get out early if we are not in gamemode NORMAL
        if (ModeManager.Instance.currentMode != GameMode.NORMAL)
            return;


        // only do this if NOT in PANEL or CLUE mode
        horiz = Input.GetAxis("Horizontal");
        vert = Input.GetAxis("Vertical");

        pos = this.transform.position;
        pos.x += horiz * speed * Time.deltaTime;
        pos.y += vert * speed * Time.deltaTime;

        this.transform.position = pos;
        
    }
}
