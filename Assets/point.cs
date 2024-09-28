using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class point : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        float x = Random.Range(0, 15);
        float y = Random.Range(5, 20);
        float z = Random.Range(0, 15);

        Debug.Log("Good Shot!");

        this.transform.position = new Vector3(x, y, z);
    }
}
