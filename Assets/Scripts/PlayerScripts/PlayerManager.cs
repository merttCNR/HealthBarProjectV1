using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int playerHealth = 10;
    PlayerBodyManager playerBodyManager;
    public BodyBarManager bodyBarManager;
    private BoxCollider2D boxCollider2D;
    void Start()
    {
        boxCollider2D = GetComponent<BoxCollider2D>();
        playerBodyManager = GetComponent<PlayerBodyManager>();
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Enemy")){
            playerHealth--;
            if(playerHealth <= 9){
                bodyBarManager.imageL_arm.color = Color.yellow;
                if(playerHealth <= 8){
                    bodyBarManager.imageL_arm.color = Color.red;
                    playerBodyManager.l_arm.transform.parent = null;
                    playerBodyManager.l_armRb.isKinematic = false;
                    playerBodyManager.l_armRb.simulated = true;
                    playerBodyManager.l_handWeapon.SetActive(false);
                    playerBodyManager.r_handWeapon.SetActive(true);
                }
            }

            if(playerHealth <= 7){
                bodyBarManager.imageL_leg.color = Color.yellow;
                if (playerHealth <= 6)
                {
                    bodyBarManager.imageL_leg.color = Color.red;
                    playerBodyManager.l_leg.transform.parent = null;
                    playerBodyManager.l_legRb.isKinematic = false;
                    playerBodyManager.l_legRb.simulated = true;
                }
            }
            if(playerHealth <= 5){
                bodyBarManager.imageR_arm.color = Color.yellow;
                if (playerHealth <= 4)
                {
                    bodyBarManager.imageR_arm.color = Color.red;
                    playerBodyManager.r_arm.transform.parent = null;
                    playerBodyManager.r_armRb.isKinematic = false;
                    playerBodyManager.r_armRb.simulated = true;
                }
            }
            if(playerHealth <= 3){
                bodyBarManager.imageR_leg.color = Color.yellow;
                if (playerHealth <= 2)
                {
                    bodyBarManager.imageR_leg.color = Color.red;
                    playerBodyManager.r_leg.transform.parent = null;
                    playerBodyManager.r_legRb.isKinematic = false;
                    playerBodyManager.r_legRb.simulated = true;
                    boxCollider2D.size = new Vector2(1.5f,1.9f);
                }
            }
            if(playerHealth <= 1){
                bodyBarManager.imageHead.color = Color.yellow;
                bodyBarManager.imageChest.color = Color.yellow;
                if (playerHealth <= 0)
                {
                    bodyBarManager.imageHead.color = Color.red;
                    bodyBarManager.imageChest.color = Color.red;
                    playerBodyManager.head.transform.parent = null;
                    playerBodyManager.chest.transform.parent = null;
                    playerBodyManager.headRb.isKinematic = false;
                    playerBodyManager.chestRb.isKinematic = false;
                    playerBodyManager.headRb.simulated = true;
                    playerBodyManager.chestRb.simulated = true;
                    Invoke("StopTime",3);
                    Debug.Log("Dead");
                }
            }
        }
    }
    private void StopTime(){
        Time.timeScale = 0;
    }
}
