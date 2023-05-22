using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //public float movementSpeed = 5f;

    void Update()
    {

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(0f, 0f, 0.01f);//+z
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(0f, 0f, -0.01f);//-z
        }

        /*
        float moveHorizontal = 0f;

        if (Input.GetKey(KeyCode.A))
            moveHorizontal = -1f;
        else if (Input.GetKey(KeyCode.D))
            moveHorizontal = 1f;

        Vector3 movement = new Vector3(moveHorizontal, 0f, 0f) * movementSpeed * Time.deltaTime;
        transform.Translate(movement);
        */
    }
}
