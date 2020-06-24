using UnityEngine;
using UnityEngine.UI;
public class Movement : MonoBehaviour
{
    public Rigidbody player;
    public Rigidbody ground;
    public GameObject panelGameover;
    public Text Score;
    public float speed = 200f;
    public float speed_moveLR = 1000f;
    public float maxSpeed = 150f;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
            gameover();
    }
    private void FixedUpdate()
    {
        if (player.velocity.magnitude < maxSpeed)
        {
            player.AddForce(0, 0, Time.deltaTime * speed);
            ground.AddForce(0, 0, Time.deltaTime * speed);
        }
        else {
            player.AddForce(0, 0, -Time.deltaTime * speed);
            ground.AddForce(0, 0, -Time.deltaTime * speed);
        }

        if (Input.GetKey("a") && player.transform.position.x > -3.5) {
            player.AddForce(-speed_moveLR * Time.deltaTime, 0, 0);
        }
        else
        if (Input.GetKey("d") && player.transform.position.x < 3.5 ) {
            player.AddForce(speed_moveLR * Time.deltaTime, 0, 0);
        }
        if (transform.position.x < -6.5 || transform.position.x > 6.5) {
            player.AddForce(0, -3, 0);
        }   
        if (transform.position.y < -2) gameover(); 
    }
    private void gameover()
    {
        panelGameover.SetActive(true);
        this.gameObject.SetActive(false);
        if (int.Parse(Score.text) > PlayerPrefs.GetInt("HightScore"))
            PlayerPrefs.SetInt("HightScore", int.Parse(Score.text));
    }
}
