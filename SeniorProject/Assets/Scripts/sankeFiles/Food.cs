using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    // Start is called before the first frame update
    public BoxCollider GridView;
    //Here you can set the value of the snake food Item
    public float ScoreValue = 10f;

    private Vector3 Origin = new Vector3();

    [SerializeField] private float RotationbySecond = 10f;
    [SerializeField] private float Frequency = 1f;
    [SerializeField] private float Hight = 3f;
    private bool state;


    private void Start() {
        
        SnakeScore.score = 0f;
        SnakeScore.Lives = 3f;
        RandomLocation();
        state = true;
        
        


    }

    private void Update()
    {
        if (state) {
        Vector3 tmpLocation = Origin;
        tmpLocation.y += Mathf.Sin(Time.fixedTime * Mathf.PI * Frequency) * Hight;
        transform.Rotate(new Vector3(0f, Time.deltaTime * RotationbySecond, 0f), Space.World);
        transform.position = tmpLocation;
        }
    }
    private void RandomLocation() {

        Bounds bounds = this.GridView.bounds;

        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);
        float z = Random.Range(bounds.min.z, bounds.max.z);

        this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), Mathf.Round(z));
        Origin = transform.position;
    }

    private void OnTriggerEnter(Collider other) {

        if (other.tag == "Player") {
            SnakeScore.score += ScoreValue;
            state = false;
            RandomLocation();
            state = true;
            

        }
        
    }
}
