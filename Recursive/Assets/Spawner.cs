using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    GameObject prefab;
    void Start()
    {
        if (transform.localScale.x > 0.1f)
        {
            prefab = Resources.Load("Cube") as GameObject;
            prefab.transform.localScale = transform.localScale / 2f;
            Instantiate(prefab, transform.position + transform.localScale , Quaternion.identity);
            Instantiate(prefab, transform.position + transform.localScale , Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
