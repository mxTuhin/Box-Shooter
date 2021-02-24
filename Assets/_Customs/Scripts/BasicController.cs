using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicController : MonoBehaviour
{
    public float moveSpeed = 10.0f;

    private float primarySpeed;
    public float gravity = 9.81f;
    public float runSpeed = 30.0f;
    private CharacterController myController;
    // Start is called before the first frame update
    void Start()
    {
        myController = gameObject.GetComponent<CharacterController>();
        primarySpeed = moveSpeed;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift)){
            moveSpeed = runSpeed;
        }
        else
        {
            moveSpeed = primarySpeed;
        }
        // Vertical Move
        Vector3 movementZ = Input.GetAxis("Vertical") * Vector3.forward * moveSpeed * Time.deltaTime;
        // Horizaontal Move
        Vector3 movementX = Input.GetAxis("Horizontal") * Vector3.right * moveSpeed * Time.deltaTime;
        // Convert from local space to world space based on the position of the current gameObject
        Vector3 movement = transform.TransformDirection(movementZ + movementX);
        // apply gravity
        movement.y -= gravity * Time.deltaTime;

        myController.Move(movement);
        
        
    }
}
