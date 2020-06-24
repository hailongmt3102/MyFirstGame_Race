using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float SpeedRotate = 100f;
    void Start()
    {
        Invoke("destroy", 10f);
    }
    private void destroy()
    {
        GameObject.Destroy(this.gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        var angles = transform.rotation.eulerAngles;
        angles.y += Time.deltaTime * SpeedRotate;
        transform.rotation = Quaternion.Euler(angles);
    }
}
