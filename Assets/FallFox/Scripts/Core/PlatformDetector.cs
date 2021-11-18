using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDetector : MonoBehaviour
{
    /*This script actively looks for which input device is being used at any given moment. Also checks for the relevant
    platform in advance to avoid gamepad axis conflicts.
    */

    [SerializeField] bool StoredInPP = false;
    [SerializeField] int LinuxWorkAround = 0;

    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("storageflag") == 1)
        {
            StoredInPP = true;
        }

        if(!StoredInPP)
        {
            Debug.Log(Application.platform);
            if(Application.platform == RuntimePlatform.LinuxEditor || Application.platform == RuntimePlatform.LinuxPlayer)
            {
                LinuxWorkAround = 1;
            }
        }
    }
}
