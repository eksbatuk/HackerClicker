using UnityEngine;
using UnityEngine.UI;

public class MoneyAmountScript : MonoBehaviour
{
    private Text text;

    void Awake()
    {
        text = GetComponent<Text>();
        text.text = GameManager.Money.ToString() + "$";
    }

    public void Update()
    {
        text.text = GameManager.Money.ToString() + "$";
    }
}
