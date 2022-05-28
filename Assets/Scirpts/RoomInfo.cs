using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// This class holds the standard data of each room type
/// </summary>
public class RoomInfo : MonoBehaviour
{
    //These strings holds the text displayed on the button as info
    public string roomName;

    public string roomType;

    public string accessText;
    
    // Custom Text Mesh Pro Text input
    public TMP_Text textName;

    public TMP_Text textType;

    public TMP_Text textAccess;

    //public TMP_Text text≈bning;

    // Changes colour for the different access types
    public TMP_ColorGradient farve;














    /// No Longer in use, here for reference


    //public string dato≈bning;

    // Custom accessType
    //public accessType cleareance;

    /// <summary>
    /// Three custom string values as enumaroters to assign access types of rooms: Afgang, BegrÊnsetAdgang, IngenAdgang
    /// </summary>

    /* public enum accessType 
     {
         FreeAccess = 0,
         LimitedAccess = 1,
         NoAccess = 2



     }*/

    // The definition of data of the rooms happen in start
    /*public void Start()
    {
        //This string holds the information of the room access data(Which type)
        string accessText = "";

        //These if statements are looking for which access type is chosen for the room, and changes the colour accordingly
        if (cleareance == accessType.FreeAccess)
        {
            accessText = "Fri Adgang";
            textAccess.color = Color.green;
        }
        if (cleareance == accessType.LimitedAccess)
        {
            accessText = "BegrÊnset adgang";
            textAccess.color = Color.yellow;

        }
        if (cleareance == accessType.NoAccess)
        {
            accessText = "Ingen adgang";
            textAccess.color = new Color(1, 0, 0);

        }

        //Displays the type of access of the room
        textAccess.text = accessText;

        //Displays the name of the room
        textName.text = "Lokale: " + roomName;

        //Displays the type of room
        textType.text = roomType;

        //Displays the date of opening the room, for now as manual writing
        //text≈bning.text = dato≈bning;

        

        
    }
    */
}
