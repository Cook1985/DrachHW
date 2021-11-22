using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManManager : MonoBehaviour
{
    [SerializeField]
    private float _speedMove = 30f;
    private Vector3 _moveVector;
    private CharacterController _characterController;
   

    void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    private void FixedUpdate()
    {
        MoveCharacter();
    }

 
    private void MoveCharacter()
    {
        _moveVector = Vector3.zero;
        _moveVector.x = Input.GetAxis("Horizontal") * _speedMove;
        _moveVector.z = Input.GetAxis("Vertical") * _speedMove;

        _characterController.Move(_moveVector * Time.deltaTime);
    }
}
