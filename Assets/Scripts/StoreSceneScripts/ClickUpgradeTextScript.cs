using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickUpgradeTextScript : MonoBehaviour
{
    public Text text;

    private void Awake()
    {
        text = GetComponent<Text>();
        text.text = GameManager.ClickUpgradePrice.ToString() + "$";
    }

    private void Update()
    {
        text.text = GameManager.ClickUpgradePrice.ToString() + "$";
    }
}
