using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    public float speed = 200f;
    public float force = 200f;
    public bool isGround;

    void Update()
    {
        float H = Input.GetAxis("Horizontal");
        float V = Input.GetAxis("Vertical");

        // Si la touche de la flèche droite est enfoncée, déplace l'objet vers la droite
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        // Si la touche de la flèche gauche est enfoncée, déplace l'objet vers la gauche
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        else
        {
            // Si aucune des touches n'est enfoncée, applique le mouvement selon les axes Horizontal et Vertical
            Vector3 mvt = new Vector3(H, 0f, V);
            transform.Translate(mvt * speed * Time.deltaTime);
        }

        if (Input.GetButtonUp("Jump"))
        {
            Debug.Log("F button up");
        }
        if (Input.GetMouseButton(0))
        {
            Debug.Log("left Button clicked");
        }
        if (Input.GetMouseButton(1))
        {
            Debug.Log("right Button clicked");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Ground"))
        {
            isGround = true;
        }
    }
}
