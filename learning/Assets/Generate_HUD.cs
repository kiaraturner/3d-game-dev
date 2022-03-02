using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate_HUD : MonoBehaviour
{
    public GUIContent rectContant;
    public Rect rectangle = new Rect(10,10,100,90);
    private void OnGUI()
    {
        GUI.Box(rectangle, rectContant);

        if (GUI.Button(new Rect(Screen.width/2, Screen.height/2, 80, 20),"Debug Messenger") == true) 
        {
            Debug.Log("Button has been clicked");
        }
    }
}
