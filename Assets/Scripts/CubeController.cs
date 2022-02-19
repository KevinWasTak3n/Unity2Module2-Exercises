using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CubeController : MonoBehaviour
{
    public TMP_Text scoreText;
    //DECLARE VARIABLES HERE
    private int currentNum;
    public Vector3 position;

    public float health;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        health = 100;
        score = 0;
        currentNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //VVV how you get input
        if(Input.GetKey("space"))
        {
            score++;
            health -= 0.001f;
        }

        //INCREMENT AND PRINT CURRENTNUM HERE 

        //Uncomment the code below and complete 
        //the if statement to check if Mouse0 is clicked 
         if (Input.GetKey(KeyCode.Mouse0))
         {
             score++;
             scoreText.text = "Score: " + score.ToString();
            print(score);
        }
    }
}
