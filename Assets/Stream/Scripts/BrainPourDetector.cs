using System.Collections;
using UnityEngine;

public class BrainPourDetector : MonoBehaviour
{

    public float pourThreashold = 70;
    public Transform origin1 = null;
    public Transform origin2 = null;
    private GameObject streamPrefab = null;

    private bool isPouring = false;
    private Stream currentStream = null;

    public GameObject colliderPrefab1;
    public GameObject colliderPrefab2;

    //public float velocity;

    private float rotationAngle;


    // The axis of rotation to calculate the angle (default is Y-axis)
    //public Vector3 rotationAxis = Vector3.right;

    // Optional: Set a reference direction for angle calculation (default is forward)
    public Vector3 referenceDirection = Vector3.up;


    private void Update()
    {

        

        if (calculateAngleDiffWay() > pourThreashold)
        {

            //startPour();
            GameObject colliderObject1 = Instantiate(colliderPrefab1, origin1.position, Quaternion.identity, transform);
            GameObject colliderObject2 = Instantiate(colliderPrefab2, origin2.position, Quaternion.identity, transform);
            colliderObject1.transform.parent = null;
            colliderObject2.transform.parent = null;
            //colliderObject1.transform.rotation = Quaternion.Euler(90, 0, 0);
            //colliderObject2.transform.rotation = Quaternion.Euler(90, 0, 0);
            //colliderObject1.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, velocity);
            //colliderObject2.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, velocity);
            Destroy(colliderObject1, 2.3f);
            Destroy(colliderObject2, 2.3f);


        }

        

    }


    private float calculateAngleDiffWay()
    {
        rotationAngle = Vector3.Angle(Vector3.up, -transform.right);
        //Debug.Log(rotationAngle);
        return rotationAngle;


    }

    private Stream createStream()
    {
        GameObject streamObject = Instantiate(streamPrefab, origin1.position, Quaternion.identity, transform);


        return streamObject.GetComponent<Stream>();
    }


}
