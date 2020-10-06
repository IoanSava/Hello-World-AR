using UnityEngine;

public class Player : MonoBehaviour
{
    private float Distance;
    public float CloseDistance = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Distance = Vector3.Distance(Camera.main.transform.position, transform.position);
        if (Distance < CloseDistance)
        {
            GetComponent<Animator>().SetBool("isCameraClose", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("isCameraClose", false);
        }
    }
}
