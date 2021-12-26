using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutter : MonoBehaviour
{
    public static void Cut(Transform CuttedObject, Vector3 cutterTransform)
    {
        Vector3 pos = new Vector3(cutterTransform.x, CuttedObject.position.y, CuttedObject.position.z);
        Vector3 cuttedObjectScale = CuttedObject.localScale;

        //Debug.Log(pos);

        Vector3 leftPoint = Vector3.zero - Vector3.right * cuttedObjectScale.x;
        Vector3 rightPoint = Vector3.zero + Vector3.right * cuttedObjectScale.x;

        leftPoint = new Vector3(leftPoint.x / 2, leftPoint.y, leftPoint.z) + CuttedObject.position;
        rightPoint = new Vector3(rightPoint.x / 2, rightPoint.y, rightPoint.z) + CuttedObject.position;

        //Debug.Log(rightPoint);
        //Debug.Log(pos);

        Material mat = CuttedObject.GetComponent<MeshRenderer>().material;
        Destroy(CuttedObject.gameObject);
        //right
        GameObject rightSideObj = GameObject.CreatePrimitive(PrimitiveType.Cube);
        rightSideObj.transform.position = (rightPoint + pos) / 2;
        float rightWidth = Vector3.Distance(pos, rightPoint);

        rightSideObj.transform.localScale = new Vector3(rightWidth, cuttedObjectScale.y, cuttedObjectScale.z);
        rightSideObj.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        //rightSideObj.AddComponent<Rigidbody>().mass = 100f;
        rightSideObj.AddComponent<SagScript>();
        rightSideObj.GetComponent<Collider>().enabled = false;
        rightSideObj.GetComponent<MeshRenderer>().material = mat;

        Destroy(rightSideObj, 1.5f);
        //left
        GameObject leftSideObj = GameObject.CreatePrimitive(PrimitiveType.Cube);
        leftSideObj.transform.position = (leftPoint + pos) / 2;
        float leftWidth = Vector3.Distance(pos, leftPoint);

        leftSideObj.transform.localScale = new Vector3(leftWidth, cuttedObjectScale.y, cuttedObjectScale.z);
        leftSideObj.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        //leftSideObj.AddComponent<Rigidbody>().mass = 100f;
        leftSideObj.AddComponent<SolScript>();
        leftSideObj.GetComponent<Collider>().enabled = false;
        leftSideObj.GetComponent<MeshRenderer>().material = mat;

        Destroy(leftSideObj, 1.5f);

    }
}