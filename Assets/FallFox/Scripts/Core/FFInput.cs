using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FFInput : MonoBehaviour
{
    float Lh,Lv; //floats for left thumbstick
    float Rh,Rv; //floats for right thumbstick
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
        return Input.GetAxis("LeftTrigger");
    }
    public float GetRightTrigger()
    {
        return Input.GetAxis("RightTrigger");
    }
}
