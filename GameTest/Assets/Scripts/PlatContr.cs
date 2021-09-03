using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatContr : MonoBehaviour
{
    public float speedMove;
    public float speed;


    private float gravityForce;
    private Vector3 moveVector;
    private Vector3 pointVector;
    private JScontroller pContr;
    private CharacterController characterController;
    
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        pContr = GameObject.FindGameObjectWithTag("Joystick").GetComponent<JScontroller>();
        pointVector.x = 0;
        pointVector.y = 2.217136f;
        pointVector.z = -10.36f;
    }

    // Update is called once per frame
    void Update()
    {
        PlatformMove();
    }

    //перемещение платформы
    private void PlatformMove()
    {
        moveVector = Vector3.zero;
        moveVector.x = pContr.Vertical()* speedMove;
        moveVector.y = pContr.Horizontal() * speedMove;

        characterController.transform.RotateAround(pointVector, moveVector, speed * Time.deltaTime);
    }
}
