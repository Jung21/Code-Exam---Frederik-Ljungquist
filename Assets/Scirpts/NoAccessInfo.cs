using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NoAccessInfo : RoomInfo
{


    public void Start()
    {
        


        accessText = "Ingen Adgang";
        textAccess.color = new Color(1, 0, 0);

        //Displays the type of access of the room
        textAccess.text = accessText;

        //Displays the name of the room
        textName.text = "til Lokale: " + roomName;

        //Displays the type of room
        textType.text = "Type: " + roomType;



    }

}
