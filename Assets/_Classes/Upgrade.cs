using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrade : MonoBehaviour
{
    [SerializeField] protected GameObject upgradeGameObject;
    [SerializeField] protected Button upgradeButton;
    [SerializeField] protected Text upgradeTitle;
    [SerializeField] protected Text upgradeCostText;
    [SerializeField] protected GameObject upgradePrefab; // item to be spawned after initial purchase
    [SerializeField] protected bool isPurchased = false; //after initial purcahse, change title text
    [SerializeField] protected float upgradeCost;
    [SerializeField] protected float upgradeCostMultiplier = 1.5f;
    
}
