using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CashHandler : MonoBehaviour
{

    [SerializeField] private float cash = 0;
    [SerializeField] private Text cashText;
    [SerializeField] private float cpcUpgradeCost = 1f;
    [SerializeField] private float cpc = 1;
    [SerializeField] private Text cpcUpgradeCostText;
    [SerializeField] private Text cpcDisplayer;
    [SerializeField] private float totalCps;
    [SerializeField] private float spaceShipClicksPerSecond = 0;
    [SerializeField] private float spaceShipUpgradeCost = 100f;
    [SerializeField] private Text spaceShipUpgradeCostText;


    void Start(){
        cashText.text = "$" + cash.ToString();
        cpcUpgradeCostText.text = "$" + cpcUpgradeCost.ToString();
        cpcDisplayer.text = "Cash Per Click: " + cpc.ToString();
        spaceShipUpgradeCostText.text = "$" + spaceShipUpgradeCost.ToString();
    }

    public void AddCash(float value){
        cash = Mathf.Ceil(cash + value);
        cashText.text = "$" + cash.ToString();
    }

    public bool RemoveCash(float value){
        if(HasSufficientCash(value)){
            cash = Mathf.Ceil(cash - value);
            cashText.text = "$" + cash.ToString();
            return true;
        }else{
            return false;
        }
    }

    private bool HasSufficientCash(float value){
        return cash >= value;
    }

    public bool UpgradeCPC(){
        if(RemoveCash(cpcUpgradeCost)){
            cpc++;
            cpcUpgradeCost = Mathf.Ceil(cpcUpgradeCost * 1.5f);
            cpcUpgradeCostText.text = "$" + cpcUpgradeCost.ToString();
            cpcDisplayer.text = "Cash Per Click: " + cpc.ToString();
            return true;
        }else{
            return false;
        }
    }

    public bool UpgradeSpaceship(){
        if(RemoveCash(spaceShipUpgradeCost)){
            spaceShipClicksPerSecond++;
            totalCps++;
            spaceShipUpgradeCost = Mathf.Ceil(spaceShipUpgradeCost * 1.5f);
            spaceShipUpgradeCostText.text = "$" + spaceShipUpgradeCost.ToString();
            return true;
        }else {
            return false;
        }
    }

}
