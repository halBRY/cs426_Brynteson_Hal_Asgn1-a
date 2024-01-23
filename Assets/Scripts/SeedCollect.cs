using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedCollect : MonoBehaviour
{

    // 0 - Oak/Acorn
    // 1 - Birch
    // 2 - Hickory
    // 3 - Maple
    // 4 - Walnut
    public float treeID;
    public Score scoreManager;

    private void OnCollisionEnter(Collision collision) {

        GameObject hitObject = collision.gameObject;

        if(hitObject.tag == "Player")
        {
            //on collision adding point to the score
            scoreManager.AddPoint(treeID);

            Debug.Log("Collecting Seed");

            Destroy(gameObject);
        }
    }
}
