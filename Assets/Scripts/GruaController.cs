using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GruaController : MonoBehaviour
{
    public Transform Base;
    public Transform Cuerpo;
    public Transform BaseGrua;
    public Transform Grua;
    public Transform Grua2;
    public Transform Grua3;
    public Transform Grua4;
    private Rigidbody rb;
    public float Velocidad;
    public AudioSource Andando;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Base.parent = transform;
        Cuerpo.parent = transform;
        BaseGrua.parent = transform;
        Grua.parent = transform;
        Grua2.parent = transform;
        Grua3.parent = transform;
        Grua4.parent = transform;
    }

    // Update is called once per frame

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("Sirve");
            rb.AddForce(-transform.up* Velocidad);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("Sirve");
            rb.AddForce(transform.up * Velocidad);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Sirve");
            transform.eulerAngles += -Vector3.up * 40 * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Sirve");
            transform.eulerAngles += Vector3.up * 40 * Time.deltaTime;
        }
    }
}
