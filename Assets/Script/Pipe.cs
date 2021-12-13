using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    // Start is called before the first frame update
    public float Speed;
    public Vector3 initialPosition;
    // Update is called once per frame
    void Start()
    {
        initialPosition = transform.position;
        this.enabled = false;
    }

    void Update()
    {
        transform.position -= Vector3.right * Speed;
    }

    public void relaunchObject()
    {
        transform.position = initialPosition;
    }

}
