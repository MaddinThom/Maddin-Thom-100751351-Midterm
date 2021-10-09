using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinCollect : MonoBehaviour
{
    public float coins;

    // Start is called before the first frame update
    void Start()
    {
        coins = 0;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            coins += 1;
            GUI.Label(new Rect(5, 5, 10, 100), coins + "/10 Coins Collected");
        }

        if (coins >= 10)
        {
            SceneManager.LoadScene("End");
        }
    }
}
