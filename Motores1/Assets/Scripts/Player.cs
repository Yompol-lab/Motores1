using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    float speed = 5f;
    void Update()
    {
        float horizontalinput = Input.GetAxis("Horizontal");
        float verticalinput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(horizontalinput, 0, verticalinput);

        transform.position = transform.position + movementDirection * speed * Time.deltaTime;




    }
}
