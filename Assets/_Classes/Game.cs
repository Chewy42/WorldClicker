using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{

    public CashHandler CashHandler;
    private float cashPerClick = 100f;

    private bool hasSpaceship = false;
    private bool isSpaceshipAlreadyMoving = false;



    [SerializeField] private GameObject spaceship;


    void Start()
    {
        
    }

    void Update()
    {
        //if has spaceship move -396.34f left then do a 180 on z axis and go back to start then loop and add 1 cash per second
        if(hasSpaceship && !isSpaceshipAlreadyMoving){
            print("moving!");
            spaceship.transform.Translate(Vector3.left * 396.34f * Time.deltaTime);
            if(spaceship.transform.position.x <= -11.38f){
                isSpaceshipAlreadyMoving = true;
                print("moving back!");
                spaceship.transform.Rotate(0, 0, 180);
                CashHandler.AddCash(1);
                isSpaceshipAlreadyMoving = false;
            }
        }
    }

    public void Click(){
        CashHandler.AddCash(cashPerClick);
    }

    public void UpgradeCPC(){
        if(CashHandler.UpgradeCPC()){
            cashPerClick = Mathf.Ceil(cashPerClick + 1);
        }
    }

    public void UpgradeSpaceship(){
        if(CashHandler.UpgradeSpaceship()){
            // instantiate spaceship as a child of the gameobject named "Upgrade-2"
            spaceship = Instantiate(spaceship, GameObject.Find("Upgrade-2").transform);
            hasSpaceship = true;
        }
    }


}
