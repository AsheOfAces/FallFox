using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FFInput : MonoBehaviour
{
    bool useLinuxWorkaround = false;
    float Lh,Lv; //floats for left thumbstick
    float Rh,Rv; //floats for right thumbstick
    float Dh,Dv; //floats for D-Pad
    float Mh,Mv; //floats for Mouse

    void Awake()
    {
        if(Application.platform == RuntimePlatform.LinuxEditor || Application.platform == RuntimePlatform.LinuxPlayer)
        {
            useLinuxWorkaround = true;
        }
    }

    void Start()
    {
        if(useLinuxWorkaround)
        {
            
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
            return (Input.GetAxis("LeftTriggerLinux") + 1)/2;
        }
        else return Input.GetAxis("LeftTrigger");
    }
    public float GetRightTrigger()
    {
        if(useLinuxWorkaround)
        {
            return (Input.GetAxis("RightTriggerLinux") + 1)/2;
        }
        else return Input.GetAxis("RightTrigger");
    }
    public Vector2 GetDPad()
    {
        if(useLinuxWorkaround)        
        {
            Dh = Input.GetAxisRaw("DpadHLinux");
            Dv = Input.GetAxisRaw("DpadVLinux");
            return new Vector2 (Dh, Dv);   
        }
        else
        {
            Dh = Input.GetAxisRaw("DpadH");
            Dv = Input.GetAxisRaw("DpadV");
            return new Vector2 (Dh, -Dv);   
        }
    }

    public Vector2 GetMouse()
    {
        Mh=Input.GetAxis("MouseX");
        Mv=Input.GetAxis("MouseY");
        return new Vector2(Mh, Mv);
    }

}
