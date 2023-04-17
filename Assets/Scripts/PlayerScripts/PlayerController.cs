using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Inputs")]
    float xInput;
    float yInput;
    [Header("Rigidbody2D")]
    Rigidbody2D playerRigidbody;
    [Header("Speed")]
    float jumpSpeed = 5f;
    float playerSpeed = 20f;
    [Header("GroundCheck")]
    bool isGrounded;
    
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
        playerRigidbody.velocity = Vector2.right * xInput * playerSpeed;
    }
    private void PlayerJump(){
       // 2D'de jump kodu olmuyor??????
    }
   private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("Ground")){
            isGrounded = true;
        }
        else{
            isGrounded = false;
        }
   }
}
