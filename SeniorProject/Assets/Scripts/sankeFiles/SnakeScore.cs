using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class SnakeScore : MonoBehaviour
{
    // Start current score at zero
    public static float score = 0f;
    public static float Lives = 3f;


    // Current Score
    public TMP_Text displyTxt;

    //High Score
    public TMP_Text HighTxt;

    //Game Over display
    public TMP_Text EndTxt;

    //LeaderBoard display
    public TMP_Text LeadTxt;

    //Lives display
    public TMP_Text LivesTxt;

    //Leaderboard display
    public TMP_Text Username;

    // Start is called before the first frame update
    void Start()
    {
        if (Username == null)
        {
            //Finds the tag on the text field and gets whats being held
            displyTxt = GameObject.FindWithTag("user")
                .GetComponent<TMP_Text>();
        }
        //Checks if the text field has no value 
        if (displyTxt == null)
        {
            //Finds the tag on the text field and gets whats being held
            displyTxt = GameObject.FindWithTag("ScoreDisplay")
                .GetComponent<TMP_Text>();
        }

        if (HighTxt == null)
        {
            //Finds the tag on the text field and gets whats being held
            HighTxt = GameObject.FindWithTag("HighScore")
                .GetComponent<TMP_Text>();
        }

        if (EndTxt == null)
        {
            //Finds the tag on the text field and gets whats being held
            EndTxt = GameObject.FindWithTag("UserScoreD")
                .GetComponent<TMP_Text>();
        }

        if (LeadTxt == null)
        {
            //Finds the tag on the text field and gets whats being held
            LeadTxt = GameObject.FindWithTag("UserHighSD")
                .GetComponent<TMP_Text>();
        }

        if (LivesTxt == null)
        {
            //Finds the tag on the text field and gets whats being held
            LivesTxt = GameObject.FindWithTag("NumOfLives")
                .GetComponent<TMP_Text>();
        }
        //Manually sets the high score to zero, just make sure to comment it out after you run once or scoring won't work
        //PlayerPrefs.SetFloat("HighScore", 0);

        Username.text = PlayerPrefs.GetString("username");

    }

    // Update is called once per frame
    void Update()
    {
        // In the Score field display the current score and add on more when called
        displyTxt.text = "Score: \t" + score;

        //Set the highscore based on the player preferences 
        HighTxt.text = "High Score: \n\n" + PlayerPrefs.GetFloat("HighScore");
        LeadTxt.text = " " + PlayerPrefs.GetFloat("HighScore");

        EndTxt.text = " " + score;

        LivesTxt.text = " " + Lives;
        // Go into the local player preferences and find the highest score,
        // check if the current is greater than the highest
        if (score > PlayerPrefs.GetFloat("HighScore", 0))
        {
            //If it's greater set the high score to the current score value
            PlayerPrefs.SetFloat("HighScore", score);


        }
    }
}
