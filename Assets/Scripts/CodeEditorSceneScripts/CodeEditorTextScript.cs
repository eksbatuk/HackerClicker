using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodeEditorTextScript : MonoBehaviour
{
    private Text text;

    void Start()
    {
        text = GetComponent<Text>();
    }

    public void ChangeText()
    {
        text.text += GameManager.codeEditorCode[GameManager.clickNumber];
    }
}
