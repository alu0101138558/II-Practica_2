using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    private float horizontalMove;
    private float verticalMove;
    public CharacterController player;
    public float playerSpeed;

    // Start is called before the first frame update
    void Start()
    {
        player = gameObject.GetComponent<CharacterController>();
        playerSpeed = 10f;
    }
    // Update is called once per frame
    void Update()
    {
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.I))
        {
            player.Move(Vector3.forward * playerSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.M))
        {
            player.Move(Vector3.back * playerSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.J))
        {
            player.Move(Vector3.left * playerSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.L))
        {
            player.Move(Vector3.right * playerSpeed * Time.deltaTime);
        }
    }
}
