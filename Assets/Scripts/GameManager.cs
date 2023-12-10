using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class GameManager : MonoBehaviour
{
    public static int clickNumber = -1;
    public static int charNumber = 0;
    public static int charNumberRate = 1;
    public static int Money = 0;
    public static int ClickUpgradePrice = 1;
    public static int AutotypeUpgradePrice = 100;

    public static string codeEditorCode = File.ReadAllText("Assets\\Resources\\CodeEditorCode.txt");

    public static void WriteCode()
    {
        charNumber += charNumberRate;
        if (charNumber % 10 == 0)
            Money += 1;
        clickNumber++;
        if (clickNumber >= codeEditorCode.Length)
            clickNumber = 0;
    }

    public static void OpenStore()
    {
        SceneManager.LoadScene(1);
    }

    public static void OpenCodeEditore() 
    {
        SceneManager.LoadScene(0);
    }
}

