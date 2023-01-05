using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{

    public CashHandler CashHandler;
    private float cashPerClick = 1f;


    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Click(){
        CashHandler.AddCash(cashPerClick);
    }

    public void UpgradeCPC(){
        if(CashHandler.UpgradeCPC()){
            cashPerClick = Mathf.Ceil(cashPerClick + 1);
        }
    }


}
