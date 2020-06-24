using System.Collections.Generic;
using UnityEngine;

public class AddObstacles : MonoBehaviour
{
    public GameObject CubeObstacle;
    public GameObject CapsuleObstacle;

    private Vector3 newObstacle;
    private bool find = false;
    private Vector3 oldPostion; 
    private void createObstacle() {
        find = false;
        newObstacle = transform.position;
        newObstacle.z += 100;
        newObstacle.x += Random.Range(-3, 3);
        int rand = Random.Range(0, 3);
        switch (rand)
        {
            case 1: Instantiate(CubeObstacle, newObstacle, CubeObstacle.transform.rotation);
                break;
            case 2: Instantiate(CapsuleObstacle, newObstacle, CapsuleObstacle.transform.rotation);
                break;
            default:
                break;
        }
    }
    //Random new postion for Obstacle with Range follow X axis.
    private List<float> RandomNewPostionObtacle(int LeftGround, int RightGround, int level, string TypeObstacle) {
        List<float> postion= new List<float>();
        if (TypeObstacle == "Cube")
        {

        }
        if (TypeObstacle == "Capsule") { 
            
        }
        return postion;
    }
    void FixedUpdate()
    {
        if (int.Parse(transform.position.z.ToString("0")) % 50 == 0 && !find) {
            find = true;
            Invoke("createObstacle", 0.5f);
        }
    }
}
