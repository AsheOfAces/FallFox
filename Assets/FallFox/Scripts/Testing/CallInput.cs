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
        LTrig.text = "Trigger Value: " + ff.GetLeftTrigger().ToString();
        if(ff.GetLeftTrigger() != 0f)
        {
            LTrigIMG.enabled = true;
        }
        else
        {
            LTrigIMG.enabled = false;
        }


        //Right Trigger
        RTrig.text = "Trigger Value: " + ff.GetRightTrigger().ToString();
        if(ff.GetRightTrigger() != 0f)
        {
            RTrigIMG.enabled = true;
        }
        else
        {
            RTrigIMG.enabled = false;
        }        
    }
}
