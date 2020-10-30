using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scapeTrigger : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            float valueMove = 0.5f;
            if (transform.position.x < other.transform.position.x)
            {
                transform.position = new Vector3(transform.position.x + valueMove, transform.position.y, transform.position.z);
            }
            else if (transform.position.x > other.transform.position.x)
            {
                transform.position = new Vector3(transform.position.x - valueMove, transform.position.y, transform.position.z);
            }
            if (transform.position.z < other.transform.position.z)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - valueMove);
            }
            else if (transform.position.z > other.transform.position.z)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + valueMove);
            }
        }
    }
}
