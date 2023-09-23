using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public float VelocidadVertical;
    public float VelocidadHorizontal;

    float EjeX;
    float EjeY;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        EjeY += VelocidadHorizontal * Input.GetAxis("Mouse X");
        EjeX -= VelocidadVertical * Input.GetAxisRaw("Mouse Y");

        transform.eulerAngles = new Vector3(EjeX, EjeY, 0.0f);
    }
}
