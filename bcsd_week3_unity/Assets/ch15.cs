using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ch15 : MonoBehaviour
{
    private void Awake()
    {
        // 컬렉션 자료 구조는 선언한 변수에 메모리를 할당해야 사용할 수 있다.
        ArrayList array = new ArrayList();
        array.Add(10);

        // 요소에 접근할 때는 첨자 연산자 []를 이용한다.
        Debug.Log(array[0]);
    }
}
