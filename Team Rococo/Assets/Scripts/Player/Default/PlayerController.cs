using UnityEngine;

public class PlayerController : MonoBehaviour
{
    GameObject gPlayer;
    Rigidbody cRigidBody;
    CharacterController cCharacterController;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cRigidBody = GetComponent<Rigidbody>();
        cCharacterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float vInputX = Input.GetAxis("Horizontal");
        float vInputZ = Input.GetAxis("Vertical");

        Vector3 vMoveDirection = new Vector3(vInputX, 0, vInputZ);
        cCharacterController.Move(transform.position + vMoveDirection * Time.deltaTime);
    }
}
