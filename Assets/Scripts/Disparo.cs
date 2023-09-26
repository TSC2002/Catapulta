using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public GameObject Bala;
    public Transform SpawnDeLaBala;

    public float FuerzaDeTiro = 1500f;
    public float FuerzaDeTiros = 0.5f;

    private float TiempoDeDisparo = 0;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (Time.time > TiempoDeDisparo)
            {
                GameObject NuevaBala;

                NuevaBala = Instantiate(Bala, SpawnDeLaBala.position, SpawnDeLaBala.rotation);

                NuevaBala.GetComponent<Rigidbody>().AddForce(SpawnDeLaBala.forward * FuerzaDeTiro);

                TiempoDeDisparo = Time.time + FuerzaDeTiros;

                Destroy(NuevaBala, 2);
            }
        }
    }
}
