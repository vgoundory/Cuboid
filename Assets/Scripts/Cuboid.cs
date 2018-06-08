using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public enum Direction
{
    North,
    South,
    East,
    West
}

public class Cuboid : MonoBehaviour
{
    public float rotationSpeed = 350;

    private bool _moving;
    private Direction _rotationDirection;
    private Vector3 _pivot;
    private float _totalRotation;
    private Vector3 _axis;
    private Vector3 _scale;
    internal static Type cs;

    void Start()
    {
        _moving = false;
        _scale = transform.localScale / 2.0f;
    }

    void Update()
    {
        if (_moving)
        {
            float deltaRotation = rotationSpeed * Time.deltaTime;
            if (_totalRotation + deltaRotation >= 90)
            {
                deltaRotation = 90 - _totalRotation;
                _moving = false;
            }
            if ((_rotationDirection == Direction.West) || (_rotationDirection == Direction.North))
                transform.RotateAround(_pivot, _axis, deltaRotation);
            else transform.RotateAround(_pivot, _axis, -deltaRotation);

            _totalRotation += deltaRotation;
        }
        else if (Input.GetKeyUp(KeyCode.UpArrow)) Rotate(Direction.North);
        else if (Input.GetKeyUp(KeyCode.LeftArrow)) Rotate(Direction.West);
        else if (Input.GetKeyUp(KeyCode.DownArrow)) Rotate(Direction.South);
        else if (Input.GetKeyUp(KeyCode.RightArrow)) Rotate(Direction.East);


        
    }

    void Rotate(Direction direction)
    {
        _rotationDirection = direction;
        _moving = true;
        _totalRotation = 0;

        switch (_rotationDirection)
        {
            case Direction.East:
                _pivot = transform.position + new Vector3(_scale.x, -_scale.y, 0);
                break;
            case Direction.West:
                _pivot = transform.position + new Vector3(-_scale.x, -_scale.y, 0);
                break;
            case Direction.North:
                _pivot = transform.position + new Vector3(0, -_scale.y, _scale.z);
                break;
            case Direction.South:
                _pivot = transform.position + new Vector3(0, -_scale.y, -_scale.z);
                break;
        }

        if ((_rotationDirection == Direction.East) || (_rotationDirection == Direction.West))
        {
            _axis = Vector3.forward;
            float temp = _scale.x;
            _scale.x = _scale.y;
            _scale.y = temp;
        }
        else
        {
            _axis = Vector3.right;
            float temp = _scale.z;
            _scale.z = _scale.y;
            _scale.y = temp;
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

