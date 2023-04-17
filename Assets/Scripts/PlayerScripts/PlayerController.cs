using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Inputs")]
    float xInput;
    float yInput;
    [Header("Rigidbody2D")]
     Rigidbody2D playerRigidbody;
    [Header("Speed")]
    float jumpSpeed = 20f;
    float playerSpeed = 20f;
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        InputChecker();
        PlayerMove();
    }
    private void InputChecker(){
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");
    }
    private void PlayerMove(){
        playerRigidbody.velocity = new Vector2(xInput * playerSpeed,yInput * jumpSpeed);
    }
}
