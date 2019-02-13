using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBrazo : MonoBehaviour
{
    public Transform BaseGrua;
    public Transform Grua;
    public float FuerzaBrazo;
    public float Cuerpo;
    private float Angle;
    // Start is called before the first frame update
    void Start()
    {

        Angle = Grua.localRotation.eulerAngles.x;
        BaseGrua.parent = transform;
        Grua.parent = transform;
    
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Sirve");
            transform.eulerAngles += -Vector3.up * Cuerpo * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log(Angle);
            transform.eulerAngles += Vector3.up * Cuerpo * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
     
            if(Angle == -100)
            {

            }
            else
            {
                Grua.transform.eulerAngles += Vector3.right * FuerzaBrazo * Time.deltaTime;
            }
     
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log(transform.localRotation.eulerAngles);
            if (Angle == -40)
            {

            }
            else
            {
                Grua.transform.eulerAngles += -Vector3.right * FuerzaBrazo * Time.deltaTime;
            }
        }
    }
}
