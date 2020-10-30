using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class collisionCube : MonoBehaviour
{
    private Renderer colorPlayer;
    // Start is called before the first frame update
    void Start()
    {
        colorPlayer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Sphere"|| collision.gameObject.tag == "SphereA")
        {
            colorPlayer.material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        }
    }
 
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "SphereA" && Input.GetKey(KeyCode.Space))
        {
            Rigidbody actualSphere = collision.collider.attachedRigidbody;
            if (transform.position.x < actualSphere.transform.position.x) 
            {
                actualSphere.transform.position = new Vector3(actualSphere.position.x + 1, actualSphere.position.y, actualSphere.position.z);
            } else if (transform.position.x > actualSphere.transform.position.x) {
                actualSphere.transform.position = new Vector3(actualSphere.position.x - 1, actualSphere.position.y, actualSphere.position.z);
            }
        }
    }
}
