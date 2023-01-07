using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceMovement : MonoBehaviour
{
    [SerializeField] private RectTransform spaceBackgroundTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

//3577
    // Update is called once per frame
    void Update()
    {
        //slowly lerp the spaceBackgroundTransform 3577 px to the right then 3577 back to the left
        spaceBackgroundTransform.anchoredPosition = Vector2.Lerp(new Vector2(1600, 0), new Vector2(-1600, 0), Mathf.PingPong(Time.time / 100, 1));
    }

}
