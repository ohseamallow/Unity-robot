using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Create : MonoBehaviour
{
    public GameObject prefab;
    public Transform[] randomPosition;

    public void GenericCreate()
    {
        Delay.action();

        Instantiate
        (
            prefab, // ������ ���� ������Ʈ
            randomPosition[Random.Range(0, 4)].position,
            Quaternion.identity // ȸ�� ��
        );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
