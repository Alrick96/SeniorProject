using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    private Vector3 Origin = new Vector3();
    //public Vector3 Position = new Vector3();

    [SerializeField] private float RotationbySecond = 10f;
    [SerializeField] private float Frequency = 1f;
    [SerializeField] private float Hight = 3f;

    // Start is called before the first frame update
    void Start()
    {
        Origin = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 tmpLocation = Origin;
        tmpLocation.y += Mathf.Sin(Time.fixedTime * Mathf.PI * Frequency) * Hight;
        transform.Rotate(new Vector3(0f,Time.deltaTime*RotationbySecond, 0f), Space.World);
        transform.position = tmpLocation;

    }
}
