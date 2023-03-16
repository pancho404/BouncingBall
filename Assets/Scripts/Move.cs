using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update

    Vector3 moveDirection = new Vector3();  

    void Start()
    {
        moveDirection.x = Random.Range(-10, 10);
        moveDirection.y = Random.Range(-10, 10);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += moveDirection * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        moveDirection = Vector3.Reflect(moveDirection, collision.GetContact(0).normal);
    }
}
