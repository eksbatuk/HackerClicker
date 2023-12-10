using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutotypeUpgradeTextScript : MonoBehaviour
{
    public Text text;

    private void Awake()
    {
        text = GetComponent<Text>();
        text.text = GameManager.AutotypeUpgradePrice.ToString() + "$";   
    }

    private void Update()
    {
        text.text = GameManager.AutotypeUpgradePrice.ToString() + "$";
    }
}
