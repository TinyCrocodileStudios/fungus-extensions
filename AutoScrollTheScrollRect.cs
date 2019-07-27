using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // Required when Using UI elements.
using Fungus;

[CommandInfo ("Tiny Crocodile Studios", 
    "Scroll To Position",
    "Scroll the Scroll Rect to certain position.")]

public class AutoScrollTheScrollRecht : Command
{

    public float scrollPercentage;
    public ScrollRect myScrollRect;

    //scrolls to a certain position in a scroll rect, defined by percentage
    public override void OnEnter()
    {
        myScrollRect.verticalNormalizedPosition = scrollPercentage;  
        Continue();  
    }


}
