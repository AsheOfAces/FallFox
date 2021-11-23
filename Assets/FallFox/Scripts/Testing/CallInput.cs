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

    /*Keyboard
    [SerializeField]Image k0;
    [SerializeField]Image k1;
    [SerializeField]Image k2;
    [SerializeField]Image k3;
    [SerializeField]Image k4;
    [SerializeField]Image k5;
    [SerializeField]Image k6;
    [SerializeField]Image k7;
    [SerializeField]Image k8;
    [SerializeField]Image k9;
    [SerializeField]Image kQ;
    [SerializeField]Image kW;
    [SerializeField]Image kE;
    [SerializeField]Image kR;
    [SerializeField]Image kT;
    [SerializeField]Image kY;
    [SerializeField]Image kU;
    [SerializeField]Image kI;
    [SerializeField]Image kO;
    [SerializeField]Image kP;
    [SerializeField]Image kA;
    [SerializeField]Image kS;
    [SerializeField]Image kD;
    [SerializeField]Image kF;
    [SerializeField]Image kG;
    [SerializeField]Image kH;
    [SerializeField]Image kJ;
    [SerializeField]Image kK;
    [SerializeField]Image kL;
    [SerializeField]Image kZ;
    [SerializeField]Image kX;
    [SerializeField]Image kC;
    [SerializeField]Image kV;
    [SerializeField]Image kB;
    [SerializeField]Image kN;
    [SerializeField]Image kM;
    [SerializeField]Image kF1;
    [SerializeField]Image kF2;
    [SerializeField]Image kF3;
    [SerializeField]Image kF4;
    [SerializeField]Image kF5;
    [SerializeField]Image kF6;
    [SerializeField]Image kF7;
    [SerializeField]Image kF8;
    [SerializeField]Image kF9;
    [SerializeField]Image kF10;
    [SerializeField]Image kF11;
    [SerializeField]Image kF12;
    [SerializeField]Image kAlt;
    [SerializeField]Image kCtrl;
    [SerializeField]Image kDel;
    [SerializeField]Image kShift;
    [SerializeField]Image kTab;
    [SerializeField]Image kCaps;
    [SerializeField]Image kReturn;
    [SerializeField]Image kSpace;
    [SerializeField]Image kArrowUp;
    [SerializeField]Image kArrowDown;
    [SerializeField]Image kArrowLeft;
    [SerializeField]Image kArrowRight;*/

    //Mouse Axes
    [SerializeField]TMPro.TMP_Text MouseH;
    [SerializeField]TMPro.TMP_Text MouseV;


    
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

        //Mouse
        MouseH.text = "H: " + ff.GetMouse().x.ToString();
        MouseV.text = "V: " + ff.GetMouse().y.ToString();
    }

    void PurgeDpadSprites()
    {
        DpadEast.enabled = false;
        DpadNorth.enabled = false;
        DpadWest.enabled = false;
        DpadSouth.enabled = false;
    }

    void PurgeKeyboardSprites()
    {

    }
}
