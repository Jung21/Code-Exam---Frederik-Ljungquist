using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LimitedAccessInfo : RoomInfo
{
    // String and TMP_Text specific for Limited Access Rooms
    string accessRequest = "Anmod om at få adgang til dette lokale";

    public TMP_Text textRequest;

    /// <summary>
    /// Will write text specified in Inspector at Start of runtime.
    /// </summary>
    public void Start()
    {
        accessText = "Begrænset Adgang";
        textAccess.color = Color.yellow;

        //Displays the type of access of the room
        textAccess.text = accessText;

        //Displays the name of the room
        textName.text = "til Lokale: " + roomName;

        textRequest.text = accessRequest;

        //Displays the type of room
        textType.text = roomType;

    }
}
