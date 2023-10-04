using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    Vector3 tempPos;
    public float leftmovement = 0.1f;

    // Update is called once per frame
    void Update()
    {
        tempPos = transform.position;
        tempPos.x -= leftmovement;
        transform.position = tempPos;
    }
}
