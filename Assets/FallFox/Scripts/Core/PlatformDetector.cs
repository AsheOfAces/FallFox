using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDetector : MonoBehaviour
{
    /*This script actively looks for which input device is being used at any given moment. Also checks for the relevant
    platform in advance to avoid gamepad axis conflicts.
    */

    [SerializeField] bool storedInPP = false;
    [SerializeField] int linuxWorkAround = 0;

    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("storageflag") == 1)
        {
            storedInPP = true;
        }

        if(!storedInPP)
        {
            Debug.Log(Application.platform);
            if(Application.platform == RuntimePlatform.LinuxEditor || Application.platform == RuntimePlatform.LinuxPlayer)
            {
                linuxWorkAround = 1;
            }
        }
        else
        {
            PlayerPrefs.SetInt("linuxWorkaround", 1);
        }
    }
}
