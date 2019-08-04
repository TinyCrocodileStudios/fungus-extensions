using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

// I noticed that there are event handlers that start a block when an object is clicked, but no reactions on "mouse enter" and "mouse exit"
// This script is NOT an event handler, it starts a certain block, if you hover the mouse over your object.
// This is how you use it:

// 1. add this script to your object
// 2. add a collider to your object
// 3. create a block in fungus and name it
// 4. enter the fungus script and block name into the public variables

public class StartBlockInFungus : MonoBehaviour
{

    public Flowchart flowchart;
    public string blockNameEnter;
    public string blockNameExit;
    


    void OnMouseEnter()
    {
        if(blockNameEnter != null)
            flowchart.ExecuteBlock(blockNameEnter);
    }

    void OnMouseExit()
    {
        if(blockNameExit != null)
            flowchart.ExecuteBlock(blockNameExit);
    }  

}
