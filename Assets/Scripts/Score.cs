// add score manager
using UnityEngine;
using UnityEngine.UI;

// access the Text Mesh Pro namespace
using TMPro;

public class Score : MonoBehaviour
{
    public TMP_Text scoreText;
    public int maxScore = 69;

    public TMP_Text oakText;
    public TMP_Text birchText;
    public TMP_Text hickoryText;
    public TMP_Text mapleText;
    public TMP_Text walnutText;

    int scoreOak;
    int scoreBirch;
    int scoreHickory;
    int scoreMaple;
    int scoreWalnut;
    int totalScore;

    // Start is called before the first frame update
    void Start()
    {
        
        scoreOak = 0;
        scoreBirch = 0;
        scoreHickory = 0;
        scoreMaple = 0;
        scoreWalnut = 0;

        totalScore = scoreOak + scoreBirch + scoreHickory + scoreMaple + scoreWalnut;

        scoreText.text = "Seeds Collected: " + totalScore;
        
        oakText.text = "" + scoreOak;
        birchText.text = "" + scoreBirch;
        hickoryText.text = "" + scoreHickory;
        mapleText.text = "" + scoreMaple;
        walnutText.text = "" + scoreWalnut;

    }

    //we will call this method from our target script
    // whenever the player collides or shoots a target a point will be added
    public void AddPoint(float treeID)
    {
        switch(treeID)
        {
 
            case 0:
                scoreOak++; 
                break;
            case 1:
                scoreBirch++; 
                break;
            case 2:
                scoreHickory++; 
                break;
            case 3:
                scoreMaple++; 
                break;
            case 4:
                scoreWalnut++; 
                break;
            default:
                Debug.Log("Error");
                break;
        }

        totalScore = scoreOak + scoreBirch + scoreHickory + scoreMaple + scoreWalnut;

        if (totalScore < maxScore)
            scoreText.text = "Seeds Collected: " + totalScore;
        else
            scoreText.text = "You won!";

        oakText.text = "" + scoreOak;
        birchText.text = "" + scoreBirch;
        hickoryText.text = "" + scoreHickory;
        mapleText.text = "" + scoreMaple;
        walnutText.text = "" + scoreWalnut;
    }

    public int getScore(float treeID)
    {
        switch(treeID)
        {
 
            case 0:
                return scoreOak; 
            case 1:
                return scoreBirch; 
            case 2:
                return scoreHickory; 
            case 3:
                return scoreMaple; 
            case 4:
                return scoreWalnut; 
            default:
                Debug.Log("Error");
                return -1;
        }
    }
}