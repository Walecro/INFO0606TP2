using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCam : MonoBehaviour
{
    public Camera cam1; // camera chariot
    public Camera cam2; // Camera cabine
    public Camera maincam; // camera de loin
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        // 1 sur le pavé numérique switch à la caméra chariot
        if (Input.GetKey(KeyCode.Keypad1)){
            cam1.enabled = true;
            cam2.enabled = false;
            maincam.enabled = false;
        }
        // 2 sur le pavé numérique switch à la caméra cabine

        if (Input.GetKey(KeyCode.Keypad2)){
            cam1.enabled = false;
            cam2.enabled = true;
            maincam.enabled = false;
        }
        // 3 sur le pavé numérique switch à la vue de loin

        if (Input.GetKey(KeyCode.Keypad3)){
            cam1.enabled = false;
            cam2.enabled = false;
            maincam.enabled = true;
        }
    }
}
