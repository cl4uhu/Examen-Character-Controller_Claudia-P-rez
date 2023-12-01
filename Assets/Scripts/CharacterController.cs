using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    CharacterController _controller;
    Animator _animator;
    Transform _camera;
    
    float _horizontal;
    float _vertical; 
    
    [SerializeField] float _playerSpeed;
    [SerializeField] float jumpHeight; 

    float _gravity;
    Vector3 _playerGravity;

    [SerializeField] Transform _sensorPosition;
    [SerializeField] float _sensorRadius;
    [SerializeField] LayerMask _groundLayer;
    bool _isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
