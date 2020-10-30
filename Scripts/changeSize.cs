using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeSize : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.y) / 1.01f;
        }
        if (other.gameObject.tag == "Sphere" || other.gameObject.tag == "SphereA")
        {
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.y) * 1.01f;
        }
    }
}
