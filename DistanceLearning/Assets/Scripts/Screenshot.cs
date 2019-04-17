using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Screenshot : MonoBehaviour
{
    void OnTriggerEnter()
    {
        ScreenCapture.CaptureScreenshot("SomeLevel.png");
        print("SAVED!");
    }
    
}
