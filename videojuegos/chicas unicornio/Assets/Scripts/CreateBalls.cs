using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBalls : MonoBehaviour
{
    //class variable to be changed drom the Unity interface
    //SerializedField - makes this variable visible from unity
    //Class and Objets start with uppercase, variables - lowercase, if they are composed from several words the second one beggins with uppercase
    [SerializeField]GameObject ball;
    [SerializeField] float delay;

    // Start is called before the first frame update
    void Start()
    {
        // Call the 'Dropball' funtion after 0.5 seconds
        // and then keep caling it every set time
        InvokeRepeating("DropBall", 0.5f, delay); 
    }

    // Update is called once per frame
    // void Update()
    // {
        
    // }

    void DropBall()
    {
        // generate new random position
        Vector3 pos = new Vector3(Random.Range(-10.0f,10.0f), 6, 0);
        // create a copy of the prefab
        GameObject obj =Instantiate(ball, pos, Quaternion.identity);
        //doom the object to die in 5 seconds
        Destroy(obj, 5);

    }
}
