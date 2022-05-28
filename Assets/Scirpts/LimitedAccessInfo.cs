using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LimitedAccessInfo : RoomInfo
{

    string accessRequest = "Anmod om at få adgang til dette lokale";

    public TMP_Text textRequest;
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
