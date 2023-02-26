using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    // Start is called before the first frame update
    public BoxCollider GridView;
    //Here you can set the value of the snake food Item
    public float ScoreValue = 10f;

    private void Start() {
        SnakeScore.score = 0f;
        RandomLocation();
    }

    private void RandomLocation() {

        Bounds bounds = this.GridView.bounds;

        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);

        this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0.0f);
    }

    private void OnTriggerEnter(Collider other) {

        if (other.tag == "Player") {
            SnakeScore.score += ScoreValue;
            RandomLocation();

        }
        
    }
}