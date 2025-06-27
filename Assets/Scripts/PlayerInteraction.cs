using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInteraction : MonoBehaviour
{
    public int health;

    private GameObject win;
    // Start is called before the first frame update
    private void Start()
    {
        win = GameObject.Find("Win");
            win.SetActive(false);
    }
    private void Update()
    {
        if(GameObject.FindGameObjectWithTag("Coin") == null)
        {
            win.SetActive(true);
            Destroy(GetComponent<Collider2D>());
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
        }
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D colision)
    {
        if (colision.gameObject.CompareTag("Enemy"))
        {
            health--;
            if (health <= 0)
                SceneManager.LoadScene(0);
        }
    }
}
