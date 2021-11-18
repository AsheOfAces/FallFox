using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CallInput : MonoBehaviour
{
    [SerializeField]FFInput ff;

    //Left Thumbstick
    [SerializeField]TMPro.TMP_Text LThH;
    [SerializeField]TMPro.TMP_Text LThV;
    [SerializeField]Image LThImg;

    //Right Thumbstick
    [SerializeField]TMPro.TMP_Text RThH;
    [SerializeField]TMPro.TMP_Text RThV;
    [SerializeField]Image RThImg;

    //Left Trigger
    [SerializeField]TMPro.TMP_Text LTrig;
    [SerializeField]Image LTrigIMG;
    
    //Right Trigger
    [SerializeField]TMPro.TMP_Text RTrig;
    [SerializeField]Image RTrigIMG;

    //Dpad
    [SerializeField]Image DpadNorth;
    [SerializeField]Image DpadSouth;
    [SerializeField]Image DpadWest;
    [SerializeField]Image DpadEast;
    [SerializeField]TMPro.TMP_Text DpadH;
    [SerializeField]TMPro.TMP_Text DpadV;

    
    // Update is called once per frame
    void Update()
    {
        //Left Thumbstick
        LThH.text = "H: " + ff.GetThumbstickL().x.ToString();
        LThV.text = "V: " + ff.GetThumbstickL().y.ToString();
        if(ff.GetThumbstickL() != Vector2.zero)
        {
            LThImg.enabled = true;
        }
        else
        {
            LThImg.enabled = false;
        }

        //Right Thumbstick
        RThH.text = "H: " + ff.GetThumbstickR().x.ToString();
        RThV.text = "V: " + ff.GetThumbstickR().y.ToString();
        if(ff.GetThumbstickR() != Vector2.zero)
        {
            RThImg.enabled = true;
        }
        else
        {
            RThImg.enabled = false;
        }

        //Left Trigger
        LTrig.text = ff.GetLeftTrigger().ToString();
        if(ff.GetLeftTrigger() != 0f)
        {
            LTrigIMG.enabled = true;
        }
        else
        {
            LTrigIMG.enabled = false;
        }


        //Right Trigger
        RTrig.text = ff.GetRightTrigger().ToString();
        if(ff.GetRightTrigger() != 0f)
        {
            RTrigIMG.enabled = true;
        }
        else
        {
            RTrigIMG.enabled = false;
        }        

        //Dpad
        if(ff.GetDPad().x==1)
        {
            PurgeDpadSprites();
            DpadEast.enabled = true;
        }
        else if(ff.GetDPad().x ==-1)
        {
            PurgeDpadSprites();
            DpadWest.enabled = true;
        }
        else if(ff.GetDPad().y ==-1)
        {
            PurgeDpadSprites();
            DpadSouth.enabled = true;
        }
        else if(ff.GetDPad().y==1)
        {
            PurgeDpadSprites();
            DpadNorth.enabled = true;
        }
        else
        {
            PurgeDpadSprites();
        }
        DpadH.text = "H: " + ff.GetDPad().x;
        DpadV.text = "V: " + ff.GetDPad().y;
    }

    void PurgeDpadSprites()
    {
        DpadEast.enabled = false;
        DpadNorth.enabled = false;
        DpadWest.enabled = false;
        DpadSouth.enabled = false;
    }
}
