using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private PlayerMovement playerMovement;

    private void Awake()
    {
        playerMovement = new PlayerMovement();
    }

    private void OnEnable()
    {
        playerMovement.Enable();
    }
    private void OnDisable()
    {
        playerMovement.Disable();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        Vector2 movement = playerMovement.Land.Movement.ReadValue<Vector2>();
        Debug.Log(movement);
        //playerMovement.Land.Jump.ReadValue<float>();
        //if (playerMovement.Land.Jump.ReadValue<float>() == 1)
        if (playerMovement.Land.Jump.triggered)
        {
            Debug.Log("Jump");
        }
    }
}
