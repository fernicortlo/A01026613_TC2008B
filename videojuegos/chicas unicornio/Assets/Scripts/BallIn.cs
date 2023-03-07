using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallIn : MonoBehaviour
{
    [SerializeField] Score scoreObj;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(){
        scoreObj.AddPoints(1);
    }
}
