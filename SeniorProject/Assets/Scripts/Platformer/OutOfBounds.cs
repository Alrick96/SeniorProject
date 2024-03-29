using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class OutOfBounds : MonoBehaviour
{

    public GameObject OFB;

    // Start is called before the first frame update
    void Start()
    {
        OFB.SetActive(false);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Out of bounds");
            OFB.SetActive(true);
            Invoke("dela", 4);
            collision.transform.position = new Vector3(0.0199999996f, 1f, 0.389999986f);
        }
    }

    void dela()
    {
        OFB.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
