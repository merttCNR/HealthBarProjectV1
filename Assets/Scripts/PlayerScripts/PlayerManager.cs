using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField]int playerHealth = 10;
    PlayerBodyManager playerBodyManager;
    // Start is called before the first frame update
    void Start()
    {
        playerBodyManager = GetComponent<PlayerBodyManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Enemy")){
            playerHealth--;
            if(playerHealth <= 8){
                playerBodyManager.l_armRb.isKinematic = false;
                playerBodyManager.l_arm.transform.parent = null;
                
            }
            if(playerHealth <= 6){
                playerBodyManager.l_leg.transform.parent = null;
                playerBodyManager.l_legRb.isKinematic = false;
            }
            if(playerHealth <= 4){
                playerBodyManager.r_arm.transform.parent = null;
                playerBodyManager.r_armRb.isKinematic = false;
            }
            if(playerHealth <= 2){
                playerBodyManager.r_leg.transform.parent = null;
                playerBodyManager.r_legRb.isKinematic = false;
            }
            if(playerHealth <= 0){
                playerBodyManager.head.transform.parent = null;
                playerBodyManager.chest.transform.parent = null;
                playerBodyManager.headRb.isKinematic = false;
                playerBodyManager.chestRb.isKinematic = false;
                Debug.Log("Dead");
            }
        }
    }
}
