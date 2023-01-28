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
            prefab, // 생성할 게임 오브젝트
            randomPosition[Random.Range(0, 4)].position,
            Quaternion.identity // 회전 값
        );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
