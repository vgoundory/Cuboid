using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction
{
    North,
    South,
    East,
    West
}

public enum Orientation
{
    YUp_XEast,
    YUp_ZEast,
    XUp_YEast,
    XUp_ZEast,
    ZUp_XEast,
    ZUp_YEast
}

public class Cuboid : MonoBehaviour
{

    public float rotationSpeed = 250;

    private Orientation _orientation;
    private bool _moving;
    private Direction _rotationDirection;
    private Vector3 _pivot;
    private float _totalRotation;
    private Vector3 _axis;
    private Vector3 _scale;

    void Start()
    {
        _moving = false;
        _orientation = Orientation.YUp_XEast;
        _scale = transform.localScale;
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
        else if (Input.GetKeyUp(KeyCode.W)) Rotate(Direction.North);
        else if (Input.GetKeyUp(KeyCode.A)) Rotate(Direction.West);
        else if (Input.GetKeyUp(KeyCode.S)) Rotate(Direction.South);
        else if (Input.GetKeyUp(KeyCode.D)) Rotate(Direction.East);

    }

    void Rotate(Direction direction)
    {
        _rotationDirection = direction;
        _moving = true;
        _totalRotation = 0;

        switch (_rotationDirection)
        {
            case Direction.East:
                switch (_orientation)
                {
                    case Orientation.XUp_YEast:
                        _pivot = transform.position + new Vector3(_scale.y / 2.0f, -_scale.x / 2.0f, 0);
                        _orientation = Orientation.YUp_XEast;
                        break;
                    case Orientation.XUp_ZEast:
                        _pivot = transform.position + new Vector3(_scale.z / 2.0f, -_scale.x / 2.0f, 0);
                        _orientation = Orientation.ZUp_XEast;
                        break;
                    case Orientation.YUp_XEast:
                        _pivot = transform.position + new Vector3(_scale.x / 2.0f, -_scale.y / 2.0f, 0);
                        _orientation = Orientation.XUp_YEast;
                        break;
                    case Orientation.YUp_ZEast:
                        _pivot = transform.position + new Vector3(_scale.z / 2.0f, -_scale.y / 2.0f, 0);
                        _orientation = Orientation.ZUp_YEast;
                        break;
                    case Orientation.ZUp_YEast:
                        _pivot = transform.position + new Vector3(_scale.y / 2.0f, -_scale.z / 2.0f, 0);
                        _orientation = Orientation.YUp_ZEast;
                        break;
                    case Orientation.ZUp_XEast:
                        _pivot = transform.position + new Vector3(_scale.x / 2.0f, -_scale.z / 2.0f, 0);
                        _orientation = Orientation.XUp_ZEast;
                        break;
                }
                _axis = Vector3.forward;
                break;
            case Direction.West:
                switch (_orientation)
                {
                    case Orientation.XUp_YEast:
                        _pivot = transform.position + new Vector3(-_scale.y / 2.0f, -_scale.x / 2.0f, 0);
                        _orientation = Orientation.YUp_XEast;
                        break;
                    case Orientation.XUp_ZEast:
                        _pivot = transform.position + new Vector3(-_scale.z / 2.0f, -_scale.x / 2.0f, 0);
                        _orientation = Orientation.ZUp_XEast;
                        break;
                    case Orientation.YUp_XEast:
                        _pivot = transform.position + new Vector3(-_scale.x / 2.0f, -_scale.y / 2.0f, 0);
                        _orientation = Orientation.XUp_YEast;
                        break;
                    case Orientation.YUp_ZEast:
                        _pivot = transform.position + new Vector3(-_scale.z / 2.0f, -_scale.y / 2.0f, 0);
                        _orientation = Orientation.ZUp_YEast;
                        break;
                    case Orientation.ZUp_YEast:
                        _pivot = transform.position + new Vector3(-_scale.y / 2.0f, -_scale.z / 2.0f, 0);
                        _orientation = Orientation.YUp_ZEast;
                        break;
                    case Orientation.ZUp_XEast:
                        _pivot = transform.position + new Vector3(-_scale.x / 2.0f, -_scale.z / 2.0f, 0);
                        _orientation = Orientation.XUp_ZEast;
                        break;
                }
                _axis = Vector3.forward;
                break;
            case Direction.North:
                switch (_orientation)
                {
                    case Orientation.XUp_YEast:
                        _pivot = transform.position + new Vector3(0, -_scale.x / 2.0f, _scale.z / 2.0f);
                        _orientation = Orientation.ZUp_YEast;
                        break;
                    case Orientation.XUp_ZEast:
                        _pivot = transform.position + new Vector3(0, -_scale.x / 2.0f, _scale.y / 2.0f);
                        _orientation = Orientation.YUp_ZEast;
                        break;
                    case Orientation.YUp_XEast:
                        _pivot = transform.position + new Vector3(0, -_scale.y / 2.0f, _scale.z / 2.0f);
                        _orientation = Orientation.ZUp_XEast;
                        break;
                    case Orientation.YUp_ZEast:
                        _pivot = transform.position + new Vector3(0, -_scale.y / 2.0f, _scale.x / 2.0f);
                        _orientation = Orientation.XUp_ZEast;
                        break;
                    case Orientation.ZUp_YEast:
                        _pivot = transform.position + new Vector3(0, -_scale.z / 2.0f, _scale.x / 2.0f);
                        _orientation = Orientation.XUp_YEast;
                        break;
                    case Orientation.ZUp_XEast:
                        _pivot = transform.position + new Vector3(0, -_scale.z / 2.0f, _scale.y / 2.0f);
                        _orientation = Orientation.YUp_XEast;
                        break;
                }
                _axis = Vector3.right;
                break;
            case Direction.South:
                switch (_orientation)
                {
                    case Orientation.XUp_YEast:
                        _pivot = transform.position + new Vector3(0, -_scale.x / 2.0f, -_scale.z / 2.0f);
                        _orientation = Orientation.ZUp_YEast;
                        break;
                    case Orientation.XUp_ZEast:
                        _pivot = transform.position + new Vector3(0, -_scale.x / 2.0f, -_scale.y / 2.0f);
                        _orientation = Orientation.YUp_ZEast;
                        break;
                    case Orientation.YUp_XEast:
                        _pivot = transform.position + new Vector3(0, -_scale.y / 2.0f, -_scale.z / 2.0f);
                        _orientation = Orientation.ZUp_XEast;
                        break;
                    case Orientation.YUp_ZEast:
                        _pivot = transform.position + new Vector3(0, -_scale.y / 2.0f, -_scale.x / 2.0f);
                        _orientation = Orientation.XUp_ZEast;
                        break;
                    case Orientation.ZUp_YEast:
                        _pivot = transform.position + new Vector3(0, -_scale.z / 2.0f, -_scale.x / 2.0f);
                        _orientation = Orientation.XUp_YEast;
                        break;
                    case Orientation.ZUp_XEast:
                        _pivot = transform.position + new Vector3(0, -_scale.z / 2.0f, -_scale.y / 2.0f);
                        _orientation = Orientation.YUp_XEast;
                        break;
                }
                _axis = Vector3.right;
                break;
        }
    }
}
 

