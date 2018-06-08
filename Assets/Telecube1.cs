using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public enum Cube1Direction
{
    North,
    South,
    East,
    West
}

public class Telecube1 : MonoBehaviour
{

    public float rotationSpeed = 350;

    private bool _moving;
    private Cube1Direction _rotationDirection;
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
            if ((_rotationDirection == Cube1Direction.West) || (_rotationDirection == Cube1Direction.North))
                transform.RotateAround(_pivot, _axis, deltaRotation);
            else transform.RotateAround(_pivot, _axis, -deltaRotation);

            _totalRotation += deltaRotation;
        }
        else if (Input.GetKeyUp(KeyCode.UpArrow)) Rotate(Cube1Direction.North);
        else if (Input.GetKeyUp(KeyCode.LeftArrow)) Rotate(Cube1Direction.West);
        else if (Input.GetKeyUp(KeyCode.DownArrow)) Rotate(Cube1Direction.South);
        else if (Input.GetKeyUp(KeyCode.RightArrow)) Rotate(Cube1Direction.East);



    }

    void Rotate(Cube1Direction direction)
    {
        _rotationDirection = direction;
        _moving = true;
        _totalRotation = 0;

        switch (_rotationDirection)
        {
            case Cube1Direction.East:
                _pivot = transform.position + new Vector3(_scale.x, -_scale.y, 0);
                break;
            case Cube1Direction.West:
                _pivot = transform.position + new Vector3(-_scale.x, -_scale.y, 0);
                break;
            case Cube1Direction.North:
                _pivot = transform.position + new Vector3(0, -_scale.y, _scale.z);
                break;
            case Cube1Direction.South:
                _pivot = transform.position + new Vector3(0, -_scale.y, -_scale.z);
                break;
        }

        if ((_rotationDirection == Cube1Direction.East) || (_rotationDirection == Cube1Direction.West))
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

