using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Inputs")]
    float xInput;
    [Header("Rigidbody2D")]
    Rigidbody2D playerRigidbody;
    [Header("Speed")]
    float jumpSpeed = 30f;
    float playerSpeed = 500f;
    [Header("RaycastVar")]
    private float raycastDistance = 1.5f;
    public bool isGrounded;
    public LayerMask groundLayer;


    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        InputChecker();
        //GroundCheck();
        PlayerJump();
        PlayerMove();
    }
    private void InputChecker(){
        xInput = Input.GetAxis("Horizontal");
    }
    private void PlayerMove(){
        playerRigidbody.velocity = new Vector2(xInput,0) * playerSpeed *Time.deltaTime;
    }
    private void PlayerJump(){
        if(Input.GetKeyDown(KeyCode.Space)){
            playerRigidbody.AddForce(Vector2.up * jumpSpeed,ForceMode2D.Impulse);
        }
    }
   /*private void GroundCheck(){
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, raycastDistance , groundLayer);
        Debug.DrawRay(transform.position,Vector2.down,Color.red);
        if(hit.collider != null){
            isGrounded = true;
            Debug.Log(hit.collider.tag);
        }
       else{
            isGrounded = false;
        }
    }*/
}
