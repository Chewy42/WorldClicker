using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthRotater : MonoBehaviour
{
    [SerializeField] private Transform earthTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //rotate the sprite
        earthTransform.Rotate(0, 0, 0.1f);
    }
}
