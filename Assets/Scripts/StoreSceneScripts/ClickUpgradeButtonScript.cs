using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickUpgradeButtonScript : MonoBehaviour
{
    void OnClick()
    {
        if (GameManager.ClickUpgradePrice <= GameManager.Money)
        {
            GameManager.charNumberRate++;
            GameManager.Money -= GameManager.ClickUpgradePrice;
        }
    }
}
