

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;

public class ImpGUI : MonoBehaviour
{

    private string text = "Choose your drug lord";
    private int attackp1 = 870;
    private int attackp2 = 311;
    private int attackp3 = 2312;

    private int defense1 = 9310;
    private int defense2 = 1322111;
    private int defense3 = 222;
    
    private int luck1 = 90;
    private int luck2 = 2111;
    private int luck3 = 232;
    
    private int speed1 = 420;
    private int speed2 = 422;
    private int speed3 = 2242;
    
    
    private int Special1 = 1234;
    private int Special2 = 6969;
    private int Special3 = 911;

    private int Intelligence1 = 200;
    private int Intelligence2 = 200;
    private int Intelligence3 = 200;

    private void OnGUI()
    {


        GUI.Box(new Rect(20, 50, 1420, 650), "Change Stats");

        if (GUI.Button(new Rect(40, 70, 150, 150), "Option 1"))
        {
            text = $"Name: george washington \r\n Attack: {attackp1} \r\n  Defense: {defense1} \r\n Speed: {speed1} \r\n luck: {luck1} \r\n Special: {Special1} \r\n Intelligence: {Intelligence1}";

        }

        if (GUI.Button(new Rect(40, 300, 150, 150), "Option 2"))
        {
            text = $"Name: mikel kors \r\n Attack: {attackp2} \r\n  Defense: {defense2} \r\n Speed: {speed2} \r\n luck: {luck2} \r\n Special: {Special2} \r\n Intelligence: {Intelligence2}";

        }

        if (GUI.Button(new Rect(40, 500, 150, 150), "Option 3"))
        {
            text = $"Name: jm amores \r\n Attack: {attackp3} \r\n  Defense: {defense3} \r\n Speed: {speed3} \r\n luck: {luck3} \r\n Special: {Special3} \r\n Intelligence: {Intelligence3}";

        }

        GUI.Label(new Rect(800, 300, 1000, 900), text);

    }
}
