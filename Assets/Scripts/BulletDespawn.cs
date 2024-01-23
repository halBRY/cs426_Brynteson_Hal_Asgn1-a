using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDespawn : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        GameObject hitObject = collision.gameObject;

        //Debug.Log("Collision Detected");
        //Debug.Log(hitObject.tag);

        if(hitObject.tag == "Ground")
        {
            Destroy(gameObject, 2);
        }

    }
}
