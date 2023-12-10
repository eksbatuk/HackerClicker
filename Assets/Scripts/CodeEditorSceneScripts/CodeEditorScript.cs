using UnityEngine;
using UnityEngine.UI;

public class CodeEditorScript : MonoBehaviour
{
    void Start()
    {
        GameManager.charNumberRate = 1;
        GameManager.Money = 0;
    }

    public void CodeEditorClick()
    {
        GameManager.WriteCode(); 
    }
}
