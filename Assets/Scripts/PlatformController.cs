using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{

    [SerializeField] Vector3 rotateSpeed;
    Rigidbody m_Rigidbody;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {

        Quaternion deltaRotation = Quaternion.Euler(rotateSpeed * Time.deltaTime);
        Quaternion oppositeRotation = Quaternion.Inverse(deltaRotation);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            m_Rigidbody.MoveRotation(m_Rigidbody.rotation * deltaRotation);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            m_Rigidbody.MoveRotation(m_Rigidbody.rotation * oppositeRotation);
        }
    }
}
