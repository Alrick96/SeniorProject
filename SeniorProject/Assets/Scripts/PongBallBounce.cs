using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongBallBounce : MonoBehaviour
{
    public PongBall pongBall;
    public PongScoreManager scoreManager;
    public PongPlayerController players;
    public AudioSource playPlayerBounceSound;
    public AudioSource playOtherBounceSound;
    public AudioSource playScoreBounceSound;

    private void Bounce(Collision collision)
    {
        Vector3 ballPos = transform.position;
        Vector3 playerPos = collision.transform.position;
        float playerHeight = collision.collider.bounds.size.y;

        float posX;
        if (collision.gameObject.name == "LeftPlayer")
        {
            posX = 1;
        }
        else
        {
            posX = -1;
        }

        float posY = (ballPos.y - playerPos.y) / playerHeight;

        //playBounceSound.Play();
        pongBall.PongHitCounter();
        pongBall.BallSpeed(new Vector3(posX, posY, 0));
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            playPlayerBounceSound.Play();
            Bounce(collision);
        }

        else if(collision.gameObject.name == "LeftWall")
        {
            playScoreBounceSound.Play();
            scoreManager.rightPlayerScored();
            if(scoreManager.gameOverScreen.activeSelf == false)
            {
                StartCoroutine(pongBall.PongBallStart());
                players.resetPlayer();
            }
        }
        else if (collision.gameObject.name == "RightWall")
        {
            playScoreBounceSound.Play();
            scoreManager.leftPlayerScored();
            if (scoreManager.gameOverScreen.activeSelf == false)
            {
                StartCoroutine(pongBall.PongBallStart());
                players.resetPlayer();
            }
        }
        else
        {
            playOtherBounceSound.Play();
        }

    }










    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
