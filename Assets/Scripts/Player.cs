using UnityEngine;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public float upForce = 5f;
    public GameObject gameOver;
    public BackgroundMove backgroundscript;


    // Update is called once per frame
    void Update()
    {
        playermove();
    }
    void playermove()
    {
        if (Input.GetButtonDown("Jump") ){
            rb.velocity = new Vector3(0, upForce, 0) ;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Ground" || collision.collider.tag == "pipe")
        {
            backgroundscript.enabled = false;
            gameOver.SetActive(true);
        }
    }
}
