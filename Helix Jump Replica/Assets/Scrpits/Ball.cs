using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody rb;

    public float JumpForce;
    private GameManager gm;
    public GameObject splashPrefab;

    public void Start()
    {
        gm=GameObject.FindAnyObjectByType<GameManager>();
    }


    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        rb.AddForce(Vector3.up * JumpForce);
        GameObject splash = Instantiate(splashPrefab,transform.position + new Vector3(0f, -0.2f, 0f), transform.rotation);
        splash.transform.SetParent(other.gameObject.transform);
        string materialName = other.gameObject.GetComponent<MeshRenderer>().material.name;
        if (materialName == "Safe Color (Instance")
        {

        }
        if (materialName == "Unsafe Color")
        {
            gm.RestartGame();
        }

        else if (materialName == "Last Ring (Instance)")
        {

        }
    }
}
