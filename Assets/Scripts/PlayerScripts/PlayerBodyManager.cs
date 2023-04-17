using UnityEngine;

public class PlayerBodyManager : MonoBehaviour
{
    [Header("BodyParts")]
    public GameObject head;
    public GameObject l_arm;
    public GameObject r_arm;
    public GameObject chest;
    public GameObject l_leg;
    public GameObject r_leg;
    public GameObject r_handWeapon;
    public GameObject l_handWeapon;
    [Header("BodyParts' Rigidbody")]
    public Rigidbody2D headRb;
    public Rigidbody2D l_armRb;
    public Rigidbody2D r_armRb;
    public Rigidbody2D chestRb;
    public Rigidbody2D l_legRb;
    public Rigidbody2D r_legRb;
    private void Awake() {
        Rigidbody2D headRb = GetComponent<Rigidbody2D>();
        Rigidbody2D l_armRb = GetComponent<Rigidbody2D>();
        Rigidbody2D r_armRb = GetComponent<Rigidbody2D>();
        Rigidbody2D chestRb = GetComponent<Rigidbody2D>();
        Rigidbody2D l_legRb = GetComponent<Rigidbody2D>();
        Rigidbody2D r_legRb = GetComponent<Rigidbody2D>();
    }

}
