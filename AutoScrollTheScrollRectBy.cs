using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // Required when Using UI elements.
using Fungus;

[CommandInfo ("Tiny Crocodile Studios", 
    "Scroll To Position By",
    "Scroll the Scroll Rect by x percent.")]

public class AutoScrollTheScrollRectBy : Command
{

    public float scrollPercentageStep;
    public ScrollRect myScrollRect;

    public override void OnEnter()
    {
        float scrollPercentage = myScrollRect.verticalNormalizedPosition;

        //scrolls the content in a scroll rect by a certain percentage
        scrollPercentage -= scrollPercentageStep;
        if(scrollPercentage < 0)
            scrollPercentage = 0;

        if(scrollPercentage > 100)
            scrollPercentage = 100;

        myScrollRect.verticalNormalizedPosition = scrollPercentage;  
        //to do: make this more smooth by increasing the scroll value slowly

        Continue();  
    }

}
