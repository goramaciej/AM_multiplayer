using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementComponent : MonoBehaviour
{
    [SerializeField] private float speedMultiplier = 5f;
    CharacterController controller;
    
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * speedMultiplier * Time.deltaTime;
        float z = Input.GetAxis("Vertical") * speedMultiplier * Time.deltaTime;
        Vector3 moveDelta = new Vector3(x, 0, z);

        controller.Move(moveDelta);
    }
}
