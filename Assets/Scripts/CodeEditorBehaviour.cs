using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class CodeEditorBehaviour : MonoBehaviour
{
    [SerializeField] int clickNumber, charNumber;
    string codeEditorCode = File.ReadAllText("Assets\\Resources\\CodeEditorCode.txt");
    public Text clickNumberText;
    public Text codeEditorText;

    public void CodeEditorClick()
    {
        clickNumber++;
        charNumber++;
        if (charNumber >= codeEditorCode.Length)
            charNumber = 0;
        codeEditorText.text += codeEditorCode[charNumber];
    }

    void Update()
    {
        clickNumberText.text = "Clicks: " + clickNumber.ToString();
    }
}
