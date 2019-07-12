using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov : MonoBehaviour
{
    public float r = 10;

    float theta;
    float phi;


    // Start is called before the first frame update
    void Start()
    {
        theta = Random.Range(0, 100);
        phi = Random.Range(0, 100);

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 pos = new Vector3();
        pos.x = r * Mathf.Sin(phi) * Mathf.Cos(theta);
        pos.y = r * Mathf.Sin(phi) * Mathf.Sin(theta);
        pos.z = r * Mathf.Cos(phi);

        transform.position = pos;


        theta += 0.01f;
        phi += 0.01f;
    }
}
