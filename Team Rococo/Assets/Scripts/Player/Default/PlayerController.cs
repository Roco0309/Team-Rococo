using UnityEngine;
using UnityEngine.InputSystem.XR;

public class PlayerController : MonoBehaviour
{
    GameObject gPlayer;
    Rigidbody cRigidBody;
    CharacterController cCharacterController;

    Vector3 vVelocity = new Vector3(0, 0, 0);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cRigidBody = GetComponent<Rigidbody>();
        cCharacterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float vInputX = Input.GetAxis("Horizontal");
        float vInputZ = Input.GetAxis("Vertical");

        Vector3 vMoveDirection = new Vector3(vInputX, 0, vInputZ);
        

        cCharacterController.Move(vMoveDirection.normalized * SystemData.I.sPlayerInfo.vMoveSpeed * Time.deltaTime);

        if (cCharacterController.isGrounded && vVelocity.y < 0)
        {
            vVelocity.y = -2f;
            Debug.Log(cCharacterController.isGrounded);
        }
        vVelocity.y += Physics.gravity.y * Time.deltaTime;

        if (cCharacterController.isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            vVelocity.y = Mathf.Sqrt(-2f * Physics.gravity.y * SystemData.I.sPlayerInfo.vJumpPower);
        } else if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            vMoveDirection *= SystemData.I.sPlayerInfo.vDashSpeed;
        }
        vVelocity.y += Physics.gravity.y * Time.deltaTime;
        cCharacterController.Move(vVelocity * Time.deltaTime);
    }
}
