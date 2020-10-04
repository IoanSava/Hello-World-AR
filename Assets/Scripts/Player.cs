using UnityEngine;

public class Player : MonoBehaviour
{
    public float Distance;
    private float CLOSE_DISTANCE = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Distance = Vector3.Distance(Camera.main.transform.position, transform.position);
        if (Distance < CLOSE_DISTANCE)
        {
            GetComponent<Animator>().SetBool("isCameraClose", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("isCameraClose", false);
        }
    }
}
