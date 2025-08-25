using UnityEngine;

public class PlayerController : MonoBehaviour
{
    GameObject gPlayer;
    CharacterController cCharacterController;
    Rigidbody cRigidbody;

    float vInputX;
    float vInputZ;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cCharacterController = GetComponent<CharacterController>();
        cRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        vInputX = Input.GetAxis("Horizontal");
        vInputZ = Input.GetAxis("Vertical");

        Vector3 vMoveDirection = new Vector3(vInputX, 0, vInputZ);

        cRigidbody.MovePosition(transform.position + vMoveDirection.normalized * 3.0f * Time.deltaTime);
;    }
}
