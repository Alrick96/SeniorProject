using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victory : MonoBehaviour
{

    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;
    public GameObject char1;
    public GameObject char2;
    public GameObject Vic;
    public GameObject mis;

    public GameObject Timer;
    public GameObject Goal;
    public GameObject UI;
    // Start is called before the first frame update
    void Start()
    {
        cam1.SetActive(true);
        cam2.SetActive(false);
        cam3.SetActive(false);
        //char1.SetActive(true);
        char2.SetActive(false);
        Vic.SetActive(false);
        mis.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (KeyCollection.score == 3) {

            Vic.SetActive(true);

        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player" && KeyCollection.score == 3)
        {
            KeyCollection.score -= 3;
            cam1.SetActive(false);
            cam2.SetActive(true);
            char1.SetActive(false);
            //char2.SetActive(true);
            UI.SetActive(false);
            Timer.SetActive(false);
            Goal.SetActive(true);
            Vic.SetActive(false);
            other.gameObject.SetActive(false);
        }
        else {

            mis.SetActive(true);
            Invoke("dela", 5);

        }

    }

    void dela()
    {
        mis.SetActive(false);
    }
}
