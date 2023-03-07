/*
Destroy rigid body objects
*/

using UnityEngine;

public class Destroyer : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        Destroy(col.gameObject);
    }
}
