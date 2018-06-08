using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public enum DirectionOfCuboid
{
    North,
    South,
    East,
    West
}

public class Cuboid : MonoBehaviour
{
    public float rotationSpeedOfCuboid = 350;

    private bool _CuboidMoving;
    private DirectionOfCuboid _rotationDirectionOfCuboid;
    private Vector3 _pivot;
    private float _totalRotationOfCuboid;
    private Vector3 _axis;
    private Vector3 _scale;

    void Start()
    {
        _CuboidMoving = false;
        _scale = transform.localScale / 2.0f;
    }

    void Update()
    {
        if (_CuboidMoving)
        {
            float deltaRotation = rotationSpeedOfCuboid * Time.deltaTime;
            if (_totalRotationOfCuboid + deltaRotation >= 90)
            {
                deltaRotation = 90 - _totalRotationOfCuboid;
                _CuboidMoving = false;
            }
            if ((_rotationDirectionOfCuboid == DirectionOfCuboid.West) || (_rotationDirectionOfCuboid == DirectionOfCuboid.North))
                transform.RotateAround(_pivot, _axis, deltaRotation);
            else transform.RotateAround(_pivot, _axis, -deltaRotation);

            _totalRotationOfCuboid += deltaRotation;
        }
        else if (Input.GetKeyUp(KeyCode.UpArrow)) Rotation(DirectionOfCuboid.North);
        else if (Input.GetKeyUp(KeyCode.LeftArrow)) Rotation(DirectionOfCuboid.West);
        else if (Input.GetKeyUp(KeyCode.DownArrow)) Rotation(DirectionOfCuboid.South);
        else if (Input.GetKeyUp(KeyCode.RightArrow)) Rotation(DirectionOfCuboid.East);
          
    }

    void Rotation(DirectionOfCuboid direction)
    {
        _rotationDirectionOfCuboid = direction;
        _CuboidMoving = true;
        _totalRotationOfCuboid = 0;

        switch (_rotationDirectionOfCuboid)
        {
            case DirectionOfCuboid.East:
                _pivot = transform.position + new Vector3(_scale.x, -_scale.y, 0);
                break;
            case DirectionOfCuboid.West:
                _pivot = transform.position + new Vector3(-_scale.x, -_scale.y, 0);
                break;
            case DirectionOfCuboid.North:
                _pivot = transform.position + new Vector3(0, -_scale.y, _scale.z);
                break;
            case DirectionOfCuboid.South:
                _pivot = transform.position + new Vector3(0, -_scale.y, -_scale.z);
                break;
        }

        if ((_rotationDirectionOfCuboid == DirectionOfCuboid.East) || (_rotationDirectionOfCuboid == DirectionOfCuboid.West))
        {
            _axis = Vector3.forward;
            float temp = _scale.x;
            _scale.x = _scale.y;
            _scale.y = temp;
        }
        else
        {
            _axis = Vector3.right;
            float t = _scale.z;
            _scale.z = _scale.y;
            _scale.y = t;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Border"))
        {
            GetComponent<Collider>().isTrigger = true;
            
        }
        if (other.gameObject.CompareTag("cubefall"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    
}

