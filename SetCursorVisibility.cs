using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

[CommandInfo("Tiny Crocodile Studios",
            "Set Cursor Visibility",
            "Set the visibility for the cursor.")]

public class SetCursorVisibility : Command
{

    public bool visibility = true;

    public override void OnEnter()
    {
        Cursor.visible = visibility;
        Continue();
    }

    /*public override string GetSummary()
    {
        return "";
    }*/

}
