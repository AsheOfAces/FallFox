using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FFInput : MonoBehaviour
{
    bool useLinuxWorkaround = false;
    float Lh,Lv; //floats for left thumbstick
    float Rh,Rv; //floats for right thumbstick

    void Awake()
    {
        if(Application.platform == RuntimePlatform.LinuxEditor || Application.platform == RuntimePlatform.LinuxPlayer)
        {
            useLinuxWorkaround = true;
        }

    }


    public Vector2 GetThumbstickL()
    {
        Lh = Input.GetAxisRaw("LeftThumbstickH");
        Lv = Input.GetAxisRaw("LeftThumbstickV");
        return new Vector2 (Lh, Lv);
    }
    public Vector2 GetThumbstickR()
    {
        //linux workaround thingmajig might come here
        Rh = Input.GetAxisRaw("RightThumbstickH");
        Rv = Input.GetAxisRaw("RightThumbstickV");
        return new Vector2 (Rh, Rv);
    }
    public float GetLeftTrigger()
    {
        if(useLinuxWorkaround)
        {
            return Input.GetAxis("LeftTriggerLinux");
        }
        else return Input.GetAxis("LeftTrigger");
    }
    public float GetRightTrigger()
    {
        if(useLinuxWorkaround)
        {
            return Input.GetAxis("RightTriggerLinux");
        }
        else return Input.GetAxis("RightTrigger");
    }
}
