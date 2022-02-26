using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTest : MonoBehaviour
{
    // Test ��ư
    public void OnClickTest()
    {
        // ���� ������ ��ü ����
        Destroy(ARPlaceOnPlane.spawnObject);

        // ť��(�׽�Ʈ)�� ������ ��ü ����
        ARPlaceOnPlane.spawnObject = GameObject.CreatePrimitive(PrimitiveType.Cube);
        ARPlaceOnPlane.spawnObject.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
    }

    // Quit ��ư
    public void OnClickExit()
    {
        Application.Quit();
        Debug.Log("Quit Application");
    }
}
