//lets add some target
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Target : MonoBehaviour
{
    public Score scoreManager;

    public GameObject spawner;
    public GameObject seed;

    public Camera camera;

    // 0 - Oak/Acorn
    // 1 - Birch
    // 2 - Hickory
    // 3 - Maple
    // 4 - Walnut
    public float treeID;

    private BillboardSprite sprite_script;
    private SeedCollect seed_script;
 
    //this method is called whenever a collision is detected
    private void OnCollisionEnter(Collision collision) {
        
        if(gameObject.tag == "TriggerTree")
        {
            //on collision adding point to the score
            scoreManager.AddPoint(treeID);
        }
        else if(collision.gameObject.tag == "Bullet")
        {
            GameObject newSeed = GameObject.Instantiate(seed, spawner.transform.position, spawner.transform.rotation) as GameObject;

            sprite_script = newSeed.GetComponentInChildren<BillboardSprite>();
            sprite_script.camera = camera;

            seed_script = newSeed.GetComponent<SeedCollect>();
            seed_script.treeID = treeID;
            seed_script.scoreManager = scoreManager;
        }

        // printing if collision is detected on the console
        Debug.Log("Collision Detected");
    }
}