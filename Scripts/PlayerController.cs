﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private float horizontalMove;
    private float verticalMove;
    public CharacterController player;
    public float playerSpeed;
    private float y;

    // Start is called before the first frame update
    void Start() {
        player = gameObject.GetComponent<CharacterController>();
        playerSpeed = 10f;
    }
  // Update is called once per frame
  void Update() {
    horizontalMove = Input.GetAxis("Horizontal");
    verticalMove = Input.GetAxis("Vertical");
    if (Input.GetKey(KeyCode.Y)) {
       y += Time.deltaTime * 100;
       transform.rotation = Quaternion.Euler(0, y, 0);
    } else if (Input.GetKey(KeyCode.O)) {
       y -= Time.deltaTime * 100;
       transform.rotation = Quaternion.Euler(0, y, 0);
    }
  }

  private void FixedUpdate() {
    player.Move(new Vector3(horizontalMove, -0.9f, verticalMove) * playerSpeed * Time.deltaTime);
  }
}
