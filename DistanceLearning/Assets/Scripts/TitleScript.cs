using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScript : MonoBehaviour
{
    //Name this variable "ShowText" then drag the "ShowText" script into the variable through the inspector.
    public ShowText textDisplayingScript;



    void Start()
    {
        //Shows two lines of text at the bottom left of the screen (10 pixels from the left and 50 from the bottom). 
        //The text lasts for 5 seconds before it disappears.
        textDisplayingScript.DisplayTextHereFor("A long time ago, a very strange thing happened. \n" +
        "A violet moon appeared in our sky...", 57, 14, 7);
    }
}
