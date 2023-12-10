using UnityEngine;
using UnityEngine.UI;

public class CharNumberScript : MonoBehaviour
{
    private Text text;

    void Awake()
    {
        text = GetComponent<Text>();
        text.text = "Chars: " + GameManager.charNumber.ToString();
    }

    public void Update()
    {
        text.text = "Chars: " + GameManager.charNumber.ToString();
    }
}
