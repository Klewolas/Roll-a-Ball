using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopKontrol : MonoBehaviour
{
    Rigidbody fizik;
    public int hiz;
    public int toplanilacakObje;
    int sayac;
    public Text sayacText;
    public Text gameOver;
    float x;
    float y;
    float z;
    Vector3 pos;

    void Start()
    {
        fizik = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float yatay = Input.GetAxisRaw("Horizontal");
        float dikey = Input.GetAxisRaw("Vertical");

        Vector3 vec = new Vector3(yatay, 0, dikey);

        fizik.AddForce(vec*hiz);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "koyun")
        {
            other.gameObject.SetActive(false);
            sayac++;
            other.gameObject.SetActive(true);
            x = Random.Range(-9, 9);
            y = 0.5f;
            z = Random.Range(-9, 9);
            pos = new Vector3(x, y, z);
            other.transform.position = pos;

            sayacText.text = "Sayac = " + sayac;
            if(toplanilacakObje == sayac)
            {
               // gameOver.text = "GAME OVER!!";
            }
        }
    }
}
