using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Atirar : MonoBehaviour
{
    public Soldado Sd;
    public float DistanciaTiro;
    public bool TIROX2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Atirando()
    {
        RaycastHit hit;

        Vector3 miraDaArma = transform.TransformDirection(
            Vector3.forward) * (20+DistanciaTiro);
        if (Physics.Raycast(transform.position, miraDaArma, out hit, 20+DistanciaTiro))
        {
            if (hit.collider.gameObject.tag == "Inimigo")
            {
                Debug.Log("Acertei O Inimigo");
                if(TIROX2 == true)
                {
                    hit.collider.gameObject.GetComponent<Soldado>().vida--;
                    hit.collider.gameObject.GetComponent<Soldado>().vida--;
                }
                else
                {
                    hit.collider.gameObject.GetComponent<Soldado>().vida--;
                }
                
                Debug.DrawLine(transform.position, miraDaArma, Color.blue);
            }

        }

    }
}
