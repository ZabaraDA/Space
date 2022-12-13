using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Rigidbody _forwardDirection;
    [SerializeField] private Rigidbody _horizontalDirection;
    [SerializeField] private Rigidbody _verticalDirection;
    [SerializeField] private Rigidbody _rotationLeftDirection;
    [SerializeField] private Rigidbody _rotationRightDirection;
    [SerializeField] private float _forceVertical;
    [SerializeField] private float _forceHorizontal;
    [SerializeField] private float _forceRotation;

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _forwardDirection.AddRelativeForce(Vector3.forward * _speed * Time.deltaTime, ForceMode.Acceleration);
            //rigidbodyRL.AddRelativeForce(Vector3.forward * force);
            //rigidbodyLF.AddRelativeForce(Vector3.forward * force);
            //transform.Translate(_speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            _forwardDirection.AddRelativeForce(Vector3.forward * _speed * -Time.deltaTime, ForceMode.Acceleration);
            //rigidbodyLF.AddRelativeForce(Vector3.forward * -force);
            //rigidbodyRL.AddRelativeForce(Vector3.forward * -force);
            //transform.Translate(_speed * Time.deltaTime * -1, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            _horizontalDirection.AddRelativeForce(Vector3.up * _forceHorizontal * Time.deltaTime, ForceMode.Acceleration);
            //rigidbodyRL.AddRelativeForce(Vector3.forward * -force);
        }
        if (Input.GetKey(KeyCode.D))
        {
            _horizontalDirection.AddRelativeForce(Vector3.up * _forceHorizontal * 1 * -Time.deltaTime, ForceMode.Acceleration);
            //rigidbodyRL.AddRelativeForce(Vector3.forward * force);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            _verticalDirection.AddRelativeForce(Vector3.up * _forceVertical * 1 * Time.deltaTime, ForceMode.Acceleration);
            
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            _verticalDirection.AddRelativeForce(Vector3.up * _forceVertical * -Time.deltaTime, ForceMode.Acceleration); 
        }
        if (Input.GetKey(KeyCode.Q))
        {
            _rotationLeftDirection.AddRelativeForce(Vector3.up * _forceRotation * -Time.deltaTime, ForceMode.Acceleration);
            _rotationRightDirection.AddRelativeForce(Vector3.up * _forceRotation * Time.deltaTime, ForceMode.Acceleration);

        }
        if (Input.GetKey(KeyCode.E))
        {
            _rotationLeftDirection.AddRelativeForce(Vector3.up * _forceRotation * Time.deltaTime, ForceMode.Acceleration);
            _rotationRightDirection.AddRelativeForce(Vector3.up * _forceRotation * -Time.deltaTime, ForceMode.Acceleration);
        }
    }
}
