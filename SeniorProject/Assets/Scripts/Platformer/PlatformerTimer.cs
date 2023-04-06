using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlatformerTimer : MonoBehaviour
{

    public float time;
    public TextMeshProUGUI timeText;




    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        time -= 1 * Time.deltaTime;
        timeText.text = time.ToString("0");
        if (time <= 0)
        {
            time = 0;
        }
    }
}