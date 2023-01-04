using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CashHandler : MonoBehaviour
{

    [SerializeField] private float cash = 0;
    [SerializeField] private Text cashText;

    public void AddCash(float value){
        cash += value;
        cashText.text = "$" + cash.ToString();
    }

    public bool RemoveCash(float value){
        if(HasSufficientCash(value)){
            cash -= value;
            cashText.text = "$" + cash.ToString();
            return true;
        }else{
            return false;
        }
    }

    private bool HasSufficientCash(float value){
        return cash >= value;
    }

}
