/*
Move a GameObject using the arrow keys or AD

Fer Cortés
2023-03-01

*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horizontalMotion : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float limit;

    Vector3 move;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move.x = Input.GetAxis("Horizontal");

        //Debug.Log("X motion: " + move.x);


        //Limit the movement to a specific range of coordinates 
        if(transform.position.x < -limit && move.x < 0){
            move.x = 0;
        } else if (transform.position.x > limit && move.x > 0){
            move.x = 0;
        }

        transform.Translate(move * speed * Time.deltaTime); //cuanto quiero que se mueva (velocidad * tiempo)




    }
}
