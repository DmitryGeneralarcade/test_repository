using UnityEngine;
using System;

public class Test : MonoBehaviour {

    private string logMesageGUI = "Debug Log:\n";
    private void Update()
    {
        
    }
    private void Log(string message, string value = "")
    {
        Console.WriteLine(message + value);
        logMesageGUI = logMesageGUI + "\n" + message + value;
    }

    private void OnGUI()
    {
        int screenWidth = Screen.width;
        int screenHeight = Screen.height;
        int rectWidth = screenWidth / 2;
        int indent = 10;
        GUIStyle style = new GUIStyle(GUI.skin.box);
        style.alignment = TextAnchor.UpperLeft;
        style.fontSize = 20;
        GUI.color = Color.white;
        GUI.Box(new Rect(rectWidth, indent, rectWidth - indent, screenHeight - indent - indent), logMesageGUI, style);
    }
}
