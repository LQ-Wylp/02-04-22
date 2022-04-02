using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [Header("Option")]
    public bool _MoveActive = true;

    [Header("Controls")]
    public Vector2 _Move;

    [Header("Physics")]
    public float _RotateSpeed;
    public float _Acceleration = 100;
    private float _InitialAccel;
    public float _Friction = 10;
    private Vector3 _Velocity;
    private CharacterController _CharacterController;
    public float _GravityPower = 1;

    [Header("Acceleration")]
    public float _CdAccel;
    public float _DurationAccel;
    public float _CoefSpeedAccel;
    private float _TimeAccel;
    private float _TimeCdAccel;
    private bool _AccelUsed;

    void Start()
    {
        _InitialAccel = _Acceleration;
        _TimeCdAccel = _CdAccel;
        _CharacterController = GetComponent<CharacterController>();
        _Velocity = Vector3.zero;
    }

    void Update()
    {

        if(_AccelUsed)
        {
            if(_TimeAccel < _DurationAccel)
            {
                _TimeAccel += Time.deltaTime;
            }
            else
            {
               _AccelUsed = false; 
               _Acceleration = _InitialAccel;
            }
        }
        else
        {
            _TimeCdAccel += Time.deltaTime;

            if(PlayerManager._playerManager._Accel == 1 && _TimeCdAccel >= _CdAccel)
            {
                _TimeAccel = 0;
                _TimeCdAccel = 0;

                _AccelUsed = true; 
                _Acceleration = _InitialAccel * _CoefSpeedAccel;
            }
        }

        _Move = PlayerManager._playerManager._MoveInput;

        if(_MoveActive)
        {
            Vector3 move = Vector3.zero;

            if (_Move.y > 0)
            {
                move += transform.forward * _Acceleration;
            }

            if (_Move.y < 0)
            {
                move -= transform.forward * _Acceleration;
            }

            if (_Move.x > 0)
            {
                transform.Rotate(0,1 * Time.deltaTime * _RotateSpeed,0, Space.World);
            }

            if (_Move.x < 0)
            {
                transform.Rotate(0,-1 * Time.deltaTime * _RotateSpeed,0, Space.World);
            }

            _Velocity += move * Time.deltaTime;
            _Velocity += Physics.gravity * _GravityPower * Time.deltaTime;

            float VerticalVel = _Velocity.y;
            Vector2 HorizontalVel = _Velocity.xz();
            HorizontalVel -= HorizontalVel * _Friction * Time.deltaTime;
            _Velocity = HorizontalVel.x_y(VerticalVel);

            _CharacterController.Move(_Velocity * Time.deltaTime);

            if (_CharacterController.isGrounded)
            {
                _Velocity.y = 0;
            }
            
        }

        
    }
}
