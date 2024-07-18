using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    private int count;
    public TextMeshProUGUI countText, winText;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        
    }


   private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
        rb.AddForce(movement * speed);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("coin"))
        {
            other.gameObject.SetActive(false);
           count++;
            countText.text = "COUNT - " + count.ToString();
            if (count >= 8)

                winText.gameObject.SetActive(true);
        


        }
    }
}
