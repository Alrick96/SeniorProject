using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    // Start is called before the first frame update
    public BoxCollider GridView;

    private void Start() {

        RandomLocation();
    }

    private void RandomLocation() {

        Bounds bounds = this.GridView.bounds;

        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);
        float z = Random.Range(bounds.min.z, bounds.max.z);

        this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), Mathf.Round(z));
    }

    private void OnTriggerEnter(Collider other) {

        if (other.tag == "Player") {
            RandomLocation();

        }
        
    }
}
