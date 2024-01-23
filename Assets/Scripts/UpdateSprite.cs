using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateSprite : MonoBehaviour
{

    public Sprite grayed;
    public Sprite collected;
    public float treeID;
    public Score scoreManager;

    public bool found = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(scoreManager.getScore(treeID) > 0)
        {
            found = true;
        }

        if(found == false)
        {
            GetComponent<Image>().sprite = grayed;
        }
        else
        {
            GetComponent<Image>().sprite = collected;
        }
    }
}
