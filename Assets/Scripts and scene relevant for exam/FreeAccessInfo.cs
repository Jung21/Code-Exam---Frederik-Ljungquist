using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FreeAccessInfo : RoomInfo
{
   
    /// <summary>
    /// Will write text specified in Inspector at Start of runtime.
    /// </summary>
    public void Start()
    {
        
        accessText = "Fri Adgang";
        textAccess.color = Color.green;

        //Displays the type of access of the room
        textAccess.text = accessText;

        //Displays the name of the room
        textName.text = "til Lokale: " + roomName;

        //Displays the type of room
        textType.text = "Type: " + roomType;

    }

}
