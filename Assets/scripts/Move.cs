using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Move : MonoBehaviour
{
    public float moveSpeed = 3f;
    public GameObject Case;

    public void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            Case.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            Case.transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
        }
    }
}
