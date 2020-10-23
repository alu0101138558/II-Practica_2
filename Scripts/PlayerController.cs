using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
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
  void Update() {
    horizontalMove = Input.GetAxis("Horizontal");
    verticalMove = Input.GetAxis("Vertical");
  }

  private void FixedUpdate() {
    player.Move(new Vector3(horizontalMove, 0, verticalMove) * playerSpeed * Time.deltaTime);
  }
}
