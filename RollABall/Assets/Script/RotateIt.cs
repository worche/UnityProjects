using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateIt : MonoBehaviour {

    public float rotateX;
    public float rotateY;
    public float rotateZ;

    void Awake()
    {
        rotateX = Random.Range(10f, 50f);
        rotateY = Random.Range(10f, 50f);
        rotateZ = Random.Range(10f, 50f);
    }

    void Update()
    {
        transform.Rotate(new Vector3(rotateX, rotateY, rotateZ) * Time.deltaTime);
    }

}
