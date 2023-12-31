using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//***Bonus feature***
public class GameManager : MonoBehaviour
{
    private int score = 0;  //Store score
    private int lives = 3;  //Store lives

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddLives(int value)
    {
        lives += value;

        if (lives <= 0)
        {
            Debug.Log("Game Over");
            lives = 0;
        }

        Debug.Log("Lives = " + lives);
    }

    public void AddScore(int value)
    {
        score += value;
        Debug.Log("Score = " + score);
    }
}
